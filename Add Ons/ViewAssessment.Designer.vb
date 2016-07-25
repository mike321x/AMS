<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAssessment
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
        Me.DbdbDataSet = New DXApplication4.dbdbDataSet()
        Me.DbdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DbdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbdbDataSet
        '
        Me.DbdbDataSet.DataSetName = "dbdbDataSet"
        Me.DbdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbdbDataSetBindingSource
        '
        Me.DbdbDataSetBindingSource.DataSource = Me.DbdbDataSet
        Me.DbdbDataSetBindingSource.Position = 0
        '
        'ViewAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 386)
        Me.Name = "ViewAssessment"
        Me.Text = "View Assessment"
        CType(Me.DbdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbdbDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbdbDataSet As DXApplication4.dbdbDataSet
End Class
