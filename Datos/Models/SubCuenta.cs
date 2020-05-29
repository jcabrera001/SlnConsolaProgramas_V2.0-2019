using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Models
{
    public class SubCuenta : DatosGenerales
    {
        public int SubCuentaID { get; set; }
        public Categoria CategoriaID { get; set; }
    }
}
