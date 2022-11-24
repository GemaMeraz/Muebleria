
namespace ProyectoFinalTallerBD
{
    partial class FormEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.grbModificarEmpleado = new System.Windows.Forms.GroupBox();
            this.txtModApeMater = new System.Windows.Forms.TextBox();
            this.txtModSalario = new System.Windows.Forms.TextBox();
            this.txtModPuesto = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtModApePater = new System.Windows.Forms.TextBox();
            this.txtModSegundoNom = new System.Windows.Forms.TextBox();
            this.txtModPrimerNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtModIdEm = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.txtSNombre = new System.Windows.Forms.TextBox();
            this.txtPNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbModificarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tabRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 518);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.iconButton3);
            this.tabPage1.Controls.Add(this.txtBuscarId);
            this.tabPage1.Controls.Add(this.grbModificarEmpleado);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvEmpleados);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TODOS LOS EMPLEADOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton3.IconColor = System.Drawing.Color.SkyBlue;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(417, 13);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(51, 35);
            this.iconButton3.TabIndex = 66;
            this.iconButton3.Text = "id";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Visible = false;
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(474, 20);
            this.txtBuscarId.MaxLength = 5;
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(129, 20);
            this.txtBuscarId.TabIndex = 39;
            // 
            // grbModificarEmpleado
            // 
            this.grbModificarEmpleado.Controls.Add(this.txtModApeMater);
            this.grbModificarEmpleado.Controls.Add(this.txtModSalario);
            this.grbModificarEmpleado.Controls.Add(this.txtModPuesto);
            this.grbModificarEmpleado.Controls.Add(this.btnEditar);
            this.grbModificarEmpleado.Controls.Add(this.txtModApePater);
            this.grbModificarEmpleado.Controls.Add(this.txtModSegundoNom);
            this.grbModificarEmpleado.Controls.Add(this.txtModPrimerNom);
            this.grbModificarEmpleado.Controls.Add(this.label8);
            this.grbModificarEmpleado.Controls.Add(this.label11);
            this.grbModificarEmpleado.Controls.Add(this.label12);
            this.grbModificarEmpleado.Controls.Add(this.label13);
            this.grbModificarEmpleado.Controls.Add(this.label14);
            this.grbModificarEmpleado.Controls.Add(this.label15);
            this.grbModificarEmpleado.Controls.Add(this.label16);
            this.grbModificarEmpleado.Controls.Add(this.txtModIdEm);
            this.grbModificarEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModificarEmpleado.Location = new System.Drawing.Point(460, 63);
            this.grbModificarEmpleado.Name = "grbModificarEmpleado";
            this.grbModificarEmpleado.Size = new System.Drawing.Size(282, 333);
            this.grbModificarEmpleado.TabIndex = 38;
            this.grbModificarEmpleado.TabStop = false;
            this.grbModificarEmpleado.Text = "Informacion empleado";
            this.grbModificarEmpleado.Visible = false;
            // 
            // txtModApeMater
            // 
            this.txtModApeMater.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModApeMater.Location = new System.Drawing.Point(146, 170);
            this.txtModApeMater.Margin = new System.Windows.Forms.Padding(2);
            this.txtModApeMater.Name = "txtModApeMater";
            this.txtModApeMater.Size = new System.Drawing.Size(131, 23);
            this.txtModApeMater.TabIndex = 90;
            // 
            // txtModSalario
            // 
            this.txtModSalario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModSalario.Location = new System.Drawing.Point(146, 234);
            this.txtModSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtModSalario.Name = "txtModSalario";
            this.txtModSalario.Size = new System.Drawing.Size(131, 23);
            this.txtModSalario.TabIndex = 89;
            // 
            // txtModPuesto
            // 
            this.txtModPuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModPuesto.Location = new System.Drawing.Point(146, 203);
            this.txtModPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtModPuesto.Name = "txtModPuesto";
            this.txtModPuesto.Size = new System.Drawing.Size(131, 23);
            this.txtModPuesto.TabIndex = 88;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(107, 278);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 37);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtModApePater
            // 
            this.txtModApePater.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModApePater.Location = new System.Drawing.Point(146, 137);
            this.txtModApePater.Margin = new System.Windows.Forms.Padding(2);
            this.txtModApePater.Name = "txtModApePater";
            this.txtModApePater.Size = new System.Drawing.Size(131, 23);
            this.txtModApePater.TabIndex = 87;
            // 
            // txtModSegundoNom
            // 
            this.txtModSegundoNom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModSegundoNom.Location = new System.Drawing.Point(146, 102);
            this.txtModSegundoNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtModSegundoNom.Name = "txtModSegundoNom";
            this.txtModSegundoNom.Size = new System.Drawing.Size(131, 23);
            this.txtModSegundoNom.TabIndex = 86;
            // 
            // txtModPrimerNom
            // 
            this.txtModPrimerNom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModPrimerNom.Location = new System.Drawing.Point(146, 70);
            this.txtModPrimerNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtModPrimerNom.Name = "txtModPrimerNom";
            this.txtModPrimerNom.Size = new System.Drawing.Size(131, 23);
            this.txtModPrimerNom.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 84;
            this.label8.Text = "SALARIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 204);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "PUESTO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 82;
            this.label12.Text = "APELLIDO MATERNO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 138);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 81;
            this.label13.Text = "APELLIDO PATERNO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 107);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 17);
            this.label14.TabIndex = 80;
            this.label14.Text = "SEGUNDO NOMBRE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 70);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 17);
            this.label15.TabIndex = 79;
            this.label15.Text = "PRIMER NOMBRE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 39);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 78;
            this.label16.Text = "ID EMPLEADO";
            // 
            // txtModIdEm
            // 
            this.txtModIdEm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModIdEm.Location = new System.Drawing.Point(146, 38);
            this.txtModIdEm.Margin = new System.Windows.Forms.Padding(2);
            this.txtModIdEm.Name = "txtModIdEm";
            this.txtModIdEm.Size = new System.Drawing.Size(131, 23);
            this.txtModIdEm.TabIndex = 77;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBuscar.Location = new System.Drawing.Point(628, 11);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(109, 37);
            this.txtBuscar.TabIndex = 37;
            this.txtBuscar.Text = "BUSCAR";
            this.txtBuscar.UseVisualStyleBackColor = true;
            this.txtBuscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(215, 406);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 36;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dgvEmpleados.Location = new System.Drawing.Point(19, 63);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.Size = new System.Drawing.Size(616, 288);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.cmbTipoUsuario);
            this.tabRegistro.Controls.Add(this.iconButton2);
            this.tabRegistro.Controls.Add(this.iconButton1);
            this.tabRegistro.Controls.Add(this.btnInfo);
            this.tabRegistro.Controls.Add(this.txtAMaterno);
            this.tabRegistro.Controls.Add(this.txtSalario);
            this.tabRegistro.Controls.Add(this.txtPuesto);
            this.tabRegistro.Controls.Add(this.txtAPaterno);
            this.tabRegistro.Controls.Add(this.txtSNombre);
            this.tabRegistro.Controls.Add(this.txtPNombre);
            this.tabRegistro.Controls.Add(this.label9);
            this.tabRegistro.Controls.Add(this.label6);
            this.tabRegistro.Controls.Add(this.label4);
            this.tabRegistro.Controls.Add(this.btnRegistrarEmpleado);
            this.tabRegistro.Controls.Add(this.label7);
            this.tabRegistro.Controls.Add(this.label5);
            this.tabRegistro.Controls.Add(this.label3);
            this.tabRegistro.Controls.Add(this.label2);
            this.tabRegistro.Controls.Add(this.txtIdEmpleado);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(761, 492);
            this.tabRegistro.TabIndex = 1;
            this.tabRegistro.Text = "REGISTRO DE EMPLEADOS";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "EMP",
            "ADM"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(272, 48);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(67, 21);
            this.cmbTipoUsuario.TabIndex = 66;
            this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUsuario_SelectedIndexChanged);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton2.IconColor = System.Drawing.Color.SkyBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(516, 44);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(135, 35);
            this.iconButton2.TabIndex = 65;
            this.iconButton2.Text = "Se autocompleta";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton1.IconColor = System.Drawing.Color.SkyBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(516, 168);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(103, 35);
            this.iconButton1.TabIndex = 64;
            this.iconButton1.Text = "opcional";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.DimGray;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnInfo.IconColor = System.Drawing.Color.SkyBlue;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 25;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(516, 104);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(103, 35);
            this.btnInfo.TabIndex = 63;
            this.btnInfo.Text = "opcional";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(273, 176);
            this.txtAMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(238, 20);
            this.txtAMaterno.TabIndex = 62;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(273, 241);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(238, 20);
            this.txtSalario.TabIndex = 61;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(273, 209);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(238, 20);
            this.txtPuesto.TabIndex = 58;
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(273, 143);
            this.txtAPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(238, 20);
            this.txtAPaterno.TabIndex = 57;
            // 
            // txtSNombre
            // 
            this.txtSNombre.Location = new System.Drawing.Point(273, 110);
            this.txtSNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSNombre.Name = "txtSNombre";
            this.txtSNombre.Size = new System.Drawing.Size(238, 20);
            this.txtSNombre.TabIndex = 56;
            // 
            // txtPNombre
            // 
            this.txtPNombre.Location = new System.Drawing.Point(273, 79);
            this.txtPNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtPNombre.Name = "txtPNombre";
            this.txtPNombre.Size = new System.Drawing.Size(238, 20);
            this.txtPNombre.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "SALARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "PUESTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "APELLIDO MATERNO";
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.BackColor = System.Drawing.Color.Beige;
            this.btnRegistrarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRegistrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(282, 338);
            this.btnRegistrarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(160, 45);
            this.btnRegistrarEmpleado.TabIndex = 34;
            this.btnRegistrarEmpleado.Text = "REGISTRAR USUARIO";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = false;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.btnRegistrarEmpleado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "APELLIDO PATERNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "SEGUNDO NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "PRIMER NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID EMPLEADO";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Location = new System.Drawing.Point(344, 49);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(167, 20);
            this.txtIdEmpleado.TabIndex = 42;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 518);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grbModificarEmpleado.ResumeLayout(false);
            this.grbModificarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button txtBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.TextBox txtSNombre;
        private System.Windows.Forms.TextBox txtPNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private FontAwesome.Sharp.IconButton btnInfo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.GroupBox grbModificarEmpleado;
        private System.Windows.Forms.TextBox txtModApeMater;
        private System.Windows.Forms.TextBox txtModSalario;
        private System.Windows.Forms.TextBox txtModPuesto;
        private System.Windows.Forms.TextBox txtModApePater;
        private System.Windows.Forms.TextBox txtModSegundoNom;
        private System.Windows.Forms.TextBox txtModPrimerNom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtModIdEm;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.TextBox txtBuscarId;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}