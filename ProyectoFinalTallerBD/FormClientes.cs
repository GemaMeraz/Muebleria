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
    public partial class FormClientes : Form
    {
        conexion cn = new conexion();
        int idCliente;
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        private void MostrarClientes()
        {
            try
            {
                cn.da = new SqlDataAdapter("Select * from Clientes Where activo = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dataGridView1.DataSource = cn.dt;
                dataGridView1.Columns["idCliente"].DisplayIndex = 0;
                dataGridView1.Columns["primerNombre"].DisplayIndex = 1;
                dataGridView1.Columns["segundoNombre"].DisplayIndex = 2;
                dataGridView1.Columns["apellidoPaterno"].DisplayIndex = 3;
                dataGridView1.Columns["apellidoMaterno"].DisplayIndex = 4;
                dataGridView1.Columns["numeroTelefono"].DisplayIndex = 5;
                dataGridView1.Columns["calle"].DisplayIndex = 6;
                dataGridView1.Columns["colonia"].DisplayIndex = 7;
                dataGridView1.Columns["numeroExterior"].DisplayIndex = 8;
                dataGridView1.Columns["numeroInterior"].DisplayIndex = 9;
                dataGridView1.Columns["statusCredito"].DisplayIndex = 10;
                dataGridView1.Columns["activo"].DisplayIndex = 11;
                dataGridView1.Columns["correoElectronico"].DisplayIndex = 12;
                dataGridView1.Columns["Editar"].DisplayIndex = 13;
                dataGridView1.Columns["Eliminar"].DisplayIndex = 14;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            idCliente = int.Parse(txtClave.Text);
            string primerNombre = txtPrimerNombre.Text;
            string segundoNombre = txtSegundoNombre.Text;
            string apellidoPaterno = txtApPaterno.Text;
            string apellidoMaterno = txtApMaterno.Text;
            string telefono = txtNumTelefono.Text;
            string calle = txtCalle.Text;
            string colonia = txtColonia.Text;
            string NumE = txtNumExt.Text;
            string NumI = txtNumInt.Text;
            string StatusCrd = cboStatusCredito.Text;
            string Email = txtEmail.Text;
            string activo = "S";
            if (ComprobarCliente() > 0)
            {
                txtClave.Text = "";
                txtClave.Focus();

                MessageBox.Show("El ID ya se encuentra registrado, intente con un nuevo id", "Id duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (idCliente != null && idCliente != 0)
            {
                try
                {
                    cn.conectarbd.Open();
                    cn.cmd = new SqlCommand("Insert into Clientes(idCliente, primerNombre, segundoNombre, apellidoPaterno, apellidoMaterno, numeroTelefono, calle, colonia, numeroExterior, numeroInterior, statusCredito, activo, correoElectronico) values("
                        + idCliente + ",'" + primerNombre + "','" + segundoNombre + "','" + apellidoPaterno + "', '" + apellidoMaterno + "','" + telefono + "','" + calle + "','" + colonia + "','" + NumE +
                        "', '" + NumI + "', '" + StatusCrd + "','" + activo + "', '" + Email + "')", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();

                    MostrarClientes();
                    MessageBox.Show("Cliente ingresado al sistema");
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
                MessageBox.Show("No deje el id del cliente vacío.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(585, 291);
            grpEditarCliente.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                dataGridView1.Size = new Size(435, 291);
                grpEditarCliente.Visible = true;
                txtModCliente.Text = dataGridView1.CurrentRow.Cells["idCliente"].Value.ToString();
                txtModPnombre.Text = dataGridView1.CurrentRow.Cells["primerNombre"].Value.ToString();
                txtModSnombre.Text = dataGridView1.CurrentRow.Cells["segundoNombre"].Value.ToString();
                txtModApPat.Text = dataGridView1.CurrentRow.Cells["apellidoPaterno"].Value.ToString();
                txtModApMat.Text = dataGridView1.CurrentRow.Cells["apellidoMaterno"].Value.ToString();
                txtModNumTelefono.Text = dataGridView1.CurrentRow.Cells["numeroTelefono"].Value.ToString();
                txtModCalle.Text = dataGridView1.CurrentRow.Cells["calle"].Value.ToString();
                txtModCol.Text = dataGridView1.CurrentRow.Cells["colonia"].Value.ToString();
                txtModNumExt.Text = dataGridView1.CurrentRow.Cells["numeroExterior"].Value.ToString();
                txtModNumInt.Text = dataGridView1.CurrentRow.Cells["numeroInterior"].Value.ToString();
                cboModStatusCrd.Text = dataGridView1.CurrentRow.Cells["statusCredito"].Value.ToString();
                txtModEmail.Text = dataGridView1.CurrentRow.Cells["correoElectronico"].Value.ToString();
                dataGridView1.CurrentRow.Cells["Editar"].Style.SelectionBackColor = Color.CadetBlue;

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string eliminarUsuario = dataGridView1.CurrentRow.Cells["idCliente"].Value.ToString();
                string modactivo = "N";

                if (MessageBox.Show("¿Desea dar de baja a este proveedor? " + eliminarUsuario, "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.conectarbd.Open();
                        cn.cmd = new SqlCommand("Update Clientes SET activo = '" + modactivo + "' where idCliente='" + eliminarUsuario + "'", cn.conectarbd);
                        cn.cmd.ExecuteNonQuery();

                        MostrarClientes();
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

        private void btnBuscarClient_Click(object sender, EventArgs e)
        {
            string buscarID = txtBuscarCliente.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["idCliente"].Value.ToString() == buscarID)
                {
                    MessageBox.Show("Cliente encontrado:" + row.Cells["idCliente"].Value.ToString() + "\n" + row.Cells["primerNombre"].Value.ToString());
                    break;
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string modPNombre = txtModPnombre.Text;
            string modSNombre = txtModSnombre.Text;
            string modAPaterno = txtModApPat.Text;
            string modAMaterno = txtModApMat.Text;
            string modTelefono = txtModNumTelefono.Text;
            string modCalle = txtModCalle.Text;
            string modColonia = txtModCol.Text;
            string modNumE = txtModNumExt.Text;
            string modNumI = txtModNumInt.Text;
            string modStatusCrd = cboModStatusCrd.Text;
            string modEmail = txtModEmail.Text;
            int modCliente = int.Parse(txtModCliente.Text);
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("Update Clientes SET primerNombre='" + modPNombre + "', segundoNombre='" + modSNombre + "',apellidoPaterno='" + modAPaterno
                   + "',apellidoMaterno='" + modAMaterno + "',numeroTelefono='" + modTelefono + "',calle='" + modCalle + "', colonia='" + modColonia
                   + "', numeroExterior='" + modNumE + "', numeroInterior='" + modNumI + "', statusCredito='" + modStatusCrd +
                   "', correoElectronico='" + modEmail + "' where idCliente =" + modCliente, cn.conectarbd);
                cn.cmd.ExecuteNonQuery();

                dataGridView1.Size = new Size(585, 291);
                grpEditarCliente.Visible = false;
                MostrarClientes();
                MessageBox.Show("Cliente Editado: " + modCliente.ToString());

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

        private int ComprobarCliente()
        {
            int intCont = 0;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("SELECT * FROM Clientes WHERE idCliente = " + idCliente, cn.conectarbd);
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
    }
}
