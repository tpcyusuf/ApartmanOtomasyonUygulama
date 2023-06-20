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
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }

        SqlHelper helper = new SqlHelper();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int daireNo = Convert.ToInt32(cmbDaireNo.Text);
            int para = (int)nudTutar.Value;
            DateTime tarih = dtTarih.Value;

            SqlParameter p1 = new SqlParameter("DaireNo", daireNo); // "DaireNo" icinde yazan ifade ile SQL de @DaireNo ayni olmak zorunda
            SqlParameter p2 = new SqlParameter("Para", para);  // "Para" icinde yazan ifade ile SQL de @Para ayni olmak zorunda
            SqlParameter p3 = new SqlParameter("Tarih", tarih);  // "Tarih" icinde yazan ifade ile SQL de @Tarih ayni olmak zorunda

            helper.ExecuteProcedure("sp_Aidat",p1,p2,p3);

        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable dtGelirler = helper.GetTable("select * from AidatOdemesi");
            foreach (DataRow row in dtGelirler.Rows)
            {
                listBox1.Items.Add(row["DaireNo"]).ToString();
                listBox2.Items.Add(row["Para"]).ToString();
                listBox3.Items.Add(row["Tarih"]).ToString();
            }
        }
    }
}
