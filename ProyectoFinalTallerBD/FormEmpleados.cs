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
        int numAdm = 2;
        int numUsu = 6;
        string conve;

        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                cn.da = new SqlDataAdapter("Select * from Empleados where status = 'AC'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dgvEmpleados.DataSource = cn.dt;
                //dgvEmpleados.Columns["id"].DisplayIndex = 0;
                //dgvEmpleados.Columns["primerNombre"].DisplayIndex = 1;
                //dgvEmpleados.Columns["SegundoNombre"].DisplayIndex = 2;
                //dgvEmpleados.Columns["apellidoPaterno"].DisplayIndex = 3;
                //dgvEmpleados.Columns["apellidoMaterno"].DisplayIndex = 4;
                //dgvEmpleados.Columns["puesto"].DisplayIndex = 5;
                //dgvEmpleados.Columns["salario"].DisplayIndex = 6;
                //dgvEmpleados.Columns["status"].DisplayIndex = 7;
                dgvEmpleados.Columns["Editar"].DisplayIndex = 8;
            }
            catch (Exception)
            {
                throw;
            }

            
           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {/*
            try
            {
                cn.da = new SqlDataAdapter("Select * from Empleados", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dataGridView1.DataSource = cn.dt;
            }
            catch (Exception)
            {

                throw;
            }*/
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

            try
            {
                cn.cmd = new SqlCommand("Insert into Empleados(idEmpleado,primerNombre,segundoNombre,apellidoPaterno,apellidoMaterno,puesto,salario,status) values('" + txtIdEmpleado.Text + "','" + primerNombre + "','" +segundoNombre + "','" + apellidoPaterno + "', '" + apellidoMaterno + "','"+puesto+"',"+salario+",'"+status+"')", cn.conectarbd);
                cn.cmd.ExecuteNonQuery();
                

                MessageBox.Show("Empleado ingresado al sistema");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex);
            }
            if (cmbTipoUsuario.SelectedItem.ToString() == "ADMINISTRADOR")
            {
                numAdm++;
            }
            if (cmbTipoUsuario.SelectedItem.ToString() == "USUARIO")
            {

                numUsu++;
            }

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
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.SelectedItem.ToString() == "ADMINISTRADOR")
            {

                idEmpleado = "ADM" + numAdm.ToString("00");
                txtIdEmpleado.Text = idEmpleado;
               
            }
            if (cmbTipoUsuario.SelectedItem.ToString() == "USUARIO")
            {

                idEmpleado = "EMP" + numUsu.ToString("00");
                txtIdEmpleado.Text = idEmpleado;
                
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
                cn.cmd = new SqlCommand("Update Empleados SET primerNombre='"+modPNombre+"', segundoNombre='"+modSNombre+"',apellidoPaterno='"+modAPaterno
                   + "',apellidoMaterno='"+modAMaterno+"',puesto='"+modPuesto+"',salario="+modSalario+" where idEmpleado='"+modId+"'", cn.conectarbd);
                cn.cmd.ExecuteNonQuery();


                MessageBox.Show("Empleado ingresado al sistema");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string buscarID=txtBuscarId.Text;
            //try
            //{
            //    cn.cmd = new SqlCommand("SELECT * FROM WHERE I", cn.conectarbd);
            //    cn.cmd.ExecuteNonQuery();


            //    MessageBox.Show("Empleado ingresado al sistema");
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error:" + ex);
            //}
        }
    }
}
