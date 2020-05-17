using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FormularioPrincipal : Form
    {
        private int childFormNumber = 0;
        public int idUsuario;
        public int idRol;
        public string nombre;
        public string rol;
        public bool estado;


        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento especial para llamar formularios dentro del toolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoriasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FormularioCategoria frmcategoria = new FormularioCategoria();
            frmcategoria.MdiParent = this;
            frmcategoria.Show();


        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioArticulo frmarticulo = new FormularioArticulo();
            frmarticulo.MdiParent = this;
            frmarticulo.Show();

        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioRoles frm = new FormularioRoles();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioUsuario frm = new FormularioUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
         
    
            tipoUsuario.Text = "Desarrollado por JcontrerasV, USUARIO: " + this.nombre;
            MessageBox.Show("Bienvenido:" + this.nombre, "Sistema ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            switch(this.rol){
                case "Administrador":
                    menuAlmacen.Enabled = true;
                    menuIngreso.Enabled = true;
                    menuVenta.Enabled = true;
                    menuAcceso.Enabled = true;
                    menuConsultas.Enabled = true;
                    toolCompra.Enabled = true;
                    toolVenta.Enabled = true;

                    break;

                case "Vendedor":
                    menuAlmacen.Enabled = false;
                    menuIngreso.Enabled = false;
                    menuVenta.Enabled = true;
                    menuAcceso.Enabled = false;
                    menuConsultas.Enabled = true;
                    toolCompra.Enabled = false;
                    toolVenta.Enabled = true;

                    break;

                case "Almacenero":

                    menuAlmacen.Enabled = true;
                    menuIngreso.Enabled = true;
                    menuVenta.Enabled = false;
                    menuAcceso.Enabled = false;
                    menuConsultas.Enabled = true;
                    toolCompra.Enabled = true;
                    toolVenta.Enabled = false;

                    break;

                default:
                    menuAlmacen.Enabled = true;
                    menuIngreso.Enabled = true;
                    menuVenta.Enabled = false;
                    menuAcceso.Enabled = false;
                    menuConsultas.Enabled = true;
                    toolCompra.Enabled = true;
                    toolVenta.Enabled = false;
                    break;
            }
            
        }

        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            DialogResult opcion;

            opcion = MessageBox.Show("Quiere salir", "Sistema", MessageBoxButtons.OKCancel);

            if (opcion==DialogResult.OK)
            {
                Application.Exit();
                
                

            }

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioProveedores frmproveedor = new FormularioProveedores();
            frmproveedor.MdiParent = this;
            frmproveedor.Show();

        }

        private void FormularioPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCliente frmcliente = new FormularioCliente();
            frmcliente.MdiParent = this;
            frmcliente.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioIngreso frmIngreso = new FormularioIngreso();
            frmIngreso.MdiParent = this;
            frmIngreso.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FormularioVentas frmVenta = new FormularioVentas();
            frmVenta.MdiParent = this;
            frmVenta.Show();

        }
    }
}
