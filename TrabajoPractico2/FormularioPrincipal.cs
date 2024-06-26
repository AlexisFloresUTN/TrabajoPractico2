﻿using NegocioTp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico2
{
    public partial class formularioPrincipal : Form
    {
        public formularioPrincipal()
        {
            InitializeComponent();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbxCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormularioAgregar());
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormularioBuscar());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormularioListar());
        }

        private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormularioListarI());
        }

        private void btnListarM_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormularioListarM());
        }

        private void btnListarC_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormularioListarC());
        }

        private void btnAgregarI_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormularioAgregarMarca());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormularioAgregarCategoria());
        }
    }
}
