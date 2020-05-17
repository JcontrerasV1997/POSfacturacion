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
    public partial class FormularioProveedores : Form
    {

        private string nombreAnterior;
        public FormularioProveedores()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NPersona.ListarProveedores();
                this.Formato();
                this.Limpiar();
                labelTotal.Text = "TOTAL DE REGISTROS :" + Convert.ToString(DgvListado.Rows.Count);

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
                DgvListado.DataSource = NPersona.BuscarProveedores(txtBuscar.text);


                if (txtBuscar.text != Convert.ToString(DgvListado.DataSource))
                {
                    MessageBox.Show("no se encuentra", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                    this.Formato();
                labelTotal.Text = " TOTAL DE REGISTROS : \t" + Convert.ToString(DgvListado.Rows.Count);
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
            DgvListado.Columns[8].Width = 210;

        }
        private void Limpiar()
        {
            txtBuscar.text = "";
            textoNombre.Text = "";
            txtID.Text = "";
            //txtDescripcion.Text = "";
            textoNumeroDocumento.Text="";
            textoDireccion.Text="";
            textoEmail.Text="";
            textoTelefono.Text="";
            botonInsertar.Visible = true;
            botonActualizar.Visible = false;
            errorIcono.Clear();
            DgvListado.Columns[0].Visible = false;
            botoEliminar.Visible = false;
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

        private void FormularioProveedores_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {

            this.Buscar();

        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (textoNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(textoNombre, "ingrese nombre");
                }
                else
                {
                    respuesta = NPersona.Insertar("Proveedor", textoNombre.Text.Trim(), comboTipoDocumento.Text, textoNumeroDocumento.Text.Trim(),
                                                     textoDireccion.Text.Trim(), textoTelefono.Text.Trim(), textoEmail.Text.Trim());
                    if (respuesta.Equals("OK"))
                    {

                        this.MensajeOk("Se Registro correctamente");
                        this.Listar();
                    }
                    else
                    {

                        this.MensajeError(respuesta);
                    }
                }
            }
            catch (Exception exepcion)
            {
                MessageBox.Show(exepcion.Message + exepcion.StackTrace);
            }


        }

        private void DgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                botonActualizar.Visible = true;
                botonInsertar.Visible = false;
                txtID.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                this.nombreAnterior = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                textoNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                comboTipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Tipo_Documento"].Value);
                textoNumeroDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Num_Documento"].Value);
                textoDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                textoTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                textoEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {


            try
            {
                string Rpta = "";
                if (txtID.Text == string.Empty || textoNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(textoNombre, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = NPersona.Actualizar(Convert.ToInt32(txtID.Text), "Proveedor", this.nombreAnterior, textoNombre.Text.Trim(), comboTipoDocumento.Text,
                        textoNumeroDocumento.Text.Trim(), textoDireccion.Text.Trim(), textoTelefono.Text.Trim(), textoEmail.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


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
                botoEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                botoEliminar.Visible = false;
            }
        }
        private void botoEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("deseas eliminar el registro", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string respuesta = "";
                    foreach (DataGridViewRow fila in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(fila.Cells[1].Value);
                            respuesta = NPersona.Eliminar(Codigo);
                            this.MensajeOk("Se elimino el registro : " + Convert.ToString(fila.Cells[3].Value));
                        }

                    }
                }
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
            chkSeleccion.Visible = true;
        }
    }

    }
 

