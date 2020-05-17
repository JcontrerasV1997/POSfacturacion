using Sistema.Negocio;
using System;
using System.Windows.Forms;
namespace Sistema.Presentacion
{
    public partial class FormularioCategoria : Form
    {
        private string nombreAnterior;
        public FormularioCategoria()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NCategoria.Listar();
                this.Formato();
                this.Limpiar();
                labelTotal.Text = "TOTAL DE REGISTROS :" + Convert.ToString(DgvListado.Rows.Count);
        
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
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[3].HeaderText = "Descripcion";
            DgvListado.Columns[4].Width = 450;
        }
        private void Limpiar()
        {
            txtBuscar.text = "";
            txtNombre.Text = "";
           txtID.Text = "";
            txtDescripcion.Text = "";
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
        private void Buscar()
        {
            try
            {
                 DgvListado.DataSource = NCategoria.Buscar(txtBuscar.text);
                this.Formato();
                labelTotal.Text = "TOTAL DE REGISTROS : \t" + Convert.ToString(DgvListado.Rows.Count);

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + e.StackTrace);
            }

        }
        private void FormularioCategoria_Load(object sender, EventArgs e)
        {  

            this.Listar();

        }
        private void botonBuscar_Click(object sender, EventArgs e)
        {



            this.Buscar();
        }
      
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }
        private void DgvListado_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                this.Limpiar();
                botonActualizar.Visible = true;
                botonInsertar.Visible = false;
                txtID.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                this.nombreAnterior = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                TabGeneral.SelectedIndex = 1;
            }

            catch(Exception )
            {
                MessageBox.Show("Seleccione desde la celda nombre");
            }
        }
        private void botonActualizar_Click_1(object sender, EventArgs e)
        {

            try
            {
                string respuesta = "";
                if (txtNombre.Text == string.Empty || txtID.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese nombre a la categoria");
                }
                else
                {
                    respuesta = NCategoria.Actualizar(Convert.ToInt32(txtID.Text),this.nombreAnterior, txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    if (respuesta.Equals("Ok"))
                    {

                        this.MensajeOk("Se actualizo de forma correcta");
                        this.Limpiar();
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
        private void botonResetear_Click(object sender, EventArgs e)
        {
            this.Listar();
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
        /// <summary>
        /// Metodo referente a evento cellcontetclick, este sirve para cuando se haga click en una celda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">este argumento compara obteniendo un valor que indica el indice de la columna con el datatable
        ///   </param>
        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e) ///este objeto el e, es de tipo evento
        {
            if (e.ColumnIndex==DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell) 
                    DgvListado.Rows[e.RowIndex].Cells["seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);

                bool valor= Convert.ToBoolean(DgvListado.SelectedCells[4].Value);

                if (valor==true)
                {
                    chkActivar.Value = true;

                }
                else
                {

                    chkActivar.Value = false;
                }
            }
            //foreach (DataGridViewRow columna in DgvListado.Rows)
            //          {
            //              bool valor = Convert.ToBoolean(columna.Cells[4].Value);

            //          }
        }
        private void botoEliminar_Click(object sender, EventArgs e)
        {
           
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("deseas eliminar el registro", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if(opcion==DialogResult.OK)
                {
                    int Codigo;
                    string respuesta = "";
                    foreach (DataGridViewRow fila in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(fila.Cells[1].Value);
                            respuesta = NCategoria.Eliminar(Codigo);
                            this.MensajeOk("Se elimino el registro : " + Convert.ToString(fila.Cells[2].Value));
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

            if (chkActivar.Value==false)
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
                                respuesta = NCategoria.Desactivar(Codigo);
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
                                respuesta = NCategoria.Activar(Codigo);
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

        public void Alert(string msg, Alerta.enmType type)
        {
            Alerta frm = new Alerta();
            frm.showAlert(msg, type);
        }

        private void botonInsertar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");

                    errorIcono.SetError(txtNombre, "ingrese nombre");
                }
                else
                {
                    respuesta = NCategoria.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    if (respuesta.Equals("Ok"))
                    {

                        this.MensajeOk("Se Registro correctamente");
                        this.Limpiar();
                        this.Listar();
                        this.Alert("Registro Existoso", Alerta.enmType.Success);

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
    }
}
