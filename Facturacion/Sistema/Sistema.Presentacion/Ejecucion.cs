using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    class Ejecucion
    {

        [STAThread] /////atributo esencial para la comunicacion de subprocesos en el sistema operativo
                        /////se recomienda siempre colocarlo en la clase principal. este sirve para comunicacion de mensajes de window como 
                        //////ventanasa para agregar imagenes etc.
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioLogin());
        }

    }

}
