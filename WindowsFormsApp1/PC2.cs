using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanHouseSystem
{
    public partial class PC2 : Form
    {
        private DateTime tempoInicio;
        private bool pcAtivo = false;
        private decimal valorPorHora = 5.00m; // R$ 5,00 por hora
        public PC2()
        {
            InitializeComponent();
        }

        private void PC2_Load(object sender, EventArgs e)
        {


            if (!pcAtivo)
            {
                DialogResult resultado = MessageBox.Show(
                    "Deseja iniciar o uso do PC2?\nValor: R$ " + valorPorHora + " por hora",
                    "Iniciar PC1",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    tempoInicio = DateTime.Now;
                    pcAtivo = true;
                    MessageBox.Show("PC2 iniciado!\nTempo começou a contar.", "PC2 Ativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("PC2 já está em uso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (pcAtivo)
            {
                DateTime tempoFim = DateTime.Now;
                TimeSpan tempoUso = tempoFim - tempoInicio;

                // Calcula valor total
                decimal valorTotal = (decimal)tempoUso.TotalHours * valorPorHora;

                // Mostra resumo
                string mensagem = "💻 RESUMO DO USO - PC2\n\n";
                mensagem += "Início: " + tempoInicio.ToString("HH:mm:ss") + "\n";
                mensagem += "Fim: " + tempoFim.ToString("HH:mm:ss") + "\n";
                mensagem += "Tempo de uso: " + tempoUso.ToString(@"hh\:mm\:ss") + "\n";
                mensagem += "Valor total: R$ " + valorTotal.ToString("F2");

                MessageBox.Show(mensagem, "Encerramento - PC2", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Reseta variáveis
                pcAtivo = false;

                Form4 product = new Form4();
                this.Visible = false;
                product.ShowDialog();
                this.Visible = true;


            }
        }

    }
}

        