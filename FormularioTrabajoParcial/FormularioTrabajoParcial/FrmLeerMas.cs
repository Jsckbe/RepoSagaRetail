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
    public partial class FrmLeerMas : Form
    {
        public FrmLeerMas()
        {
            InitializeComponent();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            //instancia del nuevo formulario
            //fmrUsuario formUsuario = new fmrUsuario();
            //formUsuario.Show();
            //Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
