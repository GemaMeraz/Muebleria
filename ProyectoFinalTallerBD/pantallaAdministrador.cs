﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ProyectoFinalTallerBD
{
    public partial class pantallaAdministrador : Form
    {
        //campo para almacenar el boton actual
        private IconButton currentBtn;
        //panel para crear un borde izquierdo
        private Panel leftBorderBtn;

        Form1 principal = new Form1();

        public pantallaAdministrador()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            pnlMenu.Controls.Add(leftBorderBtn);
        }

        //metodo para mostrar otro form en un panel
        private Form activarForm = null;
        private void openFormSecundario(Form segundoForm)
        {
            if (activarForm != null)
            {
                activarForm.Close();
            }
            activarForm = segundoForm;
            segundoForm.TopLevel = false;
            segundoForm.FormBorderStyle = FormBorderStyle.None;
            segundoForm.Dock = DockStyle.Fill;
            pnlVistaDatos.Controls.Add(segundoForm);
            pnlVistaDatos.Tag = segundoForm;
            segundoForm.BringToFront();
            segundoForm.Show();
        }

        //método para que se active los botones del menu
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn!=null)
            {
                DisabableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //cambiar el icono segun el formulario hijo que este abierto
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.White;
                lblNombreSeccion.Text = currentBtn.Text;

            }
        }

        private void DisabableButton()
        {
            if (currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(14,24,37);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            currentBtn.BackColor = Color.FromArgb(245, 198, 71);
            openFormSecundario(new FormEmpleados());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            openFormSecundario(new FormProveedores());
            ActivateButton(sender, Color.FromArgb(252, 221, 176));
            currentBtn.BackColor = Color.FromArgb(233, 119, 119);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openFormSecundario(new FormProductos());
            ActivateButton(sender, Color.Chocolate);
            currentBtn.BackColor = Color.FromArgb(255, 211, 132);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            openFormSecundario(new FormVentas());
            ActivateButton(sender, Color.Chocolate);
            currentBtn.BackColor = Color.SandyBrown;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openFormSecundario(new FormClientes());
            ActivateButton(sender, Color.Chocolate);
            currentBtn.BackColor = Color.SandyBrown;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                principal.Show();

            }
        }

        private void btnVolverAdmin_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisabableButton();
            leftBorderBtn.Visible = false;
            if (activarForm != null)
            {
                activarForm.Close();
            }
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblNombreSeccion.Text = "Home";
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            openFormSecundario(new Inventario());
            ActivateButton(sender, Color.Chocolate);
            currentBtn.BackColor = Color.SandyBrown;
        }
    }
}
