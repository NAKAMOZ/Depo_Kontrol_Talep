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
using System.Data.OleDb;
using System.Data.SQLite;

namespace depo_proje
{
    public partial class warehouse_form : Form
    {
        public warehouse_form()
        {
            InitializeComponent();
        }

        private connectionString conn = new connectionString();

        private void dataGosterge()
        {
            OleDbDataAdapter adapt = new OleDbDataAdapter($"SELECT * from depo", conn.conn());
            DataSet dset = new DataSet();
            adapt.Fill(dset, "talepler");
            dMalzemeler.DataSource = dset.Tables["talepler"];
            conn.conn().Close();
            dMalzemeler.Select();
        }

        private void warehouse_form_Load(object sender, EventArgs e)
        {
            dataGosterge();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dMalzemeler.CurrentCell.RowIndex;
                string rowID = dMalzemeler.Rows[rowIndex].Cells[0].Value.ToString();
                OleDbCommand cmd = new OleDbCommand($"DELETE FROM depo WHERE id={rowID}", conn.conn());
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            wareAdd wAdd = new wareAdd();
            wAdd.Show();
        }

        private void mainButtons2_Click(object sender, EventArgs e)
        {
            dataGosterge();
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
                OleDbDataAdapter adapt = new OleDbDataAdapter($"SELECT * from depo where urun like '%{searchTxt.Text}%' or id like '%{searchTxt.Text}'", conn.conn());
                DataSet dset = new DataSet();
                adapt.Fill(dset, "talepler");
                dMalzemeler.DataSource = dset.Tables["talepler"];
                conn.conn().Close();
                dMalzemeler.Select();
            }
        }
    }
}
