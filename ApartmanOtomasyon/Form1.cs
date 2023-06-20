using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyon
{
    public partial class Form1 : Form
    {
        /*
         * 3 Formdan olusan bir apartman otomasyonu gelistirin.Programi bir apartmanin yoneticisi kullanacak sekilde dusunebirsimiz.

            Ana Ekran Formu
            Ana ekranda navigasyon icin 2 kotrol ekleyin.Burada Gelirler ve Giderler formlarina gecis yapilabilsin.

            Gelirler Formu
            Her daire yoneticiye aylik olarak aidat odemektedir.Bu aidatlari kaydedebilecegimiz bir yeni aidat formu ekleyin.
            Hnagi dairenin hangi tarihte ne kadar odeme yaptigini da bu ekrandan takip edebilelim.Program acilip kapandiginda eski bilgileri ekranda gorebilelim.

            Giderler Formu
            Apartmanin zaman zaman masraflari olmaktadir.Yeni maasraf kaydini bu ekrandan ekleyebilelim 
            ve onceki masraflari goruntuleyebilelim.Program kapatip acildiginda bilgiler kaybolmamali.

         */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGelirler_Click(object sender, EventArgs e)
        {
            new Gelirler().Show();
        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            new Giderler().Show();
        }
    }
}
