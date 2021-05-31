using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using biblioteka;
using Npgsql;

namespace biblioteka_test
{
    [TestClass]
    public class UnitTest1
    {
        static User us = new User("12345678911", "admin", "admin", "admin@admin.com", 100, 0);

        Main_admin main_admin = new Main_admin();
        main main_user = new main(us);
        login login_page = new login();

        PgsqlConnect pg = new PgsqlConnect();
        DataSet ds;

        [TestMethod]
        public void database_connection_test()
        {
            ds = pg.Query("SELECT cardnum FROM users WHERE 1=0");
            Assert.AreEqual(1, ds.Tables[0].Columns.Count);
        }

        [TestMethod]
        public void user_login_check()
        {
            User user = login_page.user_login("12345678911");
            Assert.AreEqual("admin", user.fname);
        }

        [TestMethod]
        public void check_table_insert()
        {
            ds = pg.Query("insert into groups values(99,'test',0,0)");
            ds = pg.Query("select * from groups where id = 99");
            string group_name = ds.Tables[0].Rows[0]["name"].ToString();
            Assert.AreEqual("test", group_name);
        }

        [TestMethod]
        public void negative_balance_check()
        {
            bool result = main_user.check_negative_balance(us);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void check_table_remove()
        {

        }



    }
}
