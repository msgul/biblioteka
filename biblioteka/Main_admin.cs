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
            DataSet ds = pg.Query("select id,name,item_type,year from users");

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

            MessageBox.Show(sql);

            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query(sql);

            load_DGV1();
        }

        private void item_remove_but_Click(object sender, EventArgs e)
        {
            string item_id = item_id_tb.Text;
            string item_name = item_name_tb.Text;
            string item_year = item_year_tb.Text;
            string item_type = item_type_cb.Text;

            string sql = "delete from items where id = '" + item_id + "'";

            item_id_tb.Text = "";
            item_name_tb.Text = "";
            item_year_tb.Text = "";
            item_type_cb.Text = "";

            MessageBox.Show(sql);

            PgsqlConnect pg = new PgsqlConnect();
            DataSet ds = pg.Query(sql);

            load_DGV1();
        }

        private void user_add_but_Click(object sender, EventArgs e)
        {

        }

        private void users_but_Click(object sender, EventArgs e)
        {
            load_DGV2();
        }
    }
}
