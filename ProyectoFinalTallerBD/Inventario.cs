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
            Cargardgv();
            CargarProductosComboBox();
        }
        private void Cargardgv()
        {
            try
            {
                cn.da = new SqlDataAdapter("Select * from Inventario Where activo = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dataGridView1.DataSource = cn.dt;
                dataGridView1.Columns["idProducto"].DisplayIndex = 0;
                dataGridView1.Columns["stock"].DisplayIndex = 1;
                dataGridView1.Columns["fechaModificacion"].DisplayIndex = 2;
                dataGridView1.Columns["activo"].DisplayIndex = 3;
                dataGridView1.Columns["Editar"].DisplayIndex = 4;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnRegistrarInventario_Click(object sender, EventArgs e)
        {
            string idProducto = cboIdProducto.SelectedValue.ToString();
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
                    tabInventario.SelectedIndex = 0;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(623, 357);
            grpEditarInv.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                dataGridView1.Size = new Size(321, 357);
                grpEditarInv.Visible = true;
                txtModIdProducto.Text = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString();
                txtModStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                dtpModFechaModif.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["fechaModificacion"].Value.ToString());
                dataGridView1.CurrentRow.Cells["Editar"].Style.SelectionBackColor = Color.CadetBlue;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int modStock = int.Parse(txtModStock.Text);
            string modFechaModif = dtpModFechaModif.Value.ToString("yyyy-MM-dd");
            string modIdProducto = txtModIdProducto.Text;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("Update Inventario SET stock=" + modStock + ", fechaModificacion='" + modFechaModif + "' where idProducto = '" + modIdProducto +"'", cn.conectarbd);
                cn.cmd.ExecuteNonQuery();

                dataGridView1.Size = new Size(623, 357);
                grpEditarInv.Visible = false;
                Cargardgv();
                MessageBox.Show("Producto en inventario editado: " + modIdProducto);

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarID = txtBuscarInv.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["idProducto"].Value.ToString() == buscarID)
                {
                    MessageBox.Show("Producto encontrado:\n" + row.Cells["idProducto"].Value.ToString() + "\nStock: " + row.Cells["stock"].Value.ToString());
                    return;
                }

            }
            MessageBox.Show("Producto Inexistente");
        }
        public void CargarProductosComboBox()
        {
            try
            {   //Muestra todos los productos disponibles en el combo box
                cn.da = new SqlDataAdapter("Select idProducto, producto from Productos WHERE activo = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                cboIdProducto.DataSource = cn.dt;
                cboIdProducto.DisplayMember = "producto";
                cboIdProducto.ValueMember = "idProducto";
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
