using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanHouseSystem;

namespace WindowsFormsApp1
{
    public partial class LanHouse : Form
    {
        public LanHouse()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {

            string Email = txbEMAIL.Text.Trim();
            string Senha = txbSENHA.Text.Trim();

            // Verifica se os campos estão preenchidos
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Senha))
            {
                MessageBox.Show("Digite o email e a senha!");
                return;
            }

            string conexao = "Data Source=sqlexpress;Initial Catalog=CJ3027287PR2;User ID=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // COMANDO CORRETO: usar a tabela 'usuarios' e colunas 'EMAIL' e 'SENHA'
                string verificasql = "SELECT COUNT(*) FROM usuarios WHERE Email = @EMAIL AND Senha = @SENHA";

                using (SqlCommand cmd = new SqlCommand(verificasql, conn))
                {
                    cmd.Parameters.AddWithValue("@EMAIL", Email);
                    cmd.Parameters.AddWithValue("@SENHA", Senha);

                    int existe = (int)cmd.ExecuteScalar();

                    if (existe > 0)
                    {
                        // LOGIN BEM-SUCEDIDO
                        MessageBox.Show("Login realizado com sucesso!");
                        Form2 product = new Form2();
                        this.Hide(); // Esconde a tela atual
                        product.ShowDialog();
                        this.Close(); // Fecha a tela de login
                    }
                    else
                    {
                        MessageBox.Show("Email ou Senha incorretos");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 product = new Form3();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
