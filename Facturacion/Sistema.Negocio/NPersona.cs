using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NPersona
    {
        public static DataTable Listar()
        {
            DPersona Datos = new DPersona();
            return Datos.Listar();
        }
        public static DataTable ListarProveedores()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarProveedores();
        }

        public static DataTable ListarClientes()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarClientes();
        }

        public static DataTable Buscar(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.Buscar(Valor);
        }
        public static DataTable BuscarProveedores(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarProveedores(Valor);
        }
        public static DataTable BuscarClientes(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarClientes(Valor);
        }
        public static string Insertar(string TipoPersona, string Nombre, string TipoDocumento, 
                                    string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona metodosPersona = new DPersona(); ////se instancia la clase de persona, porque contiene los metodos referentes a mi BD
            string Existe = metodosPersona.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La persona ya existe.";
            }
            else
            {
                Persona nuevaPersona = new Persona(); /////SE INSTANCIA OBJETO ENTIDAD CON RESPECTIVOS ATRIBUTOS
                nuevaPersona.TipoPersona = TipoPersona;
                nuevaPersona.Nombre = Nombre;
                nuevaPersona.TipoDocumento = TipoDocumento;
                nuevaPersona.NumDocumento = NumDocumento;
                nuevaPersona.Direccion = Direccion;
                nuevaPersona.Telefono = Telefono;
                nuevaPersona.Email = Email;
                return metodosPersona.Insertar(nuevaPersona);
            }
        }

        public static string Actualizar(int Id, string TipoPersona, string NombreAnt, 
            string Nombre, string TipoDocumento, string NumDocumento, 
                         string Direccion, string Telefono, string Email)
        {
            DPersona metodosPersona = new DPersona();
            Persona nuevaPersona = new Persona();

            if (NombreAnt.Equals(Nombre))
            {
                nuevaPersona.IdPersona = Id;
                nuevaPersona.TipoPersona = TipoPersona;
                nuevaPersona.Nombre = Nombre;
                nuevaPersona.TipoDocumento = TipoDocumento;
                nuevaPersona.NumDocumento = NumDocumento;
                nuevaPersona.Direccion = Direccion;
                nuevaPersona.Telefono = Telefono;
                nuevaPersona.Email = Email;
                return metodosPersona.Actualizar(nuevaPersona);
            }
            else
            {
                string Existe = metodosPersona.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "Una persona con ese nombre ya existe.";
                }
                else
                {
                      nuevaPersona.IdPersona = Id;
                      nuevaPersona.TipoPersona = TipoPersona;
                      nuevaPersona.Nombre = Nombre;
                      nuevaPersona.TipoDocumento = TipoDocumento;
                      nuevaPersona.NumDocumento = NumDocumento;
                      nuevaPersona.Direccion = Direccion;
                      nuevaPersona.Telefono = Telefono;
                    nuevaPersona.Email = Email;
                    return metodosPersona.Actualizar(nuevaPersona);
                }
            }

        }

        public static string Eliminar(int Id)
        {
            DPersona Datos = new DPersona();
            return Datos.Eliminar(Id);
        }
    }
}
