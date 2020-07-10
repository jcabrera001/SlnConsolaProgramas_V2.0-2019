using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Conexion
{
    public class Estacion
    {
        SqlConnection cnx = new SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=Finanzas;Server=AMIGODB\\AMIGODB");
        SqlDataAdapter adp;
        DataTable dt = new DataTable();
        SqlCommand cmd;
        
        public List<EstacionModel> getEstaciones()
        {
            List<EstacionModel> estaciones = new List<EstacionModel>();
            adp = new SqlDataAdapter("select * from Estacion", cnx);
            adp.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                estaciones.Add(new EstacionModel
                {
                    ID = (int)row["ID"],
                    Nombre = row["Nombre"].ToString(),
                    DeviceID = row["Device"].ToString(),
                    StationID = (int)row["StationID"],
                    Codigo = row["Codigo"].ToString()

                });
            }

            return estaciones;

        }
        public bool executeQuery(string sql)
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand(sql, cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool executeQuery(string sql, List<SqlParameter> parameter)
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddRange(parameter.ToArray());
                cmd.ExecuteNonQuery();
                cnx.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool executeQuery(string sql, SqlParameter parameter)
        {
            try
            {
                cnx.Open();
                cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.Add(parameter);
                cmd.ExecuteNonQuery();
                cnx.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
