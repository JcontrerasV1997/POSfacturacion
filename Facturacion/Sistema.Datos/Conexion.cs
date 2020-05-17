using System;
using System.Data.SqlClient;  //namespace para trabajar con base de datos
namespace Sistema.Datos
{
    public class Conexion
    {
        //Estos atributos no les genero metodos getters y setters
        //porque no es necesario compartirlos con los demas, solo un solo objeto de conexion
        private string BaseDatos;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion InicioConexion = null;

        /// <summary>
        /// El Constructor es privado porque se instanciara la clase en la misma clase
        /// no es necesario que reciba parametros
        /// </summary>
        /// 
        private Conexion()
        {
            this.BaseDatos = "SOFT_FACTURACION";
            this.Servidor = "DESKTOP-RB5KS42\\SQLEXPRESS";
            this.Usuario = "juan";
            this.Clave = "juan123";
            this.Seguridad = true; ////
        }
        /// <summary>
        /// creamos un metodo de tipo sql conection, este espacio de nombre sirve para trabajar con clases predeterminadas para conexion
        /// este metodo crea la conexion con los datos necesarios
        /// </summary>
        /// <returns></returns>
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection(); ///creamos objeto de tipo sqlconection
            try
            {
                ////en pocas palabras la conexion es representada como una cadena de conexion
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.BaseDatos + ";";
                if (this.Seguridad) Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI"; //integrated es la seguridad de window
                else Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + ";Password=" + this.Clave;////Seguridad de sql
            }
            catch (Exception captura) ////la clase exception es globbal para coger cualquier excepcion
            {
                Cadena = null;  ////al capturar una excepcion es necesario que la cadena vuelva a su nulidad
                throw captura;

            }
 return Cadena;
            }
        /// <summary>
        /// el atributo conexion al ser privado requiere de un metodo get
        /// aqui valido si el objeto  inicio conexion es nulo, por tanto siempre inicia nulo
        /// entonces crea el objeto y lo retorna. este metodo instancia la conexion
        /// </summary>
        /// <returns></returns>
        public static Conexion getConexion()
        {
            if (InicioConexion == null)
                InicioConexion = new Conexion();
            return InicioConexion;
        }
    }
    }

