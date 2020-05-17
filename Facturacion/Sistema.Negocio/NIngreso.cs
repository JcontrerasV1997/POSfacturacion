using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;
using Sistema.Datos;
namespace Sistema.Negocio
{
    public class NIngreso
    {
        public static DataTable Listar()
        {
            DIngreso Datos = new DIngreso();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DIngreso Datos = new DIngreso();
            return Datos.Buscar(Valor);
        }

        public static DataTable ListarDetalle(int Id)
        {
            DIngreso Datos = new DIngreso();
            return Datos.ListarDetalle(Id);
        }

        public static string Insertar(int IdProveedor, int IdUsuario, string TipoComprobante, 
                                        string SerieComprobante, string NumComprobante, decimal Impuesto, 
                                             decimal Total, DataTable Detalles)
        {
            DIngreso Datos = new DIngreso();
            Ingreso nuevoIngreso = new Ingreso();
            nuevoIngreso.IdProveedor = IdProveedor;
            nuevoIngreso.IdUsuario = IdUsuario;
            nuevoIngreso.TipoComprobante = TipoComprobante;
            nuevoIngreso.SerieComprobante = SerieComprobante;
            nuevoIngreso.NumComprobante = NumComprobante;
            nuevoIngreso.Impuesto = Impuesto;
            nuevoIngreso.Total = Total;
            nuevoIngreso.Detalles = Detalles;
            return Datos.Insertar(nuevoIngreso);
        }
        public static string Anular(int Id)
        {
            DIngreso Datos = new DIngreso();
            return Datos.Anular(Id);
        }
    }
}
