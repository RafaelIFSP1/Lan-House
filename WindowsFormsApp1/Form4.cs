using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace LanHouseSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnPC1_Click(object sender, EventArgs e)
        {
            PC1 product = new PC1();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;


        }

        private void btnPC2_Click(object sender, EventArgs e)
        {
            PC2 product = new PC2();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void btnPC3_Click(object sender, EventArgs e)
        {
            PC3 product = new PC3();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // MOSTRA MENSAGEM DE CONFIRMAÇÃO
            DialogResult resultado = MessageBox.Show(
                "Tem certeza que quer sair do app?",
                "Confirmação de Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // SE CLICOU EM "SIM", SAI DO APLICATIVO
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("VOCE SAIU DO APP",
                "AVISO!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recordes product = new Recordes();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 product = new Form2();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}

