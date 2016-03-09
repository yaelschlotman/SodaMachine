using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySodaMachine
{
    public class Quarters : Coin
    {
        public Quarters(int quantity) : base("Quarter", quantity, 25)
        {
        }
    }
}
