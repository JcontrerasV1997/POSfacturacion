using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Sistema.Entidades;
using System.Data;

namespace Sistema.Datos
{
    /// <summary>
    /// Clase proveniente de la capa datos, donde muestra las funcionalidades desde la base de datos
    /// esta clase  tiene cierta similitud a la proporcion de un modelo donde tiene las funcionalidades de las bases de datos
    /// se tiene en cuenta que se optimizo a los clientes, proveedores dentro de la tabla tan solo utilizando el tipo de persona
    /// </summary>

    public class DPersona
    {

        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_listar", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                sqlconecta.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();
            }
        }

        public DataTable ListarProveedores()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_listar_proveedores", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                sqlconecta.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();
            }
        }

        public DataTable ListarClientes()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_listar_clientes", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                sqlconecta.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();
            }
        }

        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable BuscarProveedores(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_buscar_proveedores", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                sqlconecta.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();
            }
        }

        public DataTable BuscarClientes(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_buscar_clientes", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                sqlconecta.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlconecta.State == ConnectionState.Open) sqlconecta.Close();
            }
        }

        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_existe", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                sqlconecta.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
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

        public string Insertar(Persona agregar)
        {
            string Rpta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_insertar", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = agregar.TipoPersona;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = agregar.Nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = agregar.TipoDocumento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = agregar.NumDocumento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = agregar.Direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = agregar.Telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = agregar.Email;
                sqlconecta.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
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

        public string Actualizar(Persona Obj)
        {
            string Rpta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_actualizar", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = Obj.IdPersona;
                Comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = Obj.TipoPersona;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento;
                Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono;
                Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email;
                sqlconecta.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
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

        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion();
                SqlCommand Comando = new SqlCommand("persona_eliminar", sqlconecta);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = Id;
                sqlconecta.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
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
