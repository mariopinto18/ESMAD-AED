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
            
        }

        public bool filtros_validos(object sender, EventArgs e)
        {    // se as duas checkBox estão por ativar, erro 
            if ((checkBox1.Checked ==false) && (checkBox2.Checked==false))
            {
                return  false;
            }
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Testar de selecionou pelo menos 1 filtro
            if ( filtros_validos(sender, e) == false)
            {
                MessageBox.Show("Não Selecionou nenhum filtro nas opções de consulta");
                return;
            }

           
            dataGridView1.Rows.Clear(); // antes da consulta limpa o conteúdo da datagrig
            if (checkBox2.Checked)
            {   // neste caso torna a coluna da data de vencimento visivel
                dataGridView1.Columns[4].Visible = true;
 
            }
            else
            {   // neste caso torna a coluna da data de vencimento oculta
                dataGridView1.Columns[4].Visible = false;
            }

            string ficheiro = "faturas.txt";
            if (File.Exists(ficheiro))
            {
                string[] faturas = File.ReadAllLines(ficheiro);
                int lin = 0;
                foreach (string linha in faturas)
                {
                    string[] campos = linha.Split(';');
                    // NÃO Mostrar liquidadas?
                    if ((checkBox1.Checked== false) && (campos[3] == "S"))
                    {
                        continue;
                    }
                    // NÃO mostrar faturas por liquidar??
                    if ((checkBox2.Checked == false) && (campos[3] == "N"))
                    {
                        continue;
                    }
                    dataGridView1.Rows.Add(1);
                    dataGridView1[0, lin].Value = campos[0];   // Nº cliente
                    dataGridView1[1, lin].Value = campos[1];    // data
                    dataGridView1[2, lin].Value = campos[2];    // valor
                    dataGridView1[3, lin].Value = campos[3];    // liquidado ou por liquidar

                    if (checkBox2.Checked==true)   // Se a opção é mostrar não liquidadas
                    {                              // calcular a data de vencimento
                        dataGridView1.Columns[4].Visible = true;
                        DateTime data_venc = Convert.ToDateTime(campos[1]);
                        data_venc = data_venc.AddDays(30);
                        dataGridView1[4, lin].Value = data_venc.ToString("yyyy-MM-dd"); 

                    }
                    lin++;


                }
                label2.Text = dataGridView1.RowCount.ToString();
            }

        }
    }
}
