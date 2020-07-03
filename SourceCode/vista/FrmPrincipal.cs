using System;
using System.Windows.Forms;
using SourceCode.controlador;
using SourceCode.modelo;

namespace SourceCode
{
    public partial class FrmPrincipal : Form
    {
        private Usuario usuario;
        public FrmPrincipal(Usuario Puser)
        {
            InitializeComponent();
            usuario = Puser;
        }

        private void upadateControls()
        {
            cmbAsistencia.DataSource = null;
            cmbAsistencia.ValueMember = "carnet";
            cmbAsistencia.DisplayMember = "nombre";
            cmbAsistencia.DataSource = UsuarioDAO.GetUsuario();
        }
        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LblBienveindo.Text = "Bienvenido " + usuario.nombre;
            
            if (usuario.idDepartamento == 1)
            {
                LblBienveindo.Text = "Bienvenido " + usuario.nombre + " (Empleado)";
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null; 
                tabControl1.TabPages[1].Parent = null; 
            }
            else if (usuario.idDepartamento == 2)
            {
                LblBienveindo.Text = "Bienvenido " + usuario.nombre + " (Vigilancia)";
                tabControl1.TabPages[0].Parent = null;
                tabControl1.TabPages[1].Parent = null; 
                tabControl1.TabPages[1].Parent = null; 
                
            }
            else
            {
                LblBienveindo.Text = "Bienvenido " + usuario.nombre + " (Administrativo)";
                tabControl1.TabPages[0].Parent = null;
                tabControl1.TabPages[0].Parent = null; 
            }
            
            upadateControls();
        }


        private void btnSinFiebre_Click(object sender, EventArgs e)
        {
            var us = (Usuario) cmbAsistencia.SelectedItem;
            bool entrando = entrada.Checked;
            
            RegistroDAO.NuevoRegistro(us.carnet, entrando, 
                dtpEntrada.Value, numericUpDown1.Value);
        }
    }
}