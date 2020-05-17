using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{


    /// <summary>
    /// Clase proveniente de la capa de Negocio, esta es similar a la de un controlador
    /// esta capa trabaja junto a la capa datos y la capa entidades. aqui crearemos los metodos
    /// respectivos a la referencia de la capa datos, pero solamente se trabajaran de manera instanciadora
    /// </summary>
    public class NUsuario
    {
        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Buscar(valor);
        }

        public static DataTable Login(string email,string clave)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Login(email,clave);
        }

        public static string Insertar(int idRol,string Nombre,string tipoDocumento,
                                        string numDocumento,string direccion,string telefono,
                                        string email,string clave, string Descripcion)
        {
            DUsuario Datos = new DUsuario();
            string Existe = Datos.Existe(Nombre);

            if (Existe.Equals("1"))
            {
                return "el usuario ya existe";
            }
            else
            {
               Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.IdRol = idRol;
                nuevoUsuario.Nombre = Nombre;
                nuevoUsuario.TipoDocumento = tipoDocumento;
                nuevoUsuario.NumDocumento = numDocumento;
                nuevoUsuario.Direccion = direccion;
                nuevoUsuario.Telefono = telefono;
                nuevoUsuario.Email = email;
                nuevoUsuario.Clave = clave;
             
                return Datos.Insertar(nuevoUsuario);
            }
        }
        public static string Actualizar(int Id,int idRol, string Nombre, string tipoDocumento,
                                        string numDocumento, string direccion, string telefono,
                                        string emailAnterior,string email, string clave)
        {
            DUsuario Datos = new DUsuario();
            Usuario usuario = new Usuario();

            if (emailAnterior.Equals(email))
            {
                usuario.IdUsuario = Id;
                usuario.IdRol = idRol;
                usuario.Nombre = Nombre;
                usuario.TipoDocumento = tipoDocumento;
                usuario.NumDocumento = numDocumento;
                usuario.Direccion = direccion;
                usuario.Telefono = telefono;
                usuario.Email = email;
                usuario.Clave = clave;
                return Datos.Actualizar(usuario);
            }
            else
            {
                string Existe = Datos.Existe(email);

                if (Existe.Equals("1"))
                {
                    return "el usuario ya existe";
                }
                else
                {
                    usuario.IdUsuario = Id;
                    usuario.IdRol = idRol;
                    usuario.Nombre = Nombre;
                    usuario.TipoDocumento = tipoDocumento;
                    usuario.NumDocumento = numDocumento;
                    usuario.Direccion = direccion;
                    usuario.Telefono = telefono;
                    usuario.Email = email;
                    usuario.Clave = clave;
                    return Datos.Actualizar(usuario);
                }
            }
        }
        public static string Eliminar(int Id)
        {
           DUsuario Datos = new DUsuario();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Desactivar(Id);
        }

    }
}
