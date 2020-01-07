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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (femininoRb.Checked==true)
            {
                k = 2;
            }
            if (masculinoRb.Checked == true)
            {
                k = 4;
            }

            double altura = Convert.ToDouble(alturaTxb.Text);
            double pesoIdeal = (altura - 100) - (altura - 150) / k;
            pesoidealTxb.Text = pesoIdeal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            variaveis.CurrentForm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
           button1.Enabled = false;
           
        }

        private void alturaTxb_TextChanged(object sender, EventArgs e)
        {
            teste(sender, e);
       
        }

        private void teste(object sender, EventArgs e)
        {
            if ((alturaTxb.Text != "") & (femininoRb.Checked || masculinoRb.Checked))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

        }
        private void femininoRb_CheckedChanged(object sender, EventArgs e)
        {
            teste(sender, e);
           
        }

        private void masculinoRb_CheckedChanged(object sender, EventArgs e)
        {
            teste(sender, e);
            
        }
    }
}
