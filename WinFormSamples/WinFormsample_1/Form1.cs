using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // txt dosyaları okumak için çağrılan kütüphane

namespace WinFormsample_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String satir = ""; // boş bir değişken oluşturuldu
            StreamReader sr = new StreamReader("sinavlar.txt"); //var olan txt dosyasını yönlendirdik
            while (true) // döngü oluşturuldu
            {
                satir = sr.ReadLine(); // satiri kütüphanaye eşitledik

                if (satir == null) // eğer boşsa break methodunu çağırdık
                {
                    break;
                }
                listBox1.Items.Add(satir); // listbox1 e satırları ekledik (txt dosyasındaki elemanları)
                String[] notlar = satir.Split(' '); // notlar string arrayıni oluşturup değer olarak satirin içerindeki boşluk değerlerini ayırdık 
                double ort = 0.4 * Convert.ToDouble(notlar[1]) + 0.6 * Convert.ToDouble(notlar[2]); // notlar[1] notun ilk kısmı notlar[2] ikinci not ve bunların ortalamasını aldık 
                listBox2.Items.Add(notlar[0] + "\t" + " : " + ort); // listbox2 ye sonucları yazdırdık
            }
            sr.Close(); // okumayı kapattık;
        }
    }
}
