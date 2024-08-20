namespace EmployeeUI
{
    partial class XtraEmployeeQuit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraEmployeeQuit));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            BtnEmployeeQuit = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtReasonOfLeaving = new DevExpress.XtraEditors.ComboBoxEdit();
            txtEndingDate = new DevExpress.XtraEditors.DateEdit();
            txtName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtReasonOfLeaving.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEndingDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEndingDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { BtnEmployeeQuit, btnClose });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 2;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(BtnEmployeeQuit), new DevExpress.XtraBars.LinkPersistInfo(btnClose) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // BtnEmployeeQuit
            // 
            BtnEmployeeQuit.Caption = "Çıkış Ver";
            BtnEmployeeQuit.Id = 0;
            BtnEmployeeQuit.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnEmployeeQuit.ImageOptions.SvgImage");
            BtnEmployeeQuit.Name = "BtnEmployeeQuit";
            BtnEmployeeQuit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            BtnEmployeeQuit.ItemClick += BtnEmployeeQuit_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Kapat";
            btnClose.Id = 1;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnClose.ItemClick += btnClose_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(505, 30);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 159);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(505, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 30);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 129);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(505, 30);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 129);
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtReasonOfLeaving);
            layoutControl1.Controls.Add(txtEndingDate);
            layoutControl1.Controls.Add(txtName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 30);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(505, 129);
            layoutControl1.TabIndex = 5;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtReasonOfLeaving
            // 
            txtReasonOfLeaving.Location = new Point(95, 64);
            txtReasonOfLeaving.MenuManager = barManager1;
            txtReasonOfLeaving.Name = "txtReasonOfLeaving";
            txtReasonOfLeaving.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtReasonOfLeaving.Properties.Items.AddRange(new object[] { "", "1- Deneme süreli iş sözleşmesinin işverence feshi", "2- Deneme süreli iş sözleşmesinin işçi tarafından feshi", "3- Belirsiz süreli iş sözleşmesinin işçi tarafından feshi (istifa)", "4- Belirsiz süreli iş sözleşmesinin işveren tarafından haklı sebep bildirilmeden feshi", "5- Belirli süreli iş sözleşmesinin sona ermesi", "8- Emeklilik (yaşlılık) veye toptan ödeme nedeniyle", "9- Malulen emeklilik nedeniyle", "10- Ölüm", "11- İş kazası sonucu ölüm", "12- Askerlik", "13- Kadın işçinin evlenmesi .", "14- Emeklilik için yaş dışında diğer şartların tamamlanması", "15- Toplu işçi çıkarma", "16- Sözleşme sona ermeden sigortalının aynı işverene ait diğer işyerine nakli", "17- İşyerinin kapanması", "18- İşin sona ermesi", "19- Mevsim bitimi (İş akdinin askıya alınması halinde kullanılır.Tekrar başlatılmayacaksa \"4\" nolu kod kullanılır)", "20- Kampanya bitimi (İş akdinin askıya alınması halinde kullanılır. Tekrar başlatılmayacaksa \"4\" nolu kod kullanılır)", "21- Statü değişikliği", "22- Diğer nedenler", "23- İşçi tarafından zorunlu nedenle fesih", "24- İşçi tarafından sağlık nedeniyle fesih", "25- İşçi tarafından işverenin ahlak ve iyiniyet kurallarına aykırı davra nedeni ile fesih", "26- Disiplin kurulu kararı ile fesih", "27- İşveren tarafından zorunlu nedenlerle ve tutukluluk nedeniyle fesih", "28- İşveren tarafından sağlık nedeni ile fesih", "30- Vize süresinin bitimi ( İş akdinin askıya alınması halinde kullan Tekrar başlatılmayacaksa \"4\" nolu kod kullanılır)", "31- Borçlar Kanunu, Sendikalar Kanunu, Grev ve Lokavt Kanunu kapsamında kendi istek ve kusuru dışında fesih", "32- 4046 sayılı Kanunun 21. maddesine göre özelleştirme nedeni ile feshi", "33- Gazeteci tarafından sözleşmenin feshi", "34- İşyerinin devri, işin veya işyerinin niteliğinin değişmesi nedeniyle fesih", "37- KHK ile kamu görevinden çıkarma", "38- Doğum nedeniyle işten ayrılma", "39- 696 KHK ile kamu işçiliğine geçiş", "40- 696 KHK ile kamu işçiliğine geçilememesi sebebiyle çıkış" });
            txtReasonOfLeaving.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            txtReasonOfLeaving.Size = new Size(398, 22);
            txtReasonOfLeaving.StyleController = layoutControl1;
            txtReasonOfLeaving.TabIndex = 6;
            // 
            // txtEndingDate
            // 
            txtEndingDate.EditValue = null;
            txtEndingDate.Location = new Point(95, 38);
            txtEndingDate.MenuManager = barManager1;
            txtEndingDate.Name = "txtEndingDate";
            txtEndingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEndingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEndingDate.Size = new Size(398, 22);
            txtEndingDate.StyleController = layoutControl1;
            txtEndingDate.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(95, 12);
            txtName.MenuManager = barManager1;
            txtName.Name = "txtName";
            txtName.Size = new Size(398, 22);
            txtName.StyleController = layoutControl1;
            txtName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3 });
            Root.Name = "Root";
            Root.Size = new Size(505, 129);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtName;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(485, 26);
            layoutControlItem1.Text = "Personel Adı";
            layoutControlItem1.TextSize = new Size(71, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 78);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(485, 31);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtEndingDate;
            layoutControlItem2.Location = new Point(0, 26);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(485, 26);
            layoutControlItem2.Text = "Çıkış Tarihi";
            layoutControlItem2.TextSize = new Size(71, 16);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtReasonOfLeaving;
            layoutControlItem3.Location = new Point(0, 52);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(485, 26);
            layoutControlItem3.Text = "Çıkış Sebebi";
            layoutControlItem3.TextSize = new Size(71, 16);
            // 
            // XtraEmployeeQuit
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 179);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("XtraEmployeeQuit.IconOptions.SvgImage");
            Name = "XtraEmployeeQuit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel İşten Çıkış Formu";
            Load += XtraEmployeeQuit_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtReasonOfLeaving.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEndingDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEndingDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnEmployeeQuit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtReasonOfLeaving;
        private DevExpress.XtraEditors.DateEdit txtEndingDate;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}