using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace biblioteka
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private NpgsqlConnection connection;
        private DataSet dataSet;
        private string sql;
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_but_Click(object sender, EventArgs e)
        {

            string card_num = login_textbox.Text;
            dataSet = new DataSet();
            sql = "select * from users where cardnum = '" + card_num + "'";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection);
            add.Fill(dataSet);
            
            try
            {
                string fname = Convert.ToString(dataSet.Tables[0].Rows[0]["fname"]);
                string lname = Convert.ToString(dataSet.Tables[0].Rows[0]["fname"]);

                int balance = Convert.ToInt32(dataSet.Tables[0].Rows[0]["balance"]);
                int group_id = Convert.ToInt32(dataSet.Tables[0].Rows[0]["group_id"]);

                User user = new User(card_num, fname, lname, balance, group_id);

                var main_page = new main(user);
                this.Hide();
                main_page.Show();
                
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Kart Bulunamadı");
            }



        }

        private void login_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=bibliodb; User Id=postgres; Password=123;");
        }
    }
}
