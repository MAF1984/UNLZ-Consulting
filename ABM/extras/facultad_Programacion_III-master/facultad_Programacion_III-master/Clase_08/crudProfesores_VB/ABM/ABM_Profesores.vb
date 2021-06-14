Imports System.IO
Imports System.Data.SqlClient
Public Class ABM_Profesores
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=abm; integrated security=true")

    Private Sub ABM_Profesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub
    Sub buscar(ByVal condicion As String)
        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT nprof,apeynom from profesores_búsqueda where " & condicion & " order by apeynom", con)
        Dim ds As New DataSet
        da.Fill(ds, "Alumnos")
        If ds.Tables("Alumnos").Rows.Count = 0 Then

            DataGridView1.Visible = False

            pBotones.Visible = False
            pCampos.Visible = False
            lLegajo.Visible = False
        Else

            DataGridView1.DataSource = ds.Tables("Alumnos")
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
            CargarCamposAlumnos()
        End If

    End Sub

    Sub CargarCamposAlumnos()
        If Val(lLegajo.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(apellidoprof,'****')))) as apellido, upper(ltrim(rtrim(isnull(nombreprof,'****')))) as nombres,isnull([documento-Prof],0) as doc, ltrim(rtrim(isnull(domicilioprof,''))) as dirección,ltrim(rtrim(isnull(localidadprof,''))) as localidad,ltrim(rtrim(isnull(provinciaprof,''))) as provincia,ltrim(rtrim(isnull(teléfonosProf,''))) as teléfonos,FechanacimientoProf as fechanacimiento,ltrim(rtrim(isnull(comentariosProf,''))) as comentarios,ltrim(rtrim(isnull([E-Mail-Prof],''))) as email, isnull(estado,0) as Estado  from profesores where nprof=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, "Alumnos")
            TextBox1.Text = ds.Tables("Alumnos").Rows(0)("apellido")
            TextBox2.Text = ds.Tables("Alumnos").Rows(0)("nombres")
            TextBox3.Text = ds.Tables("Alumnos").Rows(0)("doc")

            TextBox4.Text = ds.Tables("Alumnos").Rows(0)("Dirección")
            TextBox5.Text = ds.Tables("Alumnos").Rows(0)("localidad")
            TextBox8.Text = ds.Tables("Alumnos").Rows(0)("provincia")
            TextBox6.Text = ds.Tables("Alumnos").Rows(0)("teléfonos")
            TextBox7.Text = ds.Tables("Alumnos").Rows(0)("email")
            CheckBox1.Checked = IIf(ds.Tables("Alumnos").Rows(0)("estado") = 0, False, True)


            TextBox12.Text = ds.Tables("Alumnos").Rows(0)("comentarios")

            DateTimePicker1.Value = ds.Tables("Alumnos").Rows(0)("fechanacimiento")
        End If
    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tApellido.Text = ""
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MessageBox.Show("Está por ELIMINAR definitivamente al PROFESOR: " & TextBox1.Text.Trim.ToUpper & ", " & TextBox12.Text.Trim.ToUpper & ". Es algo EXTREMO, porque todos los cursos que lo tienen desde el 2005 perderán las referencias. Está SEGURO?", "Eliminar Profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from profesores  where  nprof=" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Profesor, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else

            buscar(" nprof=" & Val(lLegajo.Text))
            MsgBox("El Profesor fue ELIMINADO de la base de datos.")

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim errores As String = "", en As String = vbCrLf
        If TextBox1.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Apellido del profesor." & en
        End If
        If TextBox2.Text.Trim.Length < 3 Then
            errores &= "Debe completar el o los nombres del profesor." & en
        End If
        TextBox3.Text = Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))
        If TextBox3.Text.Trim.Length < 4 Or TextBox3.Text.IndexOf("11111") > -1 Or TextBox3.Text.IndexOf("12345") > -1 Or TextBox3.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el documento del profesor." & en
        End If
        If TextBox7.Text.Trim.Length <> 0 And (TextBox7.Text.IndexOf("@") < 0 Or TextBox7.Text.IndexOf(".") < 0) Then
            errores &= "Verifique por favor el email del profesor. No es obligatorio, pero si lo escribe debe ser correcto." & en
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        ' TextBox12.Text = "update alumnos set apellidos='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombres='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', sexo='" & Sexo.SelectedItem & "', doc=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", nacionalidad='" & TextBox10.Text.Trim.ToUpper & "', dirección='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidad='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', teléfparticular='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', emailalumno='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimiento=" & FechaSQL(DateTimePicker1.Value) & ", ocupación='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', colegio='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', turno='" & TextBox11.Text.Trim.ToUpper.Replace("'", "´") & "', comentarios='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where legajo=" & VNum(lLegajo.Text)
        If SQL_Accion("update profesores set estado=" & IIf(CheckBox1.Checked, 1, 0) & ", apellidoprof='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombreprof='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', [documento-prof]=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", domicilioprof='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidadprof='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', provinciaprof='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', teléfonosprof='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', [e-mail-prof]='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimientoprof=" & FechaSQL(DateTimePicker1.Value) & ", comentariosprof='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where nprof=" & VNum(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar(" nprof=" & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del profesor, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub

    Private Sub bNuevoAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevoAlumno.Click
        If SQL_Accion("insert into profesores (apellidoprof, nombreprof, [documento-prof],domicilioprof, localidadprof, teléfonosprof, fechanacimientoprof, comentariosprof,[e-mail-prof],estado) values ('*****','*****',                  0,           '',           '',             '',           getdate(),               ''       ,      ''    ,     1   )  ") Then


            buscar(" apeynom like '****%' ")
            MsgBox("Se ha creado un nuevo registro para el profesor que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class