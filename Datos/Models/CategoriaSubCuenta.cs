namespace Datos.Models
{
    public class CategoriaSubCuenta
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public CategoriaCuenta CategoriaCuentaID { get; set; }

    }
}
