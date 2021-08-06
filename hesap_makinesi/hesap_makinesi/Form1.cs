using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HOŞGELDİNİZ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);//textboxa girilen bütün veriler program tarafından string halinde okunur.duoble'a dönüştürüyoruz.
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);//textboxa girilen bütün veriler program tarafından string halinde okunur.duoble'a dönüştürüyoruz.
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);//textboxa girilen bütün veriler program tarafından string halinde okunur.duoble'a dönüştürüyoruz.
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 / sayi2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);//textboxa girilen bütün veriler program tarafından string halinde okunur.duoble'a dönüştürüyoruz.
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
