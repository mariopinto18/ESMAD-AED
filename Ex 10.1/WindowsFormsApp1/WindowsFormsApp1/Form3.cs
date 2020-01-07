using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(pesoTxb.Text);
            double altura = Convert.ToDouble(alturaTxb.Text);
            altura = altura / 100;
            double imc = peso / (altura * altura);
            imcLb.Text = imc.ToString("##.##");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            variaveis.CurrentForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void alturaTxb_TextChanged(object sender, EventArgs e)
        {
            if ((alturaTxb.Text != "") && (pesoTxb.Text != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void pesoTxb_TextChanged(object sender, EventArgs e)
        {
            if ((alturaTxb.Text != "") && (pesoTxb.Text != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
