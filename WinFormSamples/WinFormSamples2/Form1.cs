using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSamples2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = ""; // label2 ye boş değer verdik
            int sayac = 0; // bir sayaç oluşturduk ve değerine 0 verdik
            listBox1.Items.Clear(); // Her seferinde listbox temizlensin
            int x = Convert.ToInt32(textBox1.Text); // x değişkeni oluşturduk ve bunu textbox1'in text'inden aldık ve int 'e çevirdik ve x değişkinine atadık 
            if (x < 2) 
            {
                MessageBox.Show("Asal Sayı Bulunmadı. "); // eğer x  2'den küçükse MessageBox ile "Asal Sayı Bulunmadı" yazdırdık
            }
            else // eğer x > 2 den 
            {
                for (int i = 2; i <= x; i++) // for döngüsü oluşturduk ve i yi 2 ye eşitledik ve x i'den küçük eşit olarak ayarladık
                {
                    int kontrol = 0; // kontrol değişkeni oluşturduk
                    for (int j = 2; j < i; j++) // for döngüsü oluşturduk ve j değişkenine  2 verdik, j değişkeni i değişkeninden küçük olmalıdır dedik  
                    {
                        if (i % j == 0) // i nin j yere göre modu 0'a eşitse kontrolu 1 artırdık ve döngüden çıkardık
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol == 0) // eğer kontrol 0 ' a eşitse => listbox1'in ıtemına i yi ekledik ve sayaca +1 ekledik
                    {
                        listBox1.Items.Add(i);
                        sayac++;
                    }
                }
            }

            label2.Text = "1-" + x + " arası " + sayac + " adet asal sayı bulundu "; // label2 ye text ekledik
        }
    }
}
