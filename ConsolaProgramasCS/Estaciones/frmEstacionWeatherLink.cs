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
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Datos.Conexion;
using Datos.Models;

namespace ConsolaProgramasCS.Estaciones
{
    public partial class frmEstacionWeatherLink : XtraForm
    {
        DateTime baseDate = new DateTime(1969, 12, 31, 18, 00, 00); //Hora base para el Timestamp
        DateTime hoy = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        private string apiKey="gyl68lwxjidftgfdpapnlkwrqv3tmrj6";
        private string apiSecretKey = "ycubqcgsyrgi7y8nigofvep7qggjlv8r";
        public Estacion estacion = new Estacion();
        public EstacionDetalle EstacionDetalle = new EstacionDetalle();


        public frmEstacionWeatherLink()
        {
            InitializeComponent();
            //nfjkgdsjkgbfkjd
        }

        private void frmEstacionWeatherLink_Load(object sender, EventArgs e)
        {
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea procesar la  información?", "Estaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
        }
        public void Integracion()
        {
            DateTime fecha = (DateTime)dtpFecha.EditValue;

            //Timestamp Inicial,   Es la fecha de ayer
            var startDate = fecha;
            var timestampStart = startDate.Subtract(baseDate).TotalSeconds;

            //Timestam Final, Es la fecha de Hoy            
            var timestampEnd = fecha.Subtract(baseDate).TotalSeconds;

            try
            {
                var estaciones = from d in estacion.getEstaciones() select d;
                foreach (var estacion in estaciones)
                {
                    getURL(estacion.StationID.ToString(), timestampStart, timestampEnd);
                }

                estacion.executeQuery("spEstacionesWeatherLinkInsert", new SqlParameter("@fecha", fecha));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Integración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getURL(string stationId, double start, double end)
        {
            try
            {
                SortedDictionary<string, string> parameters = new SortedDictionary<string, string>();
                parameters.Add("api-key", apiKey);
                parameters.Add("api-secret", apiSecretKey);
                parameters.Add("end-timestamp", end.ToString());
                parameters.Add("start-timestamp", start.ToString());
                parameters.Add("station-id", stationId);
                parameters.Add("t", hoy.Subtract(baseDate).TotalSeconds.ToString());  //DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString());


                //Removiendo el api-secret, porque no debe ser incluido en el "String" que se hara HASH
                string apiSecret = parameters["api-secret"];
                parameters.Remove("api-secret");

                StringBuilder dataStringBuilder = new StringBuilder();
                foreach (KeyValuePair<string, string> entry in parameters)
                {
                    dataStringBuilder.Append(entry.Key);
                    dataStringBuilder.Append(entry.Value);
                }
                string data = dataStringBuilder.ToString();         //String que se convertira en HASH


                //Calculate the HMAC SHA-256 hash that will be used as the API Signature.                
                string apiSignatureString = null;
                using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(apiSecret)))
                {
                    byte[] apiSignatureBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
                    apiSignatureString = BitConverter.ToString(apiSignatureBytes).Replace("-", "").ToLower();
                }


                string url = " https://api.weatherlink.com/v2/historic/" + parameters["station-id"] +
                  "?api-key=" + parameters["api-key"] +
                  "&api-signature=" + apiSignatureString +
                  "&t=" + parameters["t"] +
                  "&start-timestamp=" + parameters["start-timestamp"] +
                  "&end-timestamp=" + parameters["end-timestamp"];

                ReadAPI(url, stationId);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " getURL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReadAPI(string url, string stationId) //int StationID, string apiKey, string apiSignature)// TimeSpan t, TimeSpan star, TimeSpan end)
        {
            var client = new RestClient(url);
            var request = new RestRequest();

            // execute the request
            request.RequestFormat = DataFormat.Json;                //Convirtiendo el la información a formato JSON.
            IRestResponse response = client.Execute(request);       //Ejecutando el Request.
            var content = response.Content;                         //Almacenando el contenido del Request.

            JObject rss = JObject.Parse(content.ToString());
            List<EstacionDetalleModel> detalles = JsonConvert.DeserializeObject<List<EstacionDetalleModel>>(rss["sensors"][0]["data"].ToString());

            try
            {
                foreach (var detalle in detalles)
                {
                    detalle.StationId = stationId;
                    detalle.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).AddDays(-1);
                    EstacionDetalle.Insert(detalle);
                    //db.EstacionDetalles.Add(detalle);
                    //db.SaveChanges();
                }
            }
 
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " Read API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}