using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("A password não é igual à digitada anteriormente!","Mensagem", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            String ficheiro = "utilizadores.txt";
            StreamWriter sw;
            if (File.Exists(ficheiro))
            {
                sw = File.AppendText(ficheiro);
            }
            else
            {
                sw = File.CreateText(ficheiro);
            }
            string linha = textBox1.Text + ";" + textBox2.Text;
            sw.WriteLine(linha);
            sw.Close();
            status1.Text = "A sua conta foi criada com sucesso!";
        }
    }
}
