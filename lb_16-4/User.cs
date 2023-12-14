using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_16_4
{
    public class User
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public User(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
