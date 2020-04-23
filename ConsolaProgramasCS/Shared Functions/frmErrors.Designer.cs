namespace ConsolaProgramasCS.Shared_Functions
{
    partial class frmErrors
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmErrors));
            this.lvErrores = new System.Windows.Forms.ListView();
            this.cmdAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvErrores
            // 
            this.lvErrores.HideSelection = false;
            this.lvErrores.Location = new System.Drawing.Point(12, 0);
            this.lvErrores.Name = "lvErrores";
            this.lvErrores.Size = new System.Drawing.Size(424, 260);
            this.lvErrores.SmallImageList = this.ImageList1;
            this.lvErrores.TabIndex = 5;
            this.lvErrores.UseCompatibleStateImageBehavior = false;
            this.lvErrores.View = System.Windows.Forms.View.List;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(12, 266);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 4;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(361, 266);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "ERROR.png");
            this.ImageList1.Images.SetKeyName(1, "warning.png");
            // 
            // frmErrors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 293);
            this.Controls.Add(this.lvErrores);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.cmdCancelar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmErrors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Errores";
            this.Load += new System.EventHandler(this.frmErrors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView lvErrores;
        internal DevExpress.XtraEditors.SimpleButton cmdAceptar;
        internal DevExpress.XtraEditors.SimpleButton cmdCancelar;
        internal System.Windows.Forms.ImageList ImageList1;
    }
}