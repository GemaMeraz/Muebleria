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
    public partial class FormEntregas : Form
    {
        conexion cn = new conexion();
        static string idEntrada;
        public FormEntregas()
        {
            InitializeComponent();
        }

        private void FormEntregas_Load(object sender, EventArgs e)
        {
            MostrarEntregas();
        }

        private void MostrarEntregas()
        {
            try
            {
                //dgvEntradas.Rows.Clear();
                cn.da = new SqlDataAdapter("Select * from Entradas", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dgvEntradas.DataSource = cn.dt;
                dgvEntradas.Columns["idEntrada"].DisplayIndex = 0;
                dgvEntradas.Columns["idProveedor"].DisplayIndex = 1;
                dgvEntradas.Columns["idProducto"].DisplayIndex = 2;
                dgvEntradas.Columns["fechaEntrada"].DisplayIndex = 3;
                dgvEntradas.Columns["cantidadEntrada"].DisplayIndex = 4;
                dgvEntradas.Columns["totalPago"].DisplayIndex = 5;
                dgvEntradas.Columns["Editar"].DisplayIndex = 6;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                throw;
            }
        }

        private void iconButtonId_Click(object sender, EventArgs e)
        {

        }

        private void dgvEntradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntradas.Columns[e.ColumnIndex].Name == "Editar")
            {
                dgvEntradas.Size = new Size(440, 259);
                grpEditarEntrada.Visible = true;

                txtEditIdEntrada.Text = dgvEntradas.CurrentRow.Cells[0].Value.ToString();
                txtEditIdProveedor.Text = dgvEntradas.CurrentRow.Cells[1].Value.ToString();
                txtEditIdProducto.Text = dgvEntradas.CurrentRow.Cells[2].Value.ToString();
                dtpEditFechaEnt.Value = DateTime.Parse(dgvEntradas.CurrentRow.Cells[3].Value.ToString());
                txtEditCantEntrada.Text = dgvEntradas.CurrentRow.Cells[4].Value.ToString();
                txtEditTotalPago.Text = dgvEntradas.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvEntradas.Size = new Size(608, 259);
            grpEditarEntrada.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int modIdProveedor = int.Parse(txtEditIdProveedor.Text);
            string modIdProducto = txtEditIdProducto.Text;
            string modFechaEntrada = dtpEditFechaEnt.Value.ToString("yyyy-MM-dd");
            int modCantEntrada = int.Parse(txtEditCantEntrada.Text);
            double modTotalPago = double.Parse(txtEditTotalPago.Text);
            string modIdEntrada = txtEditIdEntrada.Text;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("Update Entrada SET idProveedor=" + modIdProveedor + ", idProducto='" + modIdProducto + "',fechaEntrada='" + modFechaEntrada
                   + "',cantidadEntrada=" + modCantEntrada + ",totalPago=" + modTotalPago + " where idEntrada='" + modIdEntrada + "'", cn.conectarbd);
                cn.cmd.ExecuteNonQuery();

                dgvEntradas.Size = new Size(608, 259);
                grpEditarEntrada.Visible = false;
                MessageBox.Show("Entrada ingresada al sistema");

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
            string buscarID = txtBuscarIdEntrega.Text;
            foreach (DataGridViewRow row in dgvEntradas.Rows)
            {
                if (row.Cells[0].Value.ToString() == buscarID)
                {
                    MessageBox.Show("Entrega encontrado: \nId Entrada: " + row.Cells[0].Value.ToString() + "\nId Proveedor: " + row.Cells[1].Value.ToString() + "\nId Producto: " + row.Cells[2].Value.ToString() + "\nCant. Productos: " + row.Cells[4].Value.ToString());
                    return;
                }
            }
            MessageBox.Show("No existe la entrada ingresada.", "ENTRADA NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRegistrarEntrega_Click(object sender, EventArgs e)
        {
            idEntrada = txtEntrada.Text;
            int idProveedor = int.Parse(txtProveedor.Text);
            string idProducto = txtProducto.Text;
            string fechaEntrada = dtpFechaEntrada.Value.ToString("yyyy-MM-dd");
            int cantEntrada = int.Parse(txtCantEntrada.Text);
            double totalPago = double.Parse(txtTotalPago.Text);
            if (ComprobarEntrada() > 0)
            {
                txtEntrada.Text = "";
                txtEntrada.Focus();

                MessageBox.Show("El ID ya se encuentra registrado, intente con un nuevo id", "Id duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (idEntrada != null && idEntrada != "")
            {
                try
                {
                    cn.conectarbd.Open();
                    cn.cmd = new SqlCommand("Insert into Entradas(idEntrada,idProveedor,idProducto,fechaEntrada,cantidadEntrada,totalPago) values('" + idEntrada + "'," + idProveedor + ",'" + idProducto + "','" + fechaEntrada + "', " + cantEntrada + "," + totalPago + ")", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();

                    MostrarEntregas();
                    MessageBox.Show("Entrada ingresada al sistema");
                    tabControl1.SelectedIndex = 0;
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
            else
            {
                MessageBox.Show("No deje el id del empleado vacío.");
            }
        }
        private int ComprobarEntrada()
        {
            int intCont = 0;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("SELECT * FROM Entradas WHERE idEntrada = '" + idEntrada + "'", cn.conectarbd);
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
            finally
            {
                cn.conectarbd.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dtpFechaEntrada.Value = DateTime.Now;
            }
        }
    }
}
