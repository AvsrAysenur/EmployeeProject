namespace EmployeeUI
{
    partial class XtraEmployeeList
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraEmployeeList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            lblActiveList = new DevExpress.XtraEditors.LabelControl();
            gCDepartmentList = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColId = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColEmployeeCount = new DevExpress.XtraGrid.Columns.GridColumn();
            gCEmployeeList = new DevExpress.XtraGrid.GridControl();
            repositoryBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryBtnEmployeeQuit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryItemBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryBtnRehired = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            btnDismiss = new DevExpress.XtraEditors.LabelControl();
            btnOff = new DevExpress.XtraEditors.LabelControl();
            btnEmployee = new DevExpress.XtraEditors.LabelControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            colIdentityNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            colStartingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colEndingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colReasonOfLeaving = new DevExpress.XtraGrid.Columns.GridColumn();
            colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmployeeQuit = new DevExpress.XtraGrid.Columns.GridColumn();
            colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            colReHired = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCDepartmentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gCEmployeeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEmployeeQuit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemBtnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnRehired).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(lblActiveList);
            layoutControl1.Controls.Add(gCDepartmentList);
            layoutControl1.Controls.Add(gCEmployeeList);
            layoutControl1.Controls.Add(labelControl4);
            layoutControl1.Controls.Add(btnDismiss);
            layoutControl1.Controls.Add(btnOff);
            layoutControl1.Controls.Add(btnEmployee);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(3480, 516, 812, 500);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1830, 897);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // lblActiveList
            // 
            lblActiveList.Appearance.Options.UseTextOptions = true;
            lblActiveList.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblActiveList.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblActiveList.Location = new Point(12, 869);
            lblActiveList.Name = "lblActiveList";
            lblActiveList.Size = new Size(1806, 16);
            lblActiveList.StyleController = layoutControl1;
            lblActiveList.TabIndex = 10;
            lblActiveList.Text = "labelControl1";
            // 
            // gCDepartmentList
            // 
            gCDepartmentList.EmbeddedNavigator.Margin = new Padding(2, 3, 2, 3);
            gCDepartmentList.Location = new Point(1193, 110);
            gCDepartmentList.MainView = gridView2;
            gCDepartmentList.Name = "gCDepartmentList";
            gCDepartmentList.Size = new Size(624, 754);
            gCDepartmentList.TabIndex = 5;
            gCDepartmentList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColId, gridColName, gridColEmployeeCount });
            gridView2.GridControl = gCDepartmentList;
            gridView2.Name = "gridView2";
            // 
            // gridColId
            // 
            gridColId.Caption = "#";
            gridColId.FieldName = "Id";
            gridColId.MinWidth = 25;
            gridColId.Name = "gridColId";
            gridColId.Width = 94;
            // 
            // gridColName
            // 
            gridColName.Caption = "Bölüm Adı";
            gridColName.FieldName = "Name";
            gridColName.MinWidth = 25;
            gridColName.Name = "gridColName";
            gridColName.Visible = true;
            gridColName.VisibleIndex = 0;
            gridColName.Width = 94;
            // 
            // gridColEmployeeCount
            // 
            gridColEmployeeCount.Caption = "Personel Sayısı";
            gridColEmployeeCount.DisplayFormat.FormatString = "n0";
            gridColEmployeeCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColEmployeeCount.FieldName = "EmployeeCount";
            gridColEmployeeCount.MinWidth = 25;
            gridColEmployeeCount.Name = "gridColEmployeeCount";
            gridColEmployeeCount.Visible = true;
            gridColEmployeeCount.VisibleIndex = 1;
            gridColEmployeeCount.Width = 94;
            // 
            // gCEmployeeList
            // 
            gCEmployeeList.EmbeddedNavigator.Margin = new Padding(2, 3, 2, 3);
            gCEmployeeList.Location = new Point(13, 109);
            gCEmployeeList.MainView = gridView1;
            gCEmployeeList.Name = "gCEmployeeList";
            gCEmployeeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryBtnEdit, repositoryItemBtnDelete, repositoryBtnEmployeeQuit, repositoryBtnRehired });
            gCEmployeeList.Size = new Size(1178, 752);
            gCEmployeeList.TabIndex = 4;
            gCEmployeeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gCEmployeeList.Click += gCEmployeeList_Click;
            // 
            // repositoryBtnEdit
            // 
            repositoryBtnEdit.AutoHeight = false;
            repositoryBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo) });
            repositoryBtnEdit.Name = "repositoryBtnEdit";
            repositoryBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnEdit.Click += repositoryBtnEdit_Click;
            // 
            // repositoryBtnEmployeeQuit
            // 
            repositoryBtnEmployeeQuit.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions1.SvgImage");
            repositoryBtnEmployeeQuit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repositoryBtnEmployeeQuit.Name = "repositoryBtnEmployeeQuit";
            repositoryBtnEmployeeQuit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnEmployeeQuit.ButtonClick += repositoryBtnEmployeeQuit_ButtonClick;
            // 
            // repositoryItemBtnDelete
            // 
            repositoryItemBtnDelete.AutoHeight = false;
            repositoryItemBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            repositoryItemBtnDelete.Name = "repositoryItemBtnDelete";
            repositoryItemBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemBtnDelete.Click += repositoryItemBtnDelete_Click;
            // 
            // repositoryBtnRehired
            // 
            repositoryBtnRehired.AutoHeight = false;
            repositoryBtnRehired.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryBtnRehired.Name = "repositoryBtnRehired";
            repositoryBtnRehired.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryBtnRehired.Click += repositoryBtnRehired_Click;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl4.Location = new Point(1195, 15);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(489, 38);
            labelControl4.StyleController = layoutControl1;
            labelControl4.TabIndex = 9;
            labelControl4.Text = " \r\n        ";
            // 
            // btnDismiss
            // 
            btnDismiss.Appearance.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnDismiss.Appearance.ForeColor = Color.Red;
            btnDismiss.Appearance.Options.UseFont = true;
            btnDismiss.Appearance.Options.UseForeColor = true;
            btnDismiss.Appearance.Options.UseTextOptions = true;
            btnDismiss.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnDismiss.AppearancePressed.Options.UseTextOptions = true;
            btnDismiss.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnDismiss.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            btnDismiss.Location = new Point(780, 12);
            btnDismiss.Name = "btnDismiss";
            btnDismiss.Size = new Size(421, 96);
            btnDismiss.StyleController = layoutControl1;
            btnDismiss.TabIndex = 8;
            btnDismiss.Text = "İşten Çıkarılan";
            btnDismiss.Click += btnDismiss_Click;
            // 
            // btnOff
            // 
            btnOff.Appearance.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnOff.Appearance.ForeColor = Color.Blue;
            btnOff.Appearance.Options.UseFont = true;
            btnOff.Appearance.Options.UseForeColor = true;
            btnOff.Appearance.Options.UseTextOptions = true;
            btnOff.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnOff.AppearancePressed.Options.UseTextOptions = true;
            btnOff.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnOff.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            btnOff.Location = new Point(391, 12);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(383, 96);
            btnOff.StyleController = layoutControl1;
            btnOff.TabIndex = 7;
            btnOff.Text = "İzinli";
            btnOff.Click += btnOff_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Appearance.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployee.Appearance.ForeColor = Color.Green;
            btnEmployee.Appearance.Options.UseFont = true;
            btnEmployee.Appearance.Options.UseForeColor = true;
            btnEmployee.Appearance.Options.UseTextOptions = true;
            btnEmployee.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnEmployee.AppearancePressed.Options.UseTextOptions = true;
            btnEmployee.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnEmployee.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            btnEmployee.Location = new Point(12, 14);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(378, 94);
            btnEmployee.StyleController = layoutControl1;
            btnEmployee.TabIndex = 6;
            btnEmployee.Text = "Çalışan";
            btnEmployee.Click += btnEmployee_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new Size(1830, 897);
            Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(1810, 857);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = lblActiveList;
            layoutControlItem1.Location = new Point(0, 857);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(1810, 20);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colDepartmentName, colIdentityNumber, colBirthDate, colSalary, colStartingDate, colEndingDate, colReasonOfLeaving, colEdit, colEmployeeQuit, colDelete, colReHired });
            gridView1.GridControl = gCEmployeeList;
            gridView1.Name = "gridView1";
            // 
            // colId
            // 
            colId.Caption = "#";
            colId.FieldName = "Id";
            colId.MinWidth = 25;
            colId.Name = "colId";
            colId.Width = 94;
            // 
            // colName
            // 
            colName.Caption = "Personel Adı ve Soyadı";
            colName.FieldName = "Name";
            colName.MinWidth = 25;
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 0;
            colName.Width = 94;
            // 
            // colDepartmentName
            // 
            colDepartmentName.Caption = "Bölüm Adı";
            colDepartmentName.FieldName = "DepartmentName";
            colDepartmentName.MinWidth = 25;
            colDepartmentName.Name = "colDepartmentName";
            colDepartmentName.Visible = true;
            colDepartmentName.VisibleIndex = 1;
            colDepartmentName.Width = 94;
            // 
            // colIdentityNumber
            // 
            colIdentityNumber.Caption = "T.C. Numarası";
            colIdentityNumber.FieldName = "IdentityNumber";
            colIdentityNumber.MinWidth = 25;
            colIdentityNumber.Name = "colIdentityNumber";
            colIdentityNumber.Visible = true;
            colIdentityNumber.VisibleIndex = 2;
            colIdentityNumber.Width = 94;
            // 
            // colBirthDate
            // 
            colBirthDate.Caption = "DoğumTarihi";
            colBirthDate.FieldName = "BirthDate";
            colBirthDate.MinWidth = 25;
            colBirthDate.Name = "colBirthDate";
            colBirthDate.Visible = true;
            colBirthDate.VisibleIndex = 3;
            colBirthDate.Width = 94;
            // 
            // colSalary
            // 
            colSalary.Caption = "Maaş";
            colSalary.DisplayFormat.FormatString = "n2";
            colSalary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colSalary.FieldName = "Salary";
            colSalary.MinWidth = 25;
            colSalary.Name = "colSalary";
            colSalary.Visible = true;
            colSalary.VisibleIndex = 4;
            colSalary.Width = 94;
            // 
            // colStartingDate
            // 
            colStartingDate.Caption = "İşe Başlama Tarihi";
            colStartingDate.FieldName = "StartingDate";
            colStartingDate.MinWidth = 25;
            colStartingDate.Name = "colStartingDate";
            colStartingDate.Visible = true;
            colStartingDate.VisibleIndex = 5;
            colStartingDate.Width = 94;
            // 
            // colEndingDate
            // 
            colEndingDate.Caption = "İşten Çıkış Tarihi";
            colEndingDate.MinWidth = 25;
            colEndingDate.Name = "colEndingDate";
            colEndingDate.Visible = true;
            colEndingDate.VisibleIndex = 6;
            colEndingDate.Width = 94;
            // 
            // colReasonOfLeaving
            // 
            colReasonOfLeaving.Caption = "Ayrılma Sebebi";
            colReasonOfLeaving.MinWidth = 25;
            colReasonOfLeaving.Name = "colReasonOfLeaving";
            colReasonOfLeaving.Visible = true;
            colReasonOfLeaving.VisibleIndex = 7;
            colReasonOfLeaving.Width = 94;
            // 
            // colEdit
            // 
            colEdit.Caption = "Güncelle";
            colEdit.ColumnEdit = repositoryBtnEdit;
            colEdit.MinWidth = 25;
            colEdit.Name = "colEdit";
            colEdit.Visible = true;
            colEdit.VisibleIndex = 8;
            colEdit.Width = 94;
            // 
            // colEmployeeQuit
            // 
            colEmployeeQuit.Caption = "İşten Çıkart";
            colEmployeeQuit.ColumnEdit = repositoryBtnEmployeeQuit;
            colEmployeeQuit.MinWidth = 25;
            colEmployeeQuit.Name = "colEmployeeQuit";
            colEmployeeQuit.Visible = true;
            colEmployeeQuit.VisibleIndex = 9;
            colEmployeeQuit.Width = 94;
            // 
            // colDelete
            // 
            colDelete.Caption = "Sil";
            colDelete.ColumnEdit = repositoryItemBtnDelete;
            colDelete.MinWidth = 25;
            colDelete.Name = "colDelete";
            colDelete.Visible = true;
            colDelete.VisibleIndex = 10;
            colDelete.Width = 94;
            // 
            // colReHired
            // 
            colReHired.Caption = "İşe Tekrar Al";
            colReHired.ColumnEdit = repositoryBtnRehired;
            colReHired.MinWidth = 25;
            colReHired.Name = "colReHired";
            colReHired.Visible = true;
            colReHired.VisibleIndex = 11;
            colReHired.Width = 94;
            // 
            // XtraEmployeeList
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1830, 897);
            Controls.Add(layoutControl1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "XtraEmployeeList";
            Text = "Personel Listesi";
            Load += XtraEmployeeList_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCDepartmentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gCEmployeeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnEmployeeQuit).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemBtnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryBtnRehired).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gCDepartmentList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gCEmployeeList;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.Columns.GridColumn gridColId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColEmployeeCount;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemBtnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnEmployeeQuit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl btnDismiss;
        private DevExpress.XtraEditors.LabelControl btnOff;
        private DevExpress.XtraEditors.LabelControl btnEmployee;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LabelControl lblActiveList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryBtnRehired;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentityNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colStartingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReasonOfLeaving;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeQuit;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colReHired;
    }
}