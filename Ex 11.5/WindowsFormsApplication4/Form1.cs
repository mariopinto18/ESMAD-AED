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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            status2.Text = "Bom dia!";
           
            
        }
       







        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt16(textBox1.Text);
            }
            catch
            {
                status1.Text = "O valor inserido não é um número válido!";
                
//                return;
            }
            dataGridView1.Rows.Clear();
            string tipo ="";

       // FILTRAR POR TIPO DE MOVIMENTO
            if (checkBox1.Checked == true)
                   tipo = "E";
            if (checkBox2.Checked == true)
                  tipo = "S";
            if ((checkBox1.Checked == true) && (checkBox2.Checked== true))
                    tipo = "T";
            
          
            // CONSULTAR DADOS DO FICHEIRO
            string ficheiro = @"acessos.txt";
            if (File.Exists(ficheiro))
            {
                StreamReader sr = File.OpenText(ficheiro);
                string linha = "";
                int x = 0;
                while ((linha = sr.ReadLine()) != null)  // ler todo o ficheiro
                {
                    string[] campos = linha.Split(';');  // divide a linha do fx pelos ;
                    if ((tipo ==campos[3] ) || (tipo == "T"))  // TIPO DE MOVIMENTO
                        {
                        if ((textBox1.Text == "") || (textBox1.Text == campos[0]))
                        {
                            dataGridView1.Rows.Add(1);
                            dataGridView1[0, x].Value = campos[0];
                            dataGridView1[1, x].Value = campos[1];
                            dataGridView1[2, x].Value = campos[2];
                            dataGridView1[3, x].Value = campos[3];
                            x++;
                        }
                        }             

                }
                sr.Close();
                /*      if (radioButton1.Checked == true)
                      {
                          dataGridView1.Sort(this.dataGridView1.Columns["Data"], ListSortDirection.Ascending);
                      }
                      else
                      {
                          dataGridView1.Sort(this.dataGridView1.Columns["Data"], ListSortDirection.Descending);
                      }
                      */
                status2.Text = "Dados da Consulta";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status1.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1[0, pos].Value.ToString();
        }
    }
}
