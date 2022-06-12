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
    public partial class login_form : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public login_form()
        {
            InitializeComponent();
        }

        private connectionString conn = new connectionString();

        private void giris_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                timer1.Stop();
                Application.Exit();
            }

            Opacity -= .2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Stop();
            }

            Opacity += .2;
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

        private void mainButtons1_Click(object sender, EventArgs e)
        {
            string g_adi = giristxt.Text;
            string sifre = pwordtxt.Text;
            OleDbCommand cmd = new OleDbCommand($"SELECT * from calisanlar where k_adi='{g_adi}' and sifre='{sifre}'", conn.conn());
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                warehouse_form ware = new warehouse_form();
                main_form main = new main_form();
                main.isim = reader[1].ToString();
                main.yetki = reader[4].ToString();
                main.Show();
                this.Hide();
            }
            else
            {
                hata.Visible = true;
            }
            conn.conn().Close();
        }
    }
}
