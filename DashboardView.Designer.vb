﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardView
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardView))
        Me.DashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.None
        Me.DashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = CType(0, Byte)
        Me.DashboardViewer1.PrintingOptions.FontInfo.Name = Nothing
        Me.DashboardViewer1.Size = New System.Drawing.Size(813, 441)
        Me.DashboardViewer1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(114, 29)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Refresh Data"
        '
        'DashboardView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 441)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.DashboardViewer1)
        Me.Name = "DashboardView"
        Me.Text = "DashboardView"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
