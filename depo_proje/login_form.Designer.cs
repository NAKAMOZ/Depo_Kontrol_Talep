namespace depo_proje
{
    partial class login_form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.exit = new System.Windows.Forms.Button();
            this.giristxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pwordtxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.hata = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainButtons1 = new depo_proje.mainButtons();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Open Sans Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(370, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 30);
            this.exit.TabIndex = 100;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            this.exit.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // giristxt
            // 
            this.giristxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.giristxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.giristxt.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giristxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.giristxt.Location = new System.Drawing.Point(128, 340);
            this.giristxt.Name = "giristxt";
            this.giristxt.Size = new System.Drawing.Size(240, 22);
            this.giristxt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(50, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 2);
            this.panel1.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(48, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 99;
            this.label1.Text = "Giriş Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(48, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 98;
            this.label2.Text = "Şifre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(51, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 2);
            this.panel2.TabIndex = 99;
            // 
            // pwordtxt
            // 
            this.pwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwordtxt.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwordtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pwordtxt.Location = new System.Drawing.Point(128, 396);
            this.pwordtxt.Name = "pwordtxt";
            this.pwordtxt.PasswordChar = '*';
            this.pwordtxt.Size = new System.Drawing.Size(240, 22);
            this.pwordtxt.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // hata
            // 
            this.hata.AutoSize = true;
            this.hata.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata.Location = new System.Drawing.Point(105, 540);
            this.hata.Margin = new System.Windows.Forms.Padding(20);
            this.hata.Name = "hata";
            this.hata.Size = new System.Drawing.Size(211, 27);
            this.hata.TabIndex = 103;
            this.hata.Text = "Giriş İşlemi Başarısız!";
            this.hata.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.exit);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 30);
            this.panel3.TabIndex = 104;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // mainButtons1
            // 
            this.mainButtons1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainButtons1.FlatAppearance.BorderSize = 3;
            this.mainButtons1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.mainButtons1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButtons1.Font = new System.Drawing.Font("Rubik", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainButtons1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainButtons1.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.mainButtons1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainButtons1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mainButtons1.IconSize = 45;
            this.mainButtons1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainButtons1.Location = new System.Drawing.Point(51, 459);
            this.mainButtons1.Margin = new System.Windows.Forms.Padding(20);
            this.mainButtons1.Name = "mainButtons1";
            this.mainButtons1.Size = new System.Drawing.Size(318, 51);
            this.mainButtons1.TabIndex = 105;
            this.mainButtons1.Text = "Giriş Yap";
            this.mainButtons1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainButtons1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainButtons1.UseVisualStyleBackColor = true;
            this.mainButtons1.Click += new System.EventHandler(this.mainButtons1_Click);
            // 
            // login_form
            // 
            this.AcceptButton = this.mainButtons1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(420, 600);
            this.Controls.Add(this.mainButtons1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.hata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pwordtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.giristxt);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login_form";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox giristxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pwordtxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label hata;
        private System.Windows.Forms.Panel panel3;
        private mainButtons mainButtons1;
    }
}

