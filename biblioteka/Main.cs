using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace biblioteka
{
    public partial class main : Form
    {
        User user;
        DateTime today_date = DateTime.Today;

        public main(User user_)
        {
            user = user_;

            InitializeComponent();

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            main_panel.BringToFront();
            label1.Text = "Hoşgeldin " + user.fname + ",";
            balance_label.Text = "Bakiye: " + user.balance + " ₺";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrow_but_Click(object sender, EventArgs e)
        {
            borrow_panel.BringToFront();
        }

        private void homepage_but_Click(object sender, EventArgs e)
        {
            main_panel.BringToFront();
        }

        private void return_panel_Click(object sender, EventArgs e)
        {
            return_panel.BringToFront();
        }

        private void return_book_but_Click(object sender, EventArgs e)
        {/*
            string return_item = return_item_barcode.Text;

            dataSet = new DataSet();
            sql = "select * from users where cardnum = '" + return_item + "'";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection);
            add.Fill(dataSet);*/
        }

        private void borrow_item_but_Click(object sender, EventArgs e)
        {
            string borrow_item = borrow_item_tb.Text;
            DateTime return_date = today_date.AddDays(30);
            
            string sql = "insert into borrows(borrower_id,item_id,return_date)" +
                  "values('" + user.cardnum + "','" + borrow_item +  "','" + return_date.ToString("yyyy-MM-dd") + "')";
            PgsqlConnect pg = new PgsqlConnect();
            DataSet dataSet = pg.Query(sql);

            MessageBox.Show("Parça " + return_date.ToString("yyyy-MM-dd") + " tarihine kadar ödünç alınmıştır");


        }

        private void bakiye_but_Click(object sender, EventArgs e)
        {
            balance_panel.BringToFront();
        }

        private void deposit_but_Click(object sender, EventArgs e)
        {
            int deposit_balance = Convert.ToInt32(balance_combobox.Text);
            string sql = "update users set balance = balance + "
                         + deposit_balance + " where cardnum = '" + user.cardnum + "'";
        }
    }
}
