Namespace AzureMapSearch

    Partial Class Form1

        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.azureMapDataProvider1 = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.imageLayer2 = New DevExpress.XtraMap.ImageLayer()
            Me.openStreetMapDataProvider1 = New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Me.informationLayer1 = New DevExpress.XtraMap.InformationLayer()
            Me.bingSearchDataProvider1 = New DevExpress.XtraMap.BingSearchDataProvider()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.imageLayer2)
            Me.mapControl1.Layers.Add(Me.informationLayer1)
            Me.mapControl1.Location = New Point(-11, -5)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New Size(627, 450)
            Me.mapControl1.TabIndex = 0
            Me.imageLayer1.DataProvider = Me.azureMapDataProvider1
            Me.imageLayer2.DataProvider = Me.openStreetMapDataProvider1
            Me.openStreetMapDataProvider1.TileUriTemplate = "https://{0}.tile.INSERT_SERVER_NAME.com/{1}/{2}/{3}.png"
            Me.informationLayer1.DataProvider = Me.bingSearchDataProvider1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.memoEdit1)
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Controls.Add(Me.textEdit1)
            Me.layoutControl1.Location = New Point(615, 7)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New Size(184, 438)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Location = New Point(12, 69)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New Size(160, 357)
            Me.memoEdit1.StyleController = Me.layoutControl1
            Me.memoEdit1.TabIndex = 6
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New Point(12, 38)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New Size(160, 27)
            Me.simpleButton1.StyleController = Me.layoutControl1
            Me.simpleButton1.TabIndex = 5
            Me.simpleButton1.Text = "Search for Location"
            Me.simpleButton1.Click += AddressOf simpleButton1_Click
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New Point(84, 12)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New Size(88, 22)
            Me.textEdit1.StyleController = Me.layoutControl1
            Me.textEdit1.TabIndex = 4
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.Root.Name = "Root"
            Me.Root.Size = New Size(184, 438)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.textEdit1
            Me.layoutControlItem1.Location = New Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New Size(164, 26)
            Me.layoutControlItem1.Text = "Key Word:"
            Me.layoutControlItem1.TextSize = New Size(60, 16)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.simpleButton1
            Me.layoutControlItem2.Location = New Point(0, 26)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New Size(164, 31)
            Me.layoutControlItem2.TextSize = New Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.memoEdit1
            Me.layoutControlItem3.Location = New Point(0, 57)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New Size(164, 361)
            Me.layoutControlItem3.TextSize = New Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(800, 450)
            Controls.Add(Me.layoutControl1)
            Controls.Add(Me.mapControl1)
            Name = "Form1"
            Text = "Form1"
            CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private imageLayer1 As DevExpress.XtraMap.ImageLayer

        Private azureMapDataProvider1 As DevExpress.XtraMap.AzureMapDataProvider

        Private imageLayer2 As DevExpress.XtraMap.ImageLayer

        Private openStreetMapDataProvider1 As DevExpress.XtraMap.OpenStreetMapDataProvider

        Private informationLayer1 As DevExpress.XtraMap.InformationLayer

        Private bingSearchDataProvider1 As DevExpress.XtraMap.BingSearchDataProvider

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
