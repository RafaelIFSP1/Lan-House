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
    public partial class PC1 : Form
    {
        private DateTime tempoInicio;
        private bool pcAtivo = false;
        private decimal valorPorHora = 5.00m; // R$ 5,00 por hora
        public PC1()
        {
            InitializeComponent();
        }






        private void FormCronometroPC1_Load(object sender, EventArgs e)

        {
            if (!pcAtivo)
            {
                DialogResult resultado = MessageBox.Show(
                    "Deseja iniciar o uso do PC1?\nValor: R$ " + valorPorHora + " por hora",
                    "Iniciar PC1",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    tempoInicio = DateTime.Now;
                    pcAtivo = true;
                    MessageBox.Show("PC1 iniciado!\nTempo começou a contar.", "PC1 Ativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("PC1 já está em uso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexitpc1_Click(object sender, EventArgs e)
        {





            if (pcAtivo)
            {
                DateTime tempoFim = DateTime.Now;
                TimeSpan tempoUso = tempoFim - tempoInicio;

                // Calcula valor total
                decimal valorTotal = (decimal)tempoUso.TotalHours * valorPorHora;

                // Mostra resumo
                string mensagem = "💻 RESUMO DO USO - PC1\n\n";
                mensagem += "Início: " + tempoInicio.ToString("HH:mm:ss") + "\n";
                mensagem += "Fim: " + tempoFim.ToString("HH:mm:ss") + "\n";
                mensagem += "Tempo de uso: " + tempoUso.ToString(@"hh\:mm\:ss") + "\n";
                mensagem += "Valor total: R$ " + valorTotal.ToString("F2");

                MessageBox.Show(mensagem, "Encerramento - PC1", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                // Reseta variáveis
                pcAtivo = false;

                Form4 product = new Form4();
                this.Visible = false;
                product.ShowDialog();
                this.Visible = true;

            }
            else
            {
                MessageBox.Show("PC1 não está em uso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }

        }
    }
