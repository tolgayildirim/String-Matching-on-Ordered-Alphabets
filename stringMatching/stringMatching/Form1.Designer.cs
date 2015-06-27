namespace stringMatching
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_karsilasma = new System.Windows.Forms.Label();
            this.lbl_arama = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_oara = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEXT =";
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(79, 14);
            this.txt_text.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_text.Multiline = true;
            this.txt_text.Name = "txt_text";
            this.txt_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_text.Size = new System.Drawing.Size(297, 168);
            this.txt_text.TabIndex = 2;
            this.txt_text.Text = "GCATCGCAGAGAGTATACAGTACG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "PATENT=";
            // 
            // lbl_karsilasma
            // 
            this.lbl_karsilasma.AutoSize = true;
            this.lbl_karsilasma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_karsilasma.Location = new System.Drawing.Point(418, 75);
            this.lbl_karsilasma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_karsilasma.Name = "lbl_karsilasma";
            this.lbl_karsilasma.Size = new System.Drawing.Size(71, 18);
            this.lbl_karsilasma.TabIndex = 5;
            this.lbl_karsilasma.Text = "karsilasma";
            // 
            // lbl_arama
            // 
            this.lbl_arama.AutoSize = true;
            this.lbl_arama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_arama.Location = new System.Drawing.Point(418, 155);
            this.lbl_arama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_arama.Name = "lbl_arama";
            this.lbl_arama.Size = new System.Drawing.Size(80, 18);
            this.lbl_arama.TabIndex = 6;
            this.lbl_arama.Text = "aramasuresi";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_adet.Location = new System.Drawing.Point(418, 18);
            this.lbl_adet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(35, 18);
            this.lbl_adet.TabIndex = 7;
            this.lbl_adet.Text = "adet";
            this.lbl_adet.Click += new System.EventHandler(this.lbl_adet_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(79, 229);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(94, 65);
            this.btn_ara.TabIndex = 8;
            this.btn_ara.Text = "ARAMA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 192);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 26);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "GCAGAGAG";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "DOSYA OKU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 230);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(161, 64);
            this.textBox1.TabIndex = 11;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_oara
            // 
            this.btn_oara.Location = new System.Drawing.Point(464, 230);
            this.btn_oara.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_oara.Name = "btn_oara";
            this.btn_oara.Size = new System.Drawing.Size(126, 64);
            this.btn_oara.TabIndex = 12;
            this.btn_oara.Text = "OKUNAN DOSYADA ARAMA";
            this.btn_oara.UseVisualStyleBackColor = true;
            this.btn_oara.Click += new System.EventHandler(this.btn_oara_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(596, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "DOSYA YOLUNU TEMİZLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(79, 327);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(643, 239);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 22);
            this.button3.TabIndex = 15;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(5, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 90);
            this.button4.TabIndex = 16;
            this.button4.Text = "DETAYLI ARAMA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(734, 582);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_oara);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.lbl_adet);
            this.Controls.Add(this.lbl_arama);
            this.Controls.Add(this.lbl_karsilasma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "form1";
            this.Text = "String Matching on Ordered Alphabets algorithm";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_karsilasma;
        private System.Windows.Forms.Label lbl_arama;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_oara;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

