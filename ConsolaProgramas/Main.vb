Imports System.Threading
Imports System.Globalization
Module Main
    Sub Main()

        'Verifica si ya existe una instancia o sesion de nuestra aplicacion en linea
        'If Process.GetProcessesByName( _
        '   Process.GetCurrentProcess.ProcessName).Length > 1 Then
        '    MessageBox.Show("Ya existe una instancia abierta...")
        'Else
        'Registrar el paquete de skins extras

        'If Not (Thread.CurrentThread.CurrentCulture.Name = My.Settings.cultura) Then
        'asignar el idioma guardado en My.Settings.Cultura
        ' al hilo que ejecuta el programa
        Thread.CurrentThread.CurrentCulture = New CultureInfo(My.Settings.cultura)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.cultura)
        'asigno el tipo de separador para los números decimales ya que la aplicación va a importar datos numéricos de un mismo fichero .txt externo que es independiente a la cultura seleccionada
        Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        'End If

        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

        Application.Run(New GenPrincipalFrm())
        'End If
    End Sub
End Module
