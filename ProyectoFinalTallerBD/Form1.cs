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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        conexion cn = new conexion();
        public static string usuario = "";

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            //prueba para mostrar otros formularios
            pantallaAdministrador pantAdmin = new pantallaAdministrador();
            pantallaEmpleado pantEmpl = new pantallaEmpleado();
            /*   if (txtUsuario.Texts=="Admin" & txtPassword.Texts=="123")
                {
                    pantAdmin.Show();
                    this.Hide();
                }
                else
                {
                    if (txtUsuario.Texts == "user" & txtPassword.Texts == "123")
                    {
                        pantEmpl.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña o usuario incorrecto");
                    }
                }   */
            //Login con stored procedure - Jafet
            int respuesta = Login();
            switch (respuesta)
            {
                case 3: MessageBox.Show("El usuario no se encuentra activo actualmente.","USUARIO INACTIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Texts = "";
                    txtPassword.Texts = "";
                    txtUsuario.Focus();
                    break;
                case 2: pantAdmin.ShowDialog();
                    this.Hide();
                    break;
                case 1: pantEmpl.ShowDialog();
                    this.Hide();
                    break;
                case 0: MessageBox.Show("Contraseña o usuario incorrecto", "ACCESSO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Texts = "";
                    txtPassword.Texts = "";
                    txtUsuario.Focus();
                    break;
            }
        }

        public int Login()      //Stored Procedure para ingresar al sistema según sea administrador o usuario - Jafet
        {
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("sp_login", cn.conectarbd);
                cn.cmd.CommandType = CommandType.StoredProcedure;
                cn.cmd.Parameters.AddWithValue("@par_user", txtUsuario.Texts);
                cn.cmd.Parameters.AddWithValue("@par_pass", txtPassword.Texts);

                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.Read())
                {
                    usuario = txtUsuario.Texts;
                    return cn.dr.GetInt32(0);
                }
                else
                    return 0;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return 0;
            }
            finally
            {
                cn.conectarbd.Close();
            }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBarraInicio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
