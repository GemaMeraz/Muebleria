
namespace ProyectoFinalTallerBD
{
    partial class InformacionProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionProducto));
            this.picRecibeImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRecibeImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // picRecibeImagen
            // 
            this.picRecibeImagen.Image = ((System.Drawing.Image)(resources.GetObject("picRecibeImagen.Image")));
            this.picRecibeImagen.Location = new System.Drawing.Point(249, 56);
            this.picRecibeImagen.Name = "picRecibeImagen";
            this.picRecibeImagen.Size = new System.Drawing.Size(210, 177);
            this.picRecibeImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRecibeImagen.TabIndex = 0;
            this.picRecibeImagen.TabStop = false;
            // 
            // InformacionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picRecibeImagen);
            this.Name = "InformacionProducto";
            this.Text = "InformacionProducto";
            ((System.ComponentModel.ISupportInitialize)(this.picRecibeImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picRecibeImagen;
    }
}