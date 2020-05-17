using System.Data;
using Sistema.Datos;

namespace Sistema.Negocio
{

    /// <summary>
    /// Clase proveniente de la capa de Negocio, esta es similar a la de un controlador
    /// esta capa trabaja junto a la capa datos y la capa entidades. aqui crearemos los metodos
    /// respectivos a la referencia de la capa datos, pero solamente se trabajaran de manera instanciadora
    /// </summary>
    public class NRol
    {

        public static DataTable Listar()
        {

            DRol datos = new DRol();

            return datos.Listar();

        }

    }
}
