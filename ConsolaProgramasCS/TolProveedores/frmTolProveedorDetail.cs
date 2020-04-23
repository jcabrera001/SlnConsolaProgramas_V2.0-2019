using ConsolaProgramasCS.Shared_Functions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsolaProgramasCS.TolProveedores
{
    public partial class frmTolProveedorDetail : DevExpress.XtraEditors.XtraForm
    {
   
        Funciones Funciones;
        SqlDataAdapter adp;
        DataTable dt = new DataTable();
        SqlConnection _cnx;
        int _ID;

        public frmTolProveedorDetail(SqlConnection cnx, int ID)
        {
            InitializeComponent();
            _cnx = cnx;            
            _ID = ID;
            Funciones = new Funciones(cnx);
        }

        private void frmTolProveedorDetail_Load(object sender, EventArgs e)
        {
            Adapters();
            LoadTables();
            setCombos();
            Init();
        }

        private void Adapters()
        {
            adp = new SqlDataAdapter("spTOLProveedoresSelect " + _ID, _cnx);
            adp.InsertCommand = Funciones.getSQLComand("spTOLProveedoresInsert");
            adp.UpdateCommand = Funciones.getSQLComand("spTOLProveedoresUpdate");
            adp.Fill(dt);
        }
        private void Init() 
        {
            if(dt.Rows.Count == 0)
            {
                dt.Rows.Add();
            }

            cmbBanco.EditValue = dt.Rows[0]["Banco"].ToString();
            txtCodigo.Text = dt.Rows[0]["CodProveedor"].ToString();
            txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
            txtRTN.Text = dt.Rows[0]["RTN"].ToString();
            txtCorreo.Text = dt.Rows[0]["Email"].ToString();
            txtCuenta.Text = dt.Rows[0]["Cuenta"].ToString();
        }       
        private void LoadTables()
        {
            Funciones.NewTable("select ID Banco, Descripcion from TOLBancos", "banco");
        }   
        private void setCombos()
        {
            Funciones.setGridLookUpEdit(cmbBanco, Funciones.dsDesarrollo.Tables["banco"], "Banco", "Descripcion");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            frmErrors err = new frmErrors();

            if (txtCodigo.Text.Length == 0) { err.NuevoError("Debe ingresar el código del proveedor", 0); }
            if (txtNombre.Text.Length == 0) { err.NuevoError("Debe ingresar el Nombre del proveedor", 0); }
            if (txtCuenta.Text.Length == 0) { err.NuevoError("Debe ingresar la cuenta del proveedor", 0); }
            if (cmbBanco.EditValue.ToString().Length ==0) { err.NuevoError("Debe ingresar el banco del proveedor", 0); }
            if (txtRTN.Text.Length == 0) { err.NuevoError("RTN del proveedor vacío", 1); }
            if (txtCorreo.Text.Length == 0) { err.NuevoError("correo del proveedor vacío", 1); }

            if (err.Errores > 0)
            {
                err.ShowDialog();
                if (!err.isOk)
                {
                    return;
                }
            }

            dt.Rows[0]["Banco"] = cmbBanco.EditValue;
            dt.Rows[0]["CodProveedor"] = txtCodigo.Text;
            dt.Rows[0]["Nombre"] = txtNombre.Text;
            dt.Rows[0]["RTN"] = txtRTN.Text;
            dt.Rows[0]["Email"] = txtCorreo.Text;
            dt.Rows[0]["Cuenta"] = txtCuenta.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MessageBox.Show(dt.Rows[i]["CodProveedor"].ToString());
                MessageBox.Show(dt.Rows[i]["Nombre"].ToString());
                MessageBox.Show(dt.Rows[i]["RTN"].ToString());
                MessageBox.Show(dt.Rows[i]["Email"].ToString());
                MessageBox.Show(dt.Rows[i]["Cuenta"].ToString());
                MessageBox.Show(dt.Rows[i]["Banco"].ToString());
            }

            adp.Update(dt);
            MessageBox.Show("Reguistros ingresados exitosamente!", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}