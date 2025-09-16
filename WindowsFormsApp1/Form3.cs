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

        private void button2_Click(object sender, EventArgs e)
        {
            

            string email = txbEMAIL.Text;
            string senha = txbSENHA.Text;

            DatabaseHelper db = new DatabaseHelper();

            // Primeiro tenta fazer LOGIN
            if (db.VerificarLogin(email, senha))
            {
                MessageBox.Show("✅ LOGIN REALIZADO COM SUCESSO!");
                // Abre a próxima tela do sistema

                Form4 product = new Form4();
                this.Visible = false;
                product.ShowDialog();
                this.Visible = true;
            }
            else
            {
                // Se login falhar, tenta CADASTRAR
                DialogResult result = MessageBox.Show(
                    "Usuário não encontrado. Deseja cadastrar? \n (A senha pode estar incorreta)",
                    "Novo usuário",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    if (db.CadastrarUsuario(email, senha))
                    {
                        MessageBox.Show("✅ CADASTRO REALIZADO COM SUCESSO!\nAgora faça login.");
                        txbEMAIL.Text = "";
                        txbSENHA.Text = "";
                    }
                }
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
