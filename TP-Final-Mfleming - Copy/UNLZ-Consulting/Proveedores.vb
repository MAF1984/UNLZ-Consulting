Imports System.Data.SqlClient
Imports System.IO

Public Class Proveedores


    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=UNLZConsultingABM; integrated security=true")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub


    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" Nombre like '" & TBuscar.Text & "%' ")
        Me.Text = "PROVEEDORES                  
                   USUARIO: " & nom & " " & ape
        Me.Refresh()
    End Sub
    Sub buscar(ByVal condicion As String)

        Dim da As New SqlDataAdapter("SELECT TOP (1000) NPro,Nombre from Proveedores where " & condicion & " order by Nombre", con)
        Dim ds As New DataSet
        da.Fill(ds, "tablaProveedores")
        If ds.Tables("tablaProveedores").Rows.Count = 0 Then

            DataGridView1.Visible = False

            pBotones.Visible = False
            pCampos.Visible = False
            lLegajo.Visible = False
        Else

            DataGridView1.DataSource = ds.Tables("tablaProveedores")
            DataGridView1.Refresh()
            DataGridView1.Visible = True

            lLegajo.Visible = True
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub
    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then
            lLegajo.Text = "0"
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            CargarCamposProfesores()
        End If

    End Sub
    Sub CargarCamposProfesores()
        If Val(lLegajo.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT upper(ltrim(rtrim(isnull(nombre,'****'))))as Nombre ,upper(ltrim(rtrim(isnull(apellido,'****')))) as Apellido,upper(ltrim(rtrim(isnull(documento,'')))) as Documento,upper(ltrim(rtrim(isnull(cuit,'')))) as CUIT,upper(ltrim(rtrim(isnull(domicilio,'')))) as Direccion,upper(ltrim(rtrim(isnull(postal,'')))) as Postal,upper(ltrim(rtrim(isnull(localidad,'')))) as Localidad,upper(ltrim(rtrim(isnull(provincia,'')))) as Provincia,upper(ltrim(rtrim(isnull(telefonos,'')))) as Telefonos,Fecha as Fecha,upper(ltrim(rtrim(isnull(e_mail,'')))) as E_Mail,upper(ltrim(rtrim(isnull(comentarios,'')))) as Comentarios  from Proveedores where NPro=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, "tablaProveedores")
            TexNombre.Text = ds.Tables("tablaProveedores").Rows(0)("Nombre")
            TextRazonSocial.Text = ds.Tables("tablaProveedores").Rows(0)("Apellido")
            TextDoc.Text = ds.Tables("tablaProveedores").Rows(0)("Documento")
            TextCUIT.Text = ds.Tables("tablaProveedores").Rows(0)("CUIT")
            TextDomicilio.Text = ds.Tables("tablaProveedores").Rows(0)("Direccion")
            TextCodigo.Text = ds.Tables("tablaProveedores").Rows(0)("Postal")
            TextLocalidad.Text = ds.Tables("tablaProveedores").Rows(0)("Localidad")
            TextProvincia.Text = ds.Tables("tablaProveedores").Rows(0)("Provincia")
            TextTelefono.Text = ds.Tables("tablaProveedores").Rows(0)("Telefonos")
            DateTimePicker1.Value = ds.Tables("tablaProveedores").Rows(0)("Fecha")
            TextEmail.Text = ds.Tables("tablaProveedores").Rows(0)("E_Mail")
            TextComentarios.Text = ds.Tables("tablaProveedores").Rows(0)("Comentarios")
        End If
    End Sub
    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click

        Dim errores As String = "", en As String = vbCrLf
        If TextRazonSocial.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Apellido del Proveedor." & en
        End If
        If TexNombre.Text.Trim.Length < 3 Then
            errores &= "Debe completar el o los nombres del Proveedor." & en
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
        If SQL_Accion("update [UNLZConsultingABM].[dbo].[Proveedores] set  Nombre='" & TexNombre.Text.Trim.ToUpper.Replace("'", "´") & "', Apellido='" & TextRazonSocial.Text.Trim.ToUpper.Replace("'", "´") & "',Documento='" & TextDoc.Text.Trim.ToUpper.Replace("'", "´") & "', CUIT='" & TextCUIT.Text.Trim.ToUpper.Replace("'", "´") & "', Domicilio='" & TextDomicilio.Text.Trim.ToUpper.Replace("'", "´") & "', Postal='" & TextCodigo.Text.Trim.ToUpper.Replace("'", "´") & "', Localidad='" & TextLocalidad.Text.Trim.ToUpper.Replace("'", "´") & "', Provincia='" & TextProvincia.Text.Trim.ToUpper.Replace("'", "´") & "', Telefonos='" & TextTelefono.Text.Trim.ToUpper.Replace("'", "´") & "', E_Mail='" & TextEmail.Text.Trim.ToUpper.Replace("'", "´") & "', Comentarios='" & TextComentarios.Text.Trim.ToUpper.Replace("'", "´") & "', Fecha='" & DateTimePicker1.Value & "' where NPro=" & Val(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar("NPro=" & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del Proveedor, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub

    Private Sub bNuevoCliente_Click(sender As Object, e As EventArgs) Handles bNuevoProveedor.Click
        If SQL_Accion("INSERT into [UNLZConsultingABM].[dbo].[Proveedores](nombre,apellido,documento,cuit,domicilio,postal,localidad,provincia,telefonos,E_Mail,comentarios) values ('****','****',          '',           '',           '',             '',                ''       ,      ''    ,     ''     ,   '',    '' )  ") Then

            buscar("Nombre like '****%' ")
            MsgBox("Se ha creado un nuevo registro para el cliente que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If

    End Sub
    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar(" Nombre like '" & TBuscar.Text & "%' ")
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        TBuscar.Text = ""
        buscar(" Nombre like '" & TBuscar.Text & "%' ")
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente al Proveedor: " & TexNombre.Text.Trim.ToUpper & ",  . Es algo EXTREMO. Está SEGURO?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from [UNLZConsultingABM].[dbo].[Proveedores]  where  NPro=" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Proveedor, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else

            buscar(" NPro=" & Val(lLegajo.Text))
            MsgBox("El Proveedor fue ELIMINADO de la base de datos.")

        End If
    End Sub

End Class