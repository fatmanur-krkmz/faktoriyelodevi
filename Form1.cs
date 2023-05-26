using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktoriyelodevi
{
    public partial class İşlemler : Form
    {
        int sayi;
      
        public İşlemler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sayi = Convert.ToInt32(sayigirtextbox.Text);
            int fakt = 1;
            for(int i=1; sayi >= i; i++)
            {
                fakt *= i;
            }
            faktsonuctext.Text = fakt.ToString();
        }

        private void asalsayi_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 1; i <= sayi; i++)
            {
                
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                asalmitext.Text = "Evet.";
            }
            else
            {
                asalmitext.Text = "Hayır.";

            }
        }

        private void sayilar_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(sayigirtextbox.Text);
            int[] sayilar = new int[100];
            for (int i = 0; sayi >= i; i++)
            {
                
                sayilar[i] = i+1;
                
            }
            for (int a = 0; a < sayi; a++)
            {
                sayilargoster.Items.Add(sayilar[a]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sayigirtextbox.Clear();
            faktsonuctext.Clear();
            asalmitext.Clear();
            sayilargoster.Items.Clear();
            
        }
    }
}
