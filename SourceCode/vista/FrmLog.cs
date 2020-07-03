using System;
using System.Windows.Forms;
using SourceCode.controlador;
using SourceCode.modelo;

namespace SourceCode
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
        }


        private void FrmLog_Load(object sender, EventArgs e)
        {
            upadateControls();
        }

        private void upadateControls()
        {
            
            cmbLogin.DataSource = null;
            cmbLogin.ValueMember = "contrasena";
            cmbLogin.DisplayMember = "nombre";
            cmbLogin.DataSource = UsuarioDAO.GetUsuario();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (cmbLogin.SelectedValue.Equals(txtLogin.Text))
            {
                Usuario u = (Usuario) cmbLogin.SelectedItem;
                FrmPrincipal ventana = new FrmPrincipal(u);
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡Contraseña incorrecta!", "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void FrmLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}