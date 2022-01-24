Partial Public Class frmMenu
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame1 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame2 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame3 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame4 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame5 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement11 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame6 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement12 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement13 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame7 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement14 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame8 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement15 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame9 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement16 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement17 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame10 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement18 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame11 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement19 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame12 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement20 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement21 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame13 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement22 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame14 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement23 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame15 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement24 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement25 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame16 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement26 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame17 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement27 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame18 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement28 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement29 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement30 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem23 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemImageEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.BarEditItem22 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarEditItem4 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemColorPickEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarEditItem5 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarEditItem6 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.BarHeaderItem2 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarListItem1 = New DevExpress.XtraBars.BarListItem()
        Me.BarMdiChildrenListItem1 = New DevExpress.XtraBars.BarMdiChildrenListItem()
        Me.BarEditItem7 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.BarEditItem8 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarEditItem9 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarEditItem10 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarEditItem11 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarEditItem12 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemHypertextLabel1 = New DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel()
        Me.BarEditItem13 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
        Me.BarEditItem14 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarEditItem15 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTokenEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarMdiChildrenListItem2 = New DevExpress.XtraBars.BarMdiChildrenListItem()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarWorkspaceMenuItem1 = New DevExpress.XtraBars.BarWorkspaceMenuItem()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager(Me.components)
        Me.BarStaticItem6 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem7 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarHeaderItem3 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarEditItem16 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemHypertextLabel2 = New DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel()
        Me.BarEditItem17 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemHeightType1 = New DevExpress.XtraRichEdit.Design.RepositoryItemHeightType()
        Me.BarEditItem18 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemAlignment1 = New DevExpress.XtraRichEdit.Design.RepositoryItemAlignment()
        Me.BarEditItem19 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
        Me.BarEditItem20 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem8 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem9 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem10 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem21 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemImageEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage6 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup15 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup16 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem6 = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup4 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem5 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem4 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem7 = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup1 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem2 = New DevExpress.XtraEditors.TileItem()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.TileItem8 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem9 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem10 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem11 = New DevExpress.XtraEditors.TileItem()
        Me.GunaPanel7 = New Guna.UI.WinForms.GunaPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel6 = New Guna.UI.WinForms.GunaPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TileItem3 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem12 = New DevExpress.XtraEditors.TileItem()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorPickEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHypertextLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTokenEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHypertextLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHeightType1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAlignment1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.BarButtonItem19, Me.BarEditItem23, Me.RibbonGalleryBarItem1, Me.BarEditItem22, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarEditItem1, Me.BarHeaderItem1, Me.BarEditItem2, Me.BarEditItem3, Me.BarEditItem4, Me.BarStaticItem1, Me.BarStaticItem2, Me.BarStaticItem3, Me.BarEditItem5, Me.BarEditItem6, Me.BarHeaderItem2, Me.BarListItem1, Me.BarMdiChildrenListItem1, Me.BarEditItem7, Me.BarEditItem8, Me.BarEditItem9, Me.BarEditItem10, Me.BarEditItem11, Me.BarEditItem12, Me.BarEditItem13, Me.BarEditItem14, Me.BarEditItem15, Me.BarStaticItem4, Me.BarMdiChildrenListItem2, Me.BarStaticItem5, Me.BarWorkspaceMenuItem1, Me.BarStaticItem6, Me.BarStaticItem7, Me.BarHeaderItem3, Me.BarEditItem16, Me.BarEditItem17, Me.BarEditItem18, Me.BarEditItem19, Me.BarEditItem20, Me.BarButtonItem12, Me.BarStaticItem8, Me.BarStaticItem9, Me.BarStaticItem10, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarEditItem21, Me.BarButtonItem18, Me.BarButtonItem20, Me.BarButtonItem21})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 68
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage6, Me.RibbonPage4, Me.RibbonPage5})
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.BarButtonItem17)
        Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.BarButtonItem21)
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemToggleSwitch1, Me.RepositoryItemImageEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemColorPickEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemTimeEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemDateEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemDateEdit3, Me.RepositoryItemHypertextLabel1, Me.RepositoryItemFontEdit1, Me.RepositoryItemTextEdit4, Me.RepositoryItemTokenEdit1, Me.RepositoryItemHypertextLabel2, Me.RepositoryItemHeightType1, Me.RepositoryItemAlignment1, Me.RepositoryItemRichTextEdit1, Me.RepositoryItemTrackBar1, Me.RepositoryItemImageEdit2, Me.RepositoryItemPictureEdit1, Me.RepositoryItemImageEdit3})
        Me.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ribbonControl1.Size = New System.Drawing.Size(1320, 153)
        Me.ribbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "BarButtonItem19"
        Me.BarButtonItem19.Id = 65
        Me.BarButtonItem19.ImageOptions.Image = CType(resources.GetObject("BarButtonItem19.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem19.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem19.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarEditItem23
        '
        Me.BarEditItem23.Caption = "نظام ادارة الموظفين"
        Me.BarEditItem23.Edit = Me.RepositoryItemImageEdit3
        Me.BarEditItem23.Hint = "نظام ادارة الموظفين"
        Me.BarEditItem23.Id = 64
        Me.BarEditItem23.ImageOptions.Image = CType(resources.GetObject("BarEditItem23.ImageOptions.Image"), System.Drawing.Image)
        Me.BarEditItem23.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem23.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarEditItem23.Name = "BarEditItem23"
        '
        'RepositoryItemImageEdit3
        '
        Me.RepositoryItemImageEdit3.AutoHeight = False
        Me.RepositoryItemImageEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit3.Name = "RepositoryItemImageEdit3"
        Me.RepositoryItemImageEdit3.PictureAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RibbonGalleryBarItem1
        '
        Me.RibbonGalleryBarItem1.Caption = "RibbonGalleryBarItem1"
        Me.RibbonGalleryBarItem1.Id = 63
        Me.RibbonGalleryBarItem1.ImageOptions.Image = CType(resources.GetObject("RibbonGalleryBarItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonGalleryBarItem1.ImageOptions.LargeImage = CType(resources.GetObject("RibbonGalleryBarItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.RibbonGalleryBarItem1.Name = "RibbonGalleryBarItem1"
        '
        'BarEditItem22
        '
        Me.BarEditItem22.Caption = "نظام ادارة الموظفين"
        Me.BarEditItem22.Edit = Me.RepositoryItemPictureEdit1
        Me.BarEditItem22.Hint = "نظام ادارة الموظفين"
        Me.BarEditItem22.Id = 62
        Me.BarEditItem22.ImageOptions.Image = CType(resources.GetObject("BarEditItem22.ImageOptions.Image"), System.Drawing.Image)
        Me.BarEditItem22.ImageOptions.LargeImage = CType(resources.GetObject("BarEditItem22.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarEditItem22.Name = "BarEditItem22"
        Me.BarEditItem22.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "اضافة موظف"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "تعديل بيانات موظف"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "حذف موظف"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "بحث عن موظف"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "استعلام متقدم"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem5.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem5.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "عرض بيانات الموظفين"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.ImageOptions.Image = CType(resources.GetObject("BarButtonItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem6.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem6.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "طباعة بيانات الموظفين"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.ImageOptions.Image = CType(resources.GetObject("BarButtonItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem7.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem7.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "رواتب الموظفين"
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem8.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem8.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem8.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        Me.BarButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "السلفيات"
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem9.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "المستخدمين والصلاحيات"
        Me.BarButtonItem10.Id = 10
        Me.BarButtonItem10.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem10.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "نسخة احتياطية"
        Me.BarButtonItem11.Id = 11
        Me.BarButtonItem11.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem11.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemToggleSwitch1
        Me.BarEditItem1.Id = 13
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "Off"
        Me.RepositoryItemToggleSwitch1.OnText = "On"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "Staff Management System"
        Me.BarHeaderItem1.Id = 14
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem2.Caption = "BarEditItem2"
        Me.BarEditItem2.Edit = Me.RepositoryItemImageEdit1
        Me.BarEditItem2.Id = 15
        Me.BarEditItem2.Name = "BarEditItem2"
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'BarEditItem3
        '
        Me.BarEditItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem3.Caption = "BarEditItem3"
        Me.BarEditItem3.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItem3.Id = 16
        Me.BarEditItem3.Name = "BarEditItem3"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'BarEditItem4
        '
        Me.BarEditItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem4.Caption = "BarEditItem4"
        Me.BarEditItem4.Edit = Me.RepositoryItemColorPickEdit1
        Me.BarEditItem4.Id = 17
        Me.BarEditItem4.Name = "BarEditItem4"
        '
        'RepositoryItemColorPickEdit1
        '
        Me.RepositoryItemColorPickEdit1.AutoHeight = False
        Me.RepositoryItemColorPickEdit1.AutomaticColor = System.Drawing.Color.Black
        Me.RepositoryItemColorPickEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemColorPickEdit1.Name = "RepositoryItemColorPickEdit1"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 18
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem2.Caption = "BarStaticItem2"
        Me.BarStaticItem2.Id = 19
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem3.Caption = "BarStaticItem3"
        Me.BarStaticItem3.Id = 20
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'BarEditItem5
        '
        Me.BarEditItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem5.Caption = "BarEditItem5"
        Me.BarEditItem5.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem5.Id = 21
        Me.BarEditItem5.Name = "BarEditItem5"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarEditItem6
        '
        Me.BarEditItem6.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem6.Caption = "BarEditItem6"
        Me.BarEditItem6.Edit = Me.RepositoryItemMemoEdit1
        Me.BarEditItem6.Id = 22
        Me.BarEditItem6.Name = "BarEditItem6"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'BarHeaderItem2
        '
        Me.BarHeaderItem2.Caption = "BarHeaderItem2"
        Me.BarHeaderItem2.Id = 23
        Me.BarHeaderItem2.Name = "BarHeaderItem2"
        '
        'BarListItem1
        '
        Me.BarListItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarListItem1.Caption = "BarListItem1"
        Me.BarListItem1.Id = 26
        Me.BarListItem1.Name = "BarListItem1"
        '
        'BarMdiChildrenListItem1
        '
        Me.BarMdiChildrenListItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarMdiChildrenListItem1.Caption = "BarMdiChildrenListItem1"
        Me.BarMdiChildrenListItem1.Id = 27
        Me.BarMdiChildrenListItem1.Name = "BarMdiChildrenListItem1"
        '
        'BarEditItem7
        '
        Me.BarEditItem7.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem7.Caption = "BarEditItem7"
        Me.BarEditItem7.Edit = Me.RepositoryItemTimeEdit1
        Me.BarEditItem7.Id = 28
        Me.BarEditItem7.Name = "BarEditItem7"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        Me.RepositoryItemTimeEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'BarEditItem8
        '
        Me.BarEditItem8.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem8.Caption = "BarEditItem8"
        Me.BarEditItem8.Edit = Me.RepositoryItemTextEdit2
        Me.BarEditItem8.Id = 29
        Me.BarEditItem8.Name = "BarEditItem8"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'BarEditItem9
        '
        Me.BarEditItem9.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem9.Caption = "BarEditItem9"
        Me.BarEditItem9.Edit = Me.RepositoryItemDateEdit2
        Me.BarEditItem9.Id = 30
        Me.BarEditItem9.Name = "BarEditItem9"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        '
        'BarEditItem10
        '
        Me.BarEditItem10.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem10.Caption = "BarEditItem10"
        Me.BarEditItem10.Edit = Me.RepositoryItemTextEdit3
        Me.BarEditItem10.Id = 31
        Me.BarEditItem10.Name = "BarEditItem10"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'BarEditItem11
        '
        Me.BarEditItem11.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem11.Caption = "التاريخ"
        Me.BarEditItem11.Edit = Me.RepositoryItemDateEdit3
        Me.BarEditItem11.Id = 32
        Me.BarEditItem11.Name = "BarEditItem11"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        Me.RepositoryItemDateEdit3.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BarEditItem12
        '
        Me.BarEditItem12.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem12.Caption = "BarEditItem12"
        Me.BarEditItem12.Edit = Me.RepositoryItemHypertextLabel1
        Me.BarEditItem12.Id = 33
        Me.BarEditItem12.Name = "BarEditItem12"
        Me.BarEditItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RepositoryItemHypertextLabel1
        '
        Me.RepositoryItemHypertextLabel1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.RepositoryItemHypertextLabel1.Name = "RepositoryItemHypertextLabel1"
        '
        'BarEditItem13
        '
        Me.BarEditItem13.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem13.Caption = "BarEditItem13"
        Me.BarEditItem13.Edit = Me.RepositoryItemFontEdit1
        Me.BarEditItem13.Id = 34
        Me.BarEditItem13.Name = "BarEditItem13"
        '
        'RepositoryItemFontEdit1
        '
        Me.RepositoryItemFontEdit1.AutoHeight = False
        Me.RepositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemFontEdit1.Name = "RepositoryItemFontEdit1"
        '
        'BarEditItem14
        '
        Me.BarEditItem14.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem14.Caption = "BarEditItem14"
        Me.BarEditItem14.Edit = Me.RepositoryItemTextEdit4
        Me.BarEditItem14.Id = 35
        Me.BarEditItem14.Name = "BarEditItem14"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'BarEditItem15
        '
        Me.BarEditItem15.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem15.Caption = "BarEditItem15"
        Me.BarEditItem15.Edit = Me.RepositoryItemTokenEdit1
        Me.BarEditItem15.Id = 36
        Me.BarEditItem15.Name = "BarEditItem15"
        '
        'RepositoryItemTokenEdit1
        '
        Me.RepositoryItemTokenEdit1.Name = "RepositoryItemTokenEdit1"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem4.Caption = "BarStaticItem4"
        Me.BarStaticItem4.Id = 37
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'BarMdiChildrenListItem2
        '
        Me.BarMdiChildrenListItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarMdiChildrenListItem2.Caption = "BarMdiChildrenListItem2"
        Me.BarMdiChildrenListItem2.Id = 38
        Me.BarMdiChildrenListItem2.Name = "BarMdiChildrenListItem2"
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem5.Caption = "BarStaticItem5"
        Me.BarStaticItem5.Id = 39
        Me.BarStaticItem5.Name = "BarStaticItem5"
        '
        'BarWorkspaceMenuItem1
        '
        Me.BarWorkspaceMenuItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarWorkspaceMenuItem1.Caption = "BarWorkspaceMenuItem1"
        Me.BarWorkspaceMenuItem1.Id = 40
        Me.BarWorkspaceMenuItem1.Name = "BarWorkspaceMenuItem1"
        Me.BarWorkspaceMenuItem1.WorkspaceManager = Me.WorkspaceManager1
        '
        'WorkspaceManager1
        '
        Me.WorkspaceManager1.TargetControl = Me
        Me.WorkspaceManager1.TransitionType = PushTransition1
        '
        'BarStaticItem6
        '
        Me.BarStaticItem6.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem6.Caption = "BarStaticItem6"
        Me.BarStaticItem6.Id = 41
        Me.BarStaticItem6.Name = "BarStaticItem6"
        '
        'BarStaticItem7
        '
        Me.BarStaticItem7.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem7.Caption = "BarStaticItem7"
        Me.BarStaticItem7.Id = 42
        Me.BarStaticItem7.Name = "BarStaticItem7"
        '
        'BarHeaderItem3
        '
        Me.BarHeaderItem3.Caption = "BarHeaderItem3"
        Me.BarHeaderItem3.Id = 43
        Me.BarHeaderItem3.Name = "BarHeaderItem3"
        '
        'BarEditItem16
        '
        Me.BarEditItem16.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem16.Caption = "BarEditItem16"
        Me.BarEditItem16.Edit = Me.RepositoryItemHypertextLabel2
        Me.BarEditItem16.Id = 44
        Me.BarEditItem16.Name = "BarEditItem16"
        '
        'RepositoryItemHypertextLabel2
        '
        Me.RepositoryItemHypertextLabel2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemHypertextLabel2.Name = "RepositoryItemHypertextLabel2"
        '
        'BarEditItem17
        '
        Me.BarEditItem17.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem17.Caption = "BarEditItem17"
        Me.BarEditItem17.Edit = Me.RepositoryItemHeightType1
        Me.BarEditItem17.Id = 45
        Me.BarEditItem17.Name = "BarEditItem17"
        '
        'RepositoryItemHeightType1
        '
        Me.RepositoryItemHeightType1.AutoHeight = False
        Me.RepositoryItemHeightType1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemHeightType1.Name = "RepositoryItemHeightType1"
        '
        'BarEditItem18
        '
        Me.BarEditItem18.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem18.Caption = "BarEditItem18"
        Me.BarEditItem18.Edit = Me.RepositoryItemAlignment1
        Me.BarEditItem18.Id = 46
        Me.BarEditItem18.Name = "BarEditItem18"
        '
        'RepositoryItemAlignment1
        '
        Me.RepositoryItemAlignment1.AutoHeight = False
        Me.RepositoryItemAlignment1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemAlignment1.HasArabic = False
        Me.RepositoryItemAlignment1.HasDistribute = False
        Me.RepositoryItemAlignment1.HasThaiDistribute = False
        Me.RepositoryItemAlignment1.Name = "RepositoryItemAlignment1"
        '
        'BarEditItem19
        '
        Me.BarEditItem19.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem19.Caption = "BarEditItem19"
        Me.BarEditItem19.Edit = Me.RepositoryItemRichTextEdit1
        Me.BarEditItem19.Id = 47
        Me.BarEditItem19.Name = "BarEditItem19"
        '
        'RepositoryItemRichTextEdit1
        '
        Me.RepositoryItemRichTextEdit1.Name = "RepositoryItemRichTextEdit1"
        Me.RepositoryItemRichTextEdit1.ShowCaretInReadOnly = False
        '
        'BarEditItem20
        '
        Me.BarEditItem20.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItem20.Caption = "BarEditItem20"
        Me.BarEditItem20.Edit = Me.RepositoryItemTrackBar1
        Me.BarEditItem20.Id = 48
        Me.BarEditItem20.Name = "BarEditItem20"
        '
        'RepositoryItemTrackBar1
        '
        Me.RepositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = True
        Me.RepositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemTrackBar1.Name = "RepositoryItemTrackBar1"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "BarButtonItem12"
        Me.BarButtonItem12.Id = 49
        Me.BarButtonItem12.Name = "BarButtonItem12"
        Me.BarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarStaticItem8
        '
        Me.BarStaticItem8.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem8.Caption = "BarStaticItem8"
        Me.BarStaticItem8.Id = 50
        Me.BarStaticItem8.Name = "BarStaticItem8"
        '
        'BarStaticItem9
        '
        Me.BarStaticItem9.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem9.Caption = "BarStaticItem9"
        Me.BarStaticItem9.Id = 51
        Me.BarStaticItem9.Name = "BarStaticItem9"
        '
        'BarStaticItem10
        '
        Me.BarStaticItem10.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem10.Caption = "BarStaticItem10"
        Me.BarStaticItem10.Id = 52
        Me.BarStaticItem10.Name = "BarStaticItem10"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "عرض وطباعة"
        Me.BarButtonItem13.Id = 55
        Me.BarButtonItem13.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem13.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem13.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem13.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem13.ItemAppearance.Hovered.FontSizeDelta = 10
        Me.BarButtonItem13.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem13.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem13.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem13.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem13.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem13.ItemInMenuAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem13.ItemInMenuAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem13.Name = "BarButtonItem13"
        Me.BarButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "عرض وطباعة"
        Me.BarButtonItem14.Id = 56
        Me.BarButtonItem14.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem14.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem14.Name = "BarButtonItem14"
        Me.BarButtonItem14.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "رواتب الموظفين"
        Me.BarButtonItem15.Id = 57
        Me.BarButtonItem15.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem15.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "تسجيل خروج"
        Me.BarButtonItem16.Hint = "تسجيل خروج"
        Me.BarButtonItem16.Id = 58
        Me.BarButtonItem16.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem16.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem16.Name = "BarButtonItem16"
        Me.BarButtonItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "تسجيل الخروج"
        Me.BarButtonItem17.Hint = "تسجيل الخروج"
        Me.BarButtonItem17.Id = 59
        Me.BarButtonItem17.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Close_Window_96px_1
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarEditItem21
        '
        Me.BarEditItem21.Caption = "BarEditItem21"
        Me.BarEditItem21.Edit = Me.RepositoryItemImageEdit2
        Me.BarEditItem21.Id = 60
        Me.BarEditItem21.Name = "BarEditItem21"
        '
        'RepositoryItemImageEdit2
        '
        Me.RepositoryItemImageEdit2.AutoHeight = False
        Me.RepositoryItemImageEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit2.Name = "RepositoryItemImageEdit2"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "BarButtonItem18"
        Me.BarButtonItem18.Id = 61
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "BarButtonItem20"
        Me.BarButtonItem20.Id = 66
        Me.BarButtonItem20.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem20.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "About"
        Me.BarButtonItem21.Hint = "About"
        Me.BarButtonItem21.Id = 67
        Me.BarButtonItem21.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem21.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.ribbonPage1.ImageOptions.Image = CType(resources.GetObject("ribbonPage1.ImageOptions.Image"), System.Drawing.Image)
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "اضافة موظف"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ImageOptions.Image = CType(resources.GetObject("RibbonPageGroup1.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup8})
        Me.RibbonPage2.ImageOptions.Image = CType(resources.GetObject("RibbonPage2.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "تعديل بيانات موظف"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup11})
        Me.RibbonPage3.ImageOptions.Image = CType(resources.GetObject("RibbonPage3.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "بحث واستعلام"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        '
        'RibbonPage6
        '
        Me.RibbonPage6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup13})
        Me.RibbonPage6.ImageOptions.Image = CType(resources.GetObject("RibbonPage6.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPage6.Name = "RibbonPage6"
        Me.RibbonPage6.Text = "عرض وطباعة"
        '
        'RibbonPageGroup13
        '
        Me.RibbonPageGroup13.AllowTextClipping = False
        Me.RibbonPageGroup13.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup13.ItemLinks.Add(Me.BarButtonItem14)
        Me.RibbonPageGroup13.Name = "RibbonPageGroup13"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup15})
        Me.RibbonPage4.ImageOptions.Image = CType(resources.GetObject("RibbonPage4.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "رواتب الموظفين"
        '
        'RibbonPageGroup15
        '
        Me.RibbonPageGroup15.AllowTextClipping = False
        Me.RibbonPageGroup15.ItemLinks.Add(Me.BarButtonItem15)
        Me.RibbonPageGroup15.Name = "RibbonPageGroup15"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup16})
        Me.RibbonPage5.ImageOptions.Image = CType(resources.GetObject("RibbonPage5.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Text = "الاعدادات العامة "
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        '
        'RibbonPageGroup16
        '
        Me.RibbonPageGroup16.ItemLinks.Add(Me.BarButtonItem11)
        Me.RibbonPageGroup16.Name = "RibbonPageGroup16"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarHeaderItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem8)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem9)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem10)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 818)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1320, 21)
        '
        'TileControl1
        '
        Me.TileControl1.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Gray
        Me.TileControl1.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.Gray
        Me.TileControl1.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.Gray
        Me.TileControl1.AppearanceItem.Pressed.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Pressed.Options.UseBorderColor = True
        Me.TileControl1.AppearanceItem.Selected.BackColor = System.Drawing.Color.Gray
        Me.TileControl1.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Gray
        Me.TileControl1.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Gray
        Me.TileControl1.AppearanceItem.Selected.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Selected.Options.UseBorderColor = True
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.Groups.Add(Me.TileGroup4)
        Me.TileControl1.Groups.Add(Me.TileGroup1)
        Me.TileControl1.IndentBetweenGroups = 15
        Me.TileControl1.IndentBetweenItems = 15
        Me.TileControl1.Location = New System.Drawing.Point(0, 153)
        Me.TileControl1.MaxId = 18
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(1320, 686)
        Me.TileControl1.TabIndex = 1
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem6)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'TileItem6
        '
        Me.TileItem6.AppearanceItem.Normal.BackColor = System.Drawing.Color.SeaGreen
        Me.TileItem6.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.SeaGreen
        Me.TileItem6.AppearanceItem.Normal.BorderColor = System.Drawing.Color.SeaGreen
        Me.TileItem6.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem6.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem6.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem6.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem6.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Gray
        Me.TileItem6.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.Gray
        Me.TileItem6.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.Gray
        Me.TileItem6.AppearanceItem.Pressed.Options.UseBackColor = True
        Me.TileItem6.AppearanceItem.Pressed.Options.UseBorderColor = True
        Me.TileItem6.AppearanceItem.Selected.BackColor = System.Drawing.Color.Gray
        Me.TileItem6.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Gray
        Me.TileItem6.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Gray
        Me.TileItem6.AppearanceItem.Selected.Options.UseBackColor = True
        Me.TileItem6.AppearanceItem.Selected.Options.UseBorderColor = True
        Me.TileItem6.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade
        TileItemElement1.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Edit_Property_100px
        TileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement1.Text = "تعديل بيانات الموظفين"
        Me.TileItem6.Elements.Add(TileItemElement1)
        TileItemFrame1.Appearance.BackColor = System.Drawing.Color.SeaGreen
        TileItemFrame1.Appearance.BackColor2 = System.Drawing.Color.SeaGreen
        TileItemFrame1.Appearance.BorderColor = System.Drawing.Color.SeaGreen
        TileItemFrame1.Appearance.Options.UseBackColor = True
        TileItemFrame1.Appearance.Options.UseBorderColor = True
        TileItemElement2.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Edit_Property_100px
        TileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement2.Text = "تعديل بيانات الموظفين"
        TileItemFrame1.Elements.Add(TileItemElement2)
        TileItemFrame1.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Edit_Property_100px
        TileItemFrame2.Appearance.BackColor = System.Drawing.Color.SeaGreen
        TileItemFrame2.Appearance.BackColor2 = System.Drawing.Color.SeaGreen
        TileItemFrame2.Appearance.BorderColor = System.Drawing.Color.SeaGreen
        TileItemFrame2.Appearance.Options.UseBackColor = True
        TileItemFrame2.Appearance.Options.UseBorderColor = True
        TileItemElement3.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Edit_Property_100px
        TileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement3.Text = "تعديل بيانات الموظفين"
        TileItemFrame2.Elements.Add(TileItemElement3)
        TileItemFrame2.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Edit_Property_100px
        TileItemFrame3.Appearance.BackColor = System.Drawing.Color.SeaGreen
        TileItemFrame3.Appearance.BackColor2 = System.Drawing.Color.SeaGreen
        TileItemFrame3.Appearance.BorderColor = System.Drawing.Color.SeaGreen
        TileItemFrame3.Appearance.Options.UseBackColor = True
        TileItemFrame3.Appearance.Options.UseBorderColor = True
        TileItemElement4.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Edit_Property_100px
        TileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement4.Text = "تعديل بيانات الموظفين"
        TileItemFrame3.Elements.Add(TileItemElement4)
        TileItemFrame3.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Edit_Property_100px
        Me.TileItem6.Frames.Add(TileItemFrame1)
        Me.TileItem6.Frames.Add(TileItemFrame2)
        Me.TileItem6.Frames.Add(TileItemFrame3)
        Me.TileItem6.Id = 14
        Me.TileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem6.Name = "TileItem6"
        '
        'TileGroup4
        '
        Me.TileGroup4.Items.Add(Me.TileItem1)
        Me.TileGroup4.Items.Add(Me.TileItem5)
        Me.TileGroup4.Items.Add(Me.TileItem4)
        Me.TileGroup4.Items.Add(Me.TileItem7)
        Me.TileGroup4.Name = "TileGroup4"
        '
        'TileItem1
        '
        Me.TileItem1.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem1.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem1.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop
        TileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement5.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        TileItemElement5.Text = "الرواتب"
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TileItem1.Elements.Add(TileItemElement5)
        Me.TileItem1.Id = 7
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem1.Name = "TileItem1"
        '
        'TileItem5
        '
        Me.TileItem5.AppearanceItem.Normal.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TileItem5.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.TileItem5.AppearanceItem.Normal.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.TileItem5.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem5.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem5.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem5.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem5.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Gray
        Me.TileItem5.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.Gray
        Me.TileItem5.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.Gray
        Me.TileItem5.AppearanceItem.Pressed.Options.UseBackColor = True
        Me.TileItem5.AppearanceItem.Pressed.Options.UseBorderColor = True
        Me.TileItem5.AppearanceItem.Selected.BackColor = System.Drawing.Color.Gray
        Me.TileItem5.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Gray
        Me.TileItem5.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Gray
        Me.TileItem5.AppearanceItem.Selected.Options.UseBackColor = True
        Me.TileItem5.AppearanceItem.Selected.Options.UseBorderColor = True
        TileItemElement6.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Add_Property_50px
        TileItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement6.Text = "اضافة جديدة"
        Me.TileItem5.Elements.Add(TileItemElement6)
        Me.TileItem5.Id = 10
        Me.TileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem5.Name = "TileItem5"
        '
        'TileItem4
        '
        Me.TileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.Goldenrod
        Me.TileItem4.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Goldenrod
        Me.TileItem4.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Goldenrod
        Me.TileItem4.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem4.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem4.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem4.AppearanceItem.Normal.Options.UseFont = True
        TileItemElement7.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Print_50px
        TileItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement7.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement7.Text = "طباعة"
        Me.TileItem4.Elements.Add(TileItemElement7)
        Me.TileItem4.Id = 11
        Me.TileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem4.Name = "TileItem4"
        '
        'TileItem7
        '
        Me.TileItem7.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem7.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem7.AppearanceItem.Pressed.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.TileItem7.AppearanceItem.Pressed.Options.UseFont = True
        Me.TileItem7.AppearanceItem.Selected.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.TileItem7.AppearanceItem.Selected.Options.UseFont = True
        TileItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement8.ImageOptions.ImageSize = New System.Drawing.Size(50, 50)
        TileItemElement8.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement8.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage1"), DevExpress.Utils.Svg.SvgImage)
        TileItemElement8.Text = "المستخدمين"
        Me.TileItem7.Elements.Add(TileItemElement8)
        Me.TileItem7.Id = 15
        Me.TileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem7.Name = "TileItem7"
        '
        'TileGroup1
        '
        Me.TileGroup1.Items.Add(Me.TileItem2)
        Me.TileGroup1.Name = "TileGroup1"
        '
        'TileItem2
        '
        Me.TileItem2.AppearanceItem.Hovered.BackColor = System.Drawing.Color.SteelBlue
        Me.TileItem2.AppearanceItem.Hovered.BackColor2 = System.Drawing.Color.SteelBlue
        Me.TileItem2.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.SteelBlue
        Me.TileItem2.AppearanceItem.Hovered.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem2.AppearanceItem.Hovered.Options.UseBackColor = True
        Me.TileItem2.AppearanceItem.Hovered.Options.UseBorderColor = True
        Me.TileItem2.AppearanceItem.Hovered.Options.UseFont = True
        Me.TileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.DodgerBlue
        Me.TileItem2.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.DodgerBlue
        Me.TileItem2.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DodgerBlue
        Me.TileItem2.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem2.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem2.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem2.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem2.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.SegmentedFade
        TileItemElement9.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Year_View_100px
        TileItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement9.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement9.Text = "استعلام متقدم"
        Me.TileItem2.Elements.Add(TileItemElement9)
        TileItemFrame4.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        TileItemFrame4.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue
        TileItemFrame4.Appearance.BorderColor = System.Drawing.Color.DodgerBlue
        TileItemFrame4.Appearance.Options.UseBackColor = True
        TileItemFrame4.Appearance.Options.UseBorderColor = True
        TileItemElement10.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Year_View_100px
        TileItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement10.Text = "استعلام متقدم"
        TileItemFrame4.Elements.Add(TileItemElement10)
        TileItemFrame4.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Year_View_100px
        TileItemFrame5.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        TileItemFrame5.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue
        TileItemFrame5.Appearance.BorderColor = System.Drawing.Color.DodgerBlue
        TileItemFrame5.Appearance.Options.UseBackColor = True
        TileItemFrame5.Appearance.Options.UseBorderColor = True
        TileItemElement11.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Year_View_100px
        TileItemElement11.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement11.Text = "استعلام متقدم"
        TileItemFrame5.Elements.Add(TileItemElement11)
        TileItemFrame5.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Year_View_100px
        TileItemFrame6.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        TileItemFrame6.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue
        TileItemFrame6.Appearance.BorderColor = System.Drawing.Color.DodgerBlue
        TileItemFrame6.Appearance.Options.UseBackColor = True
        TileItemFrame6.Appearance.Options.UseBorderColor = True
        TileItemElement12.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Year_View_100px
        TileItemElement12.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement12.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement12.Text = "استعلام متقدم"
        TileItemFrame6.Elements.Add(TileItemElement12)
        TileItemFrame6.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Year_View_100px
        Me.TileItem2.Frames.Add(TileItemFrame4)
        Me.TileItem2.Frames.Add(TileItemFrame5)
        Me.TileItem2.Frames.Add(TileItemFrame6)
        Me.TileItem2.Id = 8
        Me.TileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem2.Name = "TileItem2"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        '
        'TileItem8
        '
        Me.TileItem8.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkRed
        Me.TileItem8.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.DarkRed
        Me.TileItem8.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkRed
        Me.TileItem8.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem8.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem8.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem8.AppearanceItem.Normal.Options.UseFont = True
        TileItemElement13.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement13.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement13.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement13.Text = "عرض الموظفين"
        Me.TileItem8.Elements.Add(TileItemElement13)
        TileItemFrame7.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame7.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame7.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame7.Appearance.Options.UseBackColor = True
        TileItemFrame7.Appearance.Options.UseBorderColor = True
        TileItemElement14.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement14.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement14.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement14.Text = "عرض الموظفين"
        TileItemFrame7.Elements.Add(TileItemElement14)
        TileItemFrame7.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemFrame8.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame8.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame8.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame8.Appearance.Options.UseBackColor = True
        TileItemFrame8.Appearance.Options.UseBorderColor = True
        TileItemElement15.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement15.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement15.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement15.Text = "عرض الموظفين"
        TileItemFrame8.Elements.Add(TileItemElement15)
        TileItemFrame8.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemFrame9.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame9.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame9.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame9.Appearance.Options.UseBackColor = True
        TileItemFrame9.Appearance.Options.UseBorderColor = True
        TileItemElement16.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement16.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement16.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement16.Text = "عرض الموظفين"
        TileItemFrame9.Elements.Add(TileItemElement16)
        TileItemFrame9.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        Me.TileItem8.Frames.Add(TileItemFrame7)
        Me.TileItem8.Frames.Add(TileItemFrame8)
        Me.TileItem8.Frames.Add(TileItemFrame9)
        Me.TileItem8.Id = 3
        Me.TileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem8.Name = "TileItem8"
        '
        'TileItem9
        '
        Me.TileItem9.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkRed
        Me.TileItem9.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.DarkRed
        Me.TileItem9.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkRed
        Me.TileItem9.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem9.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem9.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem9.AppearanceItem.Normal.Options.UseFont = True
        TileItemElement17.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement17.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement17.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement17.Text = "عرض الموظفين"
        Me.TileItem9.Elements.Add(TileItemElement17)
        TileItemFrame10.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame10.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame10.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame10.Appearance.Options.UseBackColor = True
        TileItemFrame10.Appearance.Options.UseBorderColor = True
        TileItemElement18.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement18.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement18.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement18.Text = "عرض الموظفين"
        TileItemFrame10.Elements.Add(TileItemElement18)
        TileItemFrame10.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemFrame11.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame11.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame11.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame11.Appearance.Options.UseBackColor = True
        TileItemFrame11.Appearance.Options.UseBorderColor = True
        TileItemElement19.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement19.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement19.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement19.Text = "عرض الموظفين"
        TileItemFrame11.Elements.Add(TileItemElement19)
        TileItemFrame11.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemFrame12.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame12.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame12.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame12.Appearance.Options.UseBackColor = True
        TileItemFrame12.Appearance.Options.UseBorderColor = True
        TileItemElement20.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement20.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement20.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement20.Text = "عرض الموظفين"
        TileItemFrame12.Elements.Add(TileItemElement20)
        TileItemFrame12.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        Me.TileItem9.Frames.Add(TileItemFrame10)
        Me.TileItem9.Frames.Add(TileItemFrame11)
        Me.TileItem9.Frames.Add(TileItemFrame12)
        Me.TileItem9.Id = 3
        Me.TileItem9.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem9.Name = "TileItem9"
        '
        'TileItem10
        '
        Me.TileItem10.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkRed
        Me.TileItem10.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.DarkRed
        Me.TileItem10.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkRed
        Me.TileItem10.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem10.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem10.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem10.AppearanceItem.Normal.Options.UseFont = True
        TileItemElement21.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement21.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement21.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement21.Text = "عرض الموظفين"
        Me.TileItem10.Elements.Add(TileItemElement21)
        TileItemFrame13.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame13.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame13.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame13.Appearance.Options.UseBackColor = True
        TileItemFrame13.Appearance.Options.UseBorderColor = True
        TileItemElement22.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement22.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement22.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement22.Text = "عرض الموظفين"
        TileItemFrame13.Elements.Add(TileItemElement22)
        TileItemFrame13.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemFrame14.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame14.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame14.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame14.Appearance.Options.UseBackColor = True
        TileItemFrame14.Appearance.Options.UseBorderColor = True
        TileItemElement23.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement23.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement23.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement23.Text = "عرض الموظفين"
        TileItemFrame14.Elements.Add(TileItemElement23)
        TileItemFrame14.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemFrame15.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame15.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame15.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame15.Appearance.Options.UseBackColor = True
        TileItemFrame15.Appearance.Options.UseBorderColor = True
        TileItemElement24.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement24.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement24.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement24.Text = "عرض الموظفين"
        TileItemFrame15.Elements.Add(TileItemElement24)
        TileItemFrame15.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        Me.TileItem10.Frames.Add(TileItemFrame13)
        Me.TileItem10.Frames.Add(TileItemFrame14)
        Me.TileItem10.Frames.Add(TileItemFrame15)
        Me.TileItem10.Id = 3
        Me.TileItem10.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem10.Name = "TileItem10"
        '
        'TileItem11
        '
        Me.TileItem11.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkRed
        Me.TileItem11.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.DarkRed
        Me.TileItem11.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkRed
        Me.TileItem11.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem11.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem11.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem11.AppearanceItem.Normal.Options.UseFont = True
        TileItemElement25.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement25.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement25.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement25.Text = "عرض الموظفين"
        Me.TileItem11.Elements.Add(TileItemElement25)
        TileItemFrame16.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame16.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame16.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame16.Appearance.Options.UseBackColor = True
        TileItemFrame16.Appearance.Options.UseBorderColor = True
        TileItemElement26.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement26.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement26.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement26.Text = "عرض الموظفين"
        TileItemFrame16.Elements.Add(TileItemElement26)
        TileItemFrame16.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemFrame17.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame17.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame17.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame17.Appearance.Options.UseBackColor = True
        TileItemFrame17.Appearance.Options.UseBorderColor = True
        TileItemElement27.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement27.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement27.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement27.Text = "عرض الموظفين"
        TileItemFrame17.Elements.Add(TileItemElement27)
        TileItemFrame17.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemFrame18.Appearance.BackColor = System.Drawing.Color.DarkRed
        TileItemFrame18.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        TileItemFrame18.Appearance.BorderColor = System.Drawing.Color.DarkRed
        TileItemFrame18.Appearance.Options.UseBackColor = True
        TileItemFrame18.Appearance.Options.UseBorderColor = True
        TileItemElement28.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        TileItemElement28.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement28.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement28.Text = "عرض الموظفين"
        TileItemFrame18.Elements.Add(TileItemElement28)
        TileItemFrame18.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_View_100px
        Me.TileItem11.Frames.Add(TileItemFrame16)
        Me.TileItem11.Frames.Add(TileItemFrame17)
        Me.TileItem11.Frames.Add(TileItemFrame18)
        Me.TileItem11.Id = 3
        Me.TileItem11.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        Me.TileItem11.Name = "TileItem11"
        '
        'GunaPanel7
        '
        Me.GunaPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaPanel7.Controls.Add(Me.PictureBox1)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel7)
        Me.GunaPanel7.Controls.Add(Me.GunaLabel8)
        Me.GunaPanel7.Location = New System.Drawing.Point(3, 4)
        Me.GunaPanel7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GunaPanel7.Name = "GunaPanel7"
        Me.GunaPanel7.Size = New System.Drawing.Size(374, 66)
        Me.GunaPanel7.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Bar_Chart_100px
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'GunaLabel7
        '
        Me.GunaLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel7.ForeColor = System.Drawing.Color.White
        Me.GunaLabel7.Location = New System.Drawing.Point(260, 17)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(23, 25)
        Me.GunaLabel7.TabIndex = 31
        Me.GunaLabel7.Text = "0"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel8.ForeColor = System.Drawing.Color.White
        Me.GunaLabel8.Location = New System.Drawing.Point(294, 15)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(61, 25)
        Me.GunaLabel8.TabIndex = 1
        Me.GunaLabel8.Text = ":الاناث"
        '
        'GunaPanel6
        '
        Me.GunaPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaPanel6.Controls.Add(Me.PictureBox2)
        Me.GunaPanel6.Controls.Add(Me.GunaLabel4)
        Me.GunaPanel6.Controls.Add(Me.GunaLabel6)
        Me.GunaPanel6.Location = New System.Drawing.Point(383, 4)
        Me.GunaPanel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GunaPanel6.Name = "GunaPanel6"
        Me.GunaPanel6.Size = New System.Drawing.Size(374, 66)
        Me.GunaPanel6.TabIndex = 34
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Bar_Chart_100px
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(256, 17)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(23, 25)
        Me.GunaLabel4.TabIndex = 31
        Me.GunaLabel4.Text = "0"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(290, 13)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(66, 25)
        Me.GunaLabel6.TabIndex = 1
        Me.GunaLabel6.Text = ":الذكور"
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.GunaPanel5.Controls.Add(Me.PictureBox3)
        Me.GunaPanel5.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel5.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel5.Location = New System.Drawing.Point(763, 4)
        Me.GunaPanel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(554, 66)
        Me.GunaPanel5.TabIndex = 33
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Combo_Chart_100px
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(144, 66)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 43
        Me.PictureBox3.TabStop = False
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(355, 17)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(23, 25)
        Me.GunaLabel3.TabIndex = 31
        Me.GunaLabel3.Text = "0"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(389, 13)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(130, 25)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = ":عدد الموظفين"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 560.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GunaPanel5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GunaPanel7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GunaPanel6, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 153)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1320, 74)
        Me.TableLayoutPanel1.TabIndex = 38
        '
        'TileItem3
        '
        Me.TileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TileItem3.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.TileItem3.AppearanceItem.Normal.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.TileItem3.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem3.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem3.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem3.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem3.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Gray
        Me.TileItem3.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.Gray
        Me.TileItem3.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.Gray
        Me.TileItem3.AppearanceItem.Pressed.Options.UseBackColor = True
        Me.TileItem3.AppearanceItem.Pressed.Options.UseBorderColor = True
        Me.TileItem3.AppearanceItem.Selected.BackColor = System.Drawing.Color.Gray
        Me.TileItem3.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Gray
        Me.TileItem3.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Gray
        Me.TileItem3.AppearanceItem.Selected.Options.UseBackColor = True
        Me.TileItem3.AppearanceItem.Selected.Options.UseBorderColor = True
        TileItemElement29.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Add_Property_50px
        TileItemElement29.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement29.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement29.Text = "اضافة جديدة"
        Me.TileItem3.Elements.Add(TileItemElement29)
        Me.TileItem3.Id = 10
        Me.TileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem3.Name = "TileItem3"
        '
        'TileItem12
        '
        Me.TileItem12.AppearanceItem.Normal.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TileItem12.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.LightSeaGreen
        Me.TileItem12.AppearanceItem.Normal.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.TileItem12.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem12.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem12.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileItem12.AppearanceItem.Normal.Options.UseFont = True
        Me.TileItem12.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Gray
        Me.TileItem12.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.Gray
        Me.TileItem12.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.Gray
        Me.TileItem12.AppearanceItem.Pressed.Options.UseBackColor = True
        Me.TileItem12.AppearanceItem.Pressed.Options.UseBorderColor = True
        Me.TileItem12.AppearanceItem.Selected.BackColor = System.Drawing.Color.Gray
        Me.TileItem12.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Gray
        Me.TileItem12.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Gray
        Me.TileItem12.AppearanceItem.Selected.Options.UseBackColor = True
        Me.TileItem12.AppearanceItem.Selected.Options.UseBorderColor = True
        TileItemElement30.ImageOptions.Image = Global.Staff_Management_System.My.Resources.Resources.icons8_Add_Property_50px
        TileItemElement30.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement30.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement30.Text = "اضافة جديدة"
        Me.TileItem12.Elements.Add(TileItemElement30)
        Me.TileItem12.Id = 10
        Me.TileItem12.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem12.Name = "TileItem12"
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 651)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1320, 167)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 41
        Me.PictureBox4.TabStop = False
        '
        'frmMenu
        '
        Me.ClientSize = New System.Drawing.Size(1320, 839)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.TileControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IconOptions.LargeImage = CType(resources.GetObject("frmMenu.IconOptions.LargeImage"), System.Drawing.Image)
        Me.Name = "frmMenu"
        Me.Ribbon = Me.ribbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Staff Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorPickEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHypertextLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTokenEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHypertextLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHeightType1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAlignment1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel7.ResumeLayout(False)
        Me.GunaPanel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel6.ResumeLayout(False)
        Me.GunaPanel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup15 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup16 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem2 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem5 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem4 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem6 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup1 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents TileItem8 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem9 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem10 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem11 As DevExpress.XtraEditors.TileItem
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem4 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemColorPickEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit
    Friend WithEvents GunaPanel7 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel6 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarEditItem5 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarEditItem6 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents BarHeaderItem2 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarListItem1 As DevExpress.XtraBars.BarListItem
    Friend WithEvents BarMdiChildrenListItem1 As DevExpress.XtraBars.BarMdiChildrenListItem
    Friend WithEvents BarEditItem7 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents BarEditItem8 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarEditItem9 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem10 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarEditItem11 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarEditItem12 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemHypertextLabel1 As DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel
    Friend WithEvents BarEditItem13 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
    Friend WithEvents BarEditItem14 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarEditItem15 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTokenEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit
    Public WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarMdiChildrenListItem2 As DevExpress.XtraBars.BarMdiChildrenListItem
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarWorkspaceMenuItem1 As DevExpress.XtraBars.BarWorkspaceMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BarStaticItem7 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarHeaderItem3 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarStaticItem6 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarEditItem16 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemHypertextLabel2 As DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel
    Friend WithEvents BarEditItem17 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemHeightType1 As DevExpress.XtraRichEdit.Design.RepositoryItemHeightType
    Friend WithEvents BarEditItem19 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents BarEditItem18 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemAlignment1 As DevExpress.XtraRichEdit.Design.RepositoryItemAlignment
    Friend WithEvents BarEditItem20 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents WorkspaceManager1 As DevExpress.Utils.WorkspaceManager
    Public WithEvents BarStaticItem8 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BarStaticItem9 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem10 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TileGroup4 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem7 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem3 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem12 As DevExpress.XtraEditors.TileItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem22 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents BarEditItem21 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemImageEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents BarEditItem23 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemImageEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
End Class
