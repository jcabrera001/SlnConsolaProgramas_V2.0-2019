using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsolaProgramasCS.TolProveedores
{
    public partial class frmTolProveedores : DevExpress.XtraEditors.XtraForm
    {
        int id = 0;
        private SqlConnection cnx;
       
        private SqlDataAdapter adp;
        private DataTable dt = new DataTable();

        public frmTolProveedores(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }

        private void frmTolProveedores_Load(object sender, EventArgs e)
        {
            LoadPrincipal();
            gc.DataSource = dt;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmTolProveedorDetail frm = new frmTolProveedorDetail(cnx, -1);
            frm.ShowDialog();
            LoadPrincipal();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmTolProveedorDetail frm = new frmTolProveedorDetail(cnx, (int)gv.GetFocusedRowCellValue("ID"));

                if (int.TryParse(gv.GetFocusedRowCellValue("ID").ToString(), out id))
                {
                    frm.ShowDialog();
                    LoadPrincipal();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro para  editar", "Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPrincipal();
        }

        private void LoadPrincipal()
        {
            dt.Clear();
            adp = new SqlDataAdapter("spTOLProveedoresSelect 0", cnx);
            adp.Fill(dt);
        }
    }
}