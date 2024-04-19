Imports System.IO
Imports System.Data.SqlClient

Module Module1
	Public con As New SqlConnection
	Public cmd As New SqlCommand
	Public dr As SqlDataReader
	Public adaptador As SqlDataAdapter
	Public ds As DataSet
	Public Anombre, buscard, borrard As String

	Dim i As Integer
	Sub Main()
		Dim opcion As Char = ""
		Dim opcion2 As ConsoleKeyInfo
		Dim nombre As String = ""
		Dim Ncontacto, Telcto, Ecto As String

		con.ConnectionString = "Data Source=DESKTOP-P3R1P5S\SQLEXPRESS;Initial Catalog=AgendaC;integrated Security=True"
		If con.State = ConnectionState.Open Then
			con.Close()
		End If
		con.Open()

		Do
			Try

				Console.Clear()
				Console.WriteLine("Menú de Agenda de Contactos")
				Console.WriteLine("1. Ingreso de nombre de usuario")
				Console.WriteLine("2. Ingreso ejecucion programa")
				Console.WriteLine("3. Historial de datos")
				Console.WriteLine("4. Editar Contacto")
				Console.WriteLine("5. Borrar Contacto")
				Console.WriteLine("6. Salir")
				Console.WriteLine("Seleccione una opción")
				opcion2 = Console.ReadKey()
				opcion = opcion2.KeyChar
				Console.Clear()
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
			Select Case opcion
				Case "1"
					Try
						Console.Clear()
						Console.WriteLine("Ingrese su nombre de usuario")
						nombre = Console.ReadLine()
					Catch ex As Exception
						Console.WriteLine(ex.Message)
					End Try
				Case "2"
					Try

						If con.State = ConnectionState.Open Then
							con.Close()
						End If
						con.Open()
						Console.Clear()
						Console.WriteLine("Ingrese el nombre del contacto: ")
						Ncontacto = Console.ReadLine()

						Console.WriteLine("Ingrese el Telefono del contacto: ")
						Telcto = Console.ReadLine()

						Console.WriteLine("Ingrese el e-mail del contacto: ")
						Ecto = Console.ReadLine()

						cmd = con.CreateCommand()
						cmd.CommandType = CommandType.Text
						cmd.CommandText = "insert into Contactosc values('" & Ncontacto & "','" & Telcto & "','" & Ecto & "','" & nombre & "')"
						cmd.ExecuteNonQuery()
						Console.WriteLine("")
						Console.WriteLine("Resultados quedaron Guardados")
						Console.ReadKey()
					Catch ex As Exception
						Console.WriteLine(ex.Message)
					End Try
				Case "3"
					Console.Clear()
					If con.State = ConnectionState.Open Then
						con.Close()
					End If
					con.Open()
					Try
						Dim query As String = "SELECT * FROM Contactosc"
						Using command As New SqlCommand(query, con)
							Dim reader As SqlDataReader = command.ExecuteReader()

							' Imprimir encabezados de columnas
							For i As Integer = 0 To reader.FieldCount - 1
								Console.Write(reader.GetName(i) & vbTab)
							Next
							Console.WriteLine()

							' Imprimir datos
							While reader.Read()
								For i As Integer = 0 To reader.FieldCount - 1
									Console.Write(reader(i).ToString() & vbTab)
								Next
								Console.WriteLine()
							End While

							reader.Close()
						End Using

					Catch ex As Exception
						Console.WriteLine("Error al conectar a la base de datos: " & ex.Message)
					Finally
						If con.State = ConnectionState.Open Then
							con.Close()
						End If
					End Try
					Console.WriteLine("")
					Console.WriteLine("Presione cualquier tecla")
					Console.ReadKey()
				Case "4"
					If con.State = ConnectionState.Open Then
						con.Close()
					End If
					con.Open()
					Try
						Dim query1 As String = "SELECT * FROM Contactosc"
						Using cmd As New SqlCommand(query1, con)
							Dim reader As SqlDataReader = cmd.ExecuteReader()

							' Imprimir encabezados de columnas
							For i As Integer = 0 To reader.FieldCount - 1
								Console.Write(reader.GetName(i) & vbTab)
							Next
							Console.WriteLine()
							' Imprimir datos
							While reader.Read()
								For i As Integer = 0 To reader.FieldCount - 1
									Console.Write(reader(i).ToString() & vbTab)
								Next
								Console.WriteLine()
							End While

							reader.Close()
						End Using

					Catch ex As Exception
						Console.WriteLine("Error al conectar a la base de datos: " & ex.Message)
					Finally
						If con.State = ConnectionState.Open Then
							con.Close()
						End If
					End Try

					Console.WriteLine("Ingrese el nombre del contacto a editar")
					buscard = Console.ReadLine()
					Dim idABuscar As Integer
					' Construye la consulta SQL SELECT para buscar el registro con el ID especificado
					Dim query As String = "SELECT * FROM Contactosc WHERE Nombre_contacto = '" & buscard & "'"

					' Crea un nuevo SqlCommand con la consulta y la conexión
					Dim command As New SqlCommand(query, con)

					' Agrega el parámetro
					command.Parameters.AddWithValue("@Nombre_contacto", idABuscar)

					Try
						' Abre la conexión
						con.Open()

						' Ejecuta la consulta y obtiene el resultado
						Dim reader As SqlDataReader = command.ExecuteReader()

						' Verifica si se encontraron registros
						If reader.Read() Then
							' Si se encontró un registro, muestra los datos en los TextBox correspondientes
							'Anombre = TxBnombrec.Text.ToString()
							Console.WriteLine(reader("Nombre_contacto").ToString() & ", " & reader("Telefono_contacto").ToString() & ", " & reader("Email_contacto").ToString() & ", " & reader("Usuario").ToString())


						Else
							' Si no se encontraron registros, muestra un mensaje indicando que no se encontró el registro
							'MessageBox.Show("No se encontró el registro.")

						End If

						' Cierra el lector de datos
						reader.Close()
					Catch ex As Exception
						'MessageBox.Show("Error al buscar el registro: " & ex.Message)
					Finally
						' Cierra la conexión
						con.Close()
					End Try

					Console.WriteLine("")
					Console.ReadKey()
				Case "5"
					Console.Clear()

					If con.State = ConnectionState.Open Then
						con.Close()
					End If
					con.Open()

					Try
						Dim query1 As String = "SELECT * FROM Contactosc"
						Using cmd As New SqlCommand(query1, con)
							Dim reader As SqlDataReader = cmd.ExecuteReader()

							' Imprimir encabezados de columnas
							For i As Integer = 0 To reader.FieldCount - 1
								Console.Write(reader.GetName(i) & vbTab)
							Next
							Console.WriteLine()
							' Imprimir datos
							While reader.Read()
								For i As Integer = 0 To reader.FieldCount - 1
									Console.Write(reader(i).ToString() & vbTab)
								Next
								Console.WriteLine()
							End While

							reader.Close()
						End Using

					Catch ex As Exception
						Console.WriteLine("Error al conectar a la base de datos: " & ex.Message)
					Finally
						If con.State = ConnectionState.Open Then
							con.Close()
						End If
					End Try
					Console.WriteLine("")
					Console.WriteLine("Ingrese el nombre del contacto a borrar")
					borrard = Console.ReadLine()
					Try
						con.Open()
						cmd = con.CreateCommand()
						cmd.CommandType = CommandType.Text
						cmd.CommandText = "delete from Contactosc where Nombre_Contacto= '" & borrard & "'"
						Dim haydatos As Integer = cmd.ExecuteNonQuery()

						If haydatos > 0 Then

							Console.WriteLine("Contacto borrado exitosamente")
							Console.ReadKey()
						Else
							Console.WriteLine("Contacto no existe")
							Console.ReadKey()
						End If
					Catch ex As Exception
						Console.WriteLine("Erorr en conxion o al borrar presiona  Enter y vuelve a intentar")
						Console.ReadKey()
					End Try

				Case "6"
					Console.Clear()
					Console.WriteLine("Presione para Salir")
					Exit Do
					Console.ReadKey()
				Case Else
					Console.WriteLine("Opcion no valida")
					Console.ReadKey()
			End Select
		Loop
	End Sub

End Module

