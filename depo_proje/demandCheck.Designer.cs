namespace depo_proje
{
    partial class demandCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dTalepler = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reddet = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dTalepler)).BeginInit();
            this.SuspendLayout();
            // 
            // dTalepler
            // 
            this.dTalepler.AllowUserToAddRows = false;
            this.dTalepler.AllowUserToDeleteRows = false;
            this.dTalepler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dTalepler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dTalepler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dTalepler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dTalepler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dTalepler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dTalepler.ColumnHeadersHeight = 35;
            this.dTalepler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dTalepler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.urunAdi,
            this.urunMiktar,
            this.urunBirim,
            this.t_tarih,
            this.onay,
            this.reddet});
            this.dTalepler.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dTalepler.DefaultCellStyle = dataGridViewCellStyle16;
            this.dTalepler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTalepler.EnableHeadersVisualStyles = false;
            this.dTalepler.Location = new System.Drawing.Point(0, 0);
            this.dTalepler.Name = "dTalepler";
            this.dTalepler.ReadOnly = true;
            this.dTalepler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dTalepler.Size = new System.Drawing.Size(920, 600);
            this.dTalepler.TabIndex = 2;
            this.dTalepler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dTalepler_CellClick);
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
            this.urunAdi.DataPropertyName = "t_urun";
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // urunMiktar
            // 
            this.urunMiktar.DataPropertyName = "t_urun_miktar";
            this.urunMiktar.HeaderText = "Ürün Miktarı";
            this.urunMiktar.Name = "urunMiktar";
            this.urunMiktar.ReadOnly = true;
            // 
            // urunBirim
            // 
            this.urunBirim.DataPropertyName = "t_urun_birim";
            this.urunBirim.HeaderText = "Ürün Birimi";
            this.urunBirim.Name = "urunBirim";
            this.urunBirim.ReadOnly = true;
            // 
            // t_tarih
            // 
            this.t_tarih.DataPropertyName = "t_tarih";
            this.t_tarih.HeaderText = "Talep Tarihi";
            this.t_tarih.Name = "t_tarih";
            this.t_tarih.ReadOnly = true;
            // 
            // onay
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.onay.DefaultCellStyle = dataGridViewCellStyle14;
            this.onay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onay.HeaderText = "Onayla";
            this.onay.Name = "onay";
            this.onay.ReadOnly = true;
            this.onay.Text = "Onayla";
            this.onay.ToolTipText = "Onayla";
            this.onay.UseColumnTextForButtonValue = true;
            // 
            // reddet
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.reddet.DefaultCellStyle = dataGridViewCellStyle15;
            this.reddet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reddet.HeaderText = "Reddet";
            this.reddet.Name = "reddet";
            this.reddet.ReadOnly = true;
            this.reddet.Text = "Reddet";
            this.reddet.ToolTipText = "Reddet";
            this.reddet.UseColumnTextForButtonValue = true;
            // 
            // demandCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.dTalepler);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "demandCheck";
            this.Text = "demandCheck";
            this.Load += new System.EventHandler(this.demandCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTalepler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dTalepler;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_tarih;
        private System.Windows.Forms.DataGridViewButtonColumn onay;
        private System.Windows.Forms.DataGridViewButtonColumn reddet;
    }
}