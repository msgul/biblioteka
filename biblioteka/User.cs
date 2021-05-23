using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteka
{
    public class User
    {

        private string cardnum, fname, lname;
        private int balance, group_id;

        public User(string cardnum_, string fname_, string lname_, int balance_, int group_id_)
        {
            cardnum = cardnum_;
            fname = fname_;
            lname = lname_;
            balance = balance_;
            group_id = group_id_;
        }
        
    }
}
