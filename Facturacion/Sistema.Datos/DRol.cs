using System;
using System.Data;
using System.Data.SqlClient;
namespace Sistema.Datos
{

    public class DRol
    {
        /// <summary>
        /// Clase proveniente de la capa datos, donde muestra las funcionalidades desde la base de datos
        /// esta clase hace tiene cierta similitud de un modelo donde tiene las funcionalidades de las bases de datos
        /// </summary>
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlconecta = new SqlConnection();
            try
            {
                sqlconecta = Conexion.getConexion().CrearConexion(); ////inicio conexion
                SqlCommand comando = new SqlCommand("rol_listar", sqlconecta); ////la clase sql comand crea variable y llama a procedimientos almacenados al igual que la conexion como argumento
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

    }
}
