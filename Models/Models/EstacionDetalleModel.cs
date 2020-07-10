using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class EstacionDetalleModel
    {
        public int Id { get; set; }
        public Nullable<int> ts { get; set; }
        public Nullable<int> arch_int { get; set; }
        public Nullable<double> rev_type { get; set; }
        public Nullable<double> temp_out { get; set; }
        public Nullable<double> temp_out_hi { get; set; }
        public Nullable<double> temp_out_lo { get; set; }
        public Nullable<double> temp_in { get; set; }
        public Nullable<double> hum_in { get; set; }
        public Nullable<double> hum_out { get; set; }
        public Nullable<double> rainfall_in { get; set; }
        public Nullable<double> rainfall_clicks { get; set; }
        public Nullable<double> rainfall_mm { get; set; }
        public Nullable<double> rain_rate_hi_in { get; set; }
        public Nullable<double> rain_rate_hi_clicks { get; set; }
        public Nullable<double> rain_rate_hi_mm { get; set; }
        public Nullable<double> et { get; set; }
        public Nullable<double> bar { get; set; }
        public Nullable<double> solar_rad_avg { get; set; }
        public Nullable<double> solar_rad_hi { get; set; }
        public Nullable<double> uv_index_avg { get; set; }
        public Nullable<double> uv_index_hi { get; set; }
        public Nullable<double> wind_num_samples { get; set; }
        public Nullable<double> wind_speed_avg { get; set; }
        public Nullable<double> wind_speed_hi { get; set; }
        public Nullable<double> wind_dir_of_hi { get; set; }
        public Nullable<double> wind_dir_of_prevail { get; set; }
        public Nullable<double> forecast_rule { get; set; }
        public Nullable<double> abs_press { get; set; }
        public Nullable<double> bar_noaa { get; set; }
        public Nullable<double> dew_point_out { get; set; }
        public Nullable<double> dew_point_in { get; set; }
        public Nullable<double> emc { get; set; }
        public Nullable<double> heat_index_out { get; set; }
        public Nullable<double> heat_index_in { get; set; }
        public Nullable<double> wind_chill { get; set; }
        public Nullable<double> wind_run { get; set; }
        public Nullable<double> deg_days_heat { get; set; }
        public Nullable<double> deg_days_cool { get; set; }
        public Nullable<double> solar_energy { get; set; }
        public Nullable<double> uv_dose { get; set; }
        public Nullable<double> thw_index { get; set; }
        public Nullable<double> thsw_index { get; set; }
        public Nullable<double> wet_bulb { get; set; }
        public Nullable<double> night_cloud_cover { get; set; }
        public string StationId { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    }
}
