using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FormularioBuscarCliente : Form
    {
        public FormularioBuscarCliente()
        {
            InitializeComponent();
        }

        private void FormularioBuscarCliente_Load(object sender, EventArgs e)
        {

        }
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NPersona.BuscarClientes(txtBuscar.text);

                if (txtBuscar.text.Equals(Convert.ToString(DgvListado.DataSource)))
                {
                    MessageBox.Show("no se encuentra", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + e.StackTrace);
            }

        }
        private void Formato()
        {

            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[2].HeaderText = "Tipo Persona";
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "Documento";
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[5].HeaderText = "Numero Doc";
            DgvListado.Columns[6].Width = 190;
            DgvListado.Columns[6].HeaderText = "Direccion";
            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[7].HeaderText = "Telefono";
            DgvListado.Columns[8].Width = 120;
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesSeleccion.IdCliente = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
            VariablesSeleccion.nombreCliente = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
            this.Close();
        
        }
    }
}
