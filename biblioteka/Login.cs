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
        PgsqlConnect pg = new PgsqlConnect();

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_but_Click(object sender, EventArgs e)
        {
            
            string card_num = login_textbox.Text;

            User user = user_login(card_num);
            
            try
            {
                
                if(user.group_id == 0)
                {
                    var main_page_admin = new Main_admin();
                    this.Hide(); 
                    main_page_admin.Show();
                }
                else
                {
                    var main_page = new main(user);
                    this.Hide();
                    main_page.Show();
                }
                
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Kart Bulunamadı");
            }
        }

        public User user_login(string card_num)
        {
            DataSet dataSet = pg.Query("select * from users where cardnum = '" + card_num + "'");
            
            string fname = Convert.ToString(dataSet.Tables[0].Rows[0]["fname"]);
            string lname = Convert.ToString(dataSet.Tables[0].Rows[0]["fname"]);
            string email = Convert.ToString(dataSet.Tables[0].Rows[0]["email"]);

            int balance = Convert.ToInt32(dataSet.Tables[0].Rows[0]["balance"]);
            int group_id = Convert.ToInt32(dataSet.Tables[0].Rows[0]["group_id"]);

            User user = new User(card_num, fname, lname, email, balance, group_id);

            return user;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
