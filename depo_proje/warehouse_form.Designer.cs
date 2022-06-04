namespace depo_proje
{
    partial class warehouse_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.uyari = new System.Windows.Forms.Label();
            this.delBtn = new depo_proje.mainButtons();
            this.addBtn = new depo_proje.mainButtons();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dMalzemeler = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMalzemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.uyari);
            this.buttonPanel.Controls.Add(this.delBtn);
            this.buttonPanel.Controls.Add(this.addBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(920, 90);
            this.buttonPanel.TabIndex = 1;
            // 
            // uyari
            // 
            this.uyari.AutoSize = true;
            this.uyari.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.uyari.Location = new System.Drawing.Point(340, 32);
            this.uyari.Margin = new System.Windows.Forms.Padding(20);
            this.uyari.Name = "uyari";
            this.uyari.Size = new System.Drawing.Size(255, 27);
            this.uyari.TabIndex = 104;
            this.uyari.Text = "Çıkartma İşlemi Başarısız!";
            this.uyari.Visible = false;
            // 
            // delBtn
            // 
            this.delBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.delBtn.FlatAppearance.BorderSize = 3;
            this.delBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.delBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.delBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.delBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.delBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delBtn.IconSize = 44;
            this.delBtn.Location = new System.Drawing.Point(180, 20);
            this.delBtn.Margin = new System.Windows.Forms.Padding(20);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(120, 50);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Çıkart";
            this.delBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.addBtn.FlatAppearance.BorderSize = 3;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.addBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBtn.IconSize = 44;
            this.addBtn.Location = new System.Drawing.Point(20, 20);
            this.addBtn.Margin = new System.Windows.Forms.Padding(20);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 50);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Ekle";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dMalzemeler);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 90);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(920, 510);
            this.mainPanel.TabIndex = 2;
            // 
            // dMalzemeler
            // 
            this.dMalzemeler.AllowUserToAddRows = false;
            this.dMalzemeler.AllowUserToDeleteRows = false;
            this.dMalzemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dMalzemeler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dMalzemeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dMalzemeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dMalzemeler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dMalzemeler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dMalzemeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dMalzemeler.ColumnHeadersHeight = 35;
            this.dMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dMalzemeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.urunAdi,
            this.urunMiktar,
            this.urunBirim});
            this.dMalzemeler.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dMalzemeler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dMalzemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dMalzemeler.EnableHeadersVisualStyles = false;
            this.dMalzemeler.Location = new System.Drawing.Point(0, 0);
            this.dMalzemeler.Name = "dMalzemeler";
            this.dMalzemeler.ReadOnly = true;
            this.dMalzemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dMalzemeler.Size = new System.Drawing.Size(920, 510);
            this.dMalzemeler.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // urunAdi
            // 
            this.urunAdi.DataPropertyName = "urun";
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // urunMiktar
            // 
            this.urunMiktar.DataPropertyName = "miktar";
            this.urunMiktar.HeaderText = "Ürün Miktarı";
            this.urunMiktar.Name = "urunMiktar";
            this.urunMiktar.ReadOnly = true;
            // 
            // urunBirim
            // 
            this.urunBirim.DataPropertyName = "birim";
            this.urunBirim.HeaderText = "Ürün Birimi";
            this.urunBirim.Name = "urunBirim";
            this.urunBirim.ReadOnly = true;
            // 
            // warehouse_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.buttonPanel);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "warehouse_form";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.warehouse_form_Load);
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dMalzemeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel mainPanel;
        private mainButtons delBtn;
        private mainButtons addBtn;
        private System.Windows.Forms.DataGridView dMalzemeler;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirim;
        private System.Windows.Forms.Label uyari;
    }
}