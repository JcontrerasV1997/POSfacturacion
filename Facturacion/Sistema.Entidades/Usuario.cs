

namespace Sistema.Entidades
{

    /// <summary>
    /// Clase proveniente de la capa entidades, en esta capa se describen las entidades analisadas previamente
    /// en un diagrama entidad relacion. nuestro modelo relacional de nuestras tablas, tambien son representadas
    /// en nuestras clases por eso tambien tienen que ser iguales, esto es debido a que son ENTIDADES
    /// </summary>
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
    }
}
