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
    public partial class Inventario : Form
    {
        conexion cn = new conexion();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            Cargardgv();        }
        private void Cargardgv()
        {
            try
            {
                cn.da = new SqlDataAdapter("Select * from Inventario", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dataGridView1.DataSource = cn.dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnRegistrarInventario_Click(object sender, EventArgs e)
        {
            string idProducto = txtIdProdInventario.Text;
            int stock = int.Parse(txtStock.Text);
            string modificacionInventario = dtpFechaModificacion.Value.ToString("yyyy-MM-dd");
            char activo = 'S';
           
                try
                {
                    cn.conectarbd.Open();
                    cn.cmd = new SqlCommand("Insert into Inventario(idProducto,stock,fechaModificacion,activo) values('" + idProducto + "','" + stock+ "','" + modificacionInventario + "','" + activo + "')", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();

                    MessageBox.Show("Inventario agregado");
                    Cargardgv();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex);
                }
                finally
                {
                    cn.conectarbd.Close();
                }
            }
           
    }
}
