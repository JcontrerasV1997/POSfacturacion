using System;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class FormularioRoles : Form
    {
        public FormularioRoles()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NRol.Listar();
                this.Formato();
                labelTotal.Text = "Total registros:" + Convert.ToString(DgvListado.Rows.Count);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }

        }

        private void Formato()
        {

            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[0].HeaderText = "ID";
            DgvListado.Columns[1].Width = 330;
            DgvListado.Columns[1].HeaderText = "Nombre";
   
        }


        private void FormularioRoles_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
