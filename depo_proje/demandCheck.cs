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
    public partial class demandCheck : Form
    {
        public demandCheck()
        {
            InitializeComponent();
        }

        private connectionString conn = new connectionString();

        private void dataGosterge()
        {
            OleDbDataAdapter adapt = new OleDbDataAdapter($"SELECT id,t_urun,t_urun_miktar,t_urun_birim,t_tarih FROM talepler where t_onay = 'Onaylanmadı'", conn.conn());
            DataSet dset = new DataSet();
            adapt.Fill(dset, "talepler");
            dTalepler.DataSource = dset.Tables["talepler"];
            conn.conn().Close();
            conn.conn().Close();
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
                OleDbCommand cmd = new OleDbCommand($"UPDATE talepler SET t_onay='Onaylandı' where id={dTalepler.Rows[rowIndex].Cells[2].Value.ToString()}", conn.conn());
                cmd.ExecuteNonQuery();
                conn.conn().Close();
                System.Threading.Thread.Sleep(750);
                dataGosterge();
            }

            if (dTalepler.Columns[e.ColumnIndex].Name == "reddet")
            {
                int rowIndex = dTalepler.CurrentCell.RowIndex;
                OleDbCommand cmd = new OleDbCommand($"UPDATE talepler SET t_onay='Reddedildi' where id={dTalepler.Rows[rowIndex].Cells[2].Value.ToString()}", conn.conn());
                cmd.ExecuteNonQuery();
                conn.conn().Close();
                System.Threading.Thread.Sleep(750);
                dataGosterge();
            }
        }
    }
}
