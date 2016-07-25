<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraForm1
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
        Me.EstablishmenttableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstablishmenttableTableAdapter = New DXApplication4.dbdbDataSetTableAdapters.establishmenttableTableAdapter()
        Me.TableAdapterManager = New DXApplication4.dbdbDataSetTableAdapters.TableAdapterManager()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.EstablishmentNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstablishmentAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EstablishmentOwnerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NoOfMaleWorkersSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.NoOfFemaleWorkersSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.UnionComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CBAComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.EstablishmentTypeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.NatureOfBusinessComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForEstablishmentName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstablishmentAddress = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstablishmentOwner = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNoOfMaleWorkers = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUnion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEstablishmentType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNoOfFemaleWorkers = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCBA = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNatureOfBusiness = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DbdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstablishmenttableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.EstablishmentNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstablishmentAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstablishmentOwnerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoOfMaleWorkersSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoOfFemaleWorkersSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnionComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBAComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstablishmentTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NatureOfBusinessComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstablishmentName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstablishmentAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstablishmentOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNoOfMaleWorkers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUnion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEstablishmentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNoOfFemaleWorkers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCBA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNatureOfBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DbdbDataSet
        '
        Me.DbdbDataSet.DataSetName = "dbdbDataSet"
        Me.DbdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstablishmenttableBindingSource
        '
        Me.EstablishmenttableBindingSource.DataMember = "establishmenttable"
        Me.EstablishmenttableBindingSource.DataSource = Me.DbdbDataSet
        '
        'EstablishmenttableTableAdapter
        '
        Me.EstablishmenttableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accountstableTableAdapter = Nothing
        Me.TableAdapterManager.assessmentlisttableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.establishmenttableTableAdapter = Me.EstablishmenttableTableAdapter
        Me.TableAdapterManager.logtableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DXApplication4.dbdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.violationlistTableAdapter = Nothing
        Me.TableAdapterManager.violationstableTableAdapter = Nothing
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.EstablishmentNameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EstablishmentAddressTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EstablishmentOwnerTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NoOfMaleWorkersSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NoOfFemaleWorkersSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UnionComboBoxEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CBAComboBoxEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EstablishmentTypeComboBoxEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NatureOfBusinessComboBoxEdit)
        Me.DataLayoutControl1.DataSource = Me.EstablishmenttableBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(55, 152, 481, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.ShowTemplates = True
        Me.DataLayoutControl1.Size = New System.Drawing.Size(446, 173)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'EstablishmentNameTextEdit
        '
        Me.EstablishmentNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EstablishmenttableBindingSource, "EstablishmentName", True))
        Me.EstablishmentNameTextEdit.Location = New System.Drawing.Point(123, 12)
        Me.EstablishmentNameTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.EstablishmentNameTextEdit.Name = "EstablishmentNameTextEdit"
        Me.EstablishmentNameTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstablishmentNameTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EstablishmentNameTextEdit.Size = New System.Drawing.Size(311, 20)
        Me.EstablishmentNameTextEdit.StyleController = Me.DataLayoutControl1
        Me.EstablishmentNameTextEdit.TabIndex = 4
        '
        'EstablishmentAddressTextEdit
        '
        Me.EstablishmentAddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EstablishmenttableBindingSource, "EstablishmentAddress", True))
        Me.EstablishmentAddressTextEdit.Location = New System.Drawing.Point(123, 36)
        Me.EstablishmentAddressTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.EstablishmentAddressTextEdit.Name = "EstablishmentAddressTextEdit"
        Me.EstablishmentAddressTextEdit.Size = New System.Drawing.Size(311, 20)
        Me.EstablishmentAddressTextEdit.StyleController = Me.DataLayoutControl1
        Me.EstablishmentAddressTextEdit.TabIndex = 5
        '
        'EstablishmentOwnerTextEdit
        '
        Me.EstablishmentOwnerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EstablishmenttableBindingSource, "EstablishmentOwner", True))
        Me.EstablishmentOwnerTextEdit.Location = New System.Drawing.Point(123, 60)
        Me.EstablishmentOwnerTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.EstablishmentOwnerTextEdit.Name = "EstablishmentOwnerTextEdit"
        Me.EstablishmentOwnerTextEdit.Size = New System.Drawing.Size(311, 20)
        Me.EstablishmentOwnerTextEdit.StyleController = Me.DataLayoutControl1
        Me.EstablishmentOwnerTextEdit.TabIndex = 6
        '
        'NoOfMaleWorkersSpinEdit
        '
        Me.NoOfMaleWorkersSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EstablishmenttableBindingSource, "NoOfMaleWorkers", True))
        Me.NoOfMaleWorkersSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NoOfMaleWorkersSpinEdit.Location = New System.Drawing.Point(123, 84)
        Me.NoOfMaleWorkersSpinEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.NoOfMaleWorkersSpinEdit.Name = "NoOfMaleWorkersSpinEdit"
        Me.NoOfMaleWorkersSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NoOfMaleWorkersSpinEdit.Properties.IsFloatValue = False
        Me.NoOfMaleWorkersSpinEdit.Properties.Mask.EditMask = "N00"
        Me.NoOfMaleWorkersSpinEdit.Size = New System.Drawing.Size(97, 20)
        Me.NoOfMaleWorkersSpinEdit.StyleController = Me.DataLayoutControl1
        Me.NoOfMaleWorkersSpinEdit.TabIndex = 7
        '
        'NoOfFemaleWorkersSpinEdit
        '
        Me.NoOfFemaleWorkersSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EstablishmenttableBindingSource, "NoOfFemaleWorkers", True))
        Me.NoOfFemaleWorkersSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NoOfFemaleWorkersSpinEdit.Location = New System.Drawing.Point(335, 84)
        Me.NoOfFemaleWorkersSpinEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.NoOfFemaleWorkersSpinEdit.Name = "NoOfFemaleWorkersSpinEdit"
        Me.NoOfFemaleWorkersSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NoOfFemaleWorkersSpinEdit.Properties.IsFloatValue = False
        Me.NoOfFemaleWorkersSpinEdit.Properties.Mask.EditMask = "N00"
        Me.NoOfFemaleWorkersSpinEdit.Size = New System.Drawing.Size(99, 20)
        Me.NoOfFemaleWorkersSpinEdit.StyleController = Me.DataLayoutControl1
        Me.NoOfFemaleWorkersSpinEdit.TabIndex = 8
        '
        'UnionComboBoxEdit
        '
        Me.UnionComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EstablishmenttableBindingSource, "Union", True))
        Me.UnionComboBoxEdit.Location = New System.Drawing.Point(123, 108)
        Me.UnionComboBoxEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.UnionComboBoxEdit.Name = "UnionComboBoxEdit"
        Me.UnionComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnionComboBoxEdit.Properties.Items.AddRange(New Object() {"YES", "NO"})
        Me.UnionComboBoxEdit.Size = New System.Drawing.Size(97, 20)
        Me.UnionComboBoxEdit.StyleController = Me.DataLayoutControl1
        Me.UnionComboBoxEdit.TabIndex = 9
        '
        'CBAComboBoxEdit
        '
        Me.CBAComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EstablishmenttableBindingSource, "CBA", True))
        Me.CBAComboBoxEdit.Location = New System.Drawing.Point(335, 108)
        Me.CBAComboBoxEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.CBAComboBoxEdit.Name = "CBAComboBoxEdit"
        Me.CBAComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBAComboBoxEdit.Properties.Items.AddRange(New Object() {"YES", "NO"})
        Me.CBAComboBoxEdit.Size = New System.Drawing.Size(99, 20)
        Me.CBAComboBoxEdit.StyleController = Me.DataLayoutControl1
        Me.CBAComboBoxEdit.TabIndex = 10
        '
        'EstablishmentTypeComboBoxEdit
        '
        Me.EstablishmentTypeComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EstablishmenttableBindingSource, "EstablishmentType", True))
        Me.EstablishmentTypeComboBoxEdit.Location = New System.Drawing.Point(123, 132)
        Me.EstablishmentTypeComboBoxEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.EstablishmentTypeComboBoxEdit.Name = "EstablishmentTypeComboBoxEdit"
        Me.EstablishmentTypeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EstablishmentTypeComboBoxEdit.Size = New System.Drawing.Size(97, 20)
        Me.EstablishmentTypeComboBoxEdit.StyleController = Me.DataLayoutControl1
        Me.EstablishmentTypeComboBoxEdit.TabIndex = 11
        '
        'NatureOfBusinessComboBoxEdit
        '
        Me.NatureOfBusinessComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EstablishmenttableBindingSource, "NatureOfBusiness", True))
        Me.NatureOfBusinessComboBoxEdit.Location = New System.Drawing.Point(335, 132)
        Me.NatureOfBusinessComboBoxEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.NatureOfBusinessComboBoxEdit.Name = "NatureOfBusinessComboBoxEdit"
        Me.NatureOfBusinessComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NatureOfBusinessComboBoxEdit.Size = New System.Drawing.Size(99, 20)
        Me.NatureOfBusinessComboBoxEdit.StyleController = Me.DataLayoutControl1
        Me.NatureOfBusinessComboBoxEdit.TabIndex = 12
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(446, 173)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForEstablishmentName, Me.ItemForEstablishmentAddress, Me.ItemForEstablishmentOwner, Me.ItemForNoOfMaleWorkers, Me.ItemForUnion, Me.ItemForEstablishmentType, Me.ItemForNoOfFemaleWorkers, Me.ItemForCBA, Me.ItemForNatureOfBusiness})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(426, 153)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForEstablishmentName
        '
        Me.ItemForEstablishmentName.Control = Me.EstablishmentNameTextEdit
        Me.ItemForEstablishmentName.CustomizationFormText = "Establishment Name"
        Me.ItemForEstablishmentName.Location = New System.Drawing.Point(0, 0)
        Me.ItemForEstablishmentName.Name = "ItemForEstablishmentName"
        Me.ItemForEstablishmentName.Size = New System.Drawing.Size(426, 24)
        Me.ItemForEstablishmentName.Text = "Establishment Name"
        Me.ItemForEstablishmentName.TextSize = New System.Drawing.Size(108, 13)
        '
        'ItemForEstablishmentAddress
        '
        Me.ItemForEstablishmentAddress.Control = Me.EstablishmentAddressTextEdit
        Me.ItemForEstablishmentAddress.CustomizationFormText = "Establishment Address"
        Me.ItemForEstablishmentAddress.Location = New System.Drawing.Point(0, 24)
        Me.ItemForEstablishmentAddress.Name = "ItemForEstablishmentAddress"
        Me.ItemForEstablishmentAddress.Size = New System.Drawing.Size(426, 24)
        Me.ItemForEstablishmentAddress.Text = "Establishment Address"
        Me.ItemForEstablishmentAddress.TextSize = New System.Drawing.Size(108, 13)
        '
        'ItemForEstablishmentOwner
        '
        Me.ItemForEstablishmentOwner.Control = Me.EstablishmentOwnerTextEdit
        Me.ItemForEstablishmentOwner.CustomizationFormText = "Establishment Owner"
        Me.ItemForEstablishmentOwner.Location = New System.Drawing.Point(0, 48)
        Me.ItemForEstablishmentOwner.Name = "ItemForEstablishmentOwner"
        Me.ItemForEstablishmentOwner.Size = New System.Drawing.Size(426, 24)
        Me.ItemForEstablishmentOwner.Text = "Establishment Owner"
        Me.ItemForEstablishmentOwner.TextSize = New System.Drawing.Size(108, 13)
        '
        'ItemForNoOfMaleWorkers
        '
        Me.ItemForNoOfMaleWorkers.Control = Me.NoOfMaleWorkersSpinEdit
        Me.ItemForNoOfMaleWorkers.CustomizationFormText = "No Of Male Workers"
        Me.ItemForNoOfMaleWorkers.Location = New System.Drawing.Point(0, 72)
        Me.ItemForNoOfMaleWorkers.Name = "ItemForNoOfMaleWorkers"
        Me.ItemForNoOfMaleWorkers.Size = New System.Drawing.Size(212, 24)
        Me.ItemForNoOfMaleWorkers.Text = "No Of Male Workers"
        Me.ItemForNoOfMaleWorkers.TextSize = New System.Drawing.Size(108, 13)
        '
        'ItemForUnion
        '
        Me.ItemForUnion.Control = Me.UnionComboBoxEdit
        Me.ItemForUnion.CustomizationFormText = "Union"
        Me.ItemForUnion.Location = New System.Drawing.Point(0, 96)
        Me.ItemForUnion.Name = "ItemForUnion"
        Me.ItemForUnion.Size = New System.Drawing.Size(212, 24)
        Me.ItemForUnion.Text = "Union"
        Me.ItemForUnion.TextSize = New System.Drawing.Size(108, 13)
        '
        'ItemForEstablishmentType
        '
        Me.ItemForEstablishmentType.Control = Me.EstablishmentTypeComboBoxEdit
        Me.ItemForEstablishmentType.CustomizationFormText = "Establishment Type"
        Me.ItemForEstablishmentType.Location = New System.Drawing.Point(0, 120)
        Me.ItemForEstablishmentType.Name = "ItemForEstablishmentType"
        Me.ItemForEstablishmentType.Size = New System.Drawing.Size(212, 33)
        Me.ItemForEstablishmentType.Text = "Establishment Type"
        Me.ItemForEstablishmentType.TextSize = New System.Drawing.Size(108, 13)
        '
        'ItemForNoOfFemaleWorkers
        '
        Me.ItemForNoOfFemaleWorkers.Control = Me.NoOfFemaleWorkersSpinEdit
        Me.ItemForNoOfFemaleWorkers.CustomizationFormText = "No Of Female Workers"
        Me.ItemForNoOfFemaleWorkers.Location = New System.Drawing.Point(212, 72)
        Me.ItemForNoOfFemaleWorkers.Name = "ItemForNoOfFemaleWorkers"
        Me.ItemForNoOfFemaleWorkers.Size = New System.Drawing.Size(214, 24)
        Me.ItemForNoOfFemaleWorkers.Text = "No Of Female Workers"
        Me.ItemForNoOfFemaleWorkers.TextSize = New System.Drawing.Size(108, 13)
        '
        'ItemForCBA
        '
        Me.ItemForCBA.Control = Me.CBAComboBoxEdit
        Me.ItemForCBA.CustomizationFormText = "CBA"
        Me.ItemForCBA.Location = New System.Drawing.Point(212, 96)
        Me.ItemForCBA.Name = "ItemForCBA"
        Me.ItemForCBA.Size = New System.Drawing.Size(214, 24)
        Me.ItemForCBA.Text = "CBA"
        Me.ItemForCBA.TextSize = New System.Drawing.Size(108, 13)
        '
        'ItemForNatureOfBusiness
        '
        Me.ItemForNatureOfBusiness.Control = Me.NatureOfBusinessComboBoxEdit
        Me.ItemForNatureOfBusiness.CustomizationFormText = "Nature Of Business"
        Me.ItemForNatureOfBusiness.Location = New System.Drawing.Point(212, 120)
        Me.ItemForNatureOfBusiness.Name = "ItemForNatureOfBusiness"
        Me.ItemForNatureOfBusiness.Size = New System.Drawing.Size(214, 33)
        Me.ItemForNatureOfBusiness.Text = "Nature Of Business"
        Me.ItemForNatureOfBusiness.TextSize = New System.Drawing.Size(108, 13)
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSize = True
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 173)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(446, 35)
        Me.PanelControl1.TabIndex = 1
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton3.Location = New System.Drawing.Point(301, 2)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(150, 31)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Cancel"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton2.Location = New System.Drawing.Point(151, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(150, 31)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Clea&r"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton1.Location = New System.Drawing.Point(2, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(149, 31)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Save"
        '
        'XtraForm1
        '
        Me.AcceptButton = Me.SimpleButton1
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SimpleButton3
        Me.ClientSize = New System.Drawing.Size(446, 208)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "XtraForm1"
        Me.Text = "Add New Establishment"
        CType(Me.DbdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstablishmenttableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.EstablishmentNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstablishmentAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstablishmentOwnerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoOfMaleWorkersSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoOfFemaleWorkersSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnionComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBAComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstablishmentTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NatureOfBusinessComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstablishmentName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstablishmentAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstablishmentOwner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNoOfMaleWorkers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUnion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEstablishmentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNoOfFemaleWorkers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCBA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNatureOfBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbdbDataSet As DXApplication4.dbdbDataSet
    Friend WithEvents EstablishmenttableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstablishmenttableTableAdapter As DXApplication4.dbdbDataSetTableAdapters.establishmenttableTableAdapter
    Friend WithEvents TableAdapterManager As DXApplication4.dbdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents EstablishmentNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EstablishmentAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EstablishmentOwnerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NoOfMaleWorkersSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NoOfFemaleWorkersSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents UnionComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CBAComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents EstablishmentTypeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents NatureOfBusinessComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForEstablishmentName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstablishmentAddress As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstablishmentOwner As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNoOfMaleWorkers As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUnion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEstablishmentType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNoOfFemaleWorkers As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCBA As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNatureOfBusiness As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
