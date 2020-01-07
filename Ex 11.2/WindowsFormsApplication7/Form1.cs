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

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        string ficheiro = "TodoList.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                status1.Text = "Não inseriu nenhum texto! :(";
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                status1.Text = "tarefa inserida na lista";
            }
            textBox1.Text = "";

            textBox2.Text = listBox1.Items.Count.ToString();
        }

        // GUARDAR PARA FICHEIRO
        private void button1_Click(object sender, EventArgs e)
        {
                    
            StreamWriter sw = File.CreateText(ficheiro);
            int num = listBox1.Items.Count;
            
            for(int i = 0; i<num; i++)
                {
                string linha = listBox1.Items[i].ToString();
                sw.WriteLine(linha);
            }
            sw.Close();
        
        }

        // REMOVE DA LISTBOX
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedIndex.ToString();
            listBox1.Items.Remove(listBox1.SelectedItem);
            
           textBox2.Text = listBox1.Items.Count.ToString();
        }


        // CLEAR DA LISTBOX
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            

            textBox2.Text = listBox1.Items.Count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        // LER DO FICHEIRO PARA A LISTBOX
        private void button4_Click(object sender, EventArgs e)
        {
           
           StreamReader sr;
           try
                {
                    sr = File.OpenText(ficheiro);
            }
           catch (Exception excp) // "apanha"  o erro / exception. 
                                  // excp traz a mensagem de erro
                {
                    MessageBox.Show(excp.ToString());
                    return;
                }
           string linha;
           while((linha=sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(linha);
                }
            sr.Close();              
            textBox2.Text = listBox1.Items.Count.ToString();

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
