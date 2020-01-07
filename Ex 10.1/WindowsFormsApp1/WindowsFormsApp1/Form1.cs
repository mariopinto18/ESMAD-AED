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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pesoIdealToolStripMenuItem_Click(object sender, EventArgs e)
        {

            variaveis.CurrentForm = Form.ActiveForm;
            this.Hide();
            Form f2 = new Form2();
            f2.Show();
         
        }

        private void massaCorporalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            variaveis.CurrentForm = Form.ActiveForm;
            this.Hide();
            Form f3 = new Form3();
            f3.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
