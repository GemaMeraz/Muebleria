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
        int IdVentaCredito;
        int idVenta1;
        private void ConsultarVentas()
        {
            try
            {
                cn.da = new SqlDataAdapter("Select * from Ventas", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dgvVenta.DataSource = cn.dt;
                dgvVenta.Columns["Editar"].DisplayIndex = 9;
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
        public int ValidarVenta()
        {
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("sp_validarVenta", cn.conectarbd);
                cn.cmd.CommandType = CommandType.StoredProcedure;
                cn.cmd.Parameters.AddWithValue("@par_idProducto", cboIdProducto.SelectedValue.ToString());
                cn.cmd.Parameters.AddWithValue("@par_cantVendido", int.Parse(txtProductosComprados.Text));

                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.Read())
                {
                    return cn.dr.GetInt32(0);
                }
                else
                    return -1;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return -1;
            }
            finally
            {
                cn.conectarbd.Close();
            }
        }
        private void FormVentas_Load(object sender, EventArgs e)
        {
            //ConsultarVentas();
            CargardgvVenta();
            Cargardgv();
            //ComboBox cliente y producto
            CargarComboboxCliente();
            CargarProductosComboBox();
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

        private void btnEditarVC_Click(object sender, EventArgs e)
        {
            int modIdVentaCredito = int.Parse(txtModIdVentaCredito.Text);
            int modIdVenta = int.Parse(txtModIdVenta.Text);
            string modFechaInicioVenta = dtpModFechaInicioVenta.Value.ToString("yyyy-MM-dd");
            string modFechaNuevoPago = dtpModFehcaNuevoPago.Value.ToString("yyyy-MM-dd");
            string modFechaLiquidacion = dtpModFechaLiquidacion.Value.ToString("yyyy-MM-dd");
            string modPagoMensualRealizado = cmbModPagoMensualRealizado.Text;
            double modTotalLiquidar = double.Parse(txtModTotalLiquidar.Text);
            double modMontoLiquidado = double.Parse(txtModMontoLiquidado.Text);
            string modActivo = "S";
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("Update VentasCredito SET idVenta='" + modIdVenta + "',fechaInicioVenta='" + modFechaInicioVenta + "', fechaNuevoPago='" + modFechaNuevoPago + "', fechaLiquidacion='" + modFechaLiquidacion + "', pagoMensualRealizado='" + modPagoMensualRealizado + "', totalALiquidar=" + modTotalLiquidar + ", montoLiquidado=" + modMontoLiquidado + ",status='" + modActivo + "' where idVentasCredito=" + modIdVentaCredito, cn.conectarbd);
                cn.cmd.ExecuteNonQuery();

                dgvVentasCrd.Size = new Size(557, 353);
                grbModificarVentasCredito.Visible = false;
                MessageBox.Show("Venta a credito ingresada al sistema");
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
        private void Cargardgv()
        {
            try
            {
                //cn.da = new SqlDataAdapter("Select * from Proveedores", cn.conectarbd);
                cn.da = new SqlDataAdapter("Select idVentasCredito,idVenta,fechaInicioVenta,fechaNuevoPago,fechaLiquidacion,pagoMensualRealizado,totalALiquidar,montoLiquidado,status from VentasCredito Where status = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dgvVentasCrd.DataSource = cn.dt;
                dgvVentasCrd.Columns["idVentasCredito"].DisplayIndex = 0;
                dgvVentasCrd.Columns["idVenta"].DisplayIndex = 1;
                dgvVentasCrd.Columns["fechaInicioVenta"].DisplayIndex = 2;
                dgvVentasCrd.Columns["fechaNuevoPago"].DisplayIndex = 3;
                dgvVentasCrd.Columns["fechaLiquidacion"].DisplayIndex = 4;
                dgvVentasCrd.Columns["pagoMensualRealizado"].DisplayIndex = 5;
                dgvVentasCrd.Columns["totalALiquidar"].DisplayIndex = 6;
                dgvVentasCrd.Columns["montoLiquidado"].DisplayIndex = 7;
                dgvVentasCrd.Columns["status"].DisplayIndex = 8;
                dgvVentasCrd.Columns["Editar2"].DisplayIndex = 9;
                dgvVentasCrd.Columns["Eliminar2"].DisplayIndex = 10;


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCancelarVC_Click(object sender, EventArgs e)
        {
            dgvVentasCrd.Size = new Size(557, 353);
            grbModificarVentasCredito.Visible = false;
        }

        private void btnBuscarVC_Click(object sender, EventArgs e)
        {
            string buscarID = txtBuscar.Text;
            foreach (DataGridViewRow row in dgvVentasCrd.Rows)
            {
                if (row.Cells[0].Value.ToString() == buscarID)
                {
                    MessageBox.Show("Venta a Credito encontrada: \nId Venta a Credito: " + row.Cells[0].Value.ToString() + "\nId Venta: " + row.Cells[1].Value.ToString() + "\nFecha Inicio de Venta: " + row.Cells[2].Value.ToString());
                    return;
                }
            }
            MessageBox.Show("No existe la venta a credito ingresada.", "VENTA A CREDITO NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvVentasCrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVentasCrd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentasCrd.Columns[e.ColumnIndex].Name == "Editar2")
            {
                dgvVentasCrd.Size = new Size(342, 353);
                grbModificarVentasCredito.Visible = true;
                //int idProvedorCon =Convert.ToInt32(dataGridView1.CurrentRow.Cells["idProveedor"].Value.ToString());
                //txtIdProveedor.Text = idProvedorCon.ToString();
                txtModIdVentaCredito.Text = dgvVentasCrd.CurrentRow.Cells["idVentasCredito"].Value.ToString();
                txtModIdVenta.Text = dgvVentasCrd.CurrentRow.Cells["idVenta"].Value.ToString();
                dtpModFechaInicioVenta.Value = Convert.ToDateTime(dgvVentasCrd.CurrentRow.Cells["fechaInicioVenta"].Value.ToString());
                dtpModFehcaNuevoPago.Value = Convert.ToDateTime(dgvVentasCrd.CurrentRow.Cells["fechaNuevoPago"].Value.ToString());
                dtpModFechaLiquidacion.Value = Convert.ToDateTime(dgvVentasCrd.CurrentRow.Cells["fechaLiquidacion"].Value.ToString());
                cmbModPagoMensualRealizado.Text = dgvVentasCrd.CurrentRow.Cells["pagoMensualRealizado"].Value.ToString();
                txtModTotalLiquidar.Text = dgvVentasCrd.CurrentRow.Cells["totalALiquidar"].Value.ToString();
                txtModMontoLiquidado.Text = dgvVentasCrd.CurrentRow.Cells["montoLiquidado"].Value.ToString();
                dgvVentasCrd.CurrentRow.Cells["Editar2"].Style.SelectionBackColor = Color.CadetBlue;
                //dgvProveedores.AllowUserToAddRows = false;
                //dgvProveedores.AllowUserToDeleteRows = false;
                //dataG.AllowUserToResizeColumns = false;
                //dataGridView1.Enabled = false;
                //dataGridView1.Columns["Editar"].ReadOnly = false;

            }
            if (dgvVentasCrd.Columns[e.ColumnIndex].Name == "Eliminar2")
            {
                string eliminarUsuario = dgvVentasCrd.CurrentRow.Cells["idVentasCredito"].Value.ToString();
                string modactivo = "N";

                if (MessageBox.Show("¿Desea dar de baja a esta Venta a Credito? " + eliminarUsuario, "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.conectarbd.Open();
                        cn.cmd = new SqlCommand("Update VentasCredito SET status = '" + modactivo + "', fechaLiquidacion = GETDATE() where idVentasCredito='" + eliminarUsuario + "'", cn.conectarbd);
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

        private void btnRegistrarVCredito_Click(object sender, EventArgs e)
        {
            IdVentaCredito = int.Parse(txtVentasCredito.Text);
            int IdVenta = int.Parse(txtVenta.Text);
            string FechaInicioVenta = dtpFechaInicioVentaCrd.Value.ToString("yyyy-MM-dd");
            string FechaNuevoPago = dtpNuevoPago.Value.ToString("yyyy-MM-dd");
            string FechaLiquidacion = dtpLiquidacion.Value.ToString("yyyy-MM-dd");
            string PagoMensualRealizado = cmbPagoMensualRealizado.Text;
            double TotalLiquidar = double.Parse(txttaLiquidar.Text);
            double MontoLiquidado = double.Parse(txtmontoLiquidado.Text);
            string Activo = "S";
            int var = ComprobarVentaCredito();
            if (IdVentaCredito != var)
            {
                try
                {
                    cn.conectarbd.Open();
                    cn.cmd = new SqlCommand("Insert into VentasCredito(idVentasCredito,idVenta,fechaInicioVenta,fechaNuevoPago,fechaLiquidacion,pagoMensualRealizado,totalALiquidar,montoLiquidado,status) values(" + IdVentaCredito + "," + IdVenta + ",'" + FechaInicioVenta + "','" + FechaNuevoPago + "','" + FechaLiquidacion + "','" + PagoMensualRealizado + "'," + TotalLiquidar + "," + MontoLiquidado + ",'" + Activo + "')", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();

                    MessageBox.Show("Venta con Credito ingresada al sistema");
                    Cargardgv();
                    tabControl1.SelectedIndex = 2;
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
                txtVentasCredito.Text = "";
                txtVentasCredito.Focus();

                MessageBox.Show("El ID ya se encuentra registrado, intente con un nuevo id", "Id duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int ComprobarVentaCredito()
        {
            int intCont = 0;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("SELECT * FROM VentasCredito WHERE idVentasCredito = '" + IdVentaCredito + "'", cn.conectarbd);
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
        private int ComprobarVenta()
        {
            int intCont = 0;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("SELECT * FROM Ventas WHERE idVenta = '" + idVenta1 + "'", cn.conectarbd);
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

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            idVenta1 = int.Parse(txtidVenta.Text);
            string FechaVenta = dtpFechaVenta.Value.ToString("yyyy-MM-dd");
            int idCliente = int.Parse(cboIdCliente.SelectedValue.ToString());
            string idProducto = cboIdProducto.SelectedValue.ToString();
            int ProductosComprados = int.Parse(txtProductosComprados.Text);
            double Total = double.Parse(txtTotal.Text);
            string FormaPago = cmbFormaPago.Text;
            string status = "S";
            string PagoconCredito = cmbPagoconCredito.Text;
            int var = ComprobarVenta();
            if (idVenta1 != var)
            {
                int respuesta = ValidarVenta();
                switch (respuesta)
                {
                    case -1: MessageBox.Show("Error inesperado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    case 0: MessageBox.Show("No hay stock.", "SIN STOCK", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    case 1: MessageBox.Show("No hay stock suficiente para completar la venta", "STOCK INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    case 2: break;
                }
                try
                {
                    cn.conectarbd.Open();
                    cn.cmd = new SqlCommand("Insert into Ventas(idVenta,fechaVenta,idCliente,idProducto,productosComprados,total,formaPago,status,pagoConCredito) values(" + idVenta1 + ",'" + FechaVenta + "','" + idCliente + "','" + idProducto + "','" + ProductosComprados + "','" + Total + "','" + FormaPago + "','" + status + "','" + PagoconCredito + "')", cn.conectarbd);
                    cn.cmd.ExecuteNonQuery();

                    MessageBox.Show("Venta Realizada");
                    Cargardgv();
                    CargardgvVenta();
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
                txtVentasCredito.Text = "";
                txtVentasCredito.Focus();

                MessageBox.Show("El ID ya se encuentra registrado, intente con un nuevo id", "Id duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            string buscarID = txtBuscarV.Text;
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                if (row.Cells["idVenta"].Value.ToString() == buscarID)
                {
                    MessageBox.Show("Venta encontrada: \nId Venta: " + row.Cells["idVenta"].Value.ToString() + "\nFecha Venta: " + row.Cells["fechaVenta"].Value.ToString() + "\nId Cliente: " + row.Cells["idCliente"].Value.ToString());
                    return;
                }
            }
            MessageBox.Show("No existe la Venta ingresada.", "VENTA NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            dgvVenta.Size = new Size(557, 347);
            gpbVentas.Visible = false;
        }

        private void btnEditarVenta_Click(object sender, EventArgs e)
        {
            int modidVenta1 = int.Parse(txtModIdVenta1.Text);
            string modFechaVenta = dtpModFechaVenta.Value.ToString("yyyy-MM-dd");
            int modidCliente = int.Parse(txtModIdCliente.Text);
            string modidProducto = txtModIdProducto.Text;
            int modProductosComprados = int.Parse(txtModProductosComprados.Text);
            double modTotal = double.Parse(txtModTotal.Text);
            string modFormaPago = cmbModFormaPago.Text;
            string modPagoconCredito = cmbModPagoCredito.Text;
            try
            {
                cn.conectarbd.Open();
                cn.cmd = new SqlCommand("Update Ventas SET fechaVenta='" + modFechaVenta + "', idCliente='" + modidCliente + "', idProducto='" + modidProducto + "', productosComprados='" + modProductosComprados + "', total='" + modTotal + "', formaPago='" + modFormaPago + "',pagoConCredito='" + modPagoconCredito + "' where idVenta=" + modidVenta1, cn.conectarbd);
                cn.cmd.ExecuteNonQuery();

                dgvVenta.Size = new Size(557, 347);
                gpbVentas.Visible = false;
                MessageBox.Show("Venta editada");
                CargardgvVenta();

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
        private void CargardgvVenta()
        {
            try
            {
                //cn.da = new SqlDataAdapter("Select * from Proveedores", cn.conectarbd);
                cn.da = new SqlDataAdapter("Select idVenta,fechaVenta,idCliente,idProducto,productosComprados,total,formaPago,status,pagoConCredito from Ventas Where status = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                dgvVenta.DataSource = cn.dt;
                dgvVenta.Columns["idVenta"].DisplayIndex = 0;
                dgvVenta.Columns["fechaVenta"].DisplayIndex = 1;
                dgvVenta.Columns["idCliente"].DisplayIndex = 2;
                dgvVenta.Columns["idProducto"].DisplayIndex = 3;
                dgvVenta.Columns["productosComprados"].DisplayIndex = 4;
                dgvVenta.Columns["total"].DisplayIndex = 5;
                dgvVenta.Columns["formaPago"].DisplayIndex = 6;
                dgvVenta.Columns["status"].DisplayIndex = 7;
                dgvVenta.Columns["pagoConCredito"].DisplayIndex = 8;
                dgvVenta.Columns["Editar"].DisplayIndex = 9;
                dgvVenta.Columns["Eliminar"].DisplayIndex = 10;


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVenta.Columns[e.ColumnIndex].Name == "Editar")
            {
                dgvVenta.Size = new Size(357, 353);
                gpbVentas.Visible = true;
                //int idProvedorCon =Convert.ToInt32(dataGridView1.CurrentRow.Cells["idProveedor"].Value.ToString());
                //txtIdProveedor.Text = idProvedorCon.ToString();
                txtModIdVenta1.Text = dgvVenta.CurrentRow.Cells["idVenta"].Value.ToString();
                dtpModFechaVenta.Value = Convert.ToDateTime(dgvVenta.CurrentRow.Cells["fechaVenta"].Value.ToString());
                txtModIdCliente.Text = dgvVenta.CurrentRow.Cells["idCliente"].Value.ToString();
                txtModIdProducto.Text = dgvVenta.CurrentRow.Cells["idProducto"].Value.ToString();
                txtModProductosComprados.Text = dgvVenta.CurrentRow.Cells["productosComprados"].Value.ToString();
                txtModTotal.Text = dgvVenta.CurrentRow.Cells["total"].Value.ToString();
                cmbModFormaPago.Text = dgvVenta.CurrentRow.Cells["formaPago"].Value.ToString();
                cmbModPagoCredito.Text = dgvVenta.CurrentRow.Cells["pagoConCredito"].Value.ToString();
                dgvVenta.CurrentRow.Cells["Editar"].Style.SelectionBackColor = Color.CadetBlue;
                //dgvProveedores.AllowUserToAddRows = false;
                //dgvProveedores.AllowUserToDeleteRows = false;
                //dataG.AllowUserToResizeColumns = false;
                //dataGridView1.Enabled = false;
                //dataGridView1.Columns["Editar"].ReadOnly = false;

            }
            if (dgvVenta.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string eliminarUsuario = dgvVenta.CurrentRow.Cells["idVenta"].Value.ToString();
                string modactivo = "N";

                if (MessageBox.Show("¿Desea dar de baja a esta Venta? " + eliminarUsuario, "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.conectarbd.Open();
                        cn.cmd = new SqlCommand("Update Ventas SET status = '" + modactivo + "', fechaVenta = GETDATE() where idVenta='" + eliminarUsuario + "'", cn.conectarbd);
                        cn.cmd.ExecuteNonQuery();

                        CargardgvVenta();
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
        public void CargarComboboxCliente()
        {
            try
            {
                cn.da = new SqlDataAdapter("SELECT CONCAT(primerNombre, ' ', apellidoPaterno) AS cliente, idCliente FROM Clientes WHERE activo = 'S'", cn.conectarbd);
                cn.dt = new DataTable();
                cn.da.Fill(cn.dt);
                cboIdCliente.DataSource = cn.dt;
                cboIdCliente.DisplayMember = "cliente";
                cboIdCliente.ValueMember = "idCliente";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
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
