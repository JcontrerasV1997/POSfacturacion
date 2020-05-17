
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;
/// <summary>
/// las funciones que son estaticas lo son porque no se va a instanciar objetos de clase
/// ncategoria, seria inecesario llenar la memoria head con todos los atributos, con solo instanciar el metodo basta
/// 
/// </summary>
namespace Sistema.Negocio
{
    /// <summary>
    /// Clase proveniente de la capa de Negocio, esta es similar a la de un controlador
    /// esta capa trabaja junto a la capa datos y la capa entidades. aqui crearemos los metodos
    /// respectivos a la referencia de la capa datos, pero solamente se trabajaran de manera instanciadora
    /// </summary>

    public class NCategoria
    {
        
        public static DataTable Listar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(valor);
        }

        public static DataTable Seleccionar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Seleccionar();
        }


        public static string Insertar(string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            string Existe = Datos.Existe(Nombre);
           
            if (Existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                Categoria nuevaCategoria = new Categoria();
                nuevaCategoria.Nombre = Nombre;
                nuevaCategoria.Descripcion = Descripcion;
                return Datos.Insertar(nuevaCategoria);
            }
        }

        public static string Actualizar(int Id, string nombreAnterior,string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            Categoria Obj = new Categoria();

            if(nombreAnterior.Equals(Nombre))
            {
                Obj.idCategoria = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);

            }
            else
            {
                string Existe = Datos.Existe(Nombre);

                if (Existe.Equals("1"))
                {
                    return "La categoría ya existe";
                }
                else
                {
                    Obj.idCategoria = Id;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);

                }

            }
           
            
        }

        public static string Eliminar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Desactivar(Id);
        }


    }
}

