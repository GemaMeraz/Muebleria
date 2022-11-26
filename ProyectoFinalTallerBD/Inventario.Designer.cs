
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
            this.txtBuscarInv = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageRegInv = new System.Windows.Forms.TabPage();
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarInventario = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProdInventario = new System.Windows.Forms.TextBox();
            this.tabInventario.SuspendLayout();
            this.tabPageConsultaInv.SuspendLayout();
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
            this.tabPageConsultaInv.Controls.Add(this.txtBuscarInv);
            this.tabPageConsultaInv.Controls.Add(this.button3);
            this.tabPageConsultaInv.Controls.Add(this.button2);
            this.tabPageConsultaInv.Controls.Add(this.button1);
            this.tabPageConsultaInv.Controls.Add(this.dataGridView1);
            this.tabPageConsultaInv.Controls.Add(this.label1);
            this.tabPageConsultaInv.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultaInv.Name = "tabPageConsultaInv";
            this.tabPageConsultaInv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultaInv.Size = new System.Drawing.Size(654, 418);
            this.tabPageConsultaInv.TabIndex = 0;
            this.tabPageConsultaInv.Text = "REGISTRO DE INVENTARIO";
            this.tabPageConsultaInv.UseVisualStyleBackColor = true;
            // 
            // txtBuscarInv
            // 
            this.txtBuscarInv.Location = new System.Drawing.Point(509, 103);
            this.txtBuscarInv.Name = "txtBuscarInv";
            this.txtBuscarInv.Size = new System.Drawing.Size(109, 20);
            this.txtBuscarInv.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(509, 145);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 37);
            this.button3.TabIndex = 41;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(509, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 40;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(509, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 39;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(455, 357);
            this.dataGridView1.TabIndex = 1;
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
            this.tabPageRegInv.Controls.Add(this.dtpFechaModificacion);
            this.tabPageRegInv.Controls.Add(this.btnRegistrarInventario);
            this.tabPageRegInv.Controls.Add(this.txtStock);
            this.tabPageRegInv.Controls.Add(this.label5);
            this.tabPageRegInv.Controls.Add(this.label3);
            this.tabPageRegInv.Controls.Add(this.label2);
            this.tabPageRegInv.Controls.Add(this.txtIdProdInventario);
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
            // txtIdProdInventario
            // 
            this.txtIdProdInventario.Location = new System.Drawing.Point(332, 88);
            this.txtIdProdInventario.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProdInventario.Name = "txtIdProdInventario";
            this.txtIdProdInventario.Size = new System.Drawing.Size(116, 20);
            this.txtIdProdInventario.TabIndex = 57;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscarInv;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProdInventario;
        private System.Windows.Forms.Button btnRegistrarInventario;
        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
    }
}