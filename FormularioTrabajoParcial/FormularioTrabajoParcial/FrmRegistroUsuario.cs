using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FormularioTrabajoParcial
{
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();

            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(txtUsuario.ClientRectangle);
            //txtUsuario.Region = new Region(path);

        }


        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se ha registrado con éxito");
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //instancia del nuevo formulario
            FrmIniciarSesionUsuario formIniciarSesionUser = new FrmIniciarSesionUsuario();
            formIniciarSesionUser.Show();

            //AbrirFormInPanel(new FrmRegistroUsuario());
        }
    }
}
