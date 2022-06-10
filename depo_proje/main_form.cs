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
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace depo_proje
{
    public partial class main_form : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public main_form()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, depobtn.Size.Height);
            panelMenu.Controls.Add(leftBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void OpenChildForm(Form childFrom)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childFrom);
            panelDesktop.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = Color.FromArgb(20,255,236);
                currentBtn.Padding = new Padding(25, 0, 0, 0);
                currentBtn.IconColor = Color.FromArgb(20, 255, 236);
                leftBorderBtn.BackColor = Color.FromArgb(20, 255, 236);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.White;
                currentBtn.Padding = new Padding(15, 0, 0, 0);
                currentBtn.IconColor = Color.White;
            }
        }

        public string yetki, isim;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            isimbtn.Text = isim;
            yetkibtn.Text = yetki;
            if (yetki == null && isim == null)
            {
                isimbtn.Text = "isim";
                yetkibtn.Text = "yetki";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form login = new login_form();
            login.Show();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.IconColor = Color.White;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.IconColor = Color.Gray;
        }

        private void maximaze_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                maximaze.IconChar = IconChar.WindowRestore;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximaze.IconChar = IconChar.WindowMaximize;
            }
        }

        private void minimaze_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximaze_MouseEnter(object sender, EventArgs e)
        {
            maximaze.IconColor = Color.White;
        }

        private void maximaze_MouseLeave(object sender, EventArgs e)
        {
            maximaze.IconColor = Color.Gray;
        }

        private void minimaze_MouseEnter(object sender, EventArgs e)
        {
            minimaze.IconColor = Color.White;
        }

        private void minimaze_MouseLeave(object sender, EventArgs e)
        {
            minimaze.IconColor = Color.Gray;
        }

        private void depobtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new warehouse_form());
        }

        private void talepbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new demand_form());
        }

        private void islembtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void onayBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentChildForm.Close();
        }
    }
}
