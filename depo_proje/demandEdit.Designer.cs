namespace depo_proje
{
    partial class demandEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demandEdit));
            this.urunName = new System.Windows.Forms.TextBox();
            this.miktarNum = new System.Windows.Forms.NumericUpDown();
            this.birimCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new depo_proje.mainButtons();
            this.dragPnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.editButton = new depo_proje.mainButtons();
            this.uyari = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.miktarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dragPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunName
            // 
            this.urunName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.urunName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urunName.Enabled = false;
            this.urunName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.urunName.Location = new System.Drawing.Point(141, 321);
            this.urunName.Name = "urunName";
            this.urunName.Size = new System.Drawing.Size(229, 22);
            this.urunName.TabIndex = 119;
            // 
            // miktarNum
            // 
            this.miktarNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.miktarNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miktarNum.Location = new System.Drawing.Point(141, 371);
            this.miktarNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.miktarNum.Name = "miktarNum";
            this.miktarNum.Size = new System.Drawing.Size(229, 25);
            this.miktarNum.TabIndex = 1;
            this.miktarNum.ThousandsSeparator = true;
            // 
            // birimCmb
            // 
            this.birimCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.birimCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.birimCmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.birimCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.birimCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.birimCmb.FormattingEnabled = true;
            this.birimCmb.Items.AddRange(new object[] {
            "Adet",
            "Kilogram",
            "Gram",
            "Litre"});
            this.birimCmb.Location = new System.Drawing.Point(141, 416);
            this.birimCmb.Name = "birimCmb";
            this.birimCmb.Size = new System.Drawing.Size(229, 31);
            this.birimCmb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(50, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 129;
            this.label3.Text = "Birimi";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(52, 450);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 2);
            this.panel4.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(50, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 127;
            this.label2.Text = "Miktarı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(52, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 2);
            this.panel2.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(50, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 125;
            this.label1.Text = "Ürün Adı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(52, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 2);
            this.panel1.TabIndex = 124;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.close.FlatAppearance.BorderSize = 3;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Open Sans Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.close.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close.IconSize = 44;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(251, 531);
            this.close.Margin = new System.Windows.Forms.Padding(10);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(150, 50);
            this.close.TabIndex = 4;
            this.close.Text = "Geri";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dragPnl
            // 
            this.dragPnl.BackColor = System.Drawing.Color.Transparent;
            this.dragPnl.Controls.Add(this.label4);
            this.dragPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPnl.Location = new System.Drawing.Point(0, 0);
            this.dragPnl.Margin = new System.Windows.Forms.Padding(5);
            this.dragPnl.Name = "dragPnl";
            this.dragPnl.Size = new System.Drawing.Size(420, 30);
            this.dragPnl.TabIndex = 132;
            this.dragPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPnl_MouseDown);
            this.dragPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPnl_MouseMove);
            this.dragPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPnl_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Open Sans Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Talep Düzenleme";
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
            // editButton
            // 
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.editButton.FlatAppearance.BorderSize = 3;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Open Sans Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.editButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.editButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editButton.IconSize = 44;
            this.editButton.Location = new System.Drawing.Point(19, 531);
            this.editButton.Margin = new System.Windows.Forms.Padding(10);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(154, 50);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Düzenle";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // uyari
            // 
            this.uyari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uyari.AutoSize = true;
            this.uyari.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.uyari.Location = new System.Drawing.Point(74, 475);
            this.uyari.Margin = new System.Windows.Forms.Padding(20);
            this.uyari.Name = "uyari";
            this.uyari.Size = new System.Drawing.Size(272, 27);
            this.uyari.TabIndex = 133;
            this.uyari.Text = "Düzenleme İşlemi Başarısız!";
            this.uyari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uyari.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // demandEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 600);
            this.Controls.Add(this.uyari);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.dragPnl);
            this.Controls.Add(this.urunName);
            this.Controls.Add(this.miktarNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.birimCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "demandEdit";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "demandEdit";
            this.Load += new System.EventHandler(this.demandEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miktarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dragPnl.ResumeLayout(false);
            this.dragPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urunName;
        private System.Windows.Forms.NumericUpDown miktarNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox birimCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private mainButtons close;
        private System.Windows.Forms.Panel dragPnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private mainButtons editButton;
        private System.Windows.Forms.Label uyari;
        private System.Windows.Forms.Timer timer3;
    }
}