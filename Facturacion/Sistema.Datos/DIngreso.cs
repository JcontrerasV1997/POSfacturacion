using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class DIngreso
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion(); ////inicio conexion
                SqlCommand comando = new SqlCommand("ingreso_listar", sqlconecta); ////la clase sql comand crea variable y llama a procedimientos almacenados al igual que la conexion como argumento
                comando.CommandType = CommandType.StoredProcedure; ////al crear un comando entonces se le denomina detipo procedimiento almacenado
                sqlconecta.Open(); ////abro conexion
                Resultado = comando.ExecuteReader(); //// asignamos comando al resultado
                tabla.Load(Resultado); ////cargamos la tabla
                return tabla; ////retornamos tabla
            }
            catch (Exception excepcion)
            {

                throw excepcion;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();

            }
        }
        public DataTable Buscar(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("ingreso_buscar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlconecta.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }

            catch (Exception excepcion)
            {

                throw excepcion;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();

            }

        }

        public string Insertar(Ingreso inserta)
        {



            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("ingreso_insertar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idproveedor", SqlDbType.Int).Value = inserta.IdProveedor;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = inserta.IdUsuario;
                comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = inserta.TipoComprobante;
                comando.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = inserta.SerieComprobante;
                comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = inserta.NumComprobante;
                comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = inserta.Impuesto;
                comando.Parameters.Add("@total", SqlDbType.Decimal).Value = inserta.Total;
                comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = inserta.Detalles; ////El tipo de dato structured sirve para representar un type de transact sql que hace referencia a una tabla
                                                                                ////Especial, de tal manera que al crear un type tipo tabla y guardarlo en un parametro, con structured sirve para referenciarlo en c#
                sqlconecta.Open();
                comando.ExecuteNonQuery();
                respuesta = "OK";

            }
            catch (Exception excepcion)
            {
                respuesta = excepcion.Message;


            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();


            }
            return respuesta;

        }

        public DataTable ListarDetalle(int Id)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();

            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("ingreso_listar_detalle", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idingreso", SqlDbType.Int).Value = Id;
                sqlconecta.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();
            }
        }


        public string Anular(int Id)
        {
            string Rpta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("ingreso_anular", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idingreso", SqlDbType.Int).Value = Id;
                sqlconecta.Open();
                comando.ExecuteNonQuery();
                Rpta = "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();
            }
            return Rpta;
        }



    }
}
