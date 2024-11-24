namespace AzureMapSearch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mapControl1 = new DevExpress.XtraMap.MapControl();
            imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            azureMapDataProvider1 = new DevExpress.XtraMap.AzureMapDataProvider();
            imageLayer2 = new DevExpress.XtraMap.ImageLayer();
            openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            bingSearchDataProvider1 = new DevExpress.XtraMap.BingSearchDataProvider();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)mapControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // mapControl1
            // 
            mapControl1.Layers.Add(imageLayer1);
            mapControl1.Layers.Add(imageLayer2);
            mapControl1.Layers.Add(informationLayer1);
            mapControl1.Location = new Point(-11, -5);
            mapControl1.Name = "mapControl1";
            mapControl1.Size = new Size(627, 450);
            mapControl1.TabIndex = 0;
            imageLayer1.DataProvider = azureMapDataProvider1;
            imageLayer2.DataProvider = openStreetMapDataProvider1;
            openStreetMapDataProvider1.TileUriTemplate = "https://{0}.tile.INSERT_SERVER_NAME.com/{1}/{2}/{3}.png";
            informationLayer1.DataProvider = bingSearchDataProvider1;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(memoEdit1);
            layoutControl1.Controls.Add(simpleButton1);
            layoutControl1.Controls.Add(textEdit1);
            layoutControl1.Location = new Point(615, 7);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(184, 438);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new Point(12, 69);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(160, 357);
            memoEdit1.StyleController = layoutControl1;
            memoEdit1.TabIndex = 6;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(12, 38);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(160, 27);
            simpleButton1.StyleController = layoutControl1;
            simpleButton1.TabIndex = 5;
            simpleButton1.Text = "Search for Location";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(78, 12);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(94, 22);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3 });
            Root.Name = "Root";
            Root.Size = new Size(184, 438);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(164, 26);
            layoutControlItem1.Text = "Keyword:";
            layoutControlItem1.TextSize = new Size(54, 16);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = simpleButton1;
            layoutControlItem2.Location = new Point(0, 26);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(164, 31);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = memoEdit1;
            layoutControlItem3.Location = new Point(0, 57);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(164, 361);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(layoutControl1);
            Controls.Add(mapControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)mapControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.AzureMapDataProvider azureMapDataProvider1;
        private DevExpress.XtraMap.ImageLayer imageLayer2;
        private DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1;
        private DevExpress.XtraMap.InformationLayer informationLayer1;
        private DevExpress.XtraMap.BingSearchDataProvider bingSearchDataProvider1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
