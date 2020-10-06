using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjLanchonete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            boxCliente.Text = "";
            boxPedido.Text = "";
            cboBatata.Text = "";
            cboLanche.Text = "";
            cboRefrigerante.Text = "";
            
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(boxCliente.Text + ", Você escolheu um " + cboLanche.Text + ", uma batata " + cboBatata.Text + ", e um " + cboRefrigerante.Text);
        }
    }
}
