using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProyectoFinalTallerBD
{
    public partial class FormProveedores : Form
    {
        conexion cn = new conexion();
        int idProveedor;
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

            
            try
            {
                //cn.da = new SqlDataAdapter("Select * from Proveedores", cn.conectarbd);
                cn.da = new SqlDataAdapter("Select * from Proveedores Where activo = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dataGridView1.DataSource = cn.dt;
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            idProveedor = int.Parse(txtIdProveedor.Text);
            string razonSocial = txtRazonSocial.Text;
            string RFC = txtRFC.Text;
            string fechaAlta = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            char activo = 'S';
            int var=ComprobarProveedor();
            if (idProveedor!=var)
            {
                try
                {
                    cn.cmd = new SqlCommand("Insert into Proveedores(idProveedor,razonSocial,RFC,fechaAlta,activo) values(" + idProveedor + ",'" + razonSocial + "','" + RFC + "','" + fechaAlta + "', '" + activo + "')", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Proveedor ingresado al sistema");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                txtIdProveedor.Text = "";
                txtIdProveedor.Focus();
                
                MessageBox.Show("El ID ya se encuentra registrado, intente con un nuevo id","Id duplicado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
           
        }

        private int ComprobarProveedor()
        {
            int intCont = 0;
            try
            {
                cn.cmd = new SqlCommand("SELECT * FROM Proveedores WHERE idProveedor = '" + idProveedor + "'", cn.conectarbd);
                cn.dr = cn.cmd.ExecuteReader();
                while (cn.dr.Read())
                {
                    intCont++;
                }
                cn.dr.Close();
                return intCont;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
                throw;
            }
        }

       
    }
}
