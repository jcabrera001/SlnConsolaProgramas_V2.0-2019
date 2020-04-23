using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsolaProgramasCS.Shared_Functions
{
    public class Funciones
    {
        SqlDataAdapter adp;
        SqlConnection _cnx;
        public DataSet dsDesarrollo = new DataSet();

        public Funciones(SqlConnection cnx)
        {
            _cnx = cnx;
        }
        public void NewTable(string sel, string nombre)
        {
           adp =new SqlDataAdapter(sel, _cnx);
           adp.Fill(dsDesarrollo, nombre);
           //dsDesarrollo.Tables[dsDesarrollo.Tables.Count].TableName = nombre;
 
        }

        public SqlDbType getSQLType(string txt)
        {
            SqlDbType tipo = new SqlDbType();
            if (txt == "varchar") { tipo = SqlDbType.VarChar; }
            else if (txt == "int") { tipo = SqlDbType.Int; }
            else if (txt == "datetime") { tipo = SqlDbType.DateTime; }
            else if (txt == "bit") { tipo = SqlDbType.Bit; }
            else if (txt == "time") { tipo = SqlDbType.Time; }
            else if (txt == "image") { tipo = SqlDbType.Image; }
            return tipo;
        }
        public SqlCommand getSQLComand(string txt)
        {
            SqlCommand cmd;
            SqlDataAdapter adp = new SqlDataAdapter("spGetParametroDB " + txt, _cnx);
            DataTable dtb = new DataTable();

            adp.Fill(dtb);

            cmd = new SqlCommand(txt, _cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
               
                //MessageBox.Show(dtb.Rows[i]["Pname"].ToString());
                //MessageBox.Show(getSQLType(dtb.Rows[i]["Tname"].ToString()).ToString());
                //MessageBox.Show(Convert.ToInt32(dtb.Rows[i]["Size"].ToString()).ToString());
                //MessageBox.Show(dtb.Rows[i]["Columna"].ToString());


                cmd.Parameters.Add(dtb.Rows[i]["Pname"].ToString(), getSQLType(dtb.Rows[i]["Tname"].ToString()),
                   Convert.ToInt32(dtb.Rows[i]["Size"].ToString()), dtb.Rows[i]["Columna"].ToString());
            }
            return cmd;
        }

        public void setGridLookUpEdit(GridLookUpEdit cmb, DataTable dt, string valueMember, string Display)
        {
            cmb.Properties.View.OptionsView.ShowAutoFilterRow = true;
            cmb.Properties.DataSource = dt;
            cmb.Properties.ValueMember = valueMember;
            cmb.Properties.DisplayMember = Display;
        }

    }
}
