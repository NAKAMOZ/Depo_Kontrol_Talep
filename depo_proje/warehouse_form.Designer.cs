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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.mainButtons2 = new depo_proje.mainButtons();
            this.editBtn = new depo_proje.mainButtons();
            this.delBtn = new depo_proje.mainButtons();
            this.addBtn = new depo_proje.mainButtons();
            this.dMalzemeler = new System.Windows.Forms.DataGridView();
            this.urunBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new depo_proje.mainButtons();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMalzemeler)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.searchBtn);
            this.buttonPanel.Controls.Add(this.searchTxt);
            this.buttonPanel.Controls.Add(this.mainButtons2);
            this.buttonPanel.Controls.Add(this.editBtn);
            this.buttonPanel.Controls.Add(this.delBtn);
            this.buttonPanel.Controls.Add(this.addBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(920, 70);
            this.buttonPanel.TabIndex = 1;
            // 
            // mainButtons2
            // 
            this.mainButtons2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainButtons2.FlatAppearance.BorderSize = 3;
            this.mainButtons2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.mainButtons2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButtons2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainButtons2.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.mainButtons2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.mainButtons2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mainButtons2.IconSize = 44;
            this.mainButtons2.Location = new System.Drawing.Point(444, 10);
            this.mainButtons2.Margin = new System.Windows.Forms.Padding(10);
            this.mainButtons2.Name = "mainButtons2";
            this.mainButtons2.Size = new System.Drawing.Size(120, 50);
            this.mainButtons2.TabIndex = 106;
            this.mainButtons2.Text = "Yenile";
            this.mainButtons2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainButtons2.UseVisualStyleBackColor = true;
            this.mainButtons2.Click += new System.EventHandler(this.mainButtons2_Click);
            // 
            // editBtn
            // 
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.editBtn.FlatAppearance.BorderSize = 3;
            this.editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.editBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.IconSize = 44;
            this.editBtn.Location = new System.Drawing.Point(150, 10);
            this.editBtn.Margin = new System.Windows.Forms.Padding(10);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(134, 50);
            this.editBtn.TabIndex = 105;
            this.editBtn.Text = "Düzenle";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.mainButtons1_Click);
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
            this.delBtn.Location = new System.Drawing.Point(304, 10);
            this.delBtn.Margin = new System.Windows.Forms.Padding(10);
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
            this.addBtn.Location = new System.Drawing.Point(10, 10);
            this.addBtn.Margin = new System.Windows.Forms.Padding(10);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 50);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Ekle";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dMalzemeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dMalzemeler.ColumnHeadersHeight = 35;
            this.dMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dMalzemeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.urunAdi,
            this.urunMiktar,
            this.urunBirim});
            this.dMalzemeler.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dMalzemeler.DefaultCellStyle = dataGridViewCellStyle6;
            this.dMalzemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dMalzemeler.EnableHeadersVisualStyles = false;
            this.dMalzemeler.Location = new System.Drawing.Point(0, 0);
            this.dMalzemeler.Name = "dMalzemeler";
            this.dMalzemeler.ReadOnly = true;
            this.dMalzemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dMalzemeler.Size = new System.Drawing.Size(920, 530);
            this.dMalzemeler.TabIndex = 0;
            // 
            // urunBirim
            // 
            this.urunBirim.DataPropertyName = "birim";
            this.urunBirim.HeaderText = "Ürün Birimi";
            this.urunBirim.Name = "urunBirim";
            this.urunBirim.ReadOnly = true;
            // 
            // urunMiktar
            // 
            this.urunMiktar.DataPropertyName = "miktar";
            this.urunMiktar.HeaderText = "Ürün Miktarı";
            this.urunMiktar.Name = "urunMiktar";
            this.urunMiktar.ReadOnly = true;
            // 
            // urunAdi
            // 
            this.urunAdi.DataPropertyName = "urun";
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dMalzemeler);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(920, 530);
            this.mainPanel.TabIndex = 2;
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxt.Font = new System.Drawing.Font("Open Sans", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.searchTxt.Location = new System.Drawing.Point(594, 10);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(259, 50);
            this.searchTxt.TabIndex = 107;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.searchBtn.FlatAppearance.BorderSize = 3;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 44;
            this.searchBtn.Location = new System.Drawing.Point(851, 10);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(2, 7, 0, 0);
            this.searchBtn.Size = new System.Drawing.Size(50, 50);
            this.searchBtn.TabIndex = 108;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dMalzemeler)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel buttonPanel;
        private mainButtons delBtn;
        private mainButtons addBtn;
        private mainButtons mainButtons2;
        private mainButtons editBtn;
        private System.Windows.Forms.DataGridView dMalzemeler;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirim;
        private System.Windows.Forms.Panel mainPanel;
        private mainButtons searchBtn;
        private System.Windows.Forms.TextBox searchTxt;
    }
}