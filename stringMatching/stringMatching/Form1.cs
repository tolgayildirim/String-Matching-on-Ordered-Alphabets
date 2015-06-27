using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace stringMatching
{
    public partial class form1 : Form
    {

        islemler arama = new islemler();
        FileStream dosya;
        string yazi;
        public form1()
        {


            InitializeComponent();

        }
        private void btn_ara_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string dizin = txt_text.Text;

            string[] bolumler = dizin.Split(' ');
            foreach (string bolum in bolumler)
            {
                comboBox1.Items.Add(bolum);
            }
            arama.findAll(txt_text.Text, comboBox1.Text);
  
     
           
            // arama.findAll("GCATCGCAGAGAGTATACAGTACGGCAGAGAG", "GCAGAGAG");
            lbl_adet.Text = arama.adet + " adet *" + comboBox1.Text + "*\n metinde bulunmaktadır";

            lbl_karsilasma.Text =arama.sayac.ToString()+" karşılaşma olmuştur";
            TimeSpan ts = arama.sw.Elapsed;
            lbl_arama.Text = ts.ToString();
            arama.adet = 0;
            arama.sayac = 0;

        }

        private void lbl_adet_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFileDialog1;
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void btn_oara_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                dosya = new FileStream(textBox1.Text, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader file = new StreamReader(dosya);
                if((yazi=file.ReadLine()) != null)
                {
                    arama.findAll(yazi, comboBox1.Text);
                    lbl_adet.Text = arama.adet + " adet *" + comboBox1.Text + "*\n metinde bulunmaktadır";

                    lbl_karsilasma.Text = arama.sayac.ToString() + " karşılaşma olmuştur";
                    TimeSpan ts = arama.sw.Elapsed;
                    lbl_arama.Text = ts.ToString();
                    arama.adet = 0;
                    arama.sayac = 0;
                }
                else { MessageBox.Show("Dosya Boş!"); }
                
            }
            else
            {
                MessageBox.Show("Dosya okuma işlemi gerçekleşmedi ! Aranılacak dosyayı seçiniz");
             
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
            e.Handled = Char.IsPunctuation(e.KeyChar);
            e.Handled = Char.IsControl(e.KeyChar);
             e.Handled=!Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) { }

        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            txt_text.Text = "GCATCGCAGAGAGTATACAGTACG";
            comboBox1.Text = "GCAGAGAG";
            lbl_adet.Text = "adet";
            lbl_arama.Text = "aramasuresi";
            lbl_karsilasma.Text = "karsilasma";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string dizin = txt_text.Text;

            string[] bolumler = dizin.Split(' ');
            foreach (string bolum in bolumler)
            {
                comboBox1.Items.Add(bolum);
            }
            arama.findAll(txt_text.Text, comboBox1.Text);
            richTextBox1.SelectedText = Environment.NewLine + arama.pat;
            richTextBox1.SelectedText = Environment.NewLine + arama.txt;
            string boslukEkle = new string(' ', arama.boslukSayisi);
            string boslukEklea = new string(' ', arama.alt);
            string boslukEklea2 = new string(' ', arama.alt2 + 1);
            string boslukEklea3 = new string(' ', arama.alt3);
            richTextBox1.SelectedText += Environment.NewLine + boslukEklea.ToString() + arama.txt;
            richTextBox1.SelectedText += Environment.NewLine + boslukEklea2.ToString() + arama.txt;
            richTextBox1.SelectedText += Environment.NewLine + boslukEkle.ToString() + arama.txt;
            richTextBox1.SelectedText += Environment.NewLine + boslukEkle.ToString() + boslukEklea3.ToString() + arama.txt;


            // arama.findAll("GCATCGCAGAGAGTATACAGTACGGCAGAGAG", "GCAGAGAG");
            lbl_adet.Text = arama.adet + " adet *" + comboBox1.Text + "*\n metinde bulunmaktadır";

            lbl_karsilasma.Text = arama.sayac.ToString() + " karşılaşma olmuştur";
            TimeSpan ts = arama.sw.Elapsed;
            lbl_arama.Text = ts.ToString();
            arama.adet = 0;
            arama.sayac = 0;
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
       
        


    }
}
