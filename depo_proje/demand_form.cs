using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace depo_proje
{
    public partial class demand_form : Form
    {
        public demand_form()
        {
            InitializeComponent();
        }

        private SQLiteConnection conn = new SQLiteConnection(@"Data Source = depo.db");

        private void dataGosterge()
        {
            conn.Open();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("SELECT id,t_urun,t_urun_miktar,t_urun_birim,strftime('%H:%M %d/%m/%Y',t_tarih) t_tarih,iif(t_onay==1,'Onaylandı',iif(t_onay==0,'Onaylanmadı','Reddedildi')) t_onay FROM talepler where gorunurluk = 1", conn);
            DataSet dset = new DataSet();
            adapt.Fill(dset, "info");
            dMalzemeler.DataSource = dset.Tables[0];
            conn.Close();
            dMalzemeler.Select();
        }

        private void demand_form_Load(object sender, EventArgs e)
        {
            dataGosterge();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int rowIndex = dMalzemeler.CurrentCell.RowIndex;
                string rowID = dMalzemeler.Rows[rowIndex].Cells[0].Value.ToString();
                SQLiteCommand cmd = new SQLiteCommand($"UPDATE talepler SET gorunurluk=0 WHERE id={rowID}", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGosterge();
            }
            catch
            {
                MessageBox.Show("Çıkartma İşlemi Başarısız!");
            }
        }

        private void mainButtons2_Click(object sender, EventArgs e)
        {
            dataGosterge();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                conn.Open();
                SQLiteDataAdapter adapt = new SQLiteDataAdapter($"SELECT id,t_urun,t_urun_miktar,t_urun_birim,strftime('%H:%M %d/%m/%Y',t_tarih) t_tarih,iif(t_onay==1,'Onaylandı',iif(t_onay==0,'Onaylanmadı','Reddedildi')) t_onay FROM talepler WHERE (t_urun LIKE '%{searchTxt.Text}%' OR id='{searchTxt.Text}') AND gorunurluk=1;", conn);
                DataSet dset = new DataSet();
                adapt.Fill(dset, "info");
                dMalzemeler.DataSource = dset.Tables[0];
                conn.Close();
                dMalzemeler.Select();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            demandAdd dAdd = new demandAdd();
            dAdd.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dMalzemeler.CurrentCell.RowIndex;
            demandEdit dEdit = new demandEdit();
            dEdit.urunId = dMalzemeler.Rows[rowIndex].Cells[0].Value.ToString();
            dEdit.urunIsim = dMalzemeler.Rows[rowIndex].Cells[1].Value.ToString();
            dEdit.urunMiktar = dMalzemeler.Rows[rowIndex].Cells[2].Value.ToString();
            dEdit.urunBirim = dMalzemeler.Rows[rowIndex].Cells[3].Value.ToString();
            dEdit.Show();
        }
    }
}
