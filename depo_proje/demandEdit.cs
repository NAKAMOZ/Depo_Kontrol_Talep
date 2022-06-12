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
using System.Diagnostics.Eventing.Reader;

namespace depo_proje
{
    public partial class demandEdit : Form
    {
        public demandEdit()
        {
            InitializeComponent();
        }

        bool drag = false;
        Point start_point = new Point(0, 0);
        private SQLiteConnection conn = new SQLiteConnection(@"Data Source = depo.db");
        public string urunId, urunIsim, urunMiktar, urunBirim;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }

            Opacity += .2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                timer2.Stop();
                this.Close();
            }

            Opacity -= .2;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void demandEdit_Load(object sender, EventArgs e)
        {
            urunName.Text = urunIsim;
            miktarNum.Text = urunMiktar;
            birimCmb.Text = urunBirim;
            timer1.Start();
        }

        private void close_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void dragPnl_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void dragPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void dragPnl_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (miktarNum.Text != "0" && birimCmb.Text != "")
            {
                try
                {
                    conn.Open();
                    SQLiteCommand dEditCmd = new SQLiteCommand($"UPDATE talepler SET t_urun_miktar='{miktarNum.Text}',t_urun_birim='{birimCmb.Text}',t_tarih=datetime('now', 'localtime'),t_onay=0 where id={urunId}", conn);
                    dEditCmd.ExecuteNonQuery();
                    conn.Close();
                    uyari.Text = "Düzenleme İşlemi Başarılı!";
                    uyari.Location = new Point(80, 475);
                    uyari.ForeColor = Color.FromArgb(0, 173, 181);
                    uyari.Visible = true;
                    editButton.Enabled = false;
                    timer3.Start();
                }
                catch
                {
                    uyari.Text = "Düzenleme İşlemi Başarısız!";
                    uyari.Location = new Point(74, 475);
                    uyari.ForeColor = Color.FromArgb(215, 35, 35);
                    uyari.Visible = true;
                }
            }
            else
            {
                uyari.Text = "Düzenleme İşlemi Başarısız!";
                uyari.Location = new Point(74, 475);
                uyari.ForeColor = Color.FromArgb(215, 35, 35);
                uyari.Visible = true;
            }
        }
    }
}
