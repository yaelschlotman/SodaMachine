using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySodaMachine
{
    public class Coin
    {
        private string CoinName;
        private int Quantity;
        private int Value;
        public Coin(string coinName, int quantity, int value)
        {
            this.CoinName = coinName;
            this.Quantity = quantity;
            this.Value = value;
        }
        public string coinName
        {
            get { return CoinName; }
            set { CoinName = value; }
        }
        public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public int value
        {
            get { return Value; }
            set { Value = value; }
        }        
    }
}
