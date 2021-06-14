Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://www.google.com/search?sxsrf=ALeKk03KIdJ0PFhqnFEsf3keRtMERvT02A%3A1586220695851&source=hp&ei=l86LXrLWMYbD5OUPp_SV0A8&q=" + TextBox1.Text + "&oq=" + TextBox1.Text + "&gs_lcp=CgZwc3ktYWIQAzICCAAyAggAMgIIADICCAAyBwgAEAoQywEyAggAMgQIABAKMgQIABAKMgIIADIFCAAQywE6BQgAEIMBShgIFxIUMGc5NWc5M2c5N2c4NGcxMTFnODVKEQgYEg0wZzFnMWcxZzFnMWcxULkNWOgVYPgWaAFwAHgAgAFZiAGwA5IBATaYAQCgAQGqAQdnd3Mtd2l6&sclient=psy-ab&ved=0ahUKEwjy_e_IjNXoAhWGIbkGHSd6BfoQ4dUDCAY&uact=5")
    End Sub
End Class
