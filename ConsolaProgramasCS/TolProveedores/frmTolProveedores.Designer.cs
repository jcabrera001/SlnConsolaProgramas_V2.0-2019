namespace ConsolaProgramasCS.TolProveedores
{
    partial class frmTolProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTolProveedores));
            this.XtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.XtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).BeginInit();
            this.XtraTabControl1.SuspendLayout();
            this.XtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // XtraTabControl1
            // 
            this.XtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XtraTabControl1.Location = new System.Drawing.Point(12, 6);
            this.XtraTabControl1.Name = "XtraTabControl1";
            this.XtraTabControl1.SelectedTabPage = this.XtraTabPage1;
            this.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.XtraTabControl1.Size = new System.Drawing.Size(875, 562);
            this.XtraTabControl1.TabIndex = 1;
            this.XtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.XtraTabPage1});
            // 
            // XtraTabPage1
            // 
            this.XtraTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.XtraTabPage1.Controls.Add(this.gc);
            this.XtraTabPage1.Controls.Add(this.tsMenu);
            this.XtraTabPage1.Name = "XtraTabPage1";
            this.XtraTabPage1.Size = new System.Drawing.Size(873, 560);
            this.XtraTabPage1.Text = "XtraTabPage1";
            // 
            // gc
            // 
            this.gc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc.Location = new System.Drawing.Point(5, 51);
            this.gc.MainView = this.gv;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(863, 506);
            this.gc.TabIndex = 17;
            this.gc.Tag = "0";
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn39,
            this.GridColumn1,
            this.GridColumn2,
            this.GridColumn3,
            this.GridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gv.GridControl = this.gc;
            this.gv.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ProdCodigo", this.GridColumn1, "###,###", 0)});
            this.gv.Name = "gv";
            this.gv.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gv.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gv.OptionsView.ShowAutoFilterRow = true;
            this.gv.OptionsView.ShowFooter = true;
            this.gv.OptionsView.ShowGroupPanel = false;
            // 
            // GridColumn39
            // 
            this.GridColumn39.Caption = "ID";
            this.GridColumn39.FieldName = "ID";
            this.GridColumn39.Name = "GridColumn39";
            this.GridColumn39.OptionsColumn.AllowEdit = false;
            this.GridColumn39.OptionsColumn.FixedWidth = true;
            this.GridColumn39.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "Codigo";
            this.GridColumn1.FieldName = "CodProveedor";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.OptionsColumn.AllowEdit = false;
            this.GridColumn1.OptionsColumn.ReadOnly = true;
            this.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            this.GridColumn1.Width = 66;
            // 
            // GridColumn2
            // 
            this.GridColumn2.Caption = "Nombre";
            this.GridColumn2.FieldName = "Nombre";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.OptionsColumn.AllowEdit = false;
            this.GridColumn2.OptionsColumn.ReadOnly = true;
            this.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            this.GridColumn2.Width = 237;
            // 
            // GridColumn3
            // 
            this.GridColumn3.Caption = "RTN";
            this.GridColumn3.FieldName = "RTN";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.OptionsColumn.AllowEdit = false;
            this.GridColumn3.OptionsColumn.ReadOnly = true;
            this.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GridColumn3.Visible = true;
            this.GridColumn3.VisibleIndex = 2;
            this.GridColumn3.Width = 171;
            // 
            // GridColumn4
            // 
            this.GridColumn4.Caption = "Correo";
            this.GridColumn4.FieldName = "Email";
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.OptionsColumn.AllowEdit = false;
            this.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 3;
            this.GridColumn4.Width = 166;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cuenta";
            this.gridColumn5.FieldName = "Cuenta";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Banco";
            this.gridColumn6.FieldName = "nomBanco";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 98;
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.ToolStripSeparator1,
            this.btnEditar,
            this.btnRefresh,
            this.ToolStripSeparator3});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(873, 53);
            this.tsMenu.TabIndex = 16;
            this.tsMenu.Tag = "0";
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = false;
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.Tag = "2";
            this.btnNuevo.Text = "Nueva Remisión";
            this.btnNuevo.ToolTipText = "Nueva Remisión";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = false;
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.Tag = "3";
            this.btnEditar.Text = "Editar Remisión";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 50);
            this.btnRefresh.Tag = "1";
            this.btnRefresh.Text = "Actualizar Consulta";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 53);
            // 
            // frmTolProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 575);
            this.Controls.Add(this.XtraTabControl1);
            this.Name = "frmTolProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmTolProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).EndInit();
            this.XtraTabControl1.ResumeLayout(false);
            this.XtraTabPage1.ResumeLayout(false);
            this.XtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraTab.XtraTabControl XtraTabControl1;
        internal DevExpress.XtraTab.XtraTabPage XtraTabPage1;
        internal System.Windows.Forms.ToolStrip tsMenu;
        internal System.Windows.Forms.ToolStripButton btnNuevo;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btnEditar;
        internal System.Windows.Forms.ToolStripButton btnRefresh;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal DevExpress.XtraGrid.GridControl gc;
        internal DevExpress.XtraGrid.Views.Grid.GridView gv;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn39;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}