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
        string categoria="";
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
                cn.da = new SqlDataAdapter("Select idProducto,producto,material,color,largo,ancho,alto,diasGarantia,precioCompra,precioVenta,idCategoria from Productos", cn.conectarbd);
                //cn.da = new SqlDataAdapter("Select * from Productos Where activo = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dataGridView1.DataSource = cn.dt;
                dataGridView1.Columns["idProducto"].DisplayIndex = 0;
                dataGridView1.Columns["producto"].DisplayIndex = 1;
                //dataGridView1.Columns["descripcion"].DisplayIndex = 2;
                dataGridView1.Columns["material"].DisplayIndex = 2;
                dataGridView1.Columns["color"].DisplayIndex = 3;
                dataGridView1.Columns["largo"].DisplayIndex = 4;
                dataGridView1.Columns["ancho"].DisplayIndex = 5;
                dataGridView1.Columns["alto"].DisplayIndex = 6;
                dataGridView1.Columns["diasGarantia"].DisplayIndex = 7;
                dataGridView1.Columns["precioCompra"].DisplayIndex = 8;
                dataGridView1.Columns["precioVenta"].DisplayIndex = 9;
                dataGridView1.Columns["idCategoria"].DisplayIndex = 10;
                //dataGridView1.Columns["imagen"].DisplayIndex = 12;
                //dataGridView1.Columns["activo"].DisplayIndex = 12;
                dataGridView1.Columns["Editar"].DisplayIndex = 11;
                dataGridView1.Columns["Ver"].DisplayIndex = 12;
                dataGridView1.Columns["Eliminar"].DisplayIndex = 13 ;


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
            byte[] imagen = ms.GetBuffer();

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
                    cn.cmd = new SqlCommand("Insert into Productos(idProducto,producto,descripcion,material,color,largo,ancho,alto,diasGarantia,precioCompra,precioVenta,idCategoria,imagen,activo) values('" + idProducto + "','" + Producto + "','" + descripcion + "','" + material + "', '" + color + "','" + largo + "','"+ancho+
                        "','"+largo+"',"+diasGarantia+","+precioCompra+","+precioVenta+",'"+categoria+"','"+imagen+"','"+activo+"')", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();

                    Cargardgv();
                    MessageBox.Show("Product ingresada al sistema");
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
                MessageBox.Show("No deje el id del producto vacío.");
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
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("SELECT * FROM Productos WHERE producto LIKE '"+buscarID+"%'", cn.conectarbd);
                cn.cmd.ExecuteNonQuery();

                //Cargardgv();
                MessageBox.Show("Empleado ingresado al sistema");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex);
            }
            finally
            {
                cn.conectarbd.Close();
            }

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (row.Cells["producto"].Value.ToString() == buscarID)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Yellow;
            //        MessageBox.Show("Producto encontrado:\nId Producto: " + row.Cells["idProducto"].Value.ToString() + "\nProducto: " + row.Cells["producto"].Value.ToString());
            //        row.DefaultCellStyle.BackColor = Color.White;

            //        return;
            //    }


            //}
            //MessageBox.Show("Producto Inexistente");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                dataGridView1.Size = new Size(399, 287);
                grpEditarProd.Visible = true;
                //int idProvedorCon =Convert.ToInt32(dataGridView1.CurrentRow.Cells["idProveedor"].Value.ToString());
                //txtIdProveedor.Text = idProvedorCon.ToString();
                txtModIdProducto.Text = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString();
                txtModProducto.Text = dataGridView1.CurrentRow.Cells["producto"].Value.ToString();
                txtModDescripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                txtModMaterial.Text = dataGridView1.CurrentRow.Cells["material"].Value.ToString();
                txtModColor.Text = dataGridView1.CurrentRow.Cells["color"].Value.ToString();
                txtModLargo.Text = dataGridView1.CurrentRow.Cells["largo"].Value.ToString();
                txtModAncho.Text = dataGridView1.CurrentRow.Cells["ancho"].Value.ToString();
                txtModAlto.Text = dataGridView1.CurrentRow.Cells["alto"].Value.ToString();
                txtModDiasG.Text = dataGridView1.CurrentRow.Cells["diasGarantia"].Value.ToString();
                txtModPrecioC.Text = dataGridView1.CurrentRow.Cells["precioCompra"].Value.ToString();
                txtModPrecioV.Text = dataGridView1.CurrentRow.Cells["precioVenta"].Value.ToString();
                cboModIdCategoria.Text = dataGridView1.CurrentRow.Cells["idCategoria"].Value.ToString();
                dataGridView1.CurrentRow.Cells["Editar"].Style.SelectionBackColor = Color.CadetBlue;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string eliminarUsuario = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString();
                string modactivo = "N";

                if (MessageBox.Show("¿Desea dar de baja este producto? " + eliminarUsuario, "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.conectarbd.Open();
                        cn.cmd = new SqlCommand("Update Productos SET activo = '" + modactivo + "' where idProducto='" + eliminarUsuario + "'", cn.conectarbd);
                        cn.cmd.ExecuteNonQuery();

                        Cargardgv();
                        //MessageBox.Show("Empleado ingresado al sistema");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(729, 287);
            grpEditarProd.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string modProducto = txtModProducto.Text;
            string modDesc = txtModDescripcion.Text;
            string modMaterial = txtModMaterial.Text;
            string modColor = txtModColor.Text;
            string modLargo = txtModLargo.Text;
            string modAncho = txtModAncho.Text;
            string modAlto = txtModAlto.Text;
            int modDiasG = int.Parse(txtModDiasG.Text);
            double modPrecioC = double.Parse(txtModPrecioC.Text);
            double modPrecioV = double.Parse(txtModPrecioV.Text);
            string modCategoria = cboModIdCategoria.Text;
            string modId = txtModIdProducto.Text;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("Update Productos SET producto='" + modProducto + "', descripcion='" + modDesc + "',material='" + modMaterial
                   + "',color='" + modColor + "',largo='" + modLargo + "',ancho='" + modAncho + "',alto='" + modAlto + "',diasGarantia=" +
                   modDiasG + ",precioCompra=" + modPrecioC + ", precioVenta=" + modPrecioV + ", idCategoria='" + modCategoria + "' where idProducto='" + modId + "'", cn.conectarbd);
                cn.cmd.ExecuteNonQuery();

                dataGridView1.Size = new Size(729, 287);
                grpEditarProd.Visible = false;
                Cargardgv();
                MessageBox.Show("Producto editado correctamente");

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
