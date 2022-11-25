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
    public partial class FormVentas : Form
    {
        conexion cn = new conexion();
        public FormVentas()
        {
            InitializeComponent();
        }
        private void ConsultarVentas()
        {
            try
            {
                cn.da = new SqlDataAdapter("Select * from Ventas", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dataGridView1.DataSource = cn.dt;
                dataGridView1.Columns["Editar"].DisplayIndex = 9;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                throw;
            }
        }
        private void ConsultarVistaVentas()
        {
            try
            {
                cn.da = new SqlDataAdapter("Select * from vw_ventasConCredito", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dgvVentasCrd.DataSource = cn.dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FormVentas_Load(object sender, EventArgs e)
        {
            ConsultarVentas();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: ConsultarVentas(); break;
                case 2: ConsultarVistaVentas(); break;
            }
        }
    }
}
