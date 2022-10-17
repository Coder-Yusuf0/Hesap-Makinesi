using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        private char _işlem;// 
        private bool _ekrantemizlenecek;//Değişkenler tanımlanıyor.
        private int _ilksayı;//
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tuş1_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "1";//buttona her tıklandığında ekrana rakamı ekler
            }

        }

        private void tuş2_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "2";//buttona her tıklandığında ekrana rakamı ekler
            }
        }

        private void tuş3_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "3";//buttona her tıklandığında ekrana rakamı ekler
            }
        }

        private void tuş4_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "4";//buttona her tıklandığında ekrana rakamı ekler
            }
        }

        private void tuş5_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "5";//buttona her tıklandığında ekrana rakamı ekler
            }
        }

        private void tuş6_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "6";//buttona her tıklandığında ekrana rakamı ekler
            }
        }

        private void tuş7_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "7";
            }
        }

        private void tuş8_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "8";//buttona her tıklandığında ekrana rakamı ekler
            }
        }

        private void tuş9_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "9";//buttona her tıklandığında ekrana rakamı ekler
            }
        }

        private void tuş0_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";//ekran da 0 yazıyorsa 0 'ı sil
            {
                ekranlabel.Text += "0";//buttona her tıklandığında ekrana rakamı ekler
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "";///Button a tıklandığında ekranı temizler
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            _işlem = "+";//+ ya basılınca toplar
            _ekrantemizlenecek = true;//sayıları ekrandan kaldırır ve işlemi yapıcağı diğer sayılara geçer
            _ilksayı = Convert.ToInt32(ekranlabel.Text);//ekrandaki sayıları  kaydeder.
        }
    }
}
