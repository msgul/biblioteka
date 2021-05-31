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
        UnitTest ut = new UnitTest();
        DateTime today_date = DateTime.Today;

        public main(User user_)
        {
            user = user_;

            InitializeComponent();

        }

        string sql;
        PgsqlConnect pg = new PgsqlConnect();
        DataSet dataSet;

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void load_main()
        {
            string sql = "select name, item_id, return_date, reserved from borrows b,items i where borrower_id = '" 
                + user.cardnum + "' and item_id = i.id";

            dataSet = pg.Query(sql);
            dataGridView1.DataSource = dataSet.Tables[0];

            int borrowed_count = dataSet.Tables[0].Rows.Count;

            sql = "select * from groups where id = " + user.group_id;

            dataSet = pg.Query(sql);
            int borrow_total = Convert.ToInt32(dataSet.Tables[0].Rows[0]["borrow_limit"]);

            label1.Text = "Hoşgeldin " + user.fname + ",";
            label4.Text = "Kalan ödünç hakkın: " + (borrow_total - borrowed_count);
            balance_label.Text = "Bakiye: " + user.balance + " ₺";

        }


        private void main_Load(object sender, EventArgs e)
        {
            main_panel.BringToFront();
            load_main();
            
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
            load_main();
        }

        private void return_panel_Click(object sender, EventArgs e)
        {
            return_panel.BringToFront();
        }

        private void return_book_but_Click(object sender, EventArgs e)
        {
            
            string return_item = return_item_barcode.Text;
            sql = "select * from borrows users where item_id = '" + return_item + "' and borrower_id = '" + user.cardnum + "'";
            dataSet = pg.Query(sql);

            DateTime return_date =  Convert.ToDateTime(dataSet.Tables[0].Rows[0]["return_date"].ToString());

            int diff = (return_date - today_date).Days;

            //MessageBox.Show(diff.ToString());

            if(diff < 0 ) // ceza
            {
                MessageBox.Show("Ödünç tarihiniz " + (diff * -1) + 
                    " gün geçmiştir." + (diff* -1) + " ₺ hesabınızdan düşülecektir.");

                user.balance += diff;

                sql = "update users set balance = balance + " + diff +
                    " where cardnum = '" + user.cardnum + "'";
                dataSet = pg.Query(sql);

            }
            else
            {
                MessageBox.Show("Parça Iadesi Tamamlanmıştır.");
            }

            sql = "delete from borrows where borrower_id = '" + user.cardnum + "' and item_id = '" + return_item + "'";
            dataSet = pg.Query(sql);

        }

        private void borrow_item_but_Click(object sender, EventArgs e)
        {
            /*
            if(ut.check_negative_balance())
            {
                MessageBox.Show("Daha fazla parça ödünç almak için lütfen bakiye yüklemesi yapınız.");
                return;
            }
            */

            string borrow_item = borrow_item_tb.Text;
            DateTime return_date = today_date.AddDays(30);
            
            string sql = "insert into borrows(borrower_id,item_id,return_date)" +
                  "values('" + user.cardnum + "','" + borrow_item +  "','" + return_date.ToString("yyyy-MM-dd") + "')";
            dataSet = pg.Query(sql);

            MessageBox.Show(sql);
        }

        private void bakiye_but_Click(object sender, EventArgs e)
        {
            balance_panel.BringToFront();
            balance_lab.Text = user.balance + " ₺";
        }

        private void deposit_but_Click(object sender, EventArgs e)
        {
            int deposit_balance = Convert.ToInt32(balance_combobox.Text);
            sql = "update users set balance = balance + " + deposit_balance + " where cardnum = '" + user.cardnum + "'";

            dataSet = pg.Query(sql);

            user.balance += deposit_balance;
        }

       
    }
}
