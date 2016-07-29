Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.iNew = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.iHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.siStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.siInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.alignButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iBoldFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iItalicFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iUnderlinedFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.fontStyleButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iLeftTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iCenterTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iRightTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.homeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.fileRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.exitRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewEstablishmentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewAssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstablishmenttableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbdbDataSet = New DXApplication4.dbdbDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEstablishmentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentOwner = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoOfMaleWorkers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoOfFemaleWorkers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCBA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNatureOfBusiness = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewAssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAssessmentStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoViolationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WithViolationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompliedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCOCStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForIssuanceGLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForIssuanceOSHSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForIssuanceGLSOSHSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssuedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfAssessmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAssessmentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentAddress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentOwner1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentTypeVisit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentAuthorityNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOCStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentLLCO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.ForCOCIssuanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAssessmentID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentAddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstablishmentOwner2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentTypeVisit1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentStatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentAuthorityNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentCategory1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOCStatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAssessmentLLCO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EstablishmenttableTableAdapter = New DXApplication4.dbdbDataSetTableAdapters.establishmenttableTableAdapter()
        Me.TableAdapterManager = New DXApplication4.dbdbDataSetTableAdapters.TableAdapterManager()
        Me.ListOfAssessmentTableAdapter = New DXApplication4.dbdbDataSetTableAdapters.ListOfAssessmentTableAdapter()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ForCOCIssuanceTableAdapter = New DXApplication4.dbdbDataSetTableAdapters.ForCOCIssuanceTableAdapter()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.EstablishmenttableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.ListOfAssessmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForCOCIssuanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.iNew, Me.iExit, Me.iHelp, Me.iAbout, Me.siStatus, Me.siInfo, Me.alignButtonGroup, Me.iBoldFontStyle, Me.iItalicFontStyle, Me.iUnderlinedFontStyle, Me.fontStyleButtonGroup, Me.iLeftTextAlign, Me.iCenterTextAlign, Me.iRightTextAlign, Me.rgbiSkins, Me.BarButtonItem1, Me.SkinRibbonGalleryBarItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 7
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.iAbout)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.homeRibbonPage})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.Size = New System.Drawing.Size(1100, 144)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.iNew)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.iHelp)
        '
        'appMenu
        '
        Me.appMenu.ItemLinks.Add(Me.iNew)
        Me.appMenu.ItemLinks.Add(Me.BarButtonItem1)
        Me.appMenu.ItemLinks.Add(Me.iExit)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.ShowRightPane = True
        '
        'iNew
        '
        Me.iNew.Caption = "New Establishment"
        Me.iNew.Description = "Creates a new, blank file."
        Me.iNew.Glyph = CType(resources.GetObject("iNew.Glyph"), System.Drawing.Image)
        Me.iNew.Hint = "Creates a new, blank file"
        Me.iNew.Id = 1
        Me.iNew.ImageIndex = 0
        Me.iNew.LargeGlyph = CType(resources.GetObject("iNew.LargeGlyph"), System.Drawing.Image)
        Me.iNew.LargeImageIndex = 0
        Me.iNew.Name = "iNew"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "New Assessment"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 63
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'iExit
        '
        Me.iExit.Caption = "Exit"
        Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
        Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
        Me.iExit.Id = 20
        Me.iExit.ImageIndex = 6
        Me.iExit.LargeImageIndex = 6
        Me.iExit.Name = "iExit"
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        '
        'iHelp
        '
        Me.iHelp.Caption = "Help"
        Me.iHelp.Description = "Start the program help system."
        Me.iHelp.Hint = "Start the program help system"
        Me.iHelp.Id = 22
        Me.iHelp.ImageIndex = 7
        Me.iHelp.LargeImageIndex = 7
        Me.iHelp.Name = "iHelp"
        '
        'iAbout
        '
        Me.iAbout.Caption = "About"
        Me.iAbout.Description = "Displays general program information."
        Me.iAbout.Hint = "Displays general program information"
        Me.iAbout.Id = 24
        Me.iAbout.ImageIndex = 8
        Me.iAbout.LargeImageIndex = 8
        Me.iAbout.Name = "iAbout"
        '
        'siStatus
        '
        Me.siStatus.Caption = "Some Status Info"
        Me.siStatus.Id = 31
        Me.siStatus.Name = "siStatus"
        Me.siStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'siInfo
        '
        Me.siInfo.Caption = "Some Info"
        Me.siInfo.Id = 32
        Me.siInfo.Name = "siInfo"
        Me.siInfo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'alignButtonGroup
        '
        Me.alignButtonGroup.Caption = "Align Commands"
        Me.alignButtonGroup.Id = 52
        Me.alignButtonGroup.ItemLinks.Add(Me.iBoldFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iItalicFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iUnderlinedFontStyle)
        Me.alignButtonGroup.Name = "alignButtonGroup"
        '
        'iBoldFontStyle
        '
        Me.iBoldFontStyle.Caption = "Bold"
        Me.iBoldFontStyle.Id = 53
        Me.iBoldFontStyle.ImageIndex = 9
        Me.iBoldFontStyle.Name = "iBoldFontStyle"
        '
        'iItalicFontStyle
        '
        Me.iItalicFontStyle.Caption = "Italic"
        Me.iItalicFontStyle.Id = 54
        Me.iItalicFontStyle.ImageIndex = 10
        Me.iItalicFontStyle.Name = "iItalicFontStyle"
        '
        'iUnderlinedFontStyle
        '
        Me.iUnderlinedFontStyle.Caption = "Underlined"
        Me.iUnderlinedFontStyle.Id = 55
        Me.iUnderlinedFontStyle.ImageIndex = 11
        Me.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle"
        '
        'fontStyleButtonGroup
        '
        Me.fontStyleButtonGroup.Caption = "Font Style"
        Me.fontStyleButtonGroup.Id = 56
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iLeftTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iCenterTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iRightTextAlign)
        Me.fontStyleButtonGroup.Name = "fontStyleButtonGroup"
        '
        'iLeftTextAlign
        '
        Me.iLeftTextAlign.Caption = "Left"
        Me.iLeftTextAlign.Id = 57
        Me.iLeftTextAlign.ImageIndex = 12
        Me.iLeftTextAlign.Name = "iLeftTextAlign"
        '
        'iCenterTextAlign
        '
        Me.iCenterTextAlign.Caption = "Center"
        Me.iCenterTextAlign.Id = 58
        Me.iCenterTextAlign.ImageIndex = 13
        Me.iCenterTextAlign.Name = "iCenterTextAlign"
        '
        'iRightTextAlign
        '
        Me.iRightTextAlign.Caption = "Right"
        Me.iRightTextAlign.Id = 59
        Me.iRightTextAlign.ImageIndex = 14
        Me.iRightTextAlign.Name = "iRightTextAlign"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        '
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = False
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 60
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 1
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Preview"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Print"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Dashboard"
        Me.BarButtonItem4.Glyph = CType(resources.GetObject("BarButtonItem4.Glyph"), System.Drawing.Image)
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.LargeGlyph = CType(resources.GetObject("BarButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        '
        'homeRibbonPage
        '
        Me.homeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.fileRibbonPageGroup, Me.skinsRibbonPageGroup, Me.RibbonPageGroup1, Me.exitRibbonPageGroup})
        Me.homeRibbonPage.Name = "homeRibbonPage"
        Me.homeRibbonPage.Text = "Home"
        '
        'fileRibbonPageGroup
        '
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iNew)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.BarButtonItem1)
        Me.fileRibbonPageGroup.Name = "fileRibbonPageGroup"
        Me.fileRibbonPageGroup.Text = "File"
        '
        'skinsRibbonPageGroup
        '
        Me.skinsRibbonPageGroup.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
        Me.skinsRibbonPageGroup.ShowCaptionButton = False
        Me.skinsRibbonPageGroup.Text = "Skins"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "View"
        '
        'exitRibbonPageGroup
        '
        Me.exitRibbonPageGroup.ItemLinks.Add(Me.iExit)
        Me.exitRibbonPageGroup.Name = "exitRibbonPageGroup"
        Me.exitRibbonPageGroup.Text = "Exit"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.siStatus)
        Me.ribbonStatusBar.ItemLinks.Add(Me.siInfo)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 669)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1100, 31)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 144)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1100, 525)
        Me.XtraTabControl1.TabIndex = 10
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1094, 497)
        Me.XtraTabPage1.Text = "List of Establishments"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.EstablishmenttableBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.ribbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1094, 497)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewEstablishmentDetailsToolStripMenuItem, Me.AddNewAssessmentToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(214, 48)
        '
        'ViewEstablishmentDetailsToolStripMenuItem
        '
        Me.ViewEstablishmentDetailsToolStripMenuItem.Name = "ViewEstablishmentDetailsToolStripMenuItem"
        Me.ViewEstablishmentDetailsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ViewEstablishmentDetailsToolStripMenuItem.Text = "View Establishment Profile"
        '
        'AddNewAssessmentToolStripMenuItem
        '
        Me.AddNewAssessmentToolStripMenuItem.Name = "AddNewAssessmentToolStripMenuItem"
        Me.AddNewAssessmentToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AddNewAssessmentToolStripMenuItem.Text = "Add New Assessment"
        '
        'EstablishmenttableBindingSource
        '
        Me.EstablishmenttableBindingSource.DataMember = "establishmenttable"
        Me.EstablishmenttableBindingSource.DataSource = Me.DbdbDataSet
        '
        'DbdbDataSet
        '
        Me.DbdbDataSet.DataSetName = "dbdbDataSet"
        Me.DbdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEstablishmentID, Me.colEstablishmentName, Me.colEstablishmentAddress, Me.colEstablishmentOwner, Me.colNoOfMaleWorkers, Me.colNoOfFemaleWorkers, Me.colUnion, Me.colCBA, Me.colEstablishmentType, Me.colNatureOfBusiness})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'colEstablishmentID
        '
        Me.colEstablishmentID.FieldName = "EstablishmentID"
        Me.colEstablishmentID.Name = "colEstablishmentID"
        Me.colEstablishmentID.Visible = True
        Me.colEstablishmentID.VisibleIndex = 0
        '
        'colEstablishmentName
        '
        Me.colEstablishmentName.FieldName = "EstablishmentName"
        Me.colEstablishmentName.Name = "colEstablishmentName"
        Me.colEstablishmentName.Visible = True
        Me.colEstablishmentName.VisibleIndex = 1
        '
        'colEstablishmentAddress
        '
        Me.colEstablishmentAddress.FieldName = "EstablishmentAddress"
        Me.colEstablishmentAddress.Name = "colEstablishmentAddress"
        Me.colEstablishmentAddress.Visible = True
        Me.colEstablishmentAddress.VisibleIndex = 2
        '
        'colEstablishmentOwner
        '
        Me.colEstablishmentOwner.FieldName = "EstablishmentOwner"
        Me.colEstablishmentOwner.Name = "colEstablishmentOwner"
        Me.colEstablishmentOwner.Visible = True
        Me.colEstablishmentOwner.VisibleIndex = 3
        '
        'colNoOfMaleWorkers
        '
        Me.colNoOfMaleWorkers.FieldName = "NoOfMaleWorkers"
        Me.colNoOfMaleWorkers.Name = "colNoOfMaleWorkers"
        Me.colNoOfMaleWorkers.Visible = True
        Me.colNoOfMaleWorkers.VisibleIndex = 4
        '
        'colNoOfFemaleWorkers
        '
        Me.colNoOfFemaleWorkers.FieldName = "NoOfFemaleWorkers"
        Me.colNoOfFemaleWorkers.Name = "colNoOfFemaleWorkers"
        Me.colNoOfFemaleWorkers.Visible = True
        Me.colNoOfFemaleWorkers.VisibleIndex = 5
        '
        'colUnion
        '
        Me.colUnion.FieldName = "Union"
        Me.colUnion.Name = "colUnion"
        Me.colUnion.Visible = True
        Me.colUnion.VisibleIndex = 6
        '
        'colCBA
        '
        Me.colCBA.FieldName = "CBA"
        Me.colCBA.Name = "colCBA"
        Me.colCBA.Visible = True
        Me.colCBA.VisibleIndex = 7
        '
        'colEstablishmentType
        '
        Me.colEstablishmentType.FieldName = "EstablishmentType"
        Me.colEstablishmentType.Name = "colEstablishmentType"
        Me.colEstablishmentType.Visible = True
        Me.colEstablishmentType.VisibleIndex = 8
        '
        'colNatureOfBusiness
        '
        Me.colNatureOfBusiness.FieldName = "NatureOfBusiness"
        Me.colNatureOfBusiness.Name = "colNatureOfBusiness"
        Me.colNatureOfBusiness.Visible = True
        Me.colNatureOfBusiness.VisibleIndex = 9
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1094, 497)
        Me.XtraTabPage2.Text = "List of Assessments"
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.GridControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl2.DataSource = Me.ListOfAssessmentBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.ribbonControl
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1094, 497)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAssessmentToolStripMenuItem, Me.UpdateAssessmentStatusToolStripMenuItem, Me.UpdateCOCStatusToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(213, 70)
        '
        'ViewAssessmentToolStripMenuItem
        '
        Me.ViewAssessmentToolStripMenuItem.Name = "ViewAssessmentToolStripMenuItem"
        Me.ViewAssessmentToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ViewAssessmentToolStripMenuItem.Text = "View Assessment"
        '
        'UpdateAssessmentStatusToolStripMenuItem
        '
        Me.UpdateAssessmentStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoViolationToolStripMenuItem, Me.WithViolationToolStripMenuItem, Me.CompliedToolStripMenuItem})
        Me.UpdateAssessmentStatusToolStripMenuItem.Name = "UpdateAssessmentStatusToolStripMenuItem"
        Me.UpdateAssessmentStatusToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.UpdateAssessmentStatusToolStripMenuItem.Text = "Update Assessment Status"
        '
        'NoViolationToolStripMenuItem
        '
        Me.NoViolationToolStripMenuItem.Name = "NoViolationToolStripMenuItem"
        Me.NoViolationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NoViolationToolStripMenuItem.Text = "No Violation"
        '
        'WithViolationToolStripMenuItem
        '
        Me.WithViolationToolStripMenuItem.Name = "WithViolationToolStripMenuItem"
        Me.WithViolationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WithViolationToolStripMenuItem.Text = "With Violation"
        '
        'CompliedToolStripMenuItem
        '
        Me.CompliedToolStripMenuItem.Name = "CompliedToolStripMenuItem"
        Me.CompliedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CompliedToolStripMenuItem.Text = "Complied"
        '
        'UpdateCOCStatusToolStripMenuItem
        '
        Me.UpdateCOCStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintedToolStripMenuItem, Me.ForIssuanceGLSToolStripMenuItem, Me.ForIssuanceOSHSToolStripMenuItem, Me.ForIssuanceGLSOSHSToolStripMenuItem, Me.IssuedToolStripMenuItem})
        Me.UpdateCOCStatusToolStripMenuItem.Name = "UpdateCOCStatusToolStripMenuItem"
        Me.UpdateCOCStatusToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.UpdateCOCStatusToolStripMenuItem.Text = "Update COC Status"
        '
        'PrintedToolStripMenuItem
        '
        Me.PrintedToolStripMenuItem.Name = "PrintedToolStripMenuItem"
        Me.PrintedToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.PrintedToolStripMenuItem.Text = "Printed"
        '
        'ForIssuanceGLSToolStripMenuItem
        '
        Me.ForIssuanceGLSToolStripMenuItem.Name = "ForIssuanceGLSToolStripMenuItem"
        Me.ForIssuanceGLSToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ForIssuanceGLSToolStripMenuItem.Text = "For Issuance GLS"
        '
        'ForIssuanceOSHSToolStripMenuItem
        '
        Me.ForIssuanceOSHSToolStripMenuItem.Name = "ForIssuanceOSHSToolStripMenuItem"
        Me.ForIssuanceOSHSToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ForIssuanceOSHSToolStripMenuItem.Text = "For Issuance OSHS"
        '
        'ForIssuanceGLSOSHSToolStripMenuItem
        '
        Me.ForIssuanceGLSOSHSToolStripMenuItem.Name = "ForIssuanceGLSOSHSToolStripMenuItem"
        Me.ForIssuanceGLSOSHSToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ForIssuanceGLSOSHSToolStripMenuItem.Text = "For Issuance GLS and OSHS"
        '
        'IssuedToolStripMenuItem
        '
        Me.IssuedToolStripMenuItem.Name = "IssuedToolStripMenuItem"
        Me.IssuedToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.IssuedToolStripMenuItem.Text = "Issued"
        '
        'ListOfAssessmentBindingSource
        '
        Me.ListOfAssessmentBindingSource.DataMember = "ListOfAssessment"
        Me.ListOfAssessmentBindingSource.DataSource = Me.DbdbDataSet
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAssessmentID, Me.colEstablishmentName1, Me.colEstablishmentAddress1, Me.colEstablishmentOwner1, Me.colAssessmentTypeVisit, Me.colAssessmentStatus, Me.colAssessmentDate, Me.colAssessmentAuthorityNumber, Me.colAssessmentCategory, Me.colCOCStatus, Me.colAssessmentLLCO})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        '
        'colAssessmentID
        '
        Me.colAssessmentID.FieldName = "AssessmentID"
        Me.colAssessmentID.Name = "colAssessmentID"
        Me.colAssessmentID.Visible = True
        Me.colAssessmentID.VisibleIndex = 0
        '
        'colEstablishmentName1
        '
        Me.colEstablishmentName1.Caption = "Name of Establishment"
        Me.colEstablishmentName1.FieldName = "EstablishmentName"
        Me.colEstablishmentName1.Name = "colEstablishmentName1"
        Me.colEstablishmentName1.Visible = True
        Me.colEstablishmentName1.VisibleIndex = 1
        '
        'colEstablishmentAddress1
        '
        Me.colEstablishmentAddress1.Caption = "Address"
        Me.colEstablishmentAddress1.FieldName = "EstablishmentAddress"
        Me.colEstablishmentAddress1.Name = "colEstablishmentAddress1"
        Me.colEstablishmentAddress1.Visible = True
        Me.colEstablishmentAddress1.VisibleIndex = 2
        '
        'colEstablishmentOwner1
        '
        Me.colEstablishmentOwner1.Caption = "Owner"
        Me.colEstablishmentOwner1.FieldName = "EstablishmentOwner"
        Me.colEstablishmentOwner1.Name = "colEstablishmentOwner1"
        Me.colEstablishmentOwner1.Visible = True
        Me.colEstablishmentOwner1.VisibleIndex = 3
        '
        'colAssessmentTypeVisit
        '
        Me.colAssessmentTypeVisit.Caption = "Type of Visit"
        Me.colAssessmentTypeVisit.FieldName = "AssessmentTypeVisit"
        Me.colAssessmentTypeVisit.Name = "colAssessmentTypeVisit"
        Me.colAssessmentTypeVisit.Visible = True
        Me.colAssessmentTypeVisit.VisibleIndex = 4
        '
        'colAssessmentStatus
        '
        Me.colAssessmentStatus.FieldName = "AssessmentStatus"
        Me.colAssessmentStatus.Name = "colAssessmentStatus"
        Me.colAssessmentStatus.Visible = True
        Me.colAssessmentStatus.VisibleIndex = 5
        '
        'colAssessmentDate
        '
        Me.colAssessmentDate.FieldName = "AssessmentDate"
        Me.colAssessmentDate.Name = "colAssessmentDate"
        Me.colAssessmentDate.Visible = True
        Me.colAssessmentDate.VisibleIndex = 6
        '
        'colAssessmentAuthorityNumber
        '
        Me.colAssessmentAuthorityNumber.Caption = "Authority Number"
        Me.colAssessmentAuthorityNumber.FieldName = "AssessmentAuthorityNumber"
        Me.colAssessmentAuthorityNumber.Name = "colAssessmentAuthorityNumber"
        Me.colAssessmentAuthorityNumber.Visible = True
        Me.colAssessmentAuthorityNumber.VisibleIndex = 7
        '
        'colAssessmentCategory
        '
        Me.colAssessmentCategory.Caption = "Category"
        Me.colAssessmentCategory.FieldName = "AssessmentCategory"
        Me.colAssessmentCategory.Name = "colAssessmentCategory"
        Me.colAssessmentCategory.Visible = True
        Me.colAssessmentCategory.VisibleIndex = 8
        '
        'colCOCStatus
        '
        Me.colCOCStatus.FieldName = "COCStatus"
        Me.colCOCStatus.Name = "colCOCStatus"
        Me.colCOCStatus.Visible = True
        Me.colCOCStatus.VisibleIndex = 9
        '
        'colAssessmentLLCO
        '
        Me.colAssessmentLLCO.Caption = "Assessed By"
        Me.colAssessmentLLCO.FieldName = "AssessmentLLCO"
        Me.colAssessmentLLCO.Name = "colAssessmentLLCO"
        Me.colAssessmentLLCO.Visible = True
        Me.colAssessmentLLCO.VisibleIndex = 10
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl3)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1094, 497)
        Me.XtraTabPage3.Text = "For Issuance of COC"
        '
        'GridControl3
        '
        Me.GridControl3.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl3.DataSource = Me.ForCOCIssuanceBindingSource
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.MenuManager = Me.ribbonControl
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(1094, 497)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'ForCOCIssuanceBindingSource
        '
        Me.ForCOCIssuanceBindingSource.DataMember = "ForCOCIssuance"
        Me.ForCOCIssuanceBindingSource.DataSource = Me.DbdbDataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAssessmentID1, Me.colEstablishmentName2, Me.colEstablishmentAddress2, Me.colEstablishmentOwner2, Me.colAssessmentTypeVisit1, Me.colAssessmentStatus1, Me.colAssessmentDate1, Me.colAssessmentAuthorityNumber1, Me.colAssessmentCategory1, Me.colCOCStatus1, Me.colAssessmentLLCO1})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        '
        'colAssessmentID1
        '
        Me.colAssessmentID1.FieldName = "AssessmentID"
        Me.colAssessmentID1.Name = "colAssessmentID1"
        Me.colAssessmentID1.Visible = True
        Me.colAssessmentID1.VisibleIndex = 0
        '
        'colEstablishmentName2
        '
        Me.colEstablishmentName2.Caption = "Name of Establishment"
        Me.colEstablishmentName2.FieldName = "EstablishmentName"
        Me.colEstablishmentName2.Name = "colEstablishmentName2"
        Me.colEstablishmentName2.Visible = True
        Me.colEstablishmentName2.VisibleIndex = 1
        '
        'colEstablishmentAddress2
        '
        Me.colEstablishmentAddress2.Caption = "Address"
        Me.colEstablishmentAddress2.FieldName = "EstablishmentAddress"
        Me.colEstablishmentAddress2.Name = "colEstablishmentAddress2"
        Me.colEstablishmentAddress2.Visible = True
        Me.colEstablishmentAddress2.VisibleIndex = 2
        '
        'colEstablishmentOwner2
        '
        Me.colEstablishmentOwner2.Caption = "Owner"
        Me.colEstablishmentOwner2.FieldName = "EstablishmentOwner"
        Me.colEstablishmentOwner2.Name = "colEstablishmentOwner2"
        Me.colEstablishmentOwner2.Visible = True
        Me.colEstablishmentOwner2.VisibleIndex = 3
        '
        'colAssessmentTypeVisit1
        '
        Me.colAssessmentTypeVisit1.Caption = "Type of Visit"
        Me.colAssessmentTypeVisit1.FieldName = "AssessmentTypeVisit"
        Me.colAssessmentTypeVisit1.Name = "colAssessmentTypeVisit1"
        Me.colAssessmentTypeVisit1.Visible = True
        Me.colAssessmentTypeVisit1.VisibleIndex = 4
        '
        'colAssessmentStatus1
        '
        Me.colAssessmentStatus1.Caption = "Status"
        Me.colAssessmentStatus1.FieldName = "AssessmentStatus"
        Me.colAssessmentStatus1.Name = "colAssessmentStatus1"
        Me.colAssessmentStatus1.Visible = True
        Me.colAssessmentStatus1.VisibleIndex = 5
        '
        'colAssessmentDate1
        '
        Me.colAssessmentDate1.FieldName = "AssessmentDate"
        Me.colAssessmentDate1.Name = "colAssessmentDate1"
        Me.colAssessmentDate1.Visible = True
        Me.colAssessmentDate1.VisibleIndex = 6
        '
        'colAssessmentAuthorityNumber1
        '
        Me.colAssessmentAuthorityNumber1.Caption = "Authority Number"
        Me.colAssessmentAuthorityNumber1.FieldName = "AssessmentAuthorityNumber"
        Me.colAssessmentAuthorityNumber1.Name = "colAssessmentAuthorityNumber1"
        Me.colAssessmentAuthorityNumber1.Visible = True
        Me.colAssessmentAuthorityNumber1.VisibleIndex = 7
        '
        'colAssessmentCategory1
        '
        Me.colAssessmentCategory1.Caption = "Category"
        Me.colAssessmentCategory1.FieldName = "AssessmentCategory"
        Me.colAssessmentCategory1.Name = "colAssessmentCategory1"
        Me.colAssessmentCategory1.Visible = True
        Me.colAssessmentCategory1.VisibleIndex = 8
        '
        'colCOCStatus1
        '
        Me.colCOCStatus1.FieldName = "COCStatus"
        Me.colCOCStatus1.Name = "colCOCStatus1"
        Me.colCOCStatus1.Visible = True
        Me.colCOCStatus1.VisibleIndex = 9
        '
        'colAssessmentLLCO1
        '
        Me.colAssessmentLLCO1.Caption = "Assessed By"
        Me.colAssessmentLLCO1.FieldName = "AssessmentLLCO"
        Me.colAssessmentLLCO1.Name = "colAssessmentLLCO1"
        Me.colAssessmentLLCO1.Visible = True
        Me.colAssessmentLLCO1.VisibleIndex = 10
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
        'ListOfAssessmentTableAdapter
        '
        Me.ListOfAssessmentTableAdapter.ClearBeforeFill = True
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.ribbonControl
        '
        'ForCOCIssuanceTableAdapter
        '
        Me.ForCOCIssuanceTableAdapter.ClearBeforeFill = True
        '
        'Main
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Main"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.EstablishmenttableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.ListOfAssessmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForCOCIssuanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents siStatus As DevExpress.XtraBars.BarStaticItem
    Private WithEvents siInfo As DevExpress.XtraBars.BarStaticItem
    Private WithEvents homeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents fileRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents iNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents alignButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iBoldFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iItalicFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iUnderlinedFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents fontStyleButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iLeftTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iCenterTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iRightTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents exitRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iHelp As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DbdbDataSet As DXApplication4.dbdbDataSet
    Friend WithEvents EstablishmenttableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstablishmenttableTableAdapter As DXApplication4.dbdbDataSetTableAdapters.establishmenttableTableAdapter
    Friend WithEvents TableAdapterManager As DXApplication4.dbdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents colEstablishmentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentOwner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoOfMaleWorkers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoOfFemaleWorkers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCBA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNatureOfBusiness As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ListOfAssessmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfAssessmentTableAdapter As DXApplication4.dbdbDataSetTableAdapters.ListOfAssessmentTableAdapter
    Friend WithEvents colAssessmentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentAddress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentOwner1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentTypeVisit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentAuthorityNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOCStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentLLCO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewEstablishmentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents AddNewAssessmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAssessmentID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentAddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstablishmentOwner2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentTypeVisit1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentAuthorityNumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentCategory1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOCStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssessmentLLCO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ForCOCIssuanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ForCOCIssuanceTableAdapter As DXApplication4.dbdbDataSetTableAdapters.ForCOCIssuanceTableAdapter
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewAssessmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateAssessmentStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCOCStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoViolationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithViolationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompliedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForIssuanceGLSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForIssuanceOSHSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForIssuanceGLSOSHSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssuedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
