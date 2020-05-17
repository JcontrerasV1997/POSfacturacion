
namespace Sistema.Entidades
{

    /// <summary>
    /// Clase proveniente de la capa entidades, en esta capa se describen las entidades analisadas previamente
    /// en un diagrama entidad relacion. nuestro modelo relacional de nuestras tablas, tambien son representadas
    /// en nuestras clases por eso tambien tienen que ser iguales, esto es debido a que son ENTIDADES
    /// </summary>
    public class Articulo
    {
        public int id_articulo { get; set; }
        public int id_categoria { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public decimal precio_venta { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public bool estado { get; set; }
    }
}
