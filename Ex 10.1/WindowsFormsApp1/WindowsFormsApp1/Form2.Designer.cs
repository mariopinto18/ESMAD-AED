namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.alturaTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femininoRb = new System.Windows.Forms.RadioButton();
            this.masculinoRb = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pesoidealTxb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alturaTxb
            // 
            this.alturaTxb.Location = new System.Drawing.Point(178, 83);
            this.alturaTxb.Name = "alturaTxb";
            this.alturaTxb.Size = new System.Drawing.Size(100, 22);
            this.alturaTxb.TabIndex = 0;
            this.alturaTxb.TextChanged += new System.EventHandler(this.alturaTxb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Altura em cm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.masculinoRb);
            this.groupBox1.Controls.Add(this.femininoRb);
            this.groupBox1.Location = new System.Drawing.Point(55, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Género";
            // 
            // femininoRb
            // 
            this.femininoRb.AutoSize = true;
            this.femininoRb.Location = new System.Drawing.Point(47, 41);
            this.femininoRb.Name = "femininoRb";
            this.femininoRb.Size = new System.Drawing.Size(86, 21);
            this.femininoRb.TabIndex = 0;
            this.femininoRb.TabStop = true;
            this.femininoRb.Text = "Feminino";
            this.femininoRb.UseVisualStyleBackColor = true;
            this.femininoRb.CheckedChanged += new System.EventHandler(this.femininoRb_CheckedChanged);
            // 
            // masculinoRb
            // 
            this.masculinoRb.AutoSize = true;
            this.masculinoRb.Location = new System.Drawing.Point(47, 93);
            this.masculinoRb.Name = "masculinoRb";
            this.masculinoRb.Size = new System.Drawing.Size(92, 21);
            this.masculinoRb.TabIndex = 1;
            this.masculinoRb.TabStop = true;
            this.masculinoRb.Text = "Masculino";
            this.masculinoRb.UseVisualStyleBackColor = true;
            this.masculinoRb.CheckedChanged += new System.EventHandler(this.masculinoRb_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pesoidealTxb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(419, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 179);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peso Ideal em Kg";
            // 
            // pesoidealTxb
            // 
            this.pesoidealTxb.Location = new System.Drawing.Point(96, 89);
            this.pesoidealTxb.Name = "pesoidealTxb";
            this.pesoidealTxb.ReadOnly = true;
            this.pesoidealTxb.Size = new System.Drawing.Size(100, 22);
            this.pesoidealTxb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular Peso Ideal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fechar Formulário";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alturaTxb);
            this.Name = "Form2";
            this.Text = "Simulador de Peso Ideal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alturaTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton masculinoRb;
        private System.Windows.Forms.RadioButton femininoRb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pesoidealTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}