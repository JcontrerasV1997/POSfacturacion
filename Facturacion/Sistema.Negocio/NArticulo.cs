using System.Data;
using Sistema.Entidades;
using Sistema.Datos;
using System;

namespace Sistema.Negocio
{

    /// <summary>
    /// Clase proveniente de la capa de Negocio, esta es similar a la de un controlador
    /// esta capa trabaja junto a la capa datos y la capa entidades. aqui crearemos los metodos
    /// respectivos a la referencia de la capa datos, pero solamente se trabajaran de manera instanciadora
    /// </summary>
    public class NArticulo
    {

        public static DataTable Listar()
        {
            DArticulo Datos = new DArticulo();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Buscar(valor);
        
        
        }

        public static string Existe(string valor)
        {
            DArticulo Datos = new DArticulo();
            string Existe = Datos.Existe(valor);

            if (Existe.Equals("0"))
            {
                return "No existe el valor";
              
            }

            return Datos.Existe(valor);

        }

        public static DataTable BuscarVenta(string valor)
        {
            DArticulo Datos = new DArticulo();


            return Datos.BuscarVenta(valor);
        }


        public static DataTable BuscarCodigo(string valor)
        {
            DArticulo Datos = new DArticulo();


            return Datos.BuscarCodigo(valor);
        }

        public static DataTable BuscarCodigoVenta(string valor)
        {
            DArticulo Datos = new DArticulo();


            return Datos.BuscarCodigoVenta(valor);
        }

        public static string Insertar(int Idcategoria,string Codigo,string Nombre, 
                                      decimal precio_venta,int stock, string descripcion, string imagen)
                                      
        {
            DArticulo Datos = new DArticulo();
            string Existe = Datos.Existe(Nombre);

            if (Existe.Equals("1"))
            {
                return "El articulo ya existe";
            }
            else
            {
                Articulo nuevoArticulo = new Articulo();
                nuevoArticulo.id_categoria = Idcategoria;
                nuevoArticulo.codigo = Codigo;
                nuevoArticulo.nombre = Nombre;
                nuevoArticulo.precio_venta = precio_venta;
                nuevoArticulo.stock = stock;
                nuevoArticulo.descripcion = descripcion;
                nuevoArticulo.imagen = imagen;
                return Datos.Insertar(nuevoArticulo);
            }
        }


        public static string Actualizar(int Idarticulo, int Idcategoria,string Codigo,
                                       string nombreAnterior, string Nombre, decimal precio_venta,
                                       int stock, string Descripcion, string imagen)
                                      
        {
           DArticulo Datos = new DArticulo();
           Articulo nuevoArticulo = new Articulo();

            if (nombreAnterior.Equals(Nombre))
            {
                nuevoArticulo.id_categoria = Idcategoria;
                nuevoArticulo.id_articulo = Idarticulo;
                nuevoArticulo.codigo = Codigo;
                nuevoArticulo.nombre =Nombre;
                nuevoArticulo.precio_venta =precio_venta;
                nuevoArticulo.stock = stock;
                nuevoArticulo.descripcion = Descripcion;
                nuevoArticulo.imagen =imagen;
                return Datos.Actualizar(nuevoArticulo);

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
                    nuevoArticulo.id_categoria = Idcategoria;
                    nuevoArticulo.id_articulo = Idarticulo;
                    nuevoArticulo.codigo = Codigo;
                    nuevoArticulo.nombre = Nombre;
                    nuevoArticulo.precio_venta = precio_venta;
                    nuevoArticulo.stock = stock;
                    nuevoArticulo.descripcion = Descripcion;
                    nuevoArticulo.imagen = imagen;
                    return Datos.Actualizar(nuevoArticulo);
                }
            }
        }

        public static string Eliminar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Desactivar(Id);
        }


    }
}
