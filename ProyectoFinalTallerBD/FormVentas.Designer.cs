
namespace ProyectoFinalTallerBD
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.dtpInicioCarrera = new System.Windows.Forms.DateTimePicker();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.tabVentasCrd = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvVentasCrd = new System.Windows.Forms.DataGridView();
            this.tabRegVentasCrd = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpNuevoPago = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFechaInicioVentaCrd = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVentasCredito = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabRegistro.SuspendLayout();
            this.tabVentasCrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasCrd)).BeginInit();
            this.tabRegVentasCrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabVentasCrd);
            this.tabControl1.Controls.Add(this.tabRegVentasCrd);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TODAS LAS VENTAS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(15, 342);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 37);
            this.button4.TabIndex = 38;
            this.button4.Text = "MOSTRAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(350, 342);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 37);
            this.button3.TabIndex = 37;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(513, 342);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 36;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(178, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 35;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENTAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dataGridView1.Location = new System.Drawing.Point(15, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(600, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.dtpInicioCarrera);
            this.tabRegistro.Controls.Add(this.textBox9);
            this.tabRegistro.Controls.Add(this.label11);
            this.tabRegistro.Controls.Add(this.textBox8);
            this.tabRegistro.Controls.Add(this.textBox7);
            this.tabRegistro.Controls.Add(this.textBox6);
            this.tabRegistro.Controls.Add(this.textBox4);
            this.tabRegistro.Controls.Add(this.textBox3);
            this.tabRegistro.Controls.Add(this.textBox2);
            this.tabRegistro.Controls.Add(this.label10);
            this.tabRegistro.Controls.Add(this.label8);
            this.tabRegistro.Controls.Add(this.label6);
            this.tabRegistro.Controls.Add(this.label4);
            this.tabRegistro.Controls.Add(this.btnBuscar);
            this.tabRegistro.Controls.Add(this.label7);
            this.tabRegistro.Controls.Add(this.label5);
            this.tabRegistro.Controls.Add(this.label3);
            this.tabRegistro.Controls.Add(this.label2);
            this.tabRegistro.Controls.Add(this.txtClave);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(792, 424);
            this.tabRegistro.TabIndex = 1;
            this.tabRegistro.Text = "REGISTRO DE VENTAS";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // dtpInicioCarrera
            // 
            this.dtpInicioCarrera.Location = new System.Drawing.Point(208, 58);
            this.dtpInicioCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicioCarrera.Name = "dtpInicioCarrera";
            this.dtpInicioCarrera.Size = new System.Drawing.Size(175, 20);
            this.dtpInicioCarrera.TabIndex = 69;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(208, 223);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 227);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "PAGO A CONTADO";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(513, 120);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(137, 20);
            this.textBox8.TabIndex = 62;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(406, 158);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(86, 20);
            this.textBox7.TabIndex = 61;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(208, 191);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 60;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 158);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 20);
            this.textBox4.TabIndex = 58;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 120);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 20);
            this.textBox3.TabIndex = 57;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 89);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "ESTATUS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "FORMA DE PAGO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "PRODUCTOS COMPRADOS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(259, 266);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 40);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "REGISTRAR VENTA";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "ID PRODUCTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "ID CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "FECHA DE VENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID VENTA";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(208, 28);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(175, 20);
            this.txtClave.TabIndex = 42;
            // 
            // tabVentasCrd
            // 
            this.tabVentasCrd.Controls.Add(this.label9);
            this.tabVentasCrd.Controls.Add(this.dgvVentasCrd);
            this.tabVentasCrd.Location = new System.Drawing.Point(4, 22);
            this.tabVentasCrd.Name = "tabVentasCrd";
            this.tabVentasCrd.Size = new System.Drawing.Size(792, 424);
            this.tabVentasCrd.TabIndex = 2;
            this.tabVentasCrd.Text = "TODAS LAS VENTAS A CREDITO";
            this.tabVentasCrd.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(205, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "VENTAS A CREDITO";
            // 
            // dgvVentasCrd
            // 
            this.dgvVentasCrd.AllowUserToAddRows = false;
            this.dgvVentasCrd.AllowUserToDeleteRows = false;
            this.dgvVentasCrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasCrd.Location = new System.Drawing.Point(8, 45);
            this.dgvVentasCrd.MultiSelect = false;
            this.dgvVentasCrd.Name = "dgvVentasCrd";
            this.dgvVentasCrd.ReadOnly = true;
            this.dgvVentasCrd.RowHeadersVisible = false;
            this.dgvVentasCrd.RowHeadersWidth = 51;
            this.dgvVentasCrd.Size = new System.Drawing.Size(600, 288);
            this.dgvVentasCrd.TabIndex = 2;
            // 
            // tabRegVentasCrd
            // 
            this.tabRegVentasCrd.Controls.Add(this.textBox1);
            this.tabRegVentasCrd.Controls.Add(this.label17);
            this.tabRegVentasCrd.Controls.Add(this.dtpLiquidacion);
            this.tabRegVentasCrd.Controls.Add(this.label16);
            this.tabRegVentasCrd.Controls.Add(this.dtpNuevoPago);
            this.tabRegVentasCrd.Controls.Add(this.label15);
            this.tabRegVentasCrd.Controls.Add(this.dtpFechaInicioVentaCrd);
            this.tabRegVentasCrd.Controls.Add(this.label14);
            this.tabRegVentasCrd.Controls.Add(this.txtVenta);
            this.tabRegVentasCrd.Controls.Add(this.label13);
            this.tabRegVentasCrd.Controls.Add(this.txtVentasCredito);
            this.tabRegVentasCrd.Controls.Add(this.label12);
            this.tabRegVentasCrd.Location = new System.Drawing.Point(4, 22);
            this.tabRegVentasCrd.Name = "tabRegVentasCrd";
            this.tabRegVentasCrd.Size = new System.Drawing.Size(792, 424);
            this.tabRegVentasCrd.TabIndex = 3;
            this.tabRegVentasCrd.Text = "REGISTRO DE VENTAS A CREDITO";
            this.tabRegVentasCrd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(212, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Pago Realizado";
            // 
            // dtpLiquidacion
            // 
            this.dtpLiquidacion.Location = new System.Drawing.Point(341, 169);
            this.dtpLiquidacion.Name = "dtpLiquidacion";
            this.dtpLiquidacion.Size = new System.Drawing.Size(200, 20);
            this.dtpLiquidacion.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(168, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "FECHA LIQUIDACION";
            // 
            // dtpNuevoPago
            // 
            this.dtpNuevoPago.Location = new System.Drawing.Point(341, 133);
            this.dtpNuevoPago.Name = "dtpNuevoPago";
            this.dtpNuevoPago.Size = new System.Drawing.Size(200, 20);
            this.dtpNuevoPago.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(168, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "FECHA DE NUEVO PAGO";
            // 
            // dtpFechaInicioVentaCrd
            // 
            this.dtpFechaInicioVentaCrd.Location = new System.Drawing.Point(341, 96);
            this.dtpFechaInicioVentaCrd.Name = "dtpFechaInicioVentaCrd";
            this.dtpFechaInicioVentaCrd.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicioVentaCrd.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(168, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "FECHA DE INICIO DE VENTA";
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(341, 61);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(100, 20);
            this.txtVenta.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "ID VENTA";
            // 
            // txtVentasCredito
            // 
            this.txtVentasCredito.Location = new System.Drawing.Point(341, 29);
            this.txtVentasCredito.Name = "txtVentasCredito";
            this.txtVentasCredito.Size = new System.Drawing.Size(100, 20);
            this.txtVentasCredito.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID VENTA CREDITO";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ProyectoFinalTallerBD.Properties.Resources.img_editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            this.tabVentasCrd.ResumeLayout(false);
            this.tabVentasCrd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasCrd)).EndInit();
            this.tabRegVentasCrd.ResumeLayout(false);
            this.tabRegVentasCrd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.DateTimePicker dtpInicioCarrera;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TabPage tabVentasCrd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvVentasCrd;
        private System.Windows.Forms.TabPage tabRegVentasCrd;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVentasCredito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpLiquidacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpNuevoPago;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioVentaCrd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}