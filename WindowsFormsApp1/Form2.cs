using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanHouseSystem;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            LanHouse product = new LanHouse();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 product = new Form4();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
   
}
