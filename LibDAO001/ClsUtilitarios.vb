
Imports System.Linq
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows
Imports System.IO

Public Class ClsUtilitarios
    Public Sub Nota(cCadena As String)
        MsgBox(cCadena)
    End Sub

    Public Sub NotaCompleta(cCadena As String, TipoBoton As Integer)
        Dim msg As String = cCadena
        Dim title As String = ""
        Dim style As MsgBoxStyle
        'Dim response As MsgBoxResult

        If TipoBoton = 0 Then
            style = MsgBoxStyle.OkOnly
            title = "Atencion:"
        End If
        If TipoBoton = 16 Then
            style = MsgBoxStyle.Critical
            title = "Error:"
        End If
        If TipoBoton = 48 Then
            style = MsgBoxStyle.Exclamation
            title = "Advertencia:"
        End If
        If TipoBoton = 64 Then
            style = MsgBoxStyle.Information
            title = "Informacion:"
        End If
        If TipoBoton = 128 Then
            style = MsgBoxStyle.YesNo
            title = "Consulta:"
        End If

        MsgBox(msg, style, title)
    End Sub

    Public Function NotaCompletaPregunta(cCadena As String, TipoBoton As Integer) As MsgBoxResult
        Dim msg As String = cCadena
        Dim title As String = ""
        Dim style As MsgBoxStyle
        'Dim response As MsgBoxResult

        If TipoBoton = 128 Then
            style = MsgBoxStyle.YesNo
            title = "Consulta"
        End If

        Return MsgBox(msg, style, title)
    End Function

    Public Function FnxLocalLeerArchivoImagen(sDireccion As String) As Byte()
        Dim fStream As New FileStream(sDireccion, FileMode.Open, FileAccess.Read)
        Dim imgData(0 To fStream.Length - 1) As Byte
        ' Lee la información del archivo
        fStream.Read(imgData, 0, CInt(fStream.Length))
        fStream.Close()
        Return imgData
    End Function

    Public Class ControlAccesoIni
        Public key As String = "AaBbCcDdEe@1!2#3$4%5&6/7(8)9=.z,Z{X}x°ÑñCAHSA$1"
        Public Function FnxProcEC000(cadena As String) As String
            Dim keyArray As Byte()
            Dim Arreglo_a_Cifrar As Byte() = UTF8Encoding.UTF8.GetBytes(cadena)
            Dim hashmd5 As New MD5CryptoServiceProvider()
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
            hashmd5.Clear()
            Dim tdes As New TripleDESCryptoServiceProvider()
            tdes.Key = keyArray
            tdes.Mode = CipherMode.ECB
            tdes.Padding = PaddingMode.PKCS7
            Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()
            Dim ArrayResultado As Byte() = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length)
            tdes.Clear()
            Return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length)
        End Function

        Public Function FnxProcDC001(clave As String) As String
            Dim keyArray As Byte()
            Dim Array_a_Descifrar As Byte() = Convert.FromBase64String(clave)
            Dim hashmd5 As New MD5CryptoServiceProvider()
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
            hashmd5.Clear()
            Dim tdes As New TripleDESCryptoServiceProvider()
            tdes.Key = keyArray
            tdes.Mode = CipherMode.ECB
            tdes.Padding = PaddingMode.PKCS7
            Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
            Dim resultArray As Byte() = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length)
            tdes.Clear()
            Return UTF8Encoding.UTF8.GetString(resultArray)
        End Function
    End Class
End Class
