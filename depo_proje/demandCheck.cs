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
    public partial class demandCheck : Form
    {
        public demandCheck()
        {
            InitializeComponent();
        }

        private SQLiteConnection conn = new SQLiteConnection("Data Source = depo.db");

        private void dataGosterge()
        {
            conn.Open();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter($"SELECT id,t_urun,t_urun_miktar,t_urun_birim,strftime('%H:%M %d/%m/%Y',t_tarih) t_tarih FROM talepler where t_onay = 0", conn);
            DataSet dset = new DataSet();
            adapt.Fill(dset, "info");
            dTalepler.DataSource = dset.Tables[0];
            conn.Close();
        }

        private void demandCheck_Load(object sender, EventArgs e)
        {
            dataGosterge();
        }

        private void dTalepler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dTalepler.Columns[e.ColumnIndex].Name == "onay")
            {
                int rowIndex = dTalepler.CurrentCell.RowIndex;
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"UPDATE talepler SET t_onay=1 where id={dTalepler.Rows[rowIndex].Cells[2].Value.ToString()}", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGosterge();
            }

            if (dTalepler.Columns[e.ColumnIndex].Name == "reddet")
            {
                int rowIndex = dTalepler.CurrentCell.RowIndex;
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"UPDATE talepler SET t_onay=2 where id={dTalepler.Rows[rowIndex].Cells[2].Value.ToString()}", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGosterge();
            }
        }
    }
}
