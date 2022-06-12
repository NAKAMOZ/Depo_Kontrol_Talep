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
    public partial class demandAdd : Form
    {
        public demandAdd()
        {
            InitializeComponent();
        }
        bool drag = false;
        Point start_point = new Point(0, 0);
        private connectionString conn = new connectionString();

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

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

        private void demandAdd_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (urunName.Text != "" && miktarNum.Text != "0" && birimCmb.Text != "")
            {
                try
                {
                    OleDbCommand addCommand = new OleDbCommand($"INSERT INTO talepler (t_urun, t_urun_miktar, t_urun_birim, t_tarih, t_onay) values('{urunName.Text}',{miktarNum.Text},'{birimCmb.Text}',Now(),'Onaylanmadı');", conn.conn());
                    addCommand.ExecuteNonQuery();
                    conn.conn().Close();
                    uyari.Visible = true;
                    uyari.Text = "Talep İşlemi Başarılı!";
                    uyari.Location = new Point(107, 475);
                    uyari.ForeColor = Color.FromArgb(0, 173, 181);
                    urunName.Text = "";
                    miktarNum.Text = "0";
                    birimCmb.Text = "";
                }
                catch
                {
                    uyari.Text = "Talep İşlemi Başarısız!";
                    uyari.Location = new Point(101, 475);
                    uyari.ForeColor = Color.FromArgb(215, 35, 35);
                    uyari.Visible = true;
                }
            }
            else
            {
                uyari.Text = "Talep İşlemi Başarısız!";
                uyari.Location = new Point(101, 475);
                uyari.ForeColor = Color.FromArgb(215, 35, 35);
                uyari.Visible = true;
            }
        }
    }
}
