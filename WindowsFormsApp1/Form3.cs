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

            string NOME = txbNOME.Text;
            string EMAIL = txbEMAIL.Text;
            string SENHA = txbSENHA.Text;

            string conexao = "Data Source=sqlexpress;Initial Catalog=CJ3027287PR2;User ID=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // Verifica se o email já existe
                string verificaSql = "SELECT COUNT(*) FROM Usuarios WHERE EMAIL = @EMAIL";
                using (SqlCommand verificaCmd = new SqlCommand(verificaSql, conn))
                {
                    verificaCmd.Parameters.AddWithValue("@EMAIL", EMAIL);
                    int existe = (int)verificaCmd.ExecuteScalar();

                    if (existe > 0)
                    {
                        MessageBox.Show("Este email já está cadastrado.");
                        return;
                    }
                }

                // Insere novo usuário
                string sql = "INSERT INTO Usuarios (NOME, EMAIL, SENHA) VALUES (@NOME, @EMAIL, @SENHA)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NOME", NOME);
                    cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
                    cmd.Parameters.AddWithValue("@SENHA", SENHA);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cadastro realizado com sucesso!");
                txbNOME.Clear();
                txbEMAIL.Clear();
                txbSENHA.Clear();
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
