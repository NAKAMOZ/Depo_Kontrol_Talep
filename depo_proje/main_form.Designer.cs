namespace depo_proje
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimaze = new FontAwesome.Sharp.IconButton();
            this.maximaze = new FontAwesome.Sharp.IconButton();
            this.close = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.onayBtn = new FontAwesome.Sharp.IconButton();
            this.clear = new FontAwesome.Sharp.IconButton();
            this.islembtn = new FontAwesome.Sharp.IconButton();
            this.talepbtn = new FontAwesome.Sharp.IconButton();
            this.depobtn = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.isimbtn = new System.Windows.Forms.Button();
            this.yetkibtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.minimaze);
            this.panel1.Controls.Add(this.maximaze);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 30);
            this.panel1.TabIndex = 102;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimaze
            // 
            this.minimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimaze.FlatAppearance.BorderSize = 0;
            this.minimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.minimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.minimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimaze.Font = new System.Drawing.Font("Open Sans Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minimaze.ForeColor = System.Drawing.Color.Gray;
            this.minimaze.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimaze.IconColor = System.Drawing.Color.Gray;
            this.minimaze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimaze.IconSize = 18;
            this.minimaze.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimaze.Location = new System.Drawing.Point(970, 0);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(50, 30);
            this.minimaze.TabIndex = 107;
            this.minimaze.UseVisualStyleBackColor = true;
            this.minimaze.Click += new System.EventHandler(this.minimaze_Click_1);
            this.minimaze.MouseEnter += new System.EventHandler(this.minimaze_MouseEnter);
            this.minimaze.MouseLeave += new System.EventHandler(this.minimaze_MouseLeave);
            // 
            // maximaze
            // 
            this.maximaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximaze.FlatAppearance.BorderSize = 0;
            this.maximaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.maximaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.maximaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximaze.Font = new System.Drawing.Font("Open Sans Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maximaze.ForeColor = System.Drawing.Color.Gray;
            this.maximaze.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximaze.IconColor = System.Drawing.Color.Gray;
            this.maximaze.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximaze.IconSize = 18;
            this.maximaze.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.maximaze.Location = new System.Drawing.Point(1020, 0);
            this.maximaze.Name = "maximaze";
            this.maximaze.Size = new System.Drawing.Size(50, 30);
            this.maximaze.TabIndex = 104;
            this.maximaze.UseVisualStyleBackColor = true;
            this.maximaze.Click += new System.EventHandler(this.maximaze_Click_1);
            this.maximaze.MouseEnter += new System.EventHandler(this.maximaze_MouseEnter);
            this.maximaze.MouseLeave += new System.EventHandler(this.maximaze_MouseLeave);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Open Sans Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close.ForeColor = System.Drawing.Color.Gray;
            this.close.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.close.IconColor = System.Drawing.Color.Gray;
            this.close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close.IconSize = 18;
            this.close.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.close.Location = new System.Drawing.Point(1070, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 30);
            this.close.TabIndex = 108;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.onayBtn);
            this.panelMenu.Controls.Add(this.clear);
            this.panelMenu.Controls.Add(this.islembtn);
            this.panelMenu.Controls.Add(this.talepbtn);
            this.panelMenu.Controls.Add(this.depobtn);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 600);
            this.panelMenu.TabIndex = 103;
            // 
            // onayBtn
            // 
            this.onayBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.onayBtn.FlatAppearance.BorderSize = 0;
            this.onayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.onayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.onayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onayBtn.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayBtn.ForeColor = System.Drawing.Color.White;
            this.onayBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.onayBtn.IconColor = System.Drawing.Color.White;
            this.onayBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.onayBtn.IconSize = 36;
            this.onayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onayBtn.Location = new System.Drawing.Point(0, 202);
            this.onayBtn.Name = "onayBtn";
            this.onayBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.onayBtn.Size = new System.Drawing.Size(200, 40);
            this.onayBtn.TabIndex = 111;
            this.onayBtn.Text = "Talep Onay";
            this.onayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.onayBtn.UseVisualStyleBackColor = true;
            this.onayBtn.Click += new System.EventHandler(this.onayBtn_Click);
            // 
            // clear
            // 
            this.clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.clear.IconColor = System.Drawing.Color.White;
            this.clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clear.IconSize = 36;
            this.clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear.Location = new System.Drawing.Point(0, 560);
            this.clear.Name = "clear";
            this.clear.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.clear.Size = new System.Drawing.Size(200, 40);
            this.clear.TabIndex = 110;
            this.clear.Text = "Sıfırla";
            this.clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // islembtn
            // 
            this.islembtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.islembtn.FlatAppearance.BorderSize = 0;
            this.islembtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.islembtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.islembtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islembtn.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islembtn.ForeColor = System.Drawing.Color.White;
            this.islembtn.IconChar = FontAwesome.Sharp.IconChar.History;
            this.islembtn.IconColor = System.Drawing.Color.White;
            this.islembtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.islembtn.IconSize = 36;
            this.islembtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.islembtn.Location = new System.Drawing.Point(0, 162);
            this.islembtn.Name = "islembtn";
            this.islembtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.islembtn.Size = new System.Drawing.Size(200, 40);
            this.islembtn.TabIndex = 109;
            this.islembtn.Text = "İşlemler";
            this.islembtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.islembtn.UseVisualStyleBackColor = true;
            this.islembtn.Click += new System.EventHandler(this.islembtn_Click);
            // 
            // talepbtn
            // 
            this.talepbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.talepbtn.FlatAppearance.BorderSize = 0;
            this.talepbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.talepbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.talepbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.talepbtn.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepbtn.ForeColor = System.Drawing.Color.White;
            this.talepbtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.talepbtn.IconColor = System.Drawing.Color.White;
            this.talepbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.talepbtn.IconSize = 36;
            this.talepbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.talepbtn.Location = new System.Drawing.Point(0, 122);
            this.talepbtn.Name = "talepbtn";
            this.talepbtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.talepbtn.Size = new System.Drawing.Size(200, 40);
            this.talepbtn.TabIndex = 108;
            this.talepbtn.Text = "Talepler";
            this.talepbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.talepbtn.UseVisualStyleBackColor = true;
            this.talepbtn.Click += new System.EventHandler(this.talepbtn_Click);
            // 
            // depobtn
            // 
            this.depobtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.depobtn.FlatAppearance.BorderSize = 0;
            this.depobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.depobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.depobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depobtn.Font = new System.Drawing.Font("Open Sans ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.depobtn.ForeColor = System.Drawing.Color.White;
            this.depobtn.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.depobtn.IconColor = System.Drawing.Color.White;
            this.depobtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.depobtn.IconSize = 36;
            this.depobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depobtn.Location = new System.Drawing.Point(0, 82);
            this.depobtn.Name = "depobtn";
            this.depobtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.depobtn.Size = new System.Drawing.Size(200, 40);
            this.depobtn.TabIndex = 107;
            this.depobtn.Text = "Depo";
            this.depobtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.depobtn.UseVisualStyleBackColor = true;
            this.depobtn.Click += new System.EventHandler(this.depobtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel5.Controls.Add(this.isimbtn);
            this.panel5.Controls.Add(this.yetkibtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 80);
            this.panel5.TabIndex = 104;
            // 
            // isimbtn
            // 
            this.isimbtn.Enabled = false;
            this.isimbtn.FlatAppearance.BorderSize = 0;
            this.isimbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isimbtn.ForeColor = System.Drawing.Color.Black;
            this.isimbtn.Location = new System.Drawing.Point(0, 0);
            this.isimbtn.Name = "isimbtn";
            this.isimbtn.Size = new System.Drawing.Size(200, 40);
            this.isimbtn.TabIndex = 107;
            this.isimbtn.Text = "İsim";
            this.isimbtn.UseVisualStyleBackColor = true;
            // 
            // yetkibtn
            // 
            this.yetkibtn.Enabled = false;
            this.yetkibtn.FlatAppearance.BorderSize = 0;
            this.yetkibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yetkibtn.ForeColor = System.Drawing.Color.Black;
            this.yetkibtn.Location = new System.Drawing.Point(0, 40);
            this.yetkibtn.Name = "yetkibtn";
            this.yetkibtn.Size = new System.Drawing.Size(200, 40);
            this.yetkibtn.TabIndex = 108;
            this.yetkibtn.Text = "Yetki";
            this.yetkibtn.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 105;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 104;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 30);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(920, 600);
            this.panelDesktop.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(253, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 105);
            this.label2.TabIndex = 2;
            this.label2.Text = "Depo Kontrol ve Takip Sistemine\r\n\r\nHoş Geldiniz!\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(375, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "SASKİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::depo_proje.Properties.Resources.Artboard_1_copy;
            this.pictureBox1.Location = new System.Drawing.Point(385, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1120, 630);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Open Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1136, 646);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.main_form_Load);
            this.SizeChanged += new System.EventHandler(this.main_form_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button isimbtn;
        private System.Windows.Forms.Button yetkibtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton minimaze;
        private FontAwesome.Sharp.IconButton maximaze;
        private FontAwesome.Sharp.IconButton depobtn;
        private FontAwesome.Sharp.IconButton talepbtn;
        private FontAwesome.Sharp.IconButton islembtn;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton clear;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton onayBtn;
    }
}