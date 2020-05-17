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

 
    public partial class FormularioIngreso : Form
    {

        private DataTable dtDetalle = new DataTable();
        public FormularioIngreso()
        {
            InitializeComponent();
        }


        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NIngreso.Listar();
                this.Formato();
                this.Limpiar();
                labelTotal.Text = "TOTAL DE REGISTROS:" + Convert.ToString(DgvListado.Rows.Count);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }

        }
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NIngreso.Buscar(txtBuscar.text);

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
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[6].HeaderText = "Serie";
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[7].HeaderText = "Número";
            DgvListado.Columns[8].Width = 200;
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[11].Width = 440;
        }
        private void FormatoArticulo()
        {
            dgvArticulos.Columns[1].Visible = false;
            dgvArticulos.Columns[2].Width = 100;
            dgvArticulos.Columns[2].HeaderText = "Categoría";
            dgvArticulos.Columns[3].Width = 100;
            dgvArticulos.Columns[3].HeaderText = "Código";
            dgvArticulos.Columns[4].Width = 150;
            dgvArticulos.Columns[5].Width = 100;
            dgvArticulos.Columns[5].HeaderText = "Precio Venta";
            dgvArticulos.Columns[6].Width = 60;
            dgvArticulos.Columns[7].Width = 200;
            dgvArticulos.Columns[7].HeaderText = "Descripción";
            dgvArticulos.Columns[8].Width = 100;

        }
        private void Limpiar()
        {
            txtBuscar.text = "";
            txtID.Text = "";
            botonInsertar.Visible = true;
            errorIcono.Clear();
            DgvListado.Columns[0].Visible = false;
            botonAnular.Visible = false;
            chkSeleccion.Checked = false;

            textoCodigoBarras.Text = "";
            textoIdproveedor.Text="";
            textoBuscarProveedor.text="";
            textoSerie.Text="";
            textoNumero.Text="";
            dtDetalle.Clear();
            textoSubtotal.Text = "0.00";
            textoTotalImpuesto.Text = "0.00";
            textoTotal.Text = "0.00";

            DgvListado.Columns[0].Visible = false;
            botonAnular.Visible = false;
            chkSeleccion.Checked = false;
        }
        private void MensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {

            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CrearTabla()
        {
            this.dtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));
            
            dgvDetalle.DataSource = this.dtDetalle;

            dgvDetalle.Columns[0].Visible = false;
            dgvDetalle.Columns[1].HeaderText = "CODIGO";
            dgvDetalle.Columns[1].Width = 100;
            dgvDetalle.Columns[2].HeaderText = "ARTICULO";
            dgvDetalle.Columns[2].Width = 100;
            dgvDetalle.Columns[3].HeaderText = "CANTIDAD";
            dgvDetalle.Columns[3].Width = 100;
            dgvDetalle.Columns[4].HeaderText = "PRECIO";
            dgvDetalle.Columns[4].Width = 100;
            dgvDetalle.Columns[5].HeaderText = "IMPORTE";
            dgvDetalle.Columns[5].Width = 100;

            dgvDetalle.Columns[1].ReadOnly = true;
            dgvDetalle.Columns[2].ReadOnly = true;
            dgvDetalle.Columns[5].ReadOnly = true;

        }
        private void FormularioIngreso_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
        }
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void botonBuscarProveedor_Click(object sender, EventArgs e)
        {
            FormularioProveedorIngreso frm = new FormularioProveedorIngreso();
            frm.ShowDialog();
            textoIdproveedor.Text = Convert.ToString(VariablesSeleccion.idProveedor);
            textoBuscarProveedor.text = Convert.ToString(VariablesSeleccion.nombreProveedor);
        }
        private void textoCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch(e.KeyCode)
                {
                    case Keys.Enter :
                        DataTable tabla = new DataTable();
                        tabla = NArticulo.BuscarCodigo(textoCodigoBarras.Text.Trim());
                        if (tabla.Rows.Count <= 0)
                        {
                            this.MensajeError("No existe el articulo con ese codigo");
                        }
                        else
                        {
                            this.agregarDetalle(Convert.ToInt32(tabla.Rows[0][0]), Convert.ToString(tabla.Rows[0][1]),
                                                Convert.ToString(tabla.Rows[0][2]), Convert.ToDecimal(tabla.Rows[0][3]));

                           
                        }
                        break;
                }
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message + exe.StackTrace);
            }
        }

        private void agregarDetalle(int idArticulo, string Codigo, string nombre,
            decimal precio)
        {

            bool agregar = true;
            foreach (DataRow filaTemporal in dtDetalle.Rows)
            {

                if (Convert.ToInt32(filaTemporal["idarticulo"])==idArticulo)
                {
                    agregar = false;
                    this.MensajeError("ya existe el articulo");
                }
            }
            if (agregar)
            {
                DataRow fila = dtDetalle.NewRow();
                fila["idarticulo"] = idArticulo;
                fila["codigo"] = Codigo;
                fila["articulo"] = nombre;
                fila["cantidad"] = 1;
                fila["precio"] = precio;
                fila["importe"] = precio;
                this.dtDetalle.Rows.Add(fila);
                this.CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            decimal total = 0;
            decimal SubTotal = 0;

            if (dgvDetalle.Rows.Count == 0)
            {
                total = 0;
            }
            else
            {
                foreach (DataRow filaTemporal in dtDetalle.Rows)
                {
                    total = total + Convert.ToDecimal(filaTemporal["importe"]);
                }
            }
            SubTotal = total / (1 + Convert.ToDecimal(textoImpuesto.Text));
            textoTotal.Text = total.ToString("#0.00#");
            textoSubtotal.Text = SubTotal.ToString("#0.00#");
            textoTotalImpuesto.Text = (total - SubTotal).ToString("#0.00");

        }
        private void botonVerArticulo_Click(object sender, EventArgs e)
        {
            cardArticulo.Visible = true;
        }

        private void botonFiltarArticulos_Click(object sender, EventArgs e)
        {
            try
            {

                dgvArticulos.DataSource = NArticulo.Buscar(textoBuscarArticulo.Text.Trim());
                this.FormatoArticulo();
                labelTotal.Text = "Total Registros" + Convert.ToString(dgvArticulos.Rows.Count);
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message+ex.StackTrace);
             
            }
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idArticulo;
            string codigo, nombre;
            decimal precio;

            idArticulo = Convert.ToInt32(dgvArticulos.CurrentRow.Cells["ID"].Value);
            codigo = Convert.ToString(dgvArticulos.CurrentRow.Cells["Codigo"].Value);
            nombre = Convert.ToString(dgvArticulos.CurrentRow.Cells["Nombre"].Value);
            precio = Convert.ToDecimal(dgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);
            this.agregarDetalle(idArticulo,codigo,nombre,precio);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            cardArticulo.Visible = false;
        }
        private void dgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow fila = (DataRow)dtDetalle.Rows[e.RowIndex];
            decimal precio=Convert.ToDecimal(fila["precio"]);
            int cantidad = Convert.ToInt32(fila["cantidad"]);
            fila["importe"] = precio *cantidad;
            this.CalcularTotales();
        }

        private void dgvDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.CalcularTotales();
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (textoIdproveedor.Text == string.Empty || textoImpuesto.Text == string.Empty || textoNumero.Text == string.Empty 
                    || dtDetalle.Rows.Count == 0)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(textoIdproveedor, "Seleccione un proveedor.");
                    errorIcono.SetError(textoImpuesto, "Ingrese un impuesto.");
                    errorIcono.SetError(textoNumero, "Ingrese el número del comprobante.");
                    errorIcono.SetError(dgvDetalle, "Debe tener al menos un detalle.");
                }
                else
                {
                    Respuesta = NIngreso.Insertar(Convert.ToInt32(textoIdproveedor.Text), VariablesSeleccion.idUsuario, comboComprobante.selectedValue, 
                        textoSerie.Text.Trim(), textoNumero.Text.Trim(), Convert.ToDecimal(textoImpuesto.Text), 
                                              Convert.ToDecimal(textoTotal.Text), dtDetalle);
                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void textoBuscarArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvMostrarDetalle.DataSource = NIngreso.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
                decimal Total, SubTotal;
                decimal Impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
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

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void chkSeleccion_OnChange(object sender, EventArgs e)
        {

            if (chkSeleccion.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                botonAnular.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
               botonAnular.Visible = false;
            }

        }

        private void botonAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas anular el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NIngreso.Anular(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se anuló el registro: " + Convert.ToString(row.Cells[6].Value) + "-" + 
                                    Convert.ToString(row.Cells[7].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void botonResetear_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
