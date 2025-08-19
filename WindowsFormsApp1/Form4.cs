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
            FormCronometroPC1 product = new FormCronometroPC1();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;

            
        }

        private void btnPC2_Click(object sender, EventArgs e)
        {
            FormCronometroPC2 product = new FormCronometroPC2();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void btnPC3_Click(object sender, EventArgs e)
        {
            FormCronometroPC3 product = new FormCronometroPC3();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VOCE SAIU DO APP",
                "AVISO!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recordes product = new Recordes();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
