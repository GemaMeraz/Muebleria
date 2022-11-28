
namespace ProyectoFinalTallerBD
{
    partial class Inventario
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
            this.tabInventario = new System.Windows.Forms.TabControl();
            this.tabPageConsultaInv = new System.Windows.Forms.TabPage();
            this.grpEditarInv = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpModFechaModif = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModIdProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBuscarInv = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageRegInv = new System.Windows.Forms.TabPage();
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarInventario = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIdProducto = new System.Windows.Forms.ComboBox();
            this.tabInventario.SuspendLayout();
            this.tabPageConsultaInv.SuspendLayout();
            this.grpEditarInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageRegInv.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.tabPageConsultaInv);
            this.tabInventario.Controls.Add(this.tabPageRegInv);
            this.tabInventario.Location = new System.Drawing.Point(2, 1);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.SelectedIndex = 0;
            this.tabInventario.Size = new System.Drawing.Size(662, 444);
            this.tabInventario.TabIndex = 0;
            // 
            // tabPageConsultaInv
            // 
            this.tabPageConsultaInv.Controls.Add(this.grpEditarInv);
            this.tabPageConsultaInv.Controls.Add(this.txtBuscarInv);
            this.tabPageConsultaInv.Controls.Add(this.btnBuscar);
            this.tabPageConsultaInv.Controls.Add(this.dataGridView1);
            this.tabPageConsultaInv.Controls.Add(this.label1);
            this.tabPageConsultaInv.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultaInv.Name = "tabPageConsultaInv";
            this.tabPageConsultaInv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultaInv.Size = new System.Drawing.Size(654, 418);
            this.tabPageConsultaInv.TabIndex = 0;
            this.tabPageConsultaInv.Text = "INVENTARIO";
            this.tabPageConsultaInv.UseVisualStyleBackColor = true;
            // 
            // grpEditarInv
            // 
            this.grpEditarInv.Controls.Add(this.btnCancelar);
            this.grpEditarInv.Controls.Add(this.dtpModFechaModif);
            this.grpEditarInv.Controls.Add(this.label7);
            this.grpEditarInv.Controls.Add(this.txtModStock);
            this.grpEditarInv.Controls.Add(this.label6);
            this.grpEditarInv.Controls.Add(this.txtModIdProducto);
            this.grpEditarInv.Controls.Add(this.label4);
            this.grpEditarInv.Controls.Add(this.btnEditar);
            this.grpEditarInv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditarInv.Location = new System.Drawing.Point(333, 54);
            this.grpEditarInv.Name = "grpEditarInv";
            this.grpEditarInv.Size = new System.Drawing.Size(315, 358);
            this.grpEditarInv.TabIndex = 43;
            this.grpEditarInv.TabStop = false;
            this.grpEditarInv.Text = "Información Inventario";
            this.grpEditarInv.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(187, 299);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 37);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpModFechaModif
            // 
            this.dtpModFechaModif.Location = new System.Drawing.Point(31, 206);
            this.dtpModFechaModif.Name = "dtpModFechaModif";
            this.dtpModFechaModif.Size = new System.Drawing.Size(265, 23);
            this.dtpModFechaModif.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "FECHA DE MODIFICACIÓN";
            // 
            // txtModStock
            // 
            this.txtModStock.Location = new System.Drawing.Point(163, 105);
            this.txtModStock.Name = "txtModStock";
            this.txtModStock.Size = new System.Drawing.Size(133, 23);
            this.txtModStock.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "STOCK";
            // 
            // txtModIdProducto
            // 
            this.txtModIdProducto.Location = new System.Drawing.Point(163, 26);
            this.txtModIdProducto.Name = "txtModIdProducto";
            this.txtModIdProducto.ReadOnly = true;
            this.txtModIdProducto.Size = new System.Drawing.Size(133, 23);
            this.txtModIdProducto.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "ID PRODUCTO";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(31, 299);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 37);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBuscarInv
            // 
            this.txtBuscarInv.Location = new System.Drawing.Point(406, 15);
            this.txtBuscarInv.Name = "txtBuscarInv";
            this.txtBuscarInv.Size = new System.Drawing.Size(109, 20);
            this.txtBuscarInv.TabIndex = 42;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(520, 6);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 37);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dataGridView1.Location = new System.Drawing.Point(6, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(623, 357);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ProyectoFinalTallerBD.Properties.Resources.img_editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTARIO";
            // 
            // tabPageRegInv
            // 
            this.tabPageRegInv.Controls.Add(this.cboIdProducto);
            this.tabPageRegInv.Controls.Add(this.dtpFechaModificacion);
            this.tabPageRegInv.Controls.Add(this.btnRegistrarInventario);
            this.tabPageRegInv.Controls.Add(this.txtStock);
            this.tabPageRegInv.Controls.Add(this.label5);
            this.tabPageRegInv.Controls.Add(this.label3);
            this.tabPageRegInv.Controls.Add(this.label2);
            this.tabPageRegInv.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegInv.Name = "tabPageRegInv";
            this.tabPageRegInv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegInv.Size = new System.Drawing.Size(654, 418);
            this.tabPageRegInv.TabIndex = 1;
            this.tabPageRegInv.Text = "REGISTRO DE INVENTARIO";
            this.tabPageRegInv.UseVisualStyleBackColor = true;
            // 
            // dtpFechaModificacion
            // 
            this.dtpFechaModificacion.Location = new System.Drawing.Point(332, 146);
            this.dtpFechaModificacion.Name = "dtpFechaModificacion";
            this.dtpFechaModificacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaModificacion.TabIndex = 64;
            // 
            // btnRegistrarInventario
            // 
            this.btnRegistrarInventario.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarInventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarInventario.Location = new System.Drawing.Point(245, 212);
            this.btnRegistrarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarInventario.Name = "btnRegistrarInventario";
            this.btnRegistrarInventario.Size = new System.Drawing.Size(126, 49);
            this.btnRegistrarInventario.TabIndex = 63;
            this.btnRegistrarInventario.Text = "REGISTRAR PRODUCTO EN INVENTARIO";
            this.btnRegistrarInventario.UseVisualStyleBackColor = true;
            this.btnRegistrarInventario.Click += new System.EventHandler(this.btnRegistrarInventario_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(332, 119);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(116, 20);
            this.txtStock.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "FECHA DE MODIFICACIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "STOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID PRODUCTO";
            // 
            // cboIdProducto
            // 
            this.cboIdProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdProducto.FormattingEnabled = true;
            this.cboIdProducto.Location = new System.Drawing.Point(332, 88);
            this.cboIdProducto.Name = "cboIdProducto";
            this.cboIdProducto.Size = new System.Drawing.Size(200, 21);
            this.cboIdProducto.TabIndex = 65;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 446);
            this.Controls.Add(this.tabInventario);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.tabInventario.ResumeLayout(false);
            this.tabPageConsultaInv.ResumeLayout(false);
            this.tabPageConsultaInv.PerformLayout();
            this.grpEditarInv.ResumeLayout(false);
            this.grpEditarInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageRegInv.ResumeLayout(false);
            this.tabPageRegInv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInventario;
        private System.Windows.Forms.TabPage tabPageConsultaInv;
        private System.Windows.Forms.TabPage tabPageRegInv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarInv;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarInventario;
        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
        private System.Windows.Forms.GroupBox grpEditarInv;
        private System.Windows.Forms.DateTimePicker dtpModFechaModif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModIdProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.ComboBox cboIdProducto;
    }
}