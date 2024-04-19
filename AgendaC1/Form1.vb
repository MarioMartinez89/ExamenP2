Imports System.Data.SqlClient

Public Class Form1
	Public con As New SqlConnection
	Public cmd As New SqlCommand
	Public dr As SqlDataReader
	Public adaptador As SqlDataAdapter
	Public ds As DataSet
	Public Anombre As String
	Dim i As Integer

	Private Sub TxBtelc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxBtelc.KeyPress

		' Permitir solo dígitos, la tecla de retroceso y los paréntesis
		If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "(" AndAlso e.KeyChar <> ")" Then
			e.Handled = True
		End If


		' Limitar la longitud total a 8 caracteres (incluyendo paréntesis y guión)
		If TxBtelc.TextLength >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then
			e.Handled = True
		End If


	End Sub
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		con.ConnectionString = "Data Source=DESKTOP-P3R1P5S\SQLEXPRESS;Initial Catalog=AgendaC;integrated Security=True"
		If con.State = ConnectionState.Open Then
			con.Close()
		End If
		con.Open()
		disp_data()
	End Sub
	Public Sub disp_data()
		cmd = con.CreateCommand()
		cmd.CommandType = CommandType.Text
		cmd.CommandText = "Select * from Contactosg"
		cmd.ExecuteNonQuery()
		Dim dt As New DataTable()
		Dim da As New SqlDataAdapter(cmd)
		da.Fill(dt)
		DataGridView1.DataSource = dt
	End Sub

	Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

		LimpiarTextBox()

		' Verificar si la celda seleccionada es válida y no es el encabezado
		If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

			' Obtener el valor de la celda seleccionada
			Dim valorC1 As String = DataGridView1.SelectedCells.Item(0).Value.ToString()

			' Asignar el valor de la celda al TextBox
			TxBnombrec.Text = valorC1

		End If
	End Sub
	Private Sub Btguardar_Click(sender As Object, e As EventArgs) Handles Btguardar.Click

		cmd = con.CreateCommand()
		cmd.CommandType = CommandType.Text
		cmd.CommandText = "insert into Contactosg values('" + TxBnombrec.Text + "','" + TxBtelc.Text + "','" + TxBemailc.Text + "','" + TxBuser.Text + "')"
		cmd.ExecuteNonQuery()
		LimpiarTextBox()
		Label6.Text = " Exito al Grabar Información"
		disp_data()
	End Sub

	Private Sub Btsalir_Click(sender As Object, e As EventArgs) Handles Btsalir.Click

		Me.Close()

	End Sub

	Private Sub Btborrar_Click(sender As Object, e As EventArgs) Handles Btborrar.Click
		If con.State = ConnectionState.Open Then
			con.Close()
		End If

		con.Open()
			cmd = con.CreateCommand()
			cmd.CommandType = CommandType.Text
		cmd.CommandText = "delete from Contactosg where Nombre_Contacto= '" + TxBnombrec.Text + "'"
		cmd.ExecuteNonQuery()
		disp_data()
		LimpiarTextBox()


	End Sub

	Private Sub Btbuscar_Click(sender As Object, e As EventArgs) Handles Btbuscar.Click

		If con.State = ConnectionState.Open Then
			con.Close()
		End If

		Dim idABuscar As Integer

		' Construye la consulta SQL SELECT para buscar el registro con el ID especificado
		Dim query As String = "SELECT * FROM Contactosg WHERE Nombre_contacto = '" + TxBnombrec.Text + "'"


			' Crea un nuevo SqlCommand con la consulta y la conexión
			Dim command As New SqlCommand(query, con)

			' Agrega el parámetro para el ID
			command.Parameters.AddWithValue("@Nombre_contacto", idABuscar)

			Try
				' Abre la conexión
				con.Open()

				' Ejecuta la consulta y obtiene el resultado
				Dim reader As SqlDataReader = command.ExecuteReader()

			' Verifica si se encontraron registros
			If reader.Read() Then
				' Si se encontró un registro, muestra los datos en los TextBox correspondientes
				Anombre = TxBnombrec.Text.ToString()
				TxBnombrec.Text = reader("Nombre_contacto").ToString()
				TxBtelc.Text = reader("Telefono_contacto").ToString()
				TxBemailc.Text = reader("Email_contacto").ToString()
				TxBuser.Text = reader("Usuario").ToString()
			Else
				' Si no se encontraron registros, muestra un mensaje indicando que no se encontró el registro
				MessageBox.Show("No se encontró el registro.")
					' Limpia los TextBox
					LimpiarTextBox()
				End If

				' Cierra el lector de datos
				reader.Close()
			Catch ex As Exception
				MessageBox.Show("Error al buscar el registro: " & ex.Message)
			Finally
				' Cierra la conexión
				con.Close()
			End Try

	End Sub
	Private Sub LimpiarTextBox()
		' Limpia los TextBox
		TxBnombrec.Clear()
		TxBtelc.Clear()
		TxBemailc.Clear()
		TxBuser.Clear()
	End Sub

	Private Sub Btedit_Click(sender As Object, e As EventArgs) Handles Btedit.Click

		If con.State = ConnectionState.Open Then
			con.Close()
		End If

		Dim nNombre As String = TxBnombrec.Text
		Dim ntel As String = TxBtelc.Text
		Dim nemail As String = TxBemailc.Text

		con.Open()
		cmd.CommandType = CommandType.Text
		cmd.CommandText = "UPDATE Contactosg SET Nombre_Contacto = '" & nNombre & "', Telefono_Contacto = '" & ntel & "', Email_contacto = '" & nemail & "' Where Nombre_Contacto ='" & Anombre & "' "

		Try
			' Ejecuta la consulta

			cmd.ExecuteNonQuery()

			MessageBox.Show("Registro actualizado correctamente.")

		Catch ex As Exception
			MessageBox.Show("Error al actualizar el registro: " & ex.Message)
		End Try
		disp_data()
		LimpiarTextBox()
	End Sub

End Class
