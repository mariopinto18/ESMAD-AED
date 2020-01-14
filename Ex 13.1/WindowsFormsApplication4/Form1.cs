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
using System.Drawing;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        static int i = -1;
        static string foto_nome = "foto ";
        //static Bitmap foto;
        static int foto_numero = 1;
        static string fotoName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button4.Visible = false;
                   
           

            foreach (Control ctl in tabPage1.Controls) ctl.Enabled = false;
            foreach (Control ctl in tabPage2.Controls) ctl.Enabled = false;

        

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
           
            
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {

           
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            
          /*  Form f2 = new Form2();
            f2.TopLevel = false;
            f2.Visible = true;
            panel6.Controls.Add(f2); */
        }

        static bool valida_user(string user, string passwd)
        {
            String ficheiro = "utilizadores.txt";
            string [] users = File.ReadAllLines(ficheiro);
            foreach ( string linha in users)
            {
                string[] campos = linha.Split(';');
                if (user == campos[0])   // o user existe em ficheiro
                {
                    if (passwd ==  campos[1])     // password correta
                    {
                        return true; 
                       
                    }
                }
            }
            return false;
         
           



        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (valida_user(textBox1.Text, textBox2.Text))
            {
                status2.Text = "Bem-Vindo " + textBox1.Text;
                panel1.Visible = false;

                button14.Visible = false;
                button4.Visible = true;
                label7.Text = textBox1.Text;

                foreach (Control ctl in tabPage1.Controls) ctl.Enabled = true;
                foreach (Control ctl in tabPage2.Controls) ctl.Enabled = true;
            }
            else
            {
                status2.Text = "O username ou a password estão incorretos";
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            panel1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button14.Visible = true;
            label7.Text = "";
          
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Clear();
            imageList1.Images.Clear();
            foto_numero = 1;
            i = -1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }


        // ADICIONAR FOTOS À LISTBOX
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter =
"Images (*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";
            openFileDialog1.Title = "Selecione Imagem";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // adiciona à imagelist
                imageList1.Images.Add(foto_nome + foto_numero.ToString("##"), Image.FromFile(openFileDialog1.FileName));
                // adiciona á listbox
                listBox1.Items.Add(openFileDialog1.SafeFileName);




                // coloca imagem selecionada na picturebox
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                // OU:
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);

              //  fotoName = openFileDialog1.SafeFileName;
                le_comentarios_foto(openFileDialog1.SafeFileName);

                // adiciona 1 ao número da imagem
                foto_numero++;
                i++;
            }
            openFileDialog1.Dispose();

        }

        // REMOVER FOTO DA LISTBOX
        private void button10_Click(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            imageList1.Images.RemoveAt(k);  // remove da ImageList
            listBox1.Items.RemoveAt(k);     // remove da listBox
        }

        // GUARDAR IMAGENS EM DISCO
        private void button8_Click(object sender, EventArgs e)
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory() + "\\imagens\\";

            int num = imageList1.Images.Count;
            for (int i = 0; i < num; i++)
            {
                Bitmap foto = new Bitmap(imageList1.Images[i]);

                foto.Save(currentDirectory + "foto" + i.ToString("00") + ".jpg");
            }
        }

        // ANTERIOR ---
        private void button5_Click(object sender, EventArgs e)
        {
            if(i > 0)
            {
                i--;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = imageList1.Images[i];
          
            le_comentarios_foto(listBox1.Items[i].ToString());

        }


        // SEGUINTE
        private void button6_Click(object sender, EventArgs e)
        {
            if (i < imageList1.Images.Count - 1)   // o array começa em 0...
            {
                i++;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = imageList1.Images[i];

            le_comentarios_foto(listBox1.Items[i].ToString());
          


        }

        // PRIMREIRA
        private void button2_Click_1(object sender, EventArgs e)
        {
           // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
          
            pictureBox1.Image = imageList1.Images[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
         //   pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            int n = imageList1.Images.Count;
            pictureBox1.Image = imageList1.Images[n-1];
        }


        // adicionar o link de um vídeo
        private void button13_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text);
            textBox3.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(listBox2.SelectedItem.ToString());
            /*
            webBrowser1.GoHome();     // Navigates webBrowser1 to the home page of the current user
            webBrowser1.GoSearch();   // Navigates webBrowser1 to the search page of the current user.
            webBrowser1.Stop();       // para execussão do objeto no webBrowser
            webBrowser1.Dispose();    // remove a instância do objeto
            */
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        void save_coments_foto(string ficheiro)
        {
           // MessageBox.Show(ficheiro);
            int pos = ficheiro.IndexOf('.');
            ficheiro = ficheiro.Substring(0, pos) + ".txt";

            StreamWriter sw =File.CreateText(ficheiro);
           for (int i=0; i < listBox3.Items.Count; i++)
            {
                sw.WriteLine(listBox3.Items[i]);
            }

            sw.Close();

        }

        void le_comentarios_foto(string ficheiro)
        {
            int pos = ficheiro.IndexOf('.');
            ficheiro = ficheiro.Substring(0, pos) + ".txt";
            listBox3.Items.Clear();
            //String ficheiro = fotoName;  // o nome do ficheiro é o nome da foto
            if (File.Exists(ficheiro))
                {
                string[] comments = File.ReadAllLines(ficheiro);
                foreach (string linha in comments)
                {
                    listBox3.Items.Add(linha);
                }
            }
        }

        //COMENTAR
        private void button17_Click(object sender, EventArgs e)
        {
            int pos = listBox3.SelectedIndex;   // linha selecionada
            //MessageBox.Show(pos.ToString());
            string comment = textBox1.Text + "|"+ DateTime.Now.ToString("yyyy-MM-dd") + ":"+ textBox4.Text;
            if (pos == -1)  // não selecionei nada
                listBox3.Items.Add(comment);
            else
            {  
                comment = "   " + comment;
                listBox3.Items.Insert(pos + 1, comment);
            }

            
            save_coments_foto(listBox1.Items[i].ToString());
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
                numericUpDown1.Value=1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
                numericUpDown1.Value=3;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
                numericUpDown1.Value=2;
        }
    }
}
