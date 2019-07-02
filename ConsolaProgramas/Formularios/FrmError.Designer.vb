<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmError
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmError))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.lvError = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "advertencia 32.png")
        Me.ImageList1.Images.SetKeyName(1, "advertencia 32.ico")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(373, 196)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Cancelar"
        '
        'lvError
        '
        Me.lvError.LargeImageList = Me.ImageList1
        Me.lvError.Location = New System.Drawing.Point(10, 3)
        Me.lvError.Name = "lvError"
        Me.lvError.Size = New System.Drawing.Size(438, 187)
        Me.lvError.SmallImageList = Me.ImageList1
        Me.lvError.TabIndex = 2
        Me.lvError.UseCompatibleStateImageBehavior = False
        Me.lvError.View = System.Windows.Forms.View.List
        '
        'FrmError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 231)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lvError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmError"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Errores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lvError As System.Windows.Forms.ListView
End Class
