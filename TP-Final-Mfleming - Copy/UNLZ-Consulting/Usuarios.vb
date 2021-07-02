Imports System.Data.SqlClient
Imports System.IO

Public Class Usuarios
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=UNLZConsultingABM; integrated security=true")


    Sub buscar(ByVal condicion As String)
        'Busca al id y nombre en la vista (Busqueda_Cliente)  ordenado por nombre'
        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT Id,Nombre from idm where " & condicion & " order by Nombre", con)
        Dim ds As New DataSet   'crea un lugar para almacenar los registros que se leen(seria una estructura)'
        da.Fill(ds, "tabla")
        If ds.Tables("tabla").Rows.Count = 0 Then

            DataGridView1.Visible = False
            pBotones.Visible = False        'si la tabla esta vacia hace invisible a todo menos tbuscar,bbuscar,checkbox'
            pCampos.Visible = False
            lLegajo.Visible = False
        Else

            DataGridView1.DataSource = ds.Tables("tabla")
            DataGridView1.Refresh()
            DataGridView1.Visible = True

            lLegajo.Visible = True
        End If

    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then  'si no hay nada en DataGrid lLegajo = 0'
            lLegajo.Text = "0"

            pBotones.Visible = False   'bNuevoCliente esta visible porque pBotones color invisible y va por encima del boton bNuevoCliente'
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            CargarCampos()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        FilaClick(e)
    End Sub


    Sub CargarCampos()
        If Val(lLegajo.Text) = 0 Then

            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT upper(ltrim(rtrim(isnull(Usuario,'****')))) as Usuario,upper(ltrim(rtrim(isnull(Clave,'****')))) as Clave,upper(ltrim(rtrim(isnull(Nombre,'****')))) as Nombre, upper(ltrim(rtrim(isnull(apellido,'****')))) as Apellido,upper(ltrim(rtrim(isnull(Email,'')))) as Email from idm where Id=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, "tabla")
            tUsuario.Text = ds.Tables("tabla").Rows(0)("Usuario")
            tContraseña.Text = ds.Tables("tabla").Rows(0)("Clave")
            tNombre.Text = ds.Tables("tabla").Rows(0)("Nombre")
            tApellido.Text = ds.Tables("tabla").Rows(0)("Apellido")
            tEmail.Text = ds.Tables("tabla").Rows(0)("Email")
            'CheckBox1.Checked = IIf(ds.Tables("tabla").Rows(0)("estado") = 0, False, True)





        End If
    End Sub
    Private Sub bNuevoCliente_Click(sender As Object, e As EventArgs) Handles bNuevoCliente.Click
        If SQL_Accion("INSERT into [UNLZConsultingABM].[dbo].[idm](Usuario,Clave,Nombre,Apellido,Email) values (          '','******',          '',           '',           '')  ") Then

            buscar("Nombre like '****%' ")
            MsgBox("Se ha creado un nuevo registro para el Usuario que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If

    End Sub
    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click

        Dim errores As String = "", en As String = vbCrLf
        If tApellido.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Apellido del Usuario." & en
        End If
        If tNombre.Text.Trim.Length < 3 Then
            errores &= "Debe completar el o los nombres del Usuario." & en
        End If
        If tContraseña.Text.Trim.Length < 6 Then
            errores &= "La contraseña debe tener 6 o mas digitos!!!." & en
        End If
        If tContraseña.Text <> tContraseñaRepite.Text Then
            errores &= "La Contraseña NO coincide!!!." & en
        End If

        If TextCodigo.Text.Trim.Length < 3 Then
            errores &= "Debe tener mas de 3 numeros!!!." & en
        End If





        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        ' TextBox12.Text = "update alumnos set apellidos='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombres='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', sexo='" & Sexo.SelectedItem & "', doc=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", nacionalidad='" & TextBox10.Text.Trim.ToUpper & "', dirección='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidad='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', teléfparticular='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', emailalumno='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimiento=" & FechaSQL(DateTimePicker1.Value) & ", ocupación='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', colegio='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', turno='" & TextBox11.Text.Trim.ToUpper.Replace("'", "´") & "', comentarios='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where legajo=" & VNum(lLegajo.Text)
        If SQL_Accion("update [UNLZConsultingABM].[dbo].[idm] set  Nombre='" & tNombre.Text.Trim.ToUpper.Replace("'", "´") & "', Apellido='" & tApellido.Text.Trim.ToUpper.Replace("'", "´") & "',Contraseña='" & tContraseña.Text.Trim.ToUpper.Replace("'", "´") & "',Documento='" & TextDoc.Text.Trim.ToUpper.Replace("'", "´") & "', CUIT='" & tContraseñaRepite.Text.Trim.ToUpper.Replace("'", "´") & "', Domicilio='" & TextDomicilio.Text.Trim.ToUpper.Replace("'", "´") & "', Postal='" & TextCodigo.Text.Trim.ToUpper.Replace("'", "´") & "', Localidad='" & TextLocalidad.Text.Trim.ToUpper.Replace("'", "´") & "', Provincia='" & TextProvincia.Text.Trim.ToUpper.Replace("'", "´") & "', Telefonos='" & TextTelefono.Text.Trim.ToUpper.Replace("'", "´") & "', E_Mail='" & TextEmail.Text.Trim.ToUpper.Replace("'", "´") & "', FechaNacimiento='" & DateTimePicker1.Value & "' where NUsuario=" & Val(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar("NUsuario=" & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del Usuario, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar("Nombre like '" & TBuscar.Text & "%' ")
        Me.Text = "USUARIOS                  
                   USUARIO: " & nom & " " & ape
        Me.Refresh()
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar("Nombre like '" & TBuscar.Text & "%' ")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        'borra lo ingresado por tbuscar'
        TBuscar.Text = ""
        buscar("Nombre like '" & TBuscar.Text & "%' ")
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub
    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente al Usuario: " & tNombre.Text.Trim.ToUpper & ",  . Es algo EXTREMO. Está SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from [UNLZConsultingABM].[dbo].[Usuarios]  where  NUsuario=" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Usuario, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else

            buscar(" NUsuario=" & Val(lLegajo.Text))
            MsgBox("El Usuario fue ELIMINADO de la base de datos.")

        End If
    End Sub

End Class