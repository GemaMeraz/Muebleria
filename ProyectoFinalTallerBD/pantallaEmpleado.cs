using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTallerBD
{
    public partial class pantallaEmpleado : Form
    {
        Form1 principal = new Form1();
        public pantallaEmpleado()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                principal.Show();

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
