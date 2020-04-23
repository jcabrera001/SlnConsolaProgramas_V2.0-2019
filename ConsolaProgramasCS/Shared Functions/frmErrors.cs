using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ConsolaProgramasCS.Shared_Functions
{
    public partial class frmErrors : DevExpress.XtraEditors.XtraForm
    {
        bool Valido = true;
        private bool _isOk = false;

        public int Errores { get { return lvErrores.Items.Count; } }
        public bool isOk { get { return _isOk; } }
        
        public frmErrors()
        {
            InitializeComponent();
        }

        private void frmErrors_Load(object sender, EventArgs e)
        {
            if(Valido)
            {
                cmdAceptar.Visible = true;
            }
            else
            {
                cmdAceptar.Visible = false;
            }
      
        }
        public void NuevoError(string mensaje, int tipo)
        {
            if (tipo == 0)
            {
                lvErrores.Items.Add("  " + mensaje, 0);
                Valido = false;
            }
            else
            {
                lvErrores.Items.Add("  " + mensaje, 1);
            }
         
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            lvErrores.Clear();
            Valido = true;
            Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            _isOk = true;
            Close();
        }
    }
}