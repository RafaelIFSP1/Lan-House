using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LanHouseSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void exitbutton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VOCE SAIU DO APP",
               "AVISO!",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string nome = txbNome.Text;
            string senha = txbSenha.Text;
            MessageBox.Show("Nome: " + nome + "\nSenha: " + senha + "\nEmail: " + email);


            Form2 product = new Form2();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
        
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LanHouse product = new LanHouse();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
