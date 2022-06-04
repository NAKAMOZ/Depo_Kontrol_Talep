﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SQLite;

namespace depo_proje
{
    public partial class warehouse_form : Form
    {
        public warehouse_form()
        {
            InitializeComponent();
        }

        private SQLiteConnection conn = new SQLiteConnection("Data Source = depo.db");
        public string name;

        private void dataGosterge()
        {
            conn.Open();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter($"SELECT * FROM depo", conn);
            DataSet dset = new DataSet();
            adapt.Fill(dset, "info");
            dMalzemeler.DataSource = dset.Tables[0];
            conn.Close();
            dMalzemeler.Select();
        }

        private void warehouse_form_Load(object sender, EventArgs e)
        {
            dataGosterge();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int rowIndex = dMalzemeler.CurrentCell.RowIndex;
                string rowID = dMalzemeler.Rows[rowIndex].Cells[0].Value.ToString();
                SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM depo WHERE id={rowID}", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGosterge();
                uyari.Visible = false;
            }
            catch
            {
                uyari.Visible = true;
            }
        }
    }
}
