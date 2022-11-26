
namespace ProyectoFinalTallerBD
{
    partial class FormClientes
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
            this.grpEditarCliente = new System.Windows.Forms.GroupBox();
            this.cboModStatusCrd = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtModEmail = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtModNumInt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtModNumExt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtModCol = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtModCalle = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtModNumTelefono = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtModApMat = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtModApPat = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtModSnombre = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtModPnombre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtModCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboStatusCredito = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumInt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumExt = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpEditarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 520);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpEditarCliente);
            this.tabPage1.Controls.Add(this.txtBuscarCliente);
            this.tabPage1.Controls.Add(this.btnBuscarClient);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TODOS LOS CLIENTES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpEditarCliente
            // 
            this.grpEditarCliente.Controls.Add(this.cboModStatusCrd);
            this.grpEditarCliente.Controls.Add(this.btnCancelar);
            this.grpEditarCliente.Controls.Add(this.btnEditar);
            this.grpEditarCliente.Controls.Add(this.txtModEmail);
            this.grpEditarCliente.Controls.Add(this.label26);
            this.grpEditarCliente.Controls.Add(this.label25);
            this.grpEditarCliente.Controls.Add(this.txtModNumInt);
            this.grpEditarCliente.Controls.Add(this.label24);
            this.grpEditarCliente.Controls.Add(this.txtModNumExt);
            this.grpEditarCliente.Controls.Add(this.label23);
            this.grpEditarCliente.Controls.Add(this.txtModCol);
            this.grpEditarCliente.Controls.Add(this.label22);
            this.grpEditarCliente.Controls.Add(this.txtModCalle);
            this.grpEditarCliente.Controls.Add(this.label21);
            this.grpEditarCliente.Controls.Add(this.txtModNumTelefono);
            this.grpEditarCliente.Controls.Add(this.label20);
            this.grpEditarCliente.Controls.Add(this.txtModApMat);
            this.grpEditarCliente.Controls.Add(this.label19);
            this.grpEditarCliente.Controls.Add(this.txtModApPat);
            this.grpEditarCliente.Controls.Add(this.label18);
            this.grpEditarCliente.Controls.Add(this.txtModSnombre);
            this.grpEditarCliente.Controls.Add(this.label17);
            this.grpEditarCliente.Controls.Add(this.txtModPnombre);
            this.grpEditarCliente.Controls.Add(this.label16);
            this.grpEditarCliente.Controls.Add(this.txtModCliente);
            this.grpEditarCliente.Controls.Add(this.label15);
            this.grpEditarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditarCliente.Location = new System.Drawing.Point(450, 59);
            this.grpEditarCliente.Name = "grpEditarCliente";
            this.grpEditarCliente.Size = new System.Drawing.Size(265, 364);
            this.grpEditarCliente.TabIndex = 47;
            this.grpEditarCliente.TabStop = false;
            this.grpEditarCliente.Text = "Informacion Cliente";
            this.grpEditarCliente.Visible = false;
            // 
            // cboModStatusCrd
            // 
            this.cboModStatusCrd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModStatusCrd.FormattingEnabled = true;
            this.cboModStatusCrd.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cboModStatusCrd.Location = new System.Drawing.Point(142, 270);
            this.cboModStatusCrd.Name = "cboModStatusCrd";
            this.cboModStatusCrd.Size = new System.Drawing.Size(100, 25);
            this.cboModStatusCrd.TabIndex = 46;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(145, 331);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 28);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(16, 331);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 28);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtModEmail
            // 
            this.txtModEmail.Location = new System.Drawing.Point(142, 299);
            this.txtModEmail.Name = "txtModEmail";
            this.txtModEmail.Size = new System.Drawing.Size(100, 23);
            this.txtModEmail.TabIndex = 23;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 302);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 17);
            this.label26.TabIndex = 22;
            this.label26.Text = "E-mail";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 273);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 17);
            this.label25.TabIndex = 20;
            this.label25.Text = "Status Credito";
            // 
            // txtModNumInt
            // 
            this.txtModNumInt.Location = new System.Drawing.Point(169, 242);
            this.txtModNumInt.Name = "txtModNumInt";
            this.txtModNumInt.Size = new System.Drawing.Size(69, 23);
            this.txtModNumInt.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(126, 245);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 17);
            this.label24.TabIndex = 18;
            this.label24.Text = "# Int";
            // 
            // txtModNumExt
            // 
            this.txtModNumExt.Location = new System.Drawing.Point(51, 242);
            this.txtModNumExt.Name = "txtModNumExt";
            this.txtModNumExt.Size = new System.Drawing.Size(69, 23);
            this.txtModNumExt.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 245);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 17);
            this.label23.TabIndex = 16;
            this.label23.Text = "# Ext";
            // 
            // txtModCol
            // 
            this.txtModCol.Location = new System.Drawing.Point(142, 214);
            this.txtModCol.Name = "txtModCol";
            this.txtModCol.Size = new System.Drawing.Size(100, 23);
            this.txtModCol.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 217);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 17);
            this.label22.TabIndex = 14;
            this.label22.Text = "Colonia";
            // 
            // txtModCalle
            // 
            this.txtModCalle.Location = new System.Drawing.Point(142, 184);
            this.txtModCalle.Name = "txtModCalle";
            this.txtModCalle.Size = new System.Drawing.Size(100, 23);
            this.txtModCalle.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 187);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 17);
            this.label21.TabIndex = 12;
            this.label21.Text = "Calle";
            // 
            // txtModNumTelefono
            // 
            this.txtModNumTelefono.Location = new System.Drawing.Point(142, 155);
            this.txtModNumTelefono.Name = "txtModNumTelefono";
            this.txtModNumTelefono.Size = new System.Drawing.Size(100, 23);
            this.txtModNumTelefono.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 17);
            this.label20.TabIndex = 10;
            this.label20.Text = "Num. Telefono";
            // 
            // txtModApMat
            // 
            this.txtModApMat.Location = new System.Drawing.Point(142, 127);
            this.txtModApMat.Name = "txtModApMat";
            this.txtModApMat.Size = new System.Drawing.Size(100, 23);
            this.txtModApMat.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "Apellido Materno";
            // 
            // txtModApPat
            // 
            this.txtModApPat.Location = new System.Drawing.Point(142, 99);
            this.txtModApPat.Name = "txtModApPat";
            this.txtModApPat.Size = new System.Drawing.Size(100, 23);
            this.txtModApPat.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Apellido Paterno";
            // 
            // txtModSnombre
            // 
            this.txtModSnombre.Location = new System.Drawing.Point(142, 72);
            this.txtModSnombre.Name = "txtModSnombre";
            this.txtModSnombre.Size = new System.Drawing.Size(100, 23);
            this.txtModSnombre.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "2do Nombre";
            // 
            // txtModPnombre
            // 
            this.txtModPnombre.Location = new System.Drawing.Point(142, 45);
            this.txtModPnombre.Name = "txtModPnombre";
            this.txtModPnombre.Size = new System.Drawing.Size(100, 23);
            this.txtModPnombre.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "1er Nombre";
            // 
            // txtModCliente
            // 
            this.txtModCliente.Location = new System.Drawing.Point(142, 19);
            this.txtModCliente.Name = "txtModCliente";
            this.txtModCliente.ReadOnly = true;
            this.txtModCliente.Size = new System.Drawing.Size(100, 23);
            this.txtModCliente.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "idCliente";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(324, 20);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(109, 20);
            this.txtBuscarCliente.TabIndex = 46;
            // 
            // btnBuscarClient
            // 
            this.btnBuscarClient.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarClient.Location = new System.Drawing.Point(450, 15);
            this.btnBuscarClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarClient.Name = "btnBuscarClient";
            this.btnBuscarClient.Size = new System.Drawing.Size(109, 29);
            this.btnBuscarClient.TabIndex = 45;
            this.btnBuscarClient.Text = "BUSCAR";
            this.btnBuscarClient.UseVisualStyleBackColor = true;
            this.btnBuscarClient.Click += new System.EventHandler(this.btnBuscarClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(9, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(585, 291);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ProyectoFinalTallerBD.Properties.Resources.img_editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Dar de baja";
            this.Eliminar.Image = global::ProyectoFinalTallerBD.Properties.Resources.img_baja;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLIENTES";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboStatusCredito);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtNumInt);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtApMaterno);
            this.tabPage2.Controls.Add(this.txtCalle);
            this.tabPage2.Controls.Add(this.txtNumExt);
            this.tabPage2.Controls.Add(this.txtColonia);
            this.tabPage2.Controls.Add(this.txtNumTelefono);
            this.tabPage2.Controls.Add(this.txtApPaterno);
            this.tabPage2.Controls.Add(this.txtSegundoNombre);
            this.tabPage2.Controls.Add(this.txtPrimerNombre);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnRegistrar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtClave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "REGISTRO DE CLIENTES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboStatusCredito
            // 
            this.cboStatusCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusCredito.FormattingEnabled = true;
            this.cboStatusCredito.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cboStatusCredito.Location = new System.Drawing.Point(283, 286);
            this.cboStatusCredito.Name = "cboStatusCredito";
            this.cboStatusCredito.Size = new System.Drawing.Size(238, 21);
            this.cboStatusCredito.TabIndex = 90;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(283, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 20);
            this.txtEmail.TabIndex = 89;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(89, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 88;
            this.label14.Text = "CORREO ELECTRÓNICO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 84;
            this.label12.Text = "STATUS CREDITO";
            // 
            // txtNumInt
            // 
            this.txtNumInt.Location = new System.Drawing.Point(283, 260);
            this.txtNumInt.Name = "txtNumInt";
            this.txtNumInt.Size = new System.Drawing.Size(238, 20);
            this.txtNumInt.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "NUMERO INTERIOR";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(283, 129);
            this.txtApMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(238, 20);
            this.txtApMaterno.TabIndex = 81;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(283, 181);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(238, 20);
            this.txtCalle.TabIndex = 80;
            // 
            // txtNumExt
            // 
            this.txtNumExt.Location = new System.Drawing.Point(283, 233);
            this.txtNumExt.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumExt.Name = "txtNumExt";
            this.txtNumExt.Size = new System.Drawing.Size(238, 20);
            this.txtNumExt.TabIndex = 79;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(283, 207);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(2);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(238, 20);
            this.txtColonia.TabIndex = 78;
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(283, 155);
            this.txtNumTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.Size = new System.Drawing.Size(238, 20);
            this.txtNumTelefono.TabIndex = 77;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(283, 103);
            this.txtApPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(238, 20);
            this.txtApPaterno.TabIndex = 76;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(283, 77);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(238, 20);
            this.txtSegundoNombre.TabIndex = 75;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(283, 51);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(238, 20);
            this.txtPrimerNombre.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "NUMERO EXTERIOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 210);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "COLONIA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "CALLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "NUMERO TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "APELLIDO MATERNO";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Location = new System.Drawing.Point(272, 357);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 24);
            this.btnRegistrar.TabIndex = 63;
            this.btnRegistrar.Text = "REGISTRAR USUARIO";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "APELLIDO PATERNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "SEGUNDO NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "PRIMER NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "ID CLIENTE";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(283, 25);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(238, 20);
            this.txtClave.TabIndex = 64;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 520);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpEditarCliente.ResumeLayout(false);
            this.grpEditarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpEditarCliente;
        private System.Windows.Forms.ComboBox cboModStatusCrd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtModEmail;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtModNumInt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtModNumExt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtModCol;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtModCalle;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtModNumTelefono;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtModApMat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtModApPat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtModSnombre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtModPnombre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtModCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboStatusCredito;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumInt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNumExt;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtNumTelefono;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
    }
}