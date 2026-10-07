using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ilkSayi = 0;
        string islem = "";
        bool yeniSayi = true;


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SayiTiklandi(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (yeniSayi)
            {
                textBox1.Text = "";
                yeniSayi = false;
            }

            textBox1.Text += btn.Text;
        }

        private void IslemTiklandi(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            ilkSayi = Convert.ToDouble(textBox1.Text);
            islem = btn.Text;
            yeniSayi = true;
        }
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(textBox1.Text);
            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = ilkSayi + ikinciSayi;
                    break;

                case "-":
                    sonuc = ilkSayi - ikinciSayi;
                    break;

                case "*":
                    sonuc = ilkSayi * ikinciSayi;
                    break;

                case "/":
                    if (ikinciSayi == 0)
                    {
                        MessageBox.Show("Sıfıra bölme yapılamaz!");
                        return;
                    }

                    sonuc = ilkSayi / ikinciSayi;
                    break;
            }

            textBox1.Text = sonuc.ToString();
            yeniSayi = true;
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            ilkSayi = 0;
            islem = "";
            yeniSayi = true;
        }
        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (yeniSayi)
            {
                textBox1.Text = "0";
                yeniSayi = false;
            }

            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }
        private void btnYuzde_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);

            sayi = sayi / 100;

            textBox1.Text = sayi.ToString();
        }





    }
}
