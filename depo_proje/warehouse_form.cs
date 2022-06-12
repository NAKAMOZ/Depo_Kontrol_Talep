using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SQLite;

namespace depo_proje
{
    public partial class warehouse_form : Form
    {
        public warehouse_form()
        {
            InitializeComponent();
        }

        private SQLiteConnection conn = new SQLiteConnection("Data Source = depo.db");
        private double sayfaSayi;
        private int bSayfa = 0, sayi = 1;

        private void dataGosterge(int a)
        {
            conn.Open();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter($"SELECT * FROM depo LIMIT 50 OFFSET {a}", conn);
            DataSet dset = new DataSet();
            adapt.Fill(dset, "info");
            dMalzemeler.DataSource = dset.Tables[0];
            conn.Close();
            dMalzemeler.Select();
        }

        private void warehouse_form_Load(object sender, EventArgs e)
        {
            dataGosterge(bSayfa);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand($"select count(*) from depo", conn);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                sayfaSayi = Math.Ceiling(Convert.ToDouble(rdr[0]) / 50);
            }
            sayfaLbl.Text = $"{sayi}/{sayfaSayi}";
            conn.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int rowIndex = dMalzemeler.CurrentCell.RowIndex;
                string rowID = dMalzemeler.Rows[rowIndex].Cells[0].Value.ToString();
                SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM depo WHERE id={rowID}", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGosterge(0);
            }
            catch
            {
                MessageBox.Show("Çıkartma İşlemi Başarısız!");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            wareAdd wAdd = new wareAdd();
            wAdd.Show();
        }

        private void mainButtons2_Click(object sender, EventArgs e)
        {
            dataGosterge(bSayfa);
        }

        private void mainButtons1_Click(object sender, EventArgs e)
        {
            wareEdit wEdit = new wareEdit();
            int rowIndex = dMalzemeler.CurrentCell.RowIndex;
            wEdit.urunId = dMalzemeler.Rows[rowIndex].Cells[0].Value.ToString();
            wEdit.urunIsim = dMalzemeler.Rows[rowIndex].Cells[1].Value.ToString();
            wEdit.urunMiktar = dMalzemeler.Rows[rowIndex].Cells[2].Value.ToString();
            wEdit.urunBirim = dMalzemeler.Rows[rowIndex].Cells[3].Value.ToString();
            wEdit.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                conn.Open();
                SQLiteDataAdapter adapt = new SQLiteDataAdapter($"SELECT * FROM depo WHERE urun LIKE '%{searchTxt.Text}%' OR id='{searchTxt.Text}';", conn);
                DataSet dset = new DataSet();
                adapt.Fill(dset, "info");
                dMalzemeler.DataSource = dset.Tables[0];
                conn.Close();
                dMalzemeler.Select();
            }
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            if (sayi != sayfaSayi)
            {
                bSayfa += 50;
                dataGosterge(bSayfa);
                sayi += 1;
                sayfaLbl.Text = $"{sayi}/{sayfaSayi}";
            }
        }

        private void backPageBtn_Click(object sender, EventArgs e)
        {
            if (bSayfa != 0)
            {
                bSayfa -= 50;
                dataGosterge(bSayfa);
                sayi -= 1;
                sayfaLbl.Text = $"{sayi}/{sayfaSayi}";
            }
        }
    }
}
