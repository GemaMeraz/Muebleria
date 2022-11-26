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
    public partial class FormEmpleados : Form
    {
        conexion cn = new conexion();
        string idEmpleado;
        //int numAdm = 2;
        //int numUsu = 6;
        string numAdm = "";
        string numUsu = "";
        string conve;

        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MostrarEmpleados()
        {
            try
            {
                cn.da = new SqlDataAdapter("Select * from Empleados where status = 'AC'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dgvEmpleados.DataSource = cn.dt;
                dgvEmpleados.Columns["idEmpleado"].DisplayIndex = 0;
                dgvEmpleados.Columns["primerNombre"].DisplayIndex = 1;
                dgvEmpleados.Columns["segundoNombre"].DisplayIndex = 2;
                dgvEmpleados.Columns["apellidoPaterno"].DisplayIndex = 3;
                dgvEmpleados.Columns["apellidoMaterno"].DisplayIndex = 4;
                dgvEmpleados.Columns["puesto"].DisplayIndex = 5;
                dgvEmpleados.Columns["salario"].DisplayIndex =6;
                dgvEmpleados.Columns["status"].DisplayIndex = 7;
                dgvEmpleados.Columns["Editar"].DisplayIndex = 8;
                dgvEmpleados.Columns["Eliminar"].DisplayIndex = 9;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            MostrarUsuarios();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            string primerNombre = txtPNombre.Text;
            string segundoNombre = txtSNombre.Text;
            string apellidoPaterno = txtAPaterno.Text;
            string apellidoMaterno = txtAMaterno.Text;
            string puesto = txtPuesto.Text;
            double salario = double.Parse(txtSalario.Text);
            string status = "AC";
            if (ComprobarEmpleado() > 0)
            {
                txtIdEmpleado.Text = "";
                txtIdEmpleado.Focus();

                MessageBox.Show("El ID ya se encuentra registrado, intente con un nuevo id", "Id duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (idEmpleado != null && idEmpleado != "00")
            {
                try
                {
                    cn.conectarbd.Open();
                    cn.cmd = new SqlCommand("Insert into Empleados(idEmpleado,primerNombre,segundoNombre,apellidoPaterno,apellidoMaterno,puesto,salario,status) values('" + txtIdEmpleado.Text + "','" + primerNombre + "','" + segundoNombre + "','" + apellidoPaterno + "', '" + apellidoMaterno + "','" + puesto + "'," + salario + ",'" + status + "')", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();

                    MostrarEmpleados();
                    MessageBox.Show("Empleado ingresado al sistema");
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
            
            //if (cmbTipoUsuario.SelectedItem.ToString() == "ADMINISTRADOR")
            //{
            //    numAdm++;
            //}
            //if (cmbTipoUsuario.SelectedItem.ToString() == "USUARIO")
            //{

            //    numUsu++;
            //}

        }

       
        
        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                dgvEmpleados.Size = new Size(414, 288);
                grbModificarEmpleado.Visible = true;
                
                txtModIdEm.Text = dgvEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString();
                txtModPrimerNom.Text = dgvEmpleados.CurrentRow.Cells["primerNombre"].Value.ToString();
                txtModSegundoNom.Text =dgvEmpleados.CurrentRow.Cells["segundoNombre"].Value.ToString();
                txtModApePater.Text = dgvEmpleados.CurrentRow.Cells["apellidoPaterno"].Value.ToString();
                txtModApeMater.Text = dgvEmpleados.CurrentRow.Cells["apellidoMaterno"].Value.ToString();
                txtModPuesto.Text = dgvEmpleados.CurrentRow.Cells["puesto"].Value.ToString();
                txtModSalario.Text = dgvEmpleados.CurrentRow.Cells["salario"].Value.ToString();

            }
            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string eliminarUsuario= dgvEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString();
                string modStatus = "IN";

                if (MessageBox.Show("¿Desea dar de baja a este empleado? "+eliminarUsuario,"Confirmar operación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    try
                    {
                        cn.conectarbd.Open();
                        cn.cmd = new SqlCommand("Update Empleados SET status = '" + modStatus + "' where idEmpleado='" + eliminarUsuario + "'", cn.conectarbd);
                        cn.cmd.ExecuteNonQuery();

                        MostrarEmpleados();
                        //MessageBox.Show("Empleado ingresado al sistema");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error:"+ex);
                    }
                    finally
                    {
                        cn.conectarbd.Close();
                    }
                    
                    
                   
                }

            }
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public string BuscarId()
        {
            try
            {
                int Id;
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("SELECT (COUNT(idEmpleado) + 1) FROM Empleados WHERE idEmpleado LIKE '%" + cmbTipoUsuario.Text + "%'", cn.conectarbd);
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.Read())
                {
                    Id = cn.dr.GetInt32(0);
                    return Id.ToString("00");
                }
                else
                {
                    return "00";
                }
            }
            catch (Exception x)
            {
                return "00";
                throw;
            }
            finally
            {
                cn.conectarbd.Close();
                cn.dr.Close();
            }
        }

        public void MostrarUsuarios()
        {
            try
            {
                cn.da = new SqlDataAdapter("Select * from vw_empleadoUsuario where status = 'AC'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dgvUsuarios.DataSource = cn.dt;
                dgvUsuarios.Columns["idEmpleado"].DisplayIndex = 0;
                dgvUsuarios.Columns["nombreEmpleado"].DisplayIndex = 1;
                dgvUsuarios.Columns["puesto"].DisplayIndex = 2;
                dgvUsuarios.Columns["salario"].DisplayIndex = 3;
                dgvUsuarios.Columns["status"].DisplayIndex = 4;
                dgvUsuarios.Columns["usuario"].DisplayIndex = 5;
                dgvUsuarios.Columns["rangoUsuario"].DisplayIndex = 6;
                //dgvUsuarios.Columns["Editar2"].DisplayIndex = 7;
                //dgvUsuarios.Columns["Eliminar2"].DisplayIndex = 8;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string modPNombre = txtModPrimerNom.Text;
            string modSNombre = txtModSegundoNom.Text;
            string modAPaterno = txtModApePater.Text;
            string modAMaterno = txtModApeMater.Text;
            string modPuesto = txtModPuesto.Text;
            double modSalario = double.Parse(txtModSalario.Text);
            string modId = txtModIdEm.Text;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("Update Empleados SET primerNombre='"+modPNombre+"', segundoNombre='"+modSNombre+"',apellidoPaterno='"+modAPaterno
                   + "',apellidoMaterno='"+modAMaterno+"',puesto='"+modPuesto+"',salario="+modSalario+" where idEmpleado='"+modId+"'", cn.conectarbd);
                cn.cmd.ExecuteNonQuery();

                dgvEmpleados.Size = new Size(616, 288);
                grbModificarEmpleado.Visible = false;
                MostrarEmpleados();
                MessageBox.Show("Empleado editado correctamente");

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

        //botón de buscar
        private void button3_Click(object sender, EventArgs e)
        {
            string buscarID = txtBuscarId.Text;
            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                if (row.Cells["idEmpleado"].Value.ToString()==buscarID)
                {
                    MessageBox.Show("Usuario encontrado:"+ row.Cells["idEmpleado"].Value.ToString() +"\n"+ row.Cells["primerNombre"].Value.ToString());
                    break;
                }
               
            }
           
        }
        private int ComprobarEmpleado()
        {
            int intCont = 0;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("SELECT * FROM Empleados WHERE idEmpleado = '" + idEmpleado + "'", cn.conectarbd);
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

        private void cmbTipoUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.Text == "ADM")
            {
                numAdm = BuscarId();
                idEmpleado = cmbTipoUsuario.Text + numAdm;
                txtIdEmpleado.Text = idEmpleado;
            }
            if (cmbTipoUsuario.Text == "EMP")
            {
                numUsu = BuscarId();
                idEmpleado = cmbTipoUsuario.Text + numUsu;
                txtIdEmpleado.Text = idEmpleado;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Size = new Size(616, 288);
            grbModificarEmpleado.Visible = false;

        }

    }
}
