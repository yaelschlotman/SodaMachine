using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySodaMachine
{
    class Pennies : Coin 
    {
        public Pennies(int quantity) : base("Penny", quantity, 01)
        {          
        }
    }
}
