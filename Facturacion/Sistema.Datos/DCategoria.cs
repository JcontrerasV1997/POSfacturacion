////EN LA CAPA DATOS SE REALIZAN TODOS LOS METODOS PARA LA PERSISTENCIA CRUD Y YAMAMOS A LAS ENTIDADES
using System;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    /// <summary>
    /// Clase proveniente de la capa datos, donde muestra las funcionalidades desde la base de datos
    /// esta clase hace tiene cierta similitud de un modelo donde tiene las funcionalidades de las bases de datos
    /// </summary>
    public class DCategoria
    {
        /// <summary>
        /// Metodo de tipo datatable para representar una tabla en memoria este es equivalente a un string
        /// </summary>
        /// <returns></returns>
        public DataTable Listar()
        {
            SqlDataReader Resultado;  
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion(); ////inicio conexion
                SqlCommand comando = new SqlCommand("listar_categoria",sqlconecta); ////la clase sql comand crea variable y llama a procedimientos almacenados al igual que la conexion como argumento
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
                SqlCommand comando = new SqlCommand("buscar_categoria", sqlconecta);
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


        public DataTable Seleccionar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion(); ////inicio conexion
                SqlCommand comando = new SqlCommand("categoria_seleccionar", sqlconecta); ////la clase sql comand crea variable y llama a procedimientos almacenados al igual que la conexion como argumento
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

        public string Existe(string valor)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("existe_categoria", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                sqlconecta.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(parExiste.Value);
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

        public string Insertar(Categoria inserta)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("insertar_categoria", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = inserta.Nombre;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = inserta.Descripcion;
                sqlconecta.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "Ok" : "no se pudo ingresar el registro";
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

        public string Actualizar(Categoria actualiza)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("actualizar_categoria", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_categoria", SqlDbType.Int).Value = actualiza.idCategoria;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = actualiza.Nombre;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = actualiza.Descripcion;

                sqlconecta.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo actualizar";
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

        public string Eliminar(int Id)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("eliminar_categoria", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;

                sqlconecta.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "ok" : "no se pudo eliminar el registro";
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

        public string Activar(int Id)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("activar_categoria", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                sqlconecta.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "ok" : "no se pudo activar la categoria";
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

        public string Desactivar(int Id)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("desactivar_categoria", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.VarChar).Value = Id;
                sqlconecta.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "ok" : "no se pudo desactivar";
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


    }


}
