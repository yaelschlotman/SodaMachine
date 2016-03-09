using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySodaMachine
{
    class Dimes : Coin
    {
        public Dimes(int quantity) : base("Dime", quantity, 10)
        {
        }
    }
}
