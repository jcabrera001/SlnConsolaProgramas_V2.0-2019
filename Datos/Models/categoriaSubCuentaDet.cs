using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Models
{
    public class categoriaSubCuentaDet
    {
        public int ID { get; set; }
        public CategoriaSubCuenta CategoriaSubCuentaID { get; set; }
        public CategoriaAgrupacion CategoriaAgrupacionID { get; set; }
        public SubCuenta SubCuentaID { get; set; }

    }
}
