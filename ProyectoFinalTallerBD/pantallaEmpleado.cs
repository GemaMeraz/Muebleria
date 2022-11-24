using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoFinalTallerBD
{
    public partial class pantallaEmpleado : Form
    {
        Form1 principal = new Form1();
        conexion cn = new conexion();
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

        private void pantallaEmpleado_Load(object sender, EventArgs e)
        {
            //Muestra el nombre y apellido del usuario en la ventana principal de control - Jafet
            try
            {
                cn.cmd = new SqlCommand("sp_mostrarUsuario", cn.conectarbd);
                cn.cmd.CommandType = CommandType.StoredProcedure;
                cn.cmd.Parameters.AddWithValue("@par_user", Form1.usuario);
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.Read())
                {
                    lblUsuario.Text = "¡Bienvenido, " + cn.dr.GetString(0) + "!";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                throw;
            }
            finally
            {
                cn.conectarbd.Close();
            }
        }
    }
}
