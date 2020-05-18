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
    public partial class ConsultaVenta : Form
    {
        public ConsultaVenta()
        {
            InitializeComponent();
        }

        private void ConsultaVenta_Load(object sender, EventArgs e)
        {
           
        }


        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NVenta.ConsultaFecha(Convert.ToDateTime(datapickerInicio.Value), 
                                                              Convert.ToDateTime(datapickerFinal.Value));
                this.Limpiar();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + e.StackTrace);
            }

        }
        private void Formato()
        {

            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[6].HeaderText = "Serie";
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[7].HeaderText = "Número";
            DgvListado.Columns[8].Width = 60;
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[11].Width = 440;
        }
   
        private void Limpiar()
        {
        
            DgvListado.Columns[0].Visible = false;
          
        }
        private void MensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {

            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvMostrarDetalle.DataSource = NVenta.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
                decimal Total, SubTotal;
                decimal Impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["total"].Value);
                SubTotal = Total / (1 + Impuesto);
                textoSubtotalDetalle.Text = SubTotal.ToString("#0.00#");
                textoTotalImpuestoDetalle.Text = (Total - SubTotal).ToString("#0.00#");
                textoTotalDetalle.Text = Total.ToString("#0.00#");
                cardMostrar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cardMostrar.Visible = false;
        }

       
    }
}
