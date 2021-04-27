using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// C# ile girilen bir cümle ya da metnin içindeki kelimeleri ayırma ve ayrılan bu kelimelerin cümle içinde kaç kere tekrarlandığını bulma işlemi
namespace WinFormSample3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string cumle;
            string[] kelimeler;
            List<string> tekil = new List<string>();
            cumle = richTextBox1.Text;
            cumle = cumle.ToLower();
            cumle = cumle.Replace(",", "").Replace(":", "").Replace(".", "").Replace(";", "");
            kelimeler = cumle.Split(' ');

            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (tekil.Contains(kelimeler[i]) == false)
                {
                    tekil.Add(kelimeler[i]);
                }
            }

            foreach (string k in tekil)
            {
                int sayac = 0;
                for (int i = 0; i < kelimeler.Length; i++)
                {
                    if (kelimeler[i] == k)
                    {
                        sayac++;
                    }
                }
                listBox1.Items.Add(k + ">>>>>>  " + sayac + " adet");
            }

        }
    }
}
