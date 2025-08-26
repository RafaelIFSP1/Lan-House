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
         
            try
            {
                string conexao = @"Server=SQLEXPRESS;Database=CJ3027287PR2;User Id=aluno;Password=aluno;";

                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(conexao))
                {
                    conn.Open();

                    string comando = "INSERT INTO usuarios (nome, email, senha) VALUES (@1, @2, @3)";

                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(comando, conn);
                    cmd.Parameters.AddWithValue("@1", txbNome.Text);
                    cmd.Parameters.AddWithValue("@2", txbEmail.Text);
                    cmd.Parameters.AddWithValue("@3", txbSenha.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salvo com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        


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
