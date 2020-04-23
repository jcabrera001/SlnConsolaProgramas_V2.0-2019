namespace ConsolaProgramasCS.TolProveedores
{
    partial class frmTolProveedorDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTolProveedorDetail));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TlSNotas = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GLEClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtCuenta = new DevExpress.XtraEditors.TextEdit();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.TlSNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLEClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.TlSNotas);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbBanco);
            this.panelControl1.Controls.Add(this.txtCuenta);
            this.panelControl1.Controls.Add(this.txtCorreo);
            this.panelControl1.Controls.Add(this.txtRTN);
            this.panelControl1.Controls.Add(this.txtNombre);
            this.panelControl1.Controls.Add(this.txtCodigo);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(490, 328);
            this.panelControl1.TabIndex = 38;
            // 
            // TlSNotas
            // 
            this.TlSNotas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnSalir});
            this.TlSNotas.Location = new System.Drawing.Point(2, 2);
            this.TlSNotas.Name = "TlSNotas";
            this.TlSNotas.Size = new System.Drawing.Size(486, 53);
            this.TlSNotas.TabIndex = 50;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = false;
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.Tag = "5";
            this.btnSalvar.Text = "Grabar cambios";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.AutoSize = false;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.Text = "Volver a la consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "RTN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Código";
            // 
            // cmbBanco
            // 
            this.cmbBanco.Location = new System.Drawing.Point(56, 221);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBanco.Properties.NullText = "";
            this.cmbBanco.Properties.PopupView = this.GLEClientes;
            this.cmbBanco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbBanco.Size = new System.Drawing.Size(188, 20);
            this.cmbBanco.TabIndex = 43;
            // 
            // GLEClientes
            // 
            this.GLEClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn5,
            this.GridColumn6});
            this.GLEClientes.DetailHeight = 10000;
            this.GLEClientes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GLEClientes.Name = "GLEClientes";
            this.GLEClientes.OptionsEditForm.PopupEditFormWidth = 10000;
            this.GLEClientes.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.GLEClientes.OptionsFilter.UseNewCustomFilterDialog = true;
            this.GLEClientes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GLEClientes.OptionsView.ShowAutoFilterRow = true;
            this.GLEClientes.OptionsView.ShowGroupPanel = false;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(57, 259);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(187, 20);
            this.txtCuenta.TabIndex = 42;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(56, 183);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(188, 20);
            this.txtCorreo.TabIndex = 41;
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(56, 145);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(188, 20);
            this.txtRTN.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(419, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(56, 69);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 20);
            this.txtCodigo.TabIndex = 38;
            // 
            // GridColumn5
            // 
            this.GridColumn5.Caption = "Banco";
            this.GridColumn5.FieldName = "Banco";
            this.GridColumn5.Name = "GridColumn5";
            this.GridColumn5.OptionsColumn.AllowEdit = false;
            this.GridColumn5.OptionsColumn.ReadOnly = true;
            this.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GridColumn5.Visible = true;
            this.GridColumn5.VisibleIndex = 0;
            this.GridColumn5.Width = 125;
            // 
            // GridColumn6
            // 
            this.GridColumn6.Caption = "Descripción";
            this.GridColumn6.FieldName = "Descripcion";
            this.GridColumn6.Name = "GridColumn6";
            this.GridColumn6.OptionsColumn.AllowEdit = false;
            this.GridColumn6.OptionsColumn.ReadOnly = true;
            this.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GridColumn6.Visible = true;
            this.GridColumn6.VisibleIndex = 1;
            this.GridColumn6.Width = 200;
            // 
            // frmTolProveedorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 357);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTolProveedorDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmTolProveedorDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.TlSNotas.ResumeLayout(false);
            this.TlSNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLEClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        internal System.Windows.Forms.ToolStrip TlSNotas;
        internal System.Windows.Forms.ToolStripButton btnSalvar;
        internal System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal DevExpress.XtraEditors.GridLookUpEdit cmbBanco;
        internal DevExpress.XtraGrid.Views.Grid.GridView GLEClientes;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
        private DevExpress.XtraEditors.TextEdit txtCuenta;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
    }
}