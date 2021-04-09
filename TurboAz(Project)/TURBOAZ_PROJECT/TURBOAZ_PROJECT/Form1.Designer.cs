
namespace TURBOAZ_PROJECT
{
    partial class FrmHome
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
            this.grdControlHome = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlControlHome = new DevExpress.XtraEditors.PanelControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.lkpEditCity = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaxPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtMinPrice = new DevExpress.XtraEditors.TextEdit();
            this.lkpEditMaximumYear = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpEditMinimumYear = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpEditCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpEditModel = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpEditBrand = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAddCar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.chckEditBarter = new DevExpress.XtraEditors.CheckEdit();
            this.chckEditCredit = new DevExpress.XtraEditors.CheckEdit();
            this.lblYear = new DevExpress.XtraEditors.LabelControl();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControlHome)).BeginInit();
            this.pnlControlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditMaximumYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditMinimumYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckEditBarter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckEditCredit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlHome
            // 
            this.grdControlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControlHome.Location = new System.Drawing.Point(0, 100);
            this.grdControlHome.MainView = this.cardView1;
            this.grdControlHome.Name = "grdControlHome";
            this.grdControlHome.Size = new System.Drawing.Size(751, 373);
            this.grdControlHome.TabIndex = 0;
            this.grdControlHome.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            this.grdControlHome.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.cardView1.GridControl = this.grdControlHome;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.FieldAutoHeight = true;
            this.cardView1.OptionsView.ShowFieldCaptions = false;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CAR_IMAGE";
            this.gridColumn2.FieldName = "CAR_IMAGE";
            this.gridColumn2.ImageOptions.SvgImageSize = new System.Drawing.Size(0, 250);
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 250;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "PRICE";
            this.gridColumn3.FieldName = "PRICE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CAR_FULL_NAME";
            this.gridColumn4.FieldName = "CAR_FULL_NAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "YEAR";
            this.gridColumn5.FieldName = "YEAR";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "MOTOR_VOLUME";
            this.gridColumn6.FieldName = "MOTOR_VOLUME";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "DISTANCE";
            this.gridColumn7.FieldName = "DISTANCE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "CITY_NAME";
            this.gridColumn8.FieldName = "CITY_NAME";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // pnlControlHome
            // 
            this.pnlControlHome.Controls.Add(this.btnYenile);
            this.pnlControlHome.Controls.Add(this.lkpEditCity);
            this.pnlControlHome.Controls.Add(this.txtMaxPrice);
            this.pnlControlHome.Controls.Add(this.txtMinPrice);
            this.pnlControlHome.Controls.Add(this.lkpEditMaximumYear);
            this.pnlControlHome.Controls.Add(this.lkpEditMinimumYear);
            this.pnlControlHome.Controls.Add(this.lkpEditCurrency);
            this.pnlControlHome.Controls.Add(this.lkpEditModel);
            this.pnlControlHome.Controls.Add(this.lkpEditBrand);
            this.pnlControlHome.Controls.Add(this.btnAddCar);
            this.pnlControlHome.Controls.Add(this.btnSearch);
            this.pnlControlHome.Controls.Add(this.chckEditBarter);
            this.pnlControlHome.Controls.Add(this.chckEditCredit);
            this.pnlControlHome.Controls.Add(this.lblYear);
            this.pnlControlHome.Controls.Add(this.lblPrice);
            this.pnlControlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlControlHome.Name = "pnlControlHome";
            this.pnlControlHome.Size = new System.Drawing.Size(751, 100);
            this.pnlControlHome.TabIndex = 1;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(450, 44);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(79, 21);
            this.btnYenile.TabIndex = 24;
            this.btnYenile.Text = "Yenilə";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lkpEditCity
            // 
            this.lkpEditCity.Location = new System.Drawing.Point(450, 11);
            this.lkpEditCity.Name = "lkpEditCity";
            this.lkpEditCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEditCity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Şəhərlər")});
            this.lkpEditCity.Properties.NullText = "Şəhərlər";
            this.lkpEditCity.Size = new System.Drawing.Size(79, 20);
            this.lkpEditCity.TabIndex = 23;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.EditValue = "";
            this.txtMaxPrice.Location = new System.Drawing.Point(367, 11);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(62, 20);
            this.txtMaxPrice.TabIndex = 22;
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.EditValue = "";
            this.txtMinPrice.Location = new System.Drawing.Point(293, 11);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(68, 20);
            this.txtMinPrice.TabIndex = 21;
            // 
            // lkpEditMaximumYear
            // 
            this.lkpEditMaximumYear.Location = new System.Drawing.Point(326, 45);
            this.lkpEditMaximumYear.Name = "lkpEditMaximumYear";
            this.lkpEditMaximumYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEditMaximumYear.Properties.NullText = "";
            this.lkpEditMaximumYear.Size = new System.Drawing.Size(103, 20);
            this.lkpEditMaximumYear.TabIndex = 18;
            // 
            // lkpEditMinimumYear
            // 
            this.lkpEditMinimumYear.Location = new System.Drawing.Point(204, 45);
            this.lkpEditMinimumYear.Name = "lkpEditMinimumYear";
            this.lkpEditMinimumYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEditMinimumYear.Properties.NullText = "";
            this.lkpEditMinimumYear.Size = new System.Drawing.Size(100, 20);
            this.lkpEditMinimumYear.TabIndex = 17;
            // 
            // lkpEditCurrency
            // 
            this.lkpEditCurrency.EditValue = 35;
            this.lkpEditCurrency.Location = new System.Drawing.Point(204, 11);
            this.lkpEditCurrency.Name = "lkpEditCurrency";
            this.lkpEditCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEditCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Valyuta")});
            this.lkpEditCurrency.Properties.NullText = "";
            this.lkpEditCurrency.Size = new System.Drawing.Size(79, 20);
            this.lkpEditCurrency.TabIndex = 16;
            // 
            // lkpEditModel
            // 
            this.lkpEditModel.Location = new System.Drawing.Point(12, 48);
            this.lkpEditModel.Name = "lkpEditModel";
            this.lkpEditModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEditModel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MODEL_NAME", "MODEL")});
            this.lkpEditModel.Properties.NullText = "";
            this.lkpEditModel.Size = new System.Drawing.Size(100, 20);
            this.lkpEditModel.TabIndex = 15;
            // 
            // lkpEditBrand
            // 
            this.lkpEditBrand.Location = new System.Drawing.Point(12, 11);
            this.lkpEditBrand.Name = "lkpEditBrand";
            this.lkpEditBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpEditBrand.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRAND_NAME", "MARKA")});
            this.lkpEditBrand.Properties.NullText = "";
            this.lkpEditBrand.Size = new System.Drawing.Size(100, 20);
            this.lkpEditBrand.TabIndex = 14;
            this.lkpEditBrand.EditValueChanged += new System.EventHandler(this.lkpEditBrand_EditValueChanged);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddCar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCar.Appearance.Options.UseBackColor = true;
            this.btnAddCar.Appearance.Options.UseFont = true;
            this.btnAddCar.Location = new System.Drawing.Point(641, 44);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(98, 23);
            this.btnAddCar.TabIndex = 12;
            this.btnAddCar.Text = "Elan yerləşdir";
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Appearance.Options.UseBackColor = true;
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(641, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chckEditBarter
            // 
            this.chckEditBarter.EditValue = 0;
            this.chckEditBarter.Location = new System.Drawing.Point(551, 48);
            this.chckEditBarter.Name = "chckEditBarter";
            this.chckEditBarter.Properties.Caption = "Barter";
            this.chckEditBarter.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chckEditBarter.Properties.ValueChecked = 1;
            this.chckEditBarter.Properties.ValueUnchecked = 0;
            this.chckEditBarter.Size = new System.Drawing.Size(84, 20);
            this.chckEditBarter.TabIndex = 10;
            // 
            // chckEditCredit
            // 
            this.chckEditCredit.EditValue = 0;
            this.chckEditCredit.Location = new System.Drawing.Point(551, 14);
            this.chckEditCredit.Name = "chckEditCredit";
            this.chckEditCredit.Properties.Caption = "Kredit";
            this.chckEditCredit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chckEditCredit.Properties.NullText = "0";
            this.chckEditCredit.Properties.ValueChecked = 1;
            this.chckEditCredit.Properties.ValueGrayed = 0;
            this.chckEditCredit.Properties.ValueUnchecked = 0;
            this.chckEditCredit.Size = new System.Drawing.Size(84, 20);
            this.chckEditCredit.TabIndex = 9;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(140, 50);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(48, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Buraxılış ili";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(140, 15);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Qiymət";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 473);
            this.Controls.Add(this.grdControlHome);
            this.Controls.Add(this.pnlControlHome);
            this.Name = "FrmHome";
            this.Text = "Turbo.az";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControlHome)).EndInit();
            this.pnlControlHome.ResumeLayout(false);
            this.pnlControlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditMaximumYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditMinimumYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEditBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckEditBarter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckEditCredit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlHome;
        private DevExpress.XtraEditors.PanelControl pnlControlHome;
        private DevExpress.XtraEditors.SimpleButton btnAddCar;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.CheckEdit chckEditBarter;
        private DevExpress.XtraEditors.CheckEdit chckEditCredit;
        private DevExpress.XtraEditors.LabelControl lblYear;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.LookUpEdit lkpEditCurrency;
        private DevExpress.XtraEditors.LookUpEdit lkpEditModel;
        private DevExpress.XtraEditors.LookUpEdit lkpEditBrand;
        private DevExpress.XtraEditors.LookUpEdit lkpEditMaximumYear;
        private DevExpress.XtraEditors.LookUpEdit lkpEditMinimumYear;
        private DevExpress.XtraEditors.TextEdit txtMaxPrice;
        private DevExpress.XtraEditors.TextEdit txtMinPrice;
        private DevExpress.XtraEditors.LookUpEdit lkpEditCity;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
    }
}

