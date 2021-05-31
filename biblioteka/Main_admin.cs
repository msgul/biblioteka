using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class Main_admin : Form
    {
        public Main_admin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventory_but_Click(object sender, EventArgs e)
        {
            inventory_panel.BringToFront();

            load_DGV1();
            
        }

        private void load_DGV1()
        {
            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query("select id,name,item_type,year from items");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void load_DGV2()
        {
            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query("select * from users");

            dataGridView2.DataSource = ds.Tables[0];
        }

        private void item_add_but_Click(object sender, EventArgs e)
        {
            string item_id = item_id_tb.Text;
            string item_name = item_name_tb.Text;
            string item_year = item_year_tb.Text;
            string item_type = item_type_cb.Text;

            string sql = "insert into items values('" + item_id + "','" + item_type + "','" + item_year + "','" + item_name + "')";

            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query(sql);

            load_DGV1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clicked_row = dataGridView1.Rows[e.RowIndex];

                item_id_tb.Text = clicked_row.Cells["id"].Value.ToString();
                item_type_cb.Text = clicked_row.Cells["item_type"].Value.ToString();
                item_name_tb.Text = clicked_row.Cells["name"].Value.ToString();
                item_year_tb.Text = clicked_row.Cells["year"].Value.ToString();
            }
        }

        private void item_update_but_Click(object sender, EventArgs e)
        {
            string item_id = item_id_tb.Text;
            string item_name = item_name_tb.Text;
            string item_year = item_year_tb.Text;
            string item_type = item_type_cb.Text;

            string sql = "update items set " +
                "item_type = '" + item_type + "', name = '"+ item_name + 
                "', year = '" + item_year + "'  where id = '" + item_id +"'";

            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query(sql);

            load_DGV1();
        }

        private void item_remove_but_Click(object sender, EventArgs e)
        {
            string item_id = item_id_tb.Text;

            string sql = "delete from items where id = '" + item_id + "'";

            item_id_tb.Text = "";
            item_name_tb.Text = "";
            item_year_tb.Text = "";
            item_type_cb.Text = "";

            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query(sql);

            load_DGV1();
        }

        private void user_add_but_Click(object sender, EventArgs e)
        {
            string user_id = user_id_tb.Text;
            string user_fname = user_fname_tb.Text;
            string user_lname = user_lname_tb.Text;
            string user_email = user_email_tb.Text;
            string user_balance = user_balance_tb.Text;
            string user_group = user_group_cb.Text;

            string sql = "insert into users values('" + user_id + "','" + user_fname +
                "','" + user_lname + "','" + user_email + "','" + user_balance + "',"+ user_group +")";

            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query(sql);

            load_DGV2();
        }

        private void users_but_Click(object sender, EventArgs e)
        {
            users_panel.BringToFront();
            load_DGV2();
        }

        private void user_update_but_Click(object sender, EventArgs e)
        {
            string user_id = user_id_tb.Text;
            string user_fname = user_fname_tb.Text;
            string user_lname = user_lname_tb.Text;
            string user_email = user_email_tb.Text;
            string user_balance = user_balance_tb.Text;
            string user_group = user_group_cb.Text;

            string sql = "update users set" + " fname = '" + user_fname + "', lname = '" + user_lname +
               "', email = '" + user_email + "', balance = "+user_balance+", group_id = "+ user_group + 
               " where cardnum = '" + user_id + "'";

            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query(sql);

            load_DGV2();
        }

        private void user_delete_but_Click(object sender, EventArgs e)
        {
            string user_id = user_id_tb.Text;
            string sql = "delete from users where cardnum = '" + user_id + "'";

            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query(sql);

            load_DGV2();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clicked_row = dataGridView2.Rows[e.RowIndex];

                user_id_tb.Text = clicked_row.Cells["cardnum"].Value.ToString();
                user_group_cb.Text = clicked_row.Cells["group_id"].Value.ToString();
                user_fname_tb.Text = clicked_row.Cells["fname"].Value.ToString();
                user_lname_tb.Text = clicked_row.Cells["lname"].Value.ToString();
                user_email_tb.Text = clicked_row.Cells["email"].Value.ToString();
                user_balance_tb.Text = clicked_row.Cells["balance"].Value.ToString();
            }
        }

        private void group_update_but_Click(object sender, EventArgs e)
        {
            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query("update groups set groups " +
                "set borrow_limit = " + student_limit_tb.Text + 
                ", borrow_time = " + student_days_tb.Text +
                " where id = 1");

            ds = pg.Query("update groups set groups " +
                "set borrow_limit = " + lecturer_limit_tb.Text +
                ", borrow_time = " + lecturer_days_tb.Text +
                " where id = 2");


            ds = pg.Query("update groups set groups " +
                "set borrow_limit = " + officer_limit_tb.Text +
                ", borrow_time = " + officer_days_tb.Text +
                " where id = 3");
        }

        private void group_but_Click(object sender, EventArgs e)
        {
            group_panel.BringToFront();

            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query("select * from groups");

            student_limit_tb.Text = ds.Tables[0].Rows[1]["borrow_limit"].ToString();
            lecturer_limit_tb.Text = ds.Tables[0].Rows[2]["borrow_limit"].ToString();
            officer_limit_tb.Text = ds.Tables[0].Rows[3]["borrow_limit"].ToString();

            student_days_tb.Text = ds.Tables[0].Rows[1]["borrow_time"].ToString();
            lecturer_days_tb.Text = ds.Tables[0].Rows[2]["borrow_time"].ToString();
            officer_days_tb.Text = ds.Tables[0].Rows[3]["borrow_time"].ToString();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
