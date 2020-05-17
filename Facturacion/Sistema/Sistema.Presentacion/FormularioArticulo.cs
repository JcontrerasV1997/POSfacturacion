using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using BarcodeLib;
using Sistema.Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema.Presentacion
{
    public partial class FormularioArticulo : Form
    {
        private string RutaOrigen;
        private string RutaDestino;
        ////Directorio es 
        private string Directorio = "C:\\Users\\USUARIO\\Desktop\\Programas y utilidades para desarrollo\\Proyectos realizados\\ImagenesArticulos\\";
        private string nombreAnterior;

        public FormularioArticulo()
        {
            InitializeComponent();
        }
        private void FormularioArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCategoria();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NArticulo.Listar();
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
                  DgvListado.DataSource=NArticulo.Buscar(txtBuscar.text.Trim());
                  this.Formato();
                  labelTotal.Text = "TOTAL DE REGISTROS : \t" + Convert.ToString(DgvListado.Rows.Count);

                }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + e.StackTrace);
            }

        }
        private void CargarCategoria()
        {
            try
            {

                comboCategoria.DataSource= NCategoria.Seleccionar();   ////el datasour
                comboCategoria.ValueMember = "id_categoria"; 
                comboCategoria.DisplayMember = "nombre";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+e.StackTrace);
                
            }
        }
        private void Formato()
        {

            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[1].Width = 100;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[3].HeaderText = "Categoria";
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "Codigo";
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[6].Width = 150;
            DgvListado.Columns[6].HeaderText = "Precio Venta";
            DgvListado.Columns[7].Width = 100;
            DgvListado.Columns[8].Width = 200;
            DgvListado.Columns[8].HeaderText = "Descripcion";
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 300;

        }
        private void Limpiar()
        {
            txtBuscar.text = "";
            txtNombre.Text = "";
            txtID.Text = "";
            labelBueno.Visible = false;
            chulo.Visible = false;
            txtDescripcion.Text = "";
            botonInsertar.Visible = true;
            botonActualizar.Visible = false;
            textoCodigo.Text = ""; 
            textoPrecioVenta.Text="";
            textoStock.Text="";
            textoImagen.Clear();
            pictureImagen.Image = null;
            panelCodigo.BackgroundImage = null;
            this.RutaDestino = "";
            this.RutaOrigen = "";
            errorIcono.Clear();
            DgvListado.Columns[0].Visible = false;
            chkActivar.Visible = false;
            botoEliminar.Visible = false;
            labelActivar.Visible = false;
            chkSeleccion.Checked = false;
            botonGuardarCodigo.Visible = false;
            labelCodigoGuardado.Visible = false;
            labelDireccionCodigo.Visible = false;
            chulo.Visible = false;
            chuloGuardado.Visible = false;
            codebarra.Visible = false;
            panelCodigo.Visible = false;
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
        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                botonActualizar.Visible = true;
                botonInsertar.Visible = false;
                txtID.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                comboCategoria.SelectedValue= Convert.ToString(DgvListado.CurrentRow.Cells["id_categoria"].Value);
                textoCodigo.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                this.nombreAnterior = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                textoPrecioVenta.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Precio_venta"].Value);
                textoStock.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Stock"].Value);
                txtDescripcion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                string Imagen;

                Imagen = Convert.ToString(DgvListado.CurrentRow.Cells["Imagen"].Value);
                if (Imagen != string.Empty)
                {
                    pictureImagen.Image = Image.FromFile(this.Directorio + Imagen);
                    textoImagen.Text = Imagen;
                }
                else
                {
                         pictureImagen.Image = null;
                         textoImagen.Text = "";

                }
                TabGeneral.SelectedIndex = 1;
                    }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre" + "| Error:" + ex);
            }
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

                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string respuesta = "";
                    string imagen="";
                    foreach (DataGridViewRow fila in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(fila.Cells[1].Value);
                            imagen = Convert.ToString(fila.Cells[9].Value);
                            respuesta = NArticulo.Eliminar(Codigo);

                            if (respuesta.Equals("ok")){

                            this.MensajeOk("Se elimino el registro : " + Convert.ToString(fila.Cells[5].Value));
                            File.Delete(this.Directorio + imagen);                        

                            }
                            else
                            {
                                this.MensajeError(respuesta);
                            }  
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
                                respuesta = NArticulo.Desactivar(Codigo);
                                this.MensajeOk("Se desactivo el registro : " + Convert.ToString(fila.Cells[5].Value));
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
                                respuesta = NArticulo.Activar(Codigo);
                                this.MensajeOk("Se activo el registro : " + Convert.ToString(fila.Cells[5].Value));
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
        private void botonGenerar_Click_1(object sender, EventArgs e)
        {
            if (textoCodigo.Text == string.Empty)
            {
                MessageBox.Show("Usted debe escribir el codigo de barras para poder generarlo, luego se habilitara el boton para guardarlo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Barcode codigo = new Barcode();
                codigo.IncludeLabel = true; ////incluye el texto del codigo de barras
                panelCodigo.BackgroundImage = codigo.Encode(TYPE.CODE128, textoCodigo.Text, Color.Black, Color.White, 400, 100);
                botonGuardarCodigo.Visible = true;
                botonGenerar.Focus();
                chulo.Visible = true;
                labelBueno.Visible = true;
                panelCodigo.Visible = true;
            }
        }
        private void botonGuardarCodigo_Click_1(object sender, EventArgs e)
        {
            Image imagenFinal = (Image)panelCodigo.BackgroundImage.Clone();
            SaveFileDialog dialogoGuardar = new SaveFileDialog();
            dialogoGuardar.AddExtension = true;
            dialogoGuardar.Filter = "Exporte Su Codigo de barras (*.png)|*.png";
            dialogoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(dialogoGuardar.FileName))
            {
                imagenFinal.Save(dialogoGuardar.FileName, ImageFormat.Png);
            }
            imagenFinal.Dispose();

        

            labelCodigoGuardado.Visible = true;
            chuloGuardado.Visible = true;
            labelDireccionCodigo.Visible = true;
            codebarra.Visible = true;

            labelDireccionCodigo.Text = Convert.ToString(dialogoGuardar.FileName+"\n");

        }
        private void botonInsertar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                if (comboCategoria.Text == string.Empty || txtNombre.Text == string.Empty
                    || textoPrecioVenta.Text == string.Empty || textoStock.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(comboCategoria, "Seleccione una categoria");
                    errorIcono.SetError(txtNombre, "ingrese nombre");
                    errorIcono.SetError(textoPrecioVenta, "ingrese un precio");
                    errorIcono.SetError(textoStock, "Ingrese stock");
                }
                else
                {
                    respuesta = NArticulo.Insertar(Convert.ToInt32(comboCategoria.SelectedValue), textoCodigo.Text.Trim(),
                        txtNombre.Text.Trim(), Convert.ToInt32(textoPrecioVenta.Text), Convert.ToInt32(textoStock.Text),
                        txtDescripcion.Text.Trim(), textoImagen.Text.Trim());

                    if (respuesta.Equals("Ok"))
                    {

                        this.MensajeOk("Se Registro correctamente");

                        if (textoImagen.Text != string.Empty)
                        {
                            this.RutaDestino = this.Directorio + textoImagen.Text;
                            File.Copy(this.RutaOrigen, this.RutaDestino);
                        }

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
        private void botonActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txtID.Text == string.Empty || comboCategoria.Text == string.Empty || txtNombre.Text == string.Empty
                    || textoPrecioVenta.Text == string.Empty || textoStock.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(comboCategoria, "Seleccione una categoria");
                    errorIcono.SetError(txtNombre, "ingrese nombre");
                    errorIcono.SetError(textoPrecioVenta, "ingrese un precio");
                    errorIcono.SetError(textoStock, "Ingrese stock");
                }
                else
                {
                    respuesta = NArticulo.Actualizar(Convert.ToInt32(txtID.Text),
                   Convert.ToInt32(comboCategoria.SelectedValue),
                   textoCodigo.Text.Trim(), this.nombreAnterior, txtNombre.Text.Trim(),
                    Convert.ToDecimal(textoPrecioVenta.Text), Convert.ToInt32(textoStock.Text),
                    txtDescripcion.Text.Trim(), textoImagen.Text.Trim());

                    if (respuesta.Equals("Ok"))
                    {

                        this.MensajeOk("se actualizo");
                        if (textoImagen.Text != string.Empty && this.RutaOrigen != string.Empty)
                        {
                            this.RutaDestino = this.Directorio + textoImagen.Text;
                            File.Copy(this.RutaOrigen, this.RutaDestino);
                        }

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
        private void botonCargarImagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif , *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                pictureImagen.Image = Image.FromFile(archivo.FileName);
                textoImagen.Text = archivo.FileName.Substring(archivo.FileName.LastIndexOf("\\") + 1);
                this.RutaOrigen = archivo.FileName;
            }
        }
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void botonReporte_Click(object sender, EventArgs e)
        {
            Reportes.FormularioReporteArticulos Reporte = new Reportes.FormularioReporteArticulos();
            Reporte.ShowDialog();
        }
    }
}
