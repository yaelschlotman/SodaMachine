using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySodaMachine
{
    public class Soda
    {
        private string Name;
        private int Quantity;
        private int Cost;
        public Soda(string name, int quantity, int cost)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Cost = cost;
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }        
        public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public int cost
        {
            get { return Cost; }
            set { Cost = value; }
        }
    }
}
