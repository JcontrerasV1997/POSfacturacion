using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{ /// <summary>
  /// Clase proveniente de la capa entidades, en esta capa se describen las entidades analisadas previamente
  /// en un diagrama entidad relacion. nuestro modelo relacional de nuestras tablas, tambien son representadas
  /// en nuestras clases por eso tambien tienen que ser iguales, esto es debido a que son ENTIDADES
  /// </summary>
    public class Persona
    {

        public int IdPersona;
        public string TipoPersona;
        public string Nombre;
        public string TipoDocumento;
        public string NumDocumento;
        public string Direccion;
        public string Telefono;
        public string Email;
    }
}
