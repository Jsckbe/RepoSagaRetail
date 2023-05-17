using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioTrabajoParcial
{
    public partial class FrmIniciarSesionUsuario : Form
    {
        public FrmIniciarSesionUsuario()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Iniciando Sesión");
            FrmIniciarSesionUsuario frm = new FrmIniciarSesionUsuario();
            frm.Close();

            ////instancia del nuevo formulario
            //fmrUsuario formUser = new fmrUsuario();
            //formUser.Show();
        }
    }
}
