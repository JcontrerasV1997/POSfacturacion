using System;
using System.Data;
using System.Windows.Forms;
using Sistema.Negocio;


namespace Sistema.Presentacion
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {

        
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NUsuario.Login(textoUsuario.Text.Trim(), textoConstraseña.Text.Trim());
                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El email o la clave es incorrecta.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToBoolean(Tabla.Rows[0][4]) == false)
                    {
                        MessageBox.Show("Este usuario no esta activo.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FormularioPrincipal Frm = new FormularioPrincipal();
                        VariablesSeleccion.idUsuario = Frm.idUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        Frm.idUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        Frm.idRol = Convert.ToInt32(Tabla.Rows[0][1]);
                        Frm.rol = Convert.ToString(Tabla.Rows[0][2]);
                        Frm.nombre = Convert.ToString(Tabla.Rows[0][3]);
                        Frm.estado = Convert.ToBoolean(Tabla.Rows[0][4]);
                        Frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textoConstraseña_OnValueChanged(object sender, EventArgs e)
        {
            textoConstraseña.isPassword = true;
        }

       
    }
}
