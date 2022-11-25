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
        private void Cargardgv()
        {
            try
            {
                //cn.da = new SqlDataAdapter("Select * from Proveedores", cn.conectarbd);
                cn.da = new SqlDataAdapter("Select idProveedor,razonSocial,RFC,fechaAlta,fechaBaja from Proveedores Where activo = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dgvProveedores.DataSource = cn.dt;
                dgvProveedores.Columns["idProveedor"].DisplayIndex = 0;
                dgvProveedores.Columns["razonSocial"].DisplayIndex = 1;
                dgvProveedores.Columns["RFC"].DisplayIndex = 2;
                dgvProveedores.Columns["fechaAlta"].DisplayIndex = 3;
                dgvProveedores.Columns["fechaBaja"].DisplayIndex = 4;
                dgvProveedores.Columns["Editar"].DisplayIndex = 5;
                dgvProveedores.Columns["Eliminar"].DisplayIndex = 6;


            }
            catch (Exception)
            {
                throw;
            }
        }
        private void FormProveedores_Load(object sender, EventArgs e)
        {


            Cargardgv();
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
                    cn.conectarbd.Open();
                    cn.cmd = new SqlCommand("Insert into Proveedores(idProveedor,razonSocial,RFC,fechaAlta,activo) values(" + idProveedor + ",'" + razonSocial + "','" + RFC + "','" + fechaAlta + "', '" + activo + "')", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Proveedor ingresado al sistema");
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
                cn.conectarbd.Open();
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
            finally
            {
                cn.conectarbd.Close();
            }
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.Columns[e.ColumnIndex].Name == "Editar")
            {
                dgvProveedores.Size = new Size(421, 238);
               grbDatosProveedores.Visible = true;
                //int idProvedorCon =Convert.ToInt32(dataGridView1.CurrentRow.Cells["idProveedor"].Value.ToString());
                //txtIdProveedor.Text = idProvedorCon.ToString();
                txtid.Text = dgvProveedores.CurrentRow.Cells["idProveedor"].Value.ToString();
                txtRSocial.Text = dgvProveedores.CurrentRow.Cells["razonSocial"].Value.ToString();
                txtRC.Text = dgvProveedores.CurrentRow.Cells["RFC"].Value.ToString();
                dtpEdFechaAlta.Value = Convert.ToDateTime(dgvProveedores.CurrentRow.Cells["fechaAlta"].Value.ToString());
                dgvProveedores.CurrentRow.Cells["Editar"].Style.SelectionBackColor = Color.CadetBlue;
                //dgvProveedores.AllowUserToAddRows = false;
                //dgvProveedores.AllowUserToDeleteRows = false;
                //dataG.AllowUserToResizeColumns = false;
                //dataGridView1.Enabled = false;
                //dataGridView1.Columns["Editar"].ReadOnly = false;

            }
            if (dgvProveedores.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string eliminarUsuario = dgvProveedores.CurrentRow.Cells["idProveedor"].Value.ToString();
                string modactivo = "N";

                if (MessageBox.Show("¿Desea dar de baja a este proveedor? " + eliminarUsuario, "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.conectarbd.Open();
                        cn.cmd = new SqlCommand("Update Proveedores SET activo = '" + modactivo + "', fechaBaja = GETDATE() where idProveedor='" + eliminarUsuario + "'", cn.conectarbd);
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
            dgvProveedores.Size = new Size(557, 238);
            grbDatosProveedores.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int modIdProv = int.Parse(txtid.Text);
            string modRSocial = txtRSocial.Text;
            string modRFC = txtRC.Text;
            string modFechaAlta = dtpEdFechaAlta.Value.ToString("yyyy-MM-dd");
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("Update Proveedores SET razonSocial='" + modRSocial + "', RFC='" + modRFC + "',fechaAlta='" + modFechaAlta
                   + "' where idProveedor=" + modIdProv, cn.conectarbd);
                cn.cmd.ExecuteNonQuery();

                dgvProveedores.Size = new Size(557, 238);
                grbDatosProveedores.Visible = false;
                MessageBox.Show("Proveedor ingresado al sistema");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarID = txtBuscar.Text;
            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                if (row.Cells[0].Value.ToString() == buscarID)
                {
                    MessageBox.Show("Proveedor encontrado: \nId Proveedor: " + row.Cells[0].Value.ToString() + "\nRazon Social: " + row.Cells[1].Value.ToString() + "\nRFC: " + row.Cells[2].Value.ToString());
                    return;
                }
            }
            MessageBox.Show("No existe el proveedor ingresado.", "PROVEEDOR NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
