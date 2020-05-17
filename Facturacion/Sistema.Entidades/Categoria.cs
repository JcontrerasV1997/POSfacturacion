
namespace Sistema.Entidades
{

    /// <summary>
    /// el modelo conceptual dentro de las bases de datos
    /// tiene mucha referencia dentro de las clases del aplicativo a desarrollar}
    /// ambas tienen entidades, instancias y atributos
    /// en la capa entidades solo se describen las entidades y sus atributos
    /// </summary>
    public class Categoria
    {

        public int idCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }


    }
}
