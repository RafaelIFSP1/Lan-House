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

            string Nome = .Text;
            string Email = tbxEmail.Text;
            string Senha = tbxSenha.Text;

            string conexao = "Data Source=sqlexpress;Initial Catalog=CJ3027511PR2;User ID=aluno;Password=aluno;";


            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // Verifica se o email já existe
                string verificaSql = "SELECT COUNT(*) FROM Usuario WHERE Email = @Email";
                using (SqlCommand verificaCmd = new SqlCommand(verificaSql, conn))
                {
                    verificaCmd.Parameters.AddWithValue("@Email", Email);
                    int existe = (int)verificaCmd.ExecuteScalar();

                    if (existe > 0)
                    {
                        MessageBox.Show("Este email já está cadastrado.");
                        return;
                    }
                }

                //Insere novo usuário
                string sql = "INSERT INTO Usuario (Email, Senha) VALUES (@Email, @Senha)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", senha);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cadastro realizado com sucesso!");
                tbxEmail1.Clear();
                tbxSenha1.Clear();
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
    }
}
