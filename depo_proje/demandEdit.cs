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
    public partial class demandEdit : Form
    {
        public demandEdit()
        {
            InitializeComponent();
        }

        bool drag = false;
        Point start_point = new Point(0, 0);
        private SQLiteConnection conn = new SQLiteConnection(@"Data Source = depo.db");

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

        }
    }
}
