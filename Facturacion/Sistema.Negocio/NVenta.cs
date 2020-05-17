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
    public class NVenta
    {
        public static DataTable Listar()
        {
            DVenta Datos = new DVenta();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DVenta Datos = new DVenta();
            return Datos.Buscar(Valor);
        }

        public static DataTable ConsultaFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DVenta Datos = new DVenta();
            return Datos.ConsultaFecha(fechaInicio,fechaFin);
        }


        public static DataTable ListarDetalle(int Id)
        {
            DVenta Datos = new DVenta();
            return Datos.ListarDetalle(Id);
        }

        public static string Insertar(int IdCliente, int IdUsuario, string TipoComprobante,
                                     string SerieComprobante, string NumComprobante, decimal Impuesto, 
                                      decimal Total, DataTable Detalles)
        {
            DVenta metodosVenta = new DVenta();
            Venta nuevaVenta = new Venta();
             nuevaVenta.IdCliente = IdCliente;
             nuevaVenta.IdUsuario = IdUsuario;
             nuevaVenta.TipoComprobante = TipoComprobante;
             nuevaVenta.SerieComprobante = SerieComprobante;
             nuevaVenta.NumComprobante = NumComprobante;
             nuevaVenta.Impuesto = Impuesto;
             nuevaVenta.Total = Total;
             nuevaVenta.Detalles = Detalles;
            return metodosVenta.Insertar(nuevaVenta);
        }
        public static string Anular(int Id)
        {
            DVenta Datos = new DVenta();
            return Datos.Anular(Id);
        }

    }
}
