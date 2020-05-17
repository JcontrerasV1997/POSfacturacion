using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema.Entidades
{
    /// <summary>
    /// Clase proveniente de la capa entidades, en esta capa se describen las entidades analisadas previamente
    /// en un diagrama entidad relacion. nuestro modelo relacional de nuestras tablas, tambien son representadas
    /// en nuestras clases por eso tambien tienen que ser iguales, esto es debido a que son ENTIDADES
    /// </summary>
    public class Ingreso
    {

        public int IdIngreso { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuario { get; set; }
        public string TipoComprobante { get; set; }
        public string SerieComprobante { get; set; }
        public string NumComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public DataTable Detalles { get; set; }


    }
}
