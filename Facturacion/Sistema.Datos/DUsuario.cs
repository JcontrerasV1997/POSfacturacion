using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sistema.Entidades;
namespace Sistema.Datos
{

    /// <summary>
    /// Clase proveniente de la capa datos, donde muestra las funcionalidades desde la base de datos
    /// esta clase hace tiene cierta similitud de un modelo donde tiene las funcionalidades de las bases de datos
    /// </summary>
    public class DUsuario
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion(); ////inicio conexion
                SqlCommand comando = new SqlCommand("usuario_listar", sqlconecta); ////la clase sql comand crea variable y llama a procedimientos almacenados al igual que la conexion como argumento
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
                SqlCommand comando = new SqlCommand("usuario_buscar", sqlconecta);
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
                SqlCommand comando = new SqlCommand("usuario_seleccionar", sqlconecta); ////la clase sql comand crea variable y llama a procedimientos almacenados al igual que la conexion como argumento
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
                SqlCommand comando = new SqlCommand("usuario_existe", sqlconecta);
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
        public string Insertar(Usuario inserta)
        {

           

            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("usuario_insertar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idrol", SqlDbType.Int).Value = inserta.IdRol;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = inserta.Nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = inserta.TipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = inserta.NumDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = inserta.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = inserta.Telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = inserta.Email;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = inserta.Clave;
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
        public string Actualizar(Usuario actualiza)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("usuario_actualizar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = actualiza.IdUsuario;
                comando.Parameters.Add("@idrol", SqlDbType.Int).Value = actualiza.IdRol;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = actualiza.Nombre;
                comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = actualiza.TipoDocumento;
                comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = actualiza.NumDocumento;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = actualiza.Direccion;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = actualiza.Telefono;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = actualiza.Email;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = actualiza.Clave;
                sqlconecta.Open();
               

                respuesta = comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo actualizar";
            }
            catch (SqlException excepcion)
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
                SqlCommand comando = new SqlCommand("usuario_eliminar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id;

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
                SqlCommand comando = new SqlCommand("usuario_activar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id;
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
                SqlCommand comando = new SqlCommand("usuario_desactivar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idusuario", SqlDbType.VarChar).Value = Id;
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
        public DataTable Login(string email,string clave)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("usuario_loguin", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;

                sqlconecta.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }

            catch (Exception excepcion)
            {
                return null;

                throw excepcion;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();

            }

        }

    }
}
