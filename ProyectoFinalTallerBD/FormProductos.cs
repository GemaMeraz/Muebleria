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
using System.IO;
using System.Drawing.Imaging;


namespace ProyectoFinalTallerBD
{
    public partial class FormProductos : Form
    {
        conexion cn = new conexion();
        string categoria;
        string idProducto;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            Cargardgv();
        }
        private void Cargardgv()
        {
             try
            {
                cn.da = new SqlDataAdapter("Select idProducto,producto,descripcion,material,color,largo,ancho,alto,diasGarantia,precioCompra,precioVenta,idCategoria,activo from Productos", cn.conectarbd);
                //cn.da = new SqlDataAdapter("Select * from Productos Where activo = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dataGridView1.DataSource = cn.dt;
                dataGridView1.Columns["idProducto"].DisplayIndex = 0;
                dataGridView1.Columns["producto"].DisplayIndex = 1;
                dataGridView1.Columns["descripcion"].DisplayIndex = 2;
                dataGridView1.Columns["material"].DisplayIndex = 3;
                dataGridView1.Columns["color"].DisplayIndex = 4;
                dataGridView1.Columns["largo"].DisplayIndex = 5;
                dataGridView1.Columns["ancho"].DisplayIndex = 6;
                dataGridView1.Columns["alto"].DisplayIndex = 7;
                dataGridView1.Columns["diasGarantia"].DisplayIndex = 8;
                dataGridView1.Columns["precioCompra"].DisplayIndex = 9;
                dataGridView1.Columns["precioVenta"].DisplayIndex = 10;
                dataGridView1.Columns["idCategoria"].DisplayIndex = 11;
                //dataGridView1.Columns["imagen"].DisplayIndex = 12;
                dataGridView1.Columns["activo"].DisplayIndex = 12;
                dataGridView1.Columns["Editar"].DisplayIndex = 13;
                dataGridView1.Columns["Ver"].DisplayIndex = 14;
                dataGridView1.Columns["Eliminar"].DisplayIndex = 15;


            }
            catch (Exception)
            {

                throw;
            }
}

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog()==DialogResult.OK)
            {
                picProducto.ImageLocation = abrirImagen.FileName;
                picProducto.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            
        }

        private void btnRegistrarProd_Click(object sender, EventArgs e)
        {
            idProducto = txtClave.Text;
            string Producto = txtProducto.Text;
            string descripcion = txtDescripcion.Text;
            string material = txtMaterial.Text;
            string color = txtColor.Text;
            string largo = txtLargo.Text;
            string ancho = txtAncho.Text;
            string alto = txtAlto.Text;
            int diasGarantia = int.Parse(txtGarantia.Text);
            double precioCompra = double.Parse(txtPrecCompra.Text);
            double precioVenta = double.Parse(txtPrecVenta.Text);

            MemoryStream ms = new MemoryStream();
            picProducto.Image.Save(ms, ImageFormat.Jpeg);
            string activo = "S";
            
            if (ComprobarProducto() > 0)
            {
                txtClave.Text = "";
                txtClave.Focus();

                MessageBox.Show("El ID ya se encuentra registrado, intente con un nuevo id", "Id duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (idProducto != null && idProducto != "")
            {
                try
                {
                    cn.conectarbd.Open();
                    cn.cmd = new SqlCommand("Insert into Productos(idProducto,producto,descripcion,material,color,largo,ancho,alto,diasGarantia,precioCompra,precioVenta,idCategoria,activo) values('" + idProducto + "','" + Producto + "','" + descripcion + "','" + material + "', '" + color + "','" + largo + "','"+ancho+
                        "','"+largo+"',"+diasGarantia+","+precioCompra+","+precioVenta+",'"+categoria+"','"+activo+"')", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();

                    Cargardgv();
                    MessageBox.Show("Producto" +
                        " ingresada al sistema");
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
        private int ComprobarProducto()
        {
            int intCont = 0;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("SELECT * FROM Entradas WHERE idProducto = '" + idProducto + "'", cn.conectarbd);
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
        private void cboIdCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboIdCategoria.Text == "COM-155")
            {
                categoria = cboIdCategoria.Text;
            }
            if (cboIdCategoria.Text == "INF-521")
            {
                categoria = cboIdCategoria.Text;
            }
            if (cboIdCategoria.Text == "JAR-789")
            {
                categoria = cboIdCategoria.Text;
            }
            if (cboIdCategoria.Text == "OFN-451")
            {
                categoria = cboIdCategoria.Text;
            }
            if (cboIdCategoria.Text == "REM-872")
            {
                categoria = cboIdCategoria.Text;
            }
            if (cboIdCategoria.Text == "SAL-021")
            {
                categoria = cboIdCategoria.Text;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarID = txtBuscarId.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["idProducto"].Value.ToString() == buscarID)
                {
                    MessageBox.Show("Producto encontrado:" + row.Cells["idProducto"].Value.ToString() + "\n" + row.Cells["producto"].Value.ToString());
                    return;
                }

            }
            MessageBox.Show("Producto Inexistente");
        }
    }
}
