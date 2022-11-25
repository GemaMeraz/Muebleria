
namespace ProyectoFinalTallerBD
{
    partial class FormEntregas
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
            this.tabEntregas = new System.Windows.Forms.TabPage();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.grpEditarEntrada = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditIdEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditIdProveedor = new System.Windows.Forms.TextBox();
            this.txtEditIdProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEditFechaEnt = new System.Windows.Forms.DateTimePicker();
            this.txtEditCantEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditTotalPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarIdEntrega = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.iconButtonId = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.txtCantEntrada = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrarEntrega = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabEntregas.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.grpEditarEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEntregas);
            this.tabControl1.Controls.Add(this.tabRegistrar);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 447);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabEntregas
            // 
            this.tabEntregas.Controls.Add(this.iconButtonId);
            this.tabEntregas.Controls.Add(this.btnBuscar);
            this.tabEntregas.Controls.Add(this.txtBuscarIdEntrega);
            this.tabEntregas.Controls.Add(this.grpEditarEntrada);
            this.tabEntregas.Controls.Add(this.lblEntradas);
            this.tabEntregas.Controls.Add(this.dgvEntradas);
            this.tabEntregas.Location = new System.Drawing.Point(4, 22);
            this.tabEntregas.Name = "tabEntregas";
            this.tabEntregas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntregas.Size = new System.Drawing.Size(788, 421);
            this.tabEntregas.TabIndex = 0;
            this.tabEntregas.Text = "TODAS LAS ENTREGAS";
            this.tabEntregas.UseVisualStyleBackColor = true;
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Controls.Add(this.dtpFechaEntrada);
            this.tabRegistrar.Controls.Add(this.txtTotalPago);
            this.tabRegistrar.Controls.Add(this.txtCantEntrada);
            this.tabRegistrar.Controls.Add(this.txtProducto);
            this.tabRegistrar.Controls.Add(this.txtProveedor);
            this.tabRegistrar.Controls.Add(this.txtEntrada);
            this.tabRegistrar.Controls.Add(this.label9);
            this.tabRegistrar.Controls.Add(this.label7);
            this.tabRegistrar.Controls.Add(this.label8);
            this.tabRegistrar.Controls.Add(this.btnRegistrarEntrega);
            this.tabRegistrar.Controls.Add(this.label10);
            this.tabRegistrar.Controls.Add(this.label11);
            this.tabRegistrar.Controls.Add(this.label12);
            this.tabRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(788, 421);
            this.tabRegistrar.TabIndex = 1;
            this.tabRegistrar.Text = "REGISTRAR ENTREGA";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dgvEntradas.Location = new System.Drawing.Point(24, 71);
            this.dgvEntradas.MultiSelect = false;
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.RowHeadersVisible = false;
            this.dgvEntradas.Size = new System.Drawing.Size(608, 259);
            this.dgvEntradas.TabIndex = 0;
            this.dgvEntradas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradas_CellDoubleClick);
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.Location = new System.Drawing.Point(261, 27);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(112, 24);
            this.lblEntradas.TabIndex = 1;
            this.lblEntradas.Text = "ENTREGAS";
            // 
            // grpEditarEntrada
            // 
            this.grpEditarEntrada.Controls.Add(this.btnCancelar);
            this.grpEditarEntrada.Controls.Add(this.btnEditar);
            this.grpEditarEntrada.Controls.Add(this.txtEditTotalPago);
            this.grpEditarEntrada.Controls.Add(this.label6);
            this.grpEditarEntrada.Controls.Add(this.txtEditCantEntrada);
            this.grpEditarEntrada.Controls.Add(this.label5);
            this.grpEditarEntrada.Controls.Add(this.dtpEditFechaEnt);
            this.grpEditarEntrada.Controls.Add(this.label4);
            this.grpEditarEntrada.Controls.Add(this.txtEditIdProducto);
            this.grpEditarEntrada.Controls.Add(this.label3);
            this.grpEditarEntrada.Controls.Add(this.txtEditIdProveedor);
            this.grpEditarEntrada.Controls.Add(this.label2);
            this.grpEditarEntrada.Controls.Add(this.txtEditIdEntrada);
            this.grpEditarEntrada.Controls.Add(this.label1);
            this.grpEditarEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditarEntrada.Location = new System.Drawing.Point(482, 63);
            this.grpEditarEntrada.Name = "grpEditarEntrada";
            this.grpEditarEntrada.Size = new System.Drawing.Size(300, 352);
            this.grpEditarEntrada.TabIndex = 2;
            this.grpEditarEntrada.TabStop = false;
            this.grpEditarEntrada.Text = "Información Entregas";
            this.grpEditarEntrada.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID ENTRADA";
            // 
            // txtEditIdEntrada
            // 
            this.txtEditIdEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditIdEntrada.Location = new System.Drawing.Point(145, 30);
            this.txtEditIdEntrada.Name = "txtEditIdEntrada";
            this.txtEditIdEntrada.ReadOnly = true;
            this.txtEditIdEntrada.Size = new System.Drawing.Size(142, 23);
            this.txtEditIdEntrada.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID PROVEEDOR";
            // 
            // txtEditIdProveedor
            // 
            this.txtEditIdProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditIdProveedor.Location = new System.Drawing.Point(145, 73);
            this.txtEditIdProveedor.Name = "txtEditIdProveedor";
            this.txtEditIdProveedor.Size = new System.Drawing.Size(142, 23);
            this.txtEditIdProveedor.TabIndex = 3;
            // 
            // txtEditIdProducto
            // 
            this.txtEditIdProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditIdProducto.Location = new System.Drawing.Point(145, 111);
            this.txtEditIdProducto.Name = "txtEditIdProducto";
            this.txtEditIdProducto.Size = new System.Drawing.Size(142, 23);
            this.txtEditIdProducto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID PRODUCTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "FECHA DE ENTRADA";
            // 
            // dtpEditFechaEnt
            // 
            this.dtpEditFechaEnt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditFechaEnt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpEditFechaEnt.Location = new System.Drawing.Point(145, 154);
            this.dtpEditFechaEnt.Name = "dtpEditFechaEnt";
            this.dtpEditFechaEnt.Size = new System.Drawing.Size(142, 23);
            this.dtpEditFechaEnt.TabIndex = 7;
            // 
            // txtEditCantEntrada
            // 
            this.txtEditCantEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCantEntrada.Location = new System.Drawing.Point(145, 192);
            this.txtEditCantEntrada.Name = "txtEditCantEntrada";
            this.txtEditCantEntrada.Size = new System.Drawing.Size(142, 23);
            this.txtEditCantEntrada.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "CANT. ENTRADA";
            // 
            // txtEditTotalPago
            // 
            this.txtEditTotalPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditTotalPago.Location = new System.Drawing.Point(145, 236);
            this.txtEditTotalPago.Name = "txtEditTotalPago";
            this.txtEditTotalPago.Size = new System.Drawing.Size(142, 23);
            this.txtEditTotalPago.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "TOTAL DE PAGO";
            // 
            // txtBuscarIdEntrega
            // 
            this.txtBuscarIdEntrega.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarIdEntrega.Location = new System.Drawing.Point(509, 18);
            this.txtBuscarIdEntrega.Name = "txtBuscarIdEntrega";
            this.txtBuscarIdEntrega.Size = new System.Drawing.Size(112, 23);
            this.txtBuscarIdEntrega.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(639, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 33);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // iconButtonId
            // 
            this.iconButtonId.FlatAppearance.BorderSize = 0;
            this.iconButtonId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonId.ForeColor = System.Drawing.Color.DimGray;
            this.iconButtonId.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButtonId.IconColor = System.Drawing.Color.SkyBlue;
            this.iconButtonId.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonId.IconSize = 25;
            this.iconButtonId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonId.Location = new System.Drawing.Point(436, 13);
            this.iconButtonId.Name = "iconButtonId";
            this.iconButtonId.Size = new System.Drawing.Size(57, 35);
            this.iconButtonId.TabIndex = 5;
            this.iconButtonId.Text = "id";
            this.iconButtonId.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonId.UseVisualStyleBackColor = true;
            this.iconButtonId.Visible = false;
            this.iconButtonId.Click += new System.EventHandler(this.iconButtonId_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(41, 287);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 36);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(174, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 36);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ProyectoFinalTallerBD.Properties.Resources.img_editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Location = new System.Drawing.Point(338, 223);
            this.txtTotalPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(238, 20);
            this.txtTotalPago.TabIndex = 72;
            // 
            // txtCantEntrada
            // 
            this.txtCantEntrada.Location = new System.Drawing.Point(338, 191);
            this.txtCantEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantEntrada.Name = "txtCantEntrada";
            this.txtCantEntrada.Size = new System.Drawing.Size(238, 20);
            this.txtCantEntrada.TabIndex = 71;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(338, 125);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(238, 20);
            this.txtProducto.TabIndex = 70;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(338, 92);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(238, 20);
            this.txtProveedor.TabIndex = 69;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(338, 61);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(238, 20);
            this.txtEntrada.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(146, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "TOTAL DE PAGO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "CANTIDAD DE ENTRADA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 65;
            this.label8.Text = "FECHA DE ENTRADA";
            // 
            // btnRegistrarEntrega
            // 
            this.btnRegistrarEntrega.BackColor = System.Drawing.Color.Beige;
            this.btnRegistrarEntrega.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRegistrarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEntrega.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEntrega.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarEntrega.Location = new System.Drawing.Point(377, 284);
            this.btnRegistrarEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarEntrega.Name = "btnRegistrarEntrega";
            this.btnRegistrarEntrega.Size = new System.Drawing.Size(160, 45);
            this.btnRegistrarEntrega.TabIndex = 73;
            this.btnRegistrarEntrega.Text = "REGISTRAR ENTREGA";
            this.btnRegistrarEntrega.UseVisualStyleBackColor = false;
            this.btnRegistrarEntrega.Click += new System.EventHandler(this.btnRegistrarEntrega_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(144, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "ID PRODUCTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(144, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "ID PROVEEDOR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(144, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 62;
            this.label12.Text = "ID ENTRADA";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Location = new System.Drawing.Point(338, 158);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(238, 20);
            this.dtpFechaEntrada.TabIndex = 74;
            // 
            // FormEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormEntregas";
            this.Text = "formEntregas";
            this.Load += new System.EventHandler(this.FormEntregas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEntregas.ResumeLayout(false);
            this.tabEntregas.PerformLayout();
            this.tabRegistrar.ResumeLayout(false);
            this.tabRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.grpEditarEntrada.ResumeLayout(false);
            this.grpEditarEntrada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEntregas;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.GroupBox grpEditarEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditIdEntrada;
        private System.Windows.Forms.TextBox txtEditIdProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditIdProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEditFechaEnt;
        private System.Windows.Forms.TextBox txtEditTotalPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditCantEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarIdEntrega;
        private System.Windows.Forms.Button btnBuscar;
        private FontAwesome.Sharp.IconButton iconButtonId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.TextBox txtCantEntrada;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrarEntrega;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
    }
}