<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ROchaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChaparronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuchinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ROchaToolStripMenuItem, Me.ChaparronToolStripMenuItem, Me.LuchinToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TallerToolStripMenuItem, Me.AdministracionToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'TallerToolStripMenuItem
        '
        Me.TallerToolStripMenuItem.Name = "TallerToolStripMenuItem"
        Me.TallerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TallerToolStripMenuItem.Text = "Taller"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'ROchaToolStripMenuItem
        '
        Me.ROchaToolStripMenuItem.Name = "ROchaToolStripMenuItem"
        Me.ROchaToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ROchaToolStripMenuItem.Text = "ROcha"
        '
        'ChaparronToolStripMenuItem
        '
        Me.ChaparronToolStripMenuItem.Name = "ChaparronToolStripMenuItem"
        Me.ChaparronToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ChaparronToolStripMenuItem.Text = "Chaparro"
        '
        'LuchinToolStripMenuItem
        '
        Me.LuchinToolStripMenuItem.Name = "LuchinToolStripMenuItem"
        Me.LuchinToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.LuchinToolStripMenuItem.Text = "luchin"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TallerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ROchaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChaparronToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LuchinToolStripMenuItem As ToolStripMenuItem
End Class
