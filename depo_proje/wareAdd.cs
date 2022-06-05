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
    public partial class wareAdd : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        private SQLiteConnection baglanti = new SQLiteConnection(@"Data Source = depo.db");
        private List<string> urunList = new List<string>();
        public wareAdd()
        {
            InitializeComponent();
        }

        private void wareAdd_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            timer1.Start();
            SQLiteCommand cmd = new SQLiteCommand("SELECT urun FROM depo;", baglanti);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                urunName.Items.Add(reader[0].ToString());
                urunList.Add(reader[0].ToString());
            }
            baglanti.Close();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (urunName.Text != "" && miktarNum.Text != "0" && birimCmb.Text != "")
            {
                try
                {
                    SQLiteCommand insCommand = new SQLiteCommand($"INSERT INTO depo (urun,miktar,birim) VALUES('{urunName.Text}','{miktarNum.Text}','{birimCmb.Text}');", baglanti);
                    insCommand.ExecuteNonQuery();
                    uyari.Visible = true;
                    uyari.Text = "Kayıt İşlemi Başarılı!";
                    uyari.Location = new Point(108, 475);
                    uyari.ForeColor = Color.FromArgb(0, 173, 181);
                    urunName.Items.Clear();
                    SQLiteCommand cmbCommand = new SQLiteCommand("SELECT urun FROM depo;", baglanti);
                    SQLiteDataReader cmbReader = cmbCommand.ExecuteReader();
                    while (cmbReader.Read())
                    {
                        urunName.Items.Add(cmbReader[0].ToString());
                    }
                    urunName.Text = "";
                    miktarNum.Text = "0";
                    birimCmb.Text = "";
                }
                catch
                {
                    uyari.Text = "Kayıt İşlemi Başarısız!";
                    uyari.Location = new Point(102, 475);
                    uyari.ForeColor = Color.FromArgb(215, 35, 35);
                    uyari.Visible = true;
                }
            }
            baglanti.Close();
        }
    }
}
