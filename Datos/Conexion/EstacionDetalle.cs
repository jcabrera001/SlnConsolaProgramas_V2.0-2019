using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Conexion
{
    public class EstacionDetalle
    {
        SqlConnection cnx = new SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=Finanzas;Server=AMIGODB\\AMIGODB");
        SqlDataAdapter adp;
        DataTable dt = new DataTable();
        SqlCommand cmd;

        public bool Insert(EstacionDetalleModel estacion)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                    new SqlParameter("@ts", estacion.ts),
                    new SqlParameter("@arch_int", estacion.arch_int),
                    new SqlParameter("@rev_type", estacion.rev_type),
                    new SqlParameter("@temp_out", estacion.temp_out),
                    new SqlParameter("@temp_out_hi", estacion.temp_out_hi),
                    new SqlParameter("@temp_out_lo", estacion.temp_out_lo),
                    new SqlParameter("@temp_in", estacion.temp_in),
                    new SqlParameter("@hum_in", estacion.hum_in),
                    new SqlParameter("@hum_out", estacion.hum_out),
                    new SqlParameter("@rainfall_in", estacion.rainfall_in),
                    new SqlParameter("@rainfall_clicks", estacion.rainfall_clicks),
                    new SqlParameter("@rainfall_mm", estacion.rainfall_mm),
                    new SqlParameter("@rain_rate_hi_in", estacion.rain_rate_hi_in),
                    new SqlParameter("@rain_rate_hi_clicks", estacion.rain_rate_hi_clicks),
                    new SqlParameter("@rain_rate_hi_mm", estacion.rain_rate_hi_mm),
                    new SqlParameter("@et", estacion.et),
                    new SqlParameter("@bar", estacion.bar),
                    new SqlParameter("@solar_rad_avg", estacion.solar_rad_avg),
                    new SqlParameter("@solar_rad_hi", estacion.solar_rad_hi),
                    new SqlParameter("@uv_index_avg", estacion.uv_index_avg),
                    new SqlParameter("@uv_index_hi", estacion.uv_index_hi),
                    new SqlParameter("@wind_num_samples", estacion.wind_num_samples),
                    new SqlParameter("@wind_speed_avg", estacion.wind_speed_avg),
                    new SqlParameter("@wind_speed_hi", estacion.wind_speed_hi),
                    new SqlParameter("@wind_dir_of_hi", estacion.wind_dir_of_hi),
                    new SqlParameter("@wind_dir_of_prevail", estacion.wind_dir_of_prevail),
                    new SqlParameter("@forecast_rule", estacion.forecast_rule),
                    new SqlParameter("@abs_press", estacion.abs_press),
                    new SqlParameter("@bar_noaa", estacion.bar_noaa),
                    new SqlParameter("@dew_point_out", estacion.dew_point_out),
                    new SqlParameter("@dew_point_in", estacion.dew_point_in),
                    new SqlParameter("@emc", estacion.emc),
                    new SqlParameter("@heat_index_out", estacion.heat_index_out),
                    new SqlParameter("@heat_index_in", estacion.heat_index_in),
                    new SqlParameter("@wind_chill", estacion.wind_chill),
                    new SqlParameter("@wind_run", estacion.wind_run),
                    new SqlParameter("@deg_days_heat", estacion.deg_days_heat),
                    new SqlParameter("@deg_days_cool", estacion.deg_days_cool),
                    new SqlParameter("@solar_energy", estacion.solar_energy),
                    new SqlParameter("@uv_dose", estacion.uv_dose),
                    new SqlParameter("@thw_index", estacion.thw_index),
                    new SqlParameter("@thsw_index", estacion.thsw_index),
                    new SqlParameter("@wet_bulb", estacion.wet_bulb),
                    new SqlParameter("@night_cloud_cover", estacion.night_cloud_cover),
                    new SqlParameter("@StationId", estacion.StationId),
                    new SqlParameter("@Fecha", estacion.Fecha)
                };

                cnx.Open();
                cmd = new SqlCommand("spEstacionDetalleInsert", cnx);
                cmd.Parameters.AddRange(parameters.ToArray());
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
