using System;
using Sistema.Negocio;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FormularioUsuario : Form
    {

        private string EmailAnterior;
        public FormularioUsuario()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NUsuario.Listar();
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
                DgvListado.DataSource = NUsuario.Buscar(txtBuscar.text);
                
                
                if (txtBuscar.text != Convert.ToString(DgvListado.DataSource))
                {
                    MessageBox.Show("no se encuentra", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                this.Formato();
                labelTotal.Text = " TOTAL DE REGISTROS: \t" + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + e.StackTrace);
            }

        }
        private void Formato()
        {

            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[4].Width = 170;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 150;
            DgvListado.Columns[6].HeaderText = "Numero Doc";
            DgvListado.Columns[7].Width = 120;
            DgvListado.Columns[7].HeaderText = "Direccion";
            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[8].HeaderText = "Telefono";
            DgvListado.Columns[9].Width = 150;
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
            textoClave.Text="";
            textoTelefono.Text="";
            botonInsertar.Visible = true;
            botonActualizar.Visible = false;
            errorIcono.Clear();
            DgvListado.Columns[0].Visible = false;
            chkActivar.Visible = false;
            botoEliminar.Visible = false;
            labelActivar.Visible = false;
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
        private void FormularioUsuario_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.cargarRol();
        }
        private void cargarRol()
        {
            try
            {
                comboRol.DataSource = NRol.Listar();
                comboRol.ValueMember = "id_rol";
                comboRol.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);  
            }

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
                if (comboRol.Text == string.Empty || textoNombre.Text==string.Empty||textoEmail.Text==string.Empty||textoClave.Text==string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");

                    errorIcono.SetError(textoNombre, "ingrese nombre");
                    errorIcono.SetError(comboRol, "ingrese rol");
                    errorIcono.SetError(textoEmail, "ingrese email");
                    errorIcono.SetError(textoClave, "ingrese clave");
                  
                }
                else
                {
                    respuesta = NUsuario.Insertar(Convert.ToInt32(comboRol.SelectedValue),textoNombre.Text.Trim(),
                                                     comboTipoDocumento.Text,textoNumeroDocumento.Text.Trim(),
                                                       textoDireccion.Text.Trim(),textoTelefono.Text.Trim(),textoEmail.Text.Trim(),
                                                       textoEmail.Text.Trim(),textoClave.Text.Trim());
                                                    
                    if (respuesta.Equals("Ok"))
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

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                botonActualizar.Visible = true;
                botonInsertar.Visible = false;
                txtID.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
               comboRol.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["id_rol"].Value);
                textoNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                comboTipoDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Tipo_Documento"].Value);
                textoNumeroDocumento.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Num_Documento"].Value);
                textoDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                textoTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                this.EmailAnterior= Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                textoEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre" + "| Error:" + ex);
            }
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                string respuesta = "";
                if (txtID.Text == string.Empty || comboRol.Text == string.Empty || textoNombre.Text == string.Empty || 
                    textoEmail.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(textoNombre, "ingrese nombre");
                    errorIcono.SetError(comboRol, "ingrese rol");
                    errorIcono.SetError(textoEmail, "ingrese email");
             
                }
                else
                {

         respuesta = NUsuario.Actualizar(Convert.ToInt32(txtID.Text),Convert.ToInt32(comboRol.SelectedValue), 
                                        textoNombre.Text.Trim(),comboTipoDocumento.Text,textoNumeroDocumento.Text.Trim(),
                                        textoDireccion.Text.Trim(),textoTelefono.Text.Trim(),this.EmailAnterior,textoEmail.Text.Trim(),
                                        textoClave.Text.Trim());

                   

                   
                    if (respuesta.Equals("Ok"))
                    {
                        this.MensajeOk("se actualizo");
                        this.Limpiar();
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;
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

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Listar();
            TabGeneral.SelectedIndex = 0;

        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)
                    DgvListado.Rows[e.RowIndex].Cells["seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);

                bool valor = Convert.ToBoolean(DgvListado.SelectedCells[10].Value);

                if (valor == true)
                {
                    chkActivar.Value = true;

                }
                else
                {

                    chkActivar.Value = false;
                }
            }

        }

        private void chkSeleccion_OnChange(object sender, EventArgs e)
        {
            if (chkSeleccion.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                botoEliminar.Visible = true;
                labelActivar.Visible = true;
                chkActivar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                chkActivar.Visible = false;
                botoEliminar.Visible = false;
                labelActivar.Visible = false;
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
                            respuesta = NUsuario.Eliminar(Codigo);
                            this.MensajeOk("Se elimino el registro : " + Convert.ToString(fila.Cells[4].Value));
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

        private void chkActivar_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkActivar.Value == false)
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("deseas desactivar el registro", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int Codigo;
                        string respuesta = "";
                        foreach (DataGridViewRow fila in DgvListado.Rows)
                        {
                            if (Convert.ToBoolean(fila.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(fila.Cells[1].Value);
                                respuesta = NUsuario.Desactivar(Codigo);
                                this.MensajeOk("Se desactivo el registro : " + Convert.ToString(fila.Cells[2].Value));
                            }
                        }
                    }
                    this.Listar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);

                }
            }

            else
            {

                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("deseas activar el registro", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int Codigo;
                        string respuesta = "";
                        foreach (DataGridViewRow fila in DgvListado.Rows)
                        {
                            if (Convert.ToBoolean(fila.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(fila.Cells[1].Value);
                                respuesta = NUsuario.Activar(Codigo);
                                this.MensajeOk("Se activo el registro : " + Convert.ToString(fila.Cells[2].Value));
                            }
                        }
                    }
                    this.Listar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);

                }
            }



        }

        private void botonResetear_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
