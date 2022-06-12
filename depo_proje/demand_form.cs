using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace depo_proje
{
    public partial class demand_form : Form
    {
        public demand_form()
        {
            InitializeComponent();
        }

        private connectionString conn = new connectionString();

        private void dataGosterge()
        {
            OleDbDataAdapter adapt = new OleDbDataAdapter($"SELECT id,t_urun,t_urun_miktar,t_urun_birim,t_tarih,t_onay FROM talepler", conn.conn());
            DataSet dset = new DataSet();
            adapt.Fill(dset, "talepler");
            dMalzemeler.DataSource = dset.Tables["talepler"];
            conn.conn().Close();
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
                int rowIndex = dMalzemeler.CurrentCell.RowIndex;
                string rowID = dMalzemeler.Rows[rowIndex].Cells[0].Value.ToString();
                OleDbCommand cmd = new OleDbCommand($"DELETE FROM talepler WHERE id={rowID}", conn.conn());
                cmd.ExecuteNonQuery();
                conn.conn().Close();
                System.Threading.Thread.Sleep(750);
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
                OleDbDataAdapter adapt = new OleDbDataAdapter($"SELECT * from talepler where t_urun like '%{searchTxt.Text}%' or id like '%{searchTxt.Text}%'", conn.conn());
                DataSet dset = new DataSet();
                adapt.Fill(dset, "talepler");
                dMalzemeler.DataSource = dset.Tables["talepler"];
                conn.conn().Close();
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
