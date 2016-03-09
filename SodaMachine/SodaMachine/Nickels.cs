using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySodaMachine
{
    public class Nickels : Coin
    {
        public Nickels(int quantity) : base("Nickel", quantity, 05)
        {
        }
    }
}
