using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteka
{
    public class User
    {
        public string cardnum { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public int balance { get; set; }
        public int group_id { get; set; }


        public User(string cardnum_, string fname_, string lname_, string email_, int balance_, int group_id_)
        {
            cardnum = cardnum_;
            fname = fname_;
            lname = lname_;
            email = email_;
            balance = balance_;
            group_id = group_id_;
        }
    }
}
