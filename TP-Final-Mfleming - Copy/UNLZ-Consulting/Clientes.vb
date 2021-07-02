Imports System.Data.SqlClient
Imports System.IO

Public Class Clientes

    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=UNLZConsultingABM; integrated security=true")


    Sub buscar(ByVal condicion As String)
        'Busca al id y nombre en la vista (Busqueda_Cliente)  ordenado por nombre'
        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT NCliente,Nombre from Clientes where " & condicion & " order by Nombre", con)
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


    Sub CargarCampos()
        If Val(lLegajo.Text) = 0 Then

            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT upper(ltrim(rtrim(isnull(nombre,'****')))) as Nombre, upper(ltrim(rtrim(isnull(apellido,'****')))) as Apellido,upper(ltrim(rtrim(isnull(documento,'')))) as Documento,upper(ltrim(rtrim(isnull(cuit,'')))) as CUIT,upper(ltrim(rtrim(isnull(domicilio,'')))) as Direccion,upper(ltrim(rtrim(isnull(postal,'')))) as Postal,upper(ltrim(rtrim(isnull(localidad,'')))) as Localidad,upper(ltrim(rtrim(isnull(provincia,'')))) as Provincia,upper(ltrim(rtrim(isnull(telefonos,'')))) as Telefonos,FechaNacimiento as FechaNacimiento,upper(ltrim(rtrim(isnull(e_mail,'')))) as E_Mail from Clientes where NCliente=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, "tabla")
            TexNombre.Text = ds.Tables("tabla").Rows(0)("Nombre")
            TextApellido.Text = ds.Tables("tabla").Rows(0)("Apellido")
            TextDoc.Text = ds.Tables("tabla").Rows(0)("Documento")
            TextCUIT.Text = ds.Tables("tabla").Rows(0)("CUIT")
            TextDomicilio.Text = ds.Tables("tabla").Rows(0)("Direccion")
            TextCodigo.Text = ds.Tables("tabla").Rows(0)("Postal")
            TextLocalidad.Text = ds.Tables("tabla").Rows(0)("Localidad")
            TextProvincia.Text = ds.Tables("tabla").Rows(0)("Provincia")
            TextTelefono.Text = ds.Tables("tabla").Rows(0)("Telefonos")
            DateTimePicker1.Value = ds.Tables("tabla").Rows(0)("FechaNacimiento")
            TextEmail.Text = ds.Tables("tabla").Rows(0)("E_Mail")
            'CheckBox1.Checked = IIf(ds.Tables("tabla").Rows(0)("estado") = 0, False, True)




            ', upper(ltrim(rtrim(isnull(apellido,'****')))) as Apellido,upper(ltrim(rtrim(isnull(documento,'')))) as Documento,upper(ltrim(rtrim(isnull(cuit,'')))) as CUIT ,isnull(Domicilio,'') as Direccion, ltrim(rtrim(isnull(Postal,''))) as Postal,ltrim(rtrim(isnull(Localidad,''))) as Localidad,ltrim(rtrim(isnull(Provincia,''))) as Provincia,ltrim(rtrim(isnull(Telefonos,''))) as Telefonos,ltrim(rtrim(isnull([E-Mail],''))) as E-Mail
        End If
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar("Nombre like '" & TBuscar.Text & "%' ")
        Me.Text = "CLIENTES                                                    
           USUARIO: " & nom & " " & ape
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub


    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click

        Dim errores As String = "", en As String = vbCrLf
        If TextApellido.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Apellido del Cliente." & en
        End If
        If TexNombre.Text.Trim.Length < 3 Then
            errores &= "Debe completar el o los nombres del Cliente." & en
        End If
        If TextDoc.Text.Trim.Length = 10 Then
            errores &= "El documento debe tener 10 digitos!!!." & en
        End If

        If TextCodigo.Text.Trim.Length < 3 Then
            errores &= "Debe tener mas de 3 numeros!!!." & en
        End If

        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        ' TextBox12.Text = "update alumnos set apellidos='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombres='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', sexo='" & Sexo.SelectedItem & "', doc=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", nacionalidad='" & TextBox10.Text.Trim.ToUpper & "', dirección='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidad='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', teléfparticular='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', emailalumno='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimiento=" & FechaSQL(DateTimePicker1.Value) & ", ocupación='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', colegio='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', turno='" & TextBox11.Text.Trim.ToUpper.Replace("'", "´") & "', comentarios='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where legajo=" & VNum(lLegajo.Text)
        If SQL_Accion("update [UNLZConsultingABM].[dbo].[Clientes] set  Nombre='" & TexNombre.Text.Trim.ToUpper.Replace("'", "´") & "', Apellido='" & TextApellido.Text.Trim.ToUpper.Replace("'", "´") & "',Documento='" & TextDoc.Text.Trim.ToUpper.Replace("'", "´") & "', CUIT='" & TextCUIT.Text.Trim.ToUpper.Replace("'", "´") & "', Domicilio='" & TextDomicilio.Text.Trim.ToUpper.Replace("'", "´") & "', Postal='" & TextCodigo.Text.Trim.ToUpper.Replace("'", "´") & "', Localidad='" & TextLocalidad.Text.Trim.ToUpper.Replace("'", "´") & "', Provincia='" & TextProvincia.Text.Trim.ToUpper.Replace("'", "´") & "', Telefonos='" & TextTelefono.Text.Trim.ToUpper.Replace("'", "´") & "', E_Mail='" & TextEmail.Text.Trim.ToUpper.Replace("'", "´") & "', FechaNacimiento='" & DateTimePicker1.Value & "' where NCliente=" & Val(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar("NCliente=" & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del Cliente, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub

    Private Sub bNuevoCliente_Click(sender As Object, e As EventArgs) Handles bNuevoCliente.Click
        If SQL_Accion("INSERT into [UNLZConsultingABM].[dbo].[Clientes](nombre,apellido,documento,cuit,domicilio,postal,localidad,provincia,telefonos,E_Mail) values ('****','****',          '',           '',           '',             '',                ''       ,      ''    ,     ''     ,   '' )  ") Then

            buscar("Nombre like '****%' ")
            MsgBox("Se ha creado un nuevo registro para el cliente que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar("Nombre like '" & TBuscar.Text & "%' ")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        'borra lo ingresado por tbuscar'
        TBuscar.Text = ""
        buscar("Nombre like '" & TBuscar.Text & "%' ")
    End Sub


    Private Sub lLegajo_Click(sender As Object, e As EventArgs) Handles lLegajo.Click

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub
    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click

        If MessageBox.Show("Está por ELIMINAR definitivamente al CLIENTE: " & TexNombre.Text.Trim.ToUpper & ",  . Es algo EXTREMO. Está SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from [UNLZConsultingABM].[dbo].[Clientes]  where  NCliente=" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Cliente, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else

            buscar(" NCliente=" & Val(lLegajo.Text))
            MsgBox("El Cliente fue ELIMINADO de la base de datos.")

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pBotones_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class