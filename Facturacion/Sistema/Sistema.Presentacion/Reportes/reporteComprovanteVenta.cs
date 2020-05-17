using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Reportes
{
    public partial class reporteComprovanteVenta : Form
    {
        public reporteComprovanteVenta()
        {
            InitializeComponent();
        }

        private void reporteComprovanteVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.venta_comprobante' Puede moverla o quitarla según sea necesario.
            this.venta_comprobanteTableAdapter.Fill(this.dsSistema.venta_comprobante,VariablesSeleccion.IdVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
