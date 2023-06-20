using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyon
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }

        SqlHelper helper = new SqlHelper();
        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            int para = (int)nudGiderTutar.Value;
            DateTime giderTarih = dtGiderTarih.Value;
            string giderler = "";
            foreach (Control item in grpBoxGiderler.Controls)
            {
                if(item is CheckBox && ((CheckBox)item).Checked)
                {
                    giderler += "," + item.Text;  // GrupBox icinde tiklenmis her bir Checkbox in text ini al demis oluyoruz.
                }
            }

            giderler = giderler.Remove(0, 1); // Ustte dongude en basa koydugumuz virgul karakterinden kurtulmak icin sifirinci index dem 1 karakter remove et diyerek kurtuluyoruz.

            SqlParameter p1 = new SqlParameter("Gider", giderler);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", giderTarih);

            helper.ExecuteProcedure("sp_Giderlerim", p1, p2, p3);
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            DataTable dtGiderler = helper.GetTable("select * from GiderTablosu");
            foreach (DataRow item in dtGiderler.Rows)
            {
                listBox1.Items.Add(item["Gider"]).ToString();
                listBox2.Items.Add(item["Para"]).ToString();
                listBox3.Items.Add(item["Tarih"]).ToString();
            }
        }
    }
}
