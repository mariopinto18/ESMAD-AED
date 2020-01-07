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

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void file_read()
        {
            string ficheiro = @"acessos.txt";
            StreamReader sr;
            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                string linha = "";
                listBox1.Items.Clear();
                while ((linha = sr.ReadLine()) != null)
                {
                    //string[] dados = linha.Split(';');
                    listBox1.Items.Add(linha);
                    //listBox1.Items.Add(dados[0] + ";" + dados[1] + ";" + dados[2] + ";" + dados[3]);
                }
                sr.Close();
            }
         

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            file_read();
            Status1.Text = "Este exercício é para fazer até ao intervalo!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status1.Text = "";
            estudante pessoa = new estudante();  // cria instância do objeto estudante
            if (radioButton1.Checked==true)
            {
                pessoa.tipo_mov = 'E';
            }
            if (radioButton2.Checked == true)
            {
                pessoa.tipo_mov = 'S';
            }
            pessoa.numero = Convert.ToInt16(textBox1.Text);
            pessoa.data = DateTime.Today.ToString("yyyy-MM-dd");
            pessoa.hora = DateTime.Now.ToString("hh:mm:ss");
            if (valido(pessoa.numero, pessoa.tipo_mov) == true)
            {
                listBox1.Items.Add(pessoa.numero + ";" + pessoa.data + ";" + pessoa.hora + ";" + pessoa.tipo_mov);
                file_store(pessoa.numero + ";" + pessoa.data + ";" + pessoa.hora + ";" + pessoa.tipo_mov);
              
            }
            else
            {
                
                Status1.Text = "Tipo de movimento inválido para este estudante!!!";
            }
        }


        public bool valido(int numero, char tipo_mov)
        {
            // percorre a listBox à procura de registos do mesmo estudante
            for (int i=listBox1.Items.Count-1; i >=0; i--)
            {
                string [] linha= listBox1.Items[i].ToString().Split(';'); // divide linha da listBox pelos ;
                if (linha[0] == numero.ToString())       // se encontra uma linha realtiva ao mesmo estudante
                {
                    if ((tipo_mov == 'S') && (linha[3] != "E"))
                    {
                        return false;
                    }
                    if (linha[3] == tipo_mov.ToString())      // se ultimo movimento é identico ao que pretende fazer
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            if (tipo_mov == 'E')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void file_store(string linha)
        {
            string ficheiro = @"acessos.txt";
            StreamWriter sw;
            if (File.Exists(ficheiro))
            {
                sw = File.AppendText(ficheiro);
            }
            else
            {
                sw = File.CreateText(ficheiro);
            }

            sw.WriteLine(linha);
         
            sw.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // radioButton1.Enabled = true;
           // radioButton2.Enabled = true;
            // percorre a listBox à procura de registos do mesmo estudante
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                string[] linha = listBox1.Items[i].ToString().Split(';'); // divide linha da listBox pelos ;
                if (linha[0] == textBox1.Text)       // se encontra uma linha realtiva ao mesmo estudante
                {
                    if (linha[3] == "E")
                    {
                       // radioButton1.Enabled = false;
                       // radioButton2.Enabled = true;
                        break;
                    }
                    else
                    {
                       // radioButton1.Enabled = true;
                       // radioButton2.Enabled = false;
                        break;
                    }
                }
            }
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }
    }
}
