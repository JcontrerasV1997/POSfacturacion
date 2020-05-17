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
   public class DArticulo
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado; ////esta clase sirve para la lectura de flujo de filas
            DataTable tabla = new DataTable(); /////objeto que representa una tabla
            SqlConnection sqlconecta = new SqlConnection();/////clase para conectar
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion(); ////inicio conexion
                SqlCommand comando = new SqlCommand("articulo_listar", sqlconecta); ////la clase sql comand crea variable y llama a procedimientos almacenados al igual que la conexion como argumento
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
                SqlCommand comando = new SqlCommand("articulo_buscar", sqlconecta);
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
        public DataTable BuscarCodigo(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_buscar_codigo", sqlconecta);
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

        public DataTable BuscarCodigoVenta(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_buscar_codigo_venta", sqlconecta);
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

        public DataTable BuscarVenta(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_buscar_venta", sqlconecta);
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
        public string Existe(string valor)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_existe", sqlconecta);
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
        public string Insertar(Articulo inserta)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_insertar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = inserta.id_categoria;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = inserta.codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = inserta.nombre;
                comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = inserta.precio_venta;
                comando.Parameters.Add("@stock", SqlDbType.Int).Value = inserta.stock;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = inserta.descripcion;
                comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = inserta.imagen;
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
        public string Actualizar(Articulo actualiza)
        {
            string respuesta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand comando = new SqlCommand("articulo_actualizar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = actualiza.id_articulo;
                comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = actualiza.id_categoria;
                comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = actualiza.codigo;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = actualiza.nombre;
                comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = actualiza.precio_venta;
                comando.Parameters.Add("@stock", SqlDbType.Int).Value = actualiza.stock;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = actualiza.descripcion;
                comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = actualiza.imagen;
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
                SqlCommand comando = new SqlCommand("articulo_eliminar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;

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
                SqlCommand comando = new SqlCommand("articulo_activar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;
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
                SqlCommand comando = new SqlCommand("articulo_desactivar", sqlconecta);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idarticulo", SqlDbType.VarChar).Value = Id;
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
