
namespace ProyectoFinalTallerBD
{
    partial class FormProductos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.txtPrecVenta = new System.Windows.Forms.TextBox();
            this.txtPrecCompra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarProd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cboIdCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(753, 479);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBuscarId);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TODOS LOS PRODUCTOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(642, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 37);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCTOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Ver,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(6, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(729, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.cboIdCategoria);
            this.tabRegistro.Controls.Add(this.btnAgregarImagen);
            this.tabRegistro.Controls.Add(this.picProducto);
            this.tabRegistro.Controls.Add(this.txtPrecVenta);
            this.tabRegistro.Controls.Add(this.txtPrecCompra);
            this.tabRegistro.Controls.Add(this.label13);
            this.tabRegistro.Controls.Add(this.label12);
            this.tabRegistro.Controls.Add(this.label11);
            this.tabRegistro.Controls.Add(this.txtColor);
            this.tabRegistro.Controls.Add(this.txtAncho);
            this.tabRegistro.Controls.Add(this.txtGarantia);
            this.tabRegistro.Controls.Add(this.txtAlto);
            this.tabRegistro.Controls.Add(this.txtLargo);
            this.tabRegistro.Controls.Add(this.txtMaterial);
            this.tabRegistro.Controls.Add(this.txtDescripcion);
            this.tabRegistro.Controls.Add(this.txtProducto);
            this.tabRegistro.Controls.Add(this.label10);
            this.tabRegistro.Controls.Add(this.label9);
            this.tabRegistro.Controls.Add(this.label8);
            this.tabRegistro.Controls.Add(this.label6);
            this.tabRegistro.Controls.Add(this.label4);
            this.tabRegistro.Controls.Add(this.btnRegistrarProd);
            this.tabRegistro.Controls.Add(this.label7);
            this.tabRegistro.Controls.Add(this.label5);
            this.tabRegistro.Controls.Add(this.label3);
            this.tabRegistro.Controls.Add(this.label2);
            this.tabRegistro.Controls.Add(this.txtClave);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(745, 453);
            this.tabRegistro.TabIndex = 1;
            this.tabRegistro.Text = "REGISTRO DE PRODUCTOS";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.Location = new System.Drawing.Point(561, 136);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(88, 64);
            this.btnAgregarImagen.TabIndex = 69;
            this.btnAgregarImagen.Text = "AGREGAR IMAGEN";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // picProducto
            // 
            this.picProducto.Location = new System.Drawing.Point(561, 5);
            this.picProducto.Margin = new System.Windows.Forms.Padding(2);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(88, 109);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProducto.TabIndex = 70;
            this.picProducto.TabStop = false;
            // 
            // txtPrecVenta
            // 
            this.txtPrecVenta.Location = new System.Drawing.Point(189, 253);
            this.txtPrecVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecVenta.Name = "txtPrecVenta";
            this.txtPrecVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecVenta.TabIndex = 67;
            // 
            // txtPrecCompra
            // 
            this.txtPrecCompra.Location = new System.Drawing.Point(189, 223);
            this.txtPrecCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecCompra.Name = "txtPrecCompra";
            this.txtPrecCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecCompra.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 285);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "ID CATEGORIA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 257);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "PRECIO DE VENTA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 227);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "PRECIO DE COMPRA";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(394, 120);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(137, 20);
            this.txtColor.TabIndex = 62;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(301, 158);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(2);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(86, 20);
            this.txtAncho.TabIndex = 61;
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(189, 191);
            this.txtGarantia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(100, 20);
            this.txtGarantia.TabIndex = 60;
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(460, 158);
            this.txtAlto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(70, 20);
            this.txtAlto.TabIndex = 59;
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(163, 158);
            this.txtLargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(74, 20);
            this.txtLargo.TabIndex = 58;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(163, 120);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(138, 20);
            this.txtMaterial.TabIndex = 57;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(163, 89);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(380, 20);
            this.txtDescripcion.TabIndex = 56;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(163, 58);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(116, 20);
            this.txtProducto.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "DIAS DE GARANTIA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "ALTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "ANCHO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "LARGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "COLOR";
            // 
            // btnRegistrarProd
            // 
            this.btnRegistrarProd.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarProd.Location = new System.Drawing.Point(250, 323);
            this.btnRegistrarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarProd.Name = "btnRegistrarProd";
            this.btnRegistrarProd.Size = new System.Drawing.Size(103, 40);
            this.btnRegistrarProd.TabIndex = 34;
            this.btnRegistrarProd.Text = "REGISTRAR PRODUCTO";
            this.btnRegistrarProd.UseVisualStyleBackColor = true;
            this.btnRegistrarProd.Click += new System.EventHandler(this.btnRegistrarProd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "MATERIAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID PRODUCTO";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(163, 28);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(116, 20);
            this.txtClave.TabIndex = 42;
            // 
            // cboIdCategoria
            // 
            this.cboIdCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdCategoria.FormattingEnabled = true;
            this.cboIdCategoria.Items.AddRange(new object[] {
            "COM-155",
            "INF-521",
            "JAR-789",
            "OFN-451",
            "REM-872",
            "SAL-021"});
            this.cboIdCategoria.Location = new System.Drawing.Point(189, 285);
            this.cboIdCategoria.Name = "cboIdCategoria";
            this.cboIdCategoria.Size = new System.Drawing.Size(100, 21);
            this.cboIdCategoria.TabIndex = 71;
            this.cboIdCategoria.SelectedValueChanged += new System.EventHandler(this.cboIdCategoria_SelectedValueChanged);
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(508, 31);
            this.txtBuscarId.MaxLength = 9;
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(129, 20);
            this.txtBuscarId.TabIndex = 40;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ProyectoFinalTallerBD.Properties.Resources.img_editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 241;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Width = 242;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 243;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 479);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.PictureBox picProducto;
        private System.Windows.Forms.TextBox txtPrecVenta;
        private System.Windows.Forms.TextBox txtPrecCompra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox cboIdCategoria;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Ver;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}