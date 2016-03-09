using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySodaMachine
{
    public class MoneyHandling
    {    /*  incorporate coin counter into money handling to give change as correct amount by coins based on 
        coin values set in coin classes.
        */    
        public int AmountPaid;
        public int TakeInMoney()
        {
            Console.WriteLine("Please enter amount paid in cents.");
            AmountPaid = Convert.ToInt32(Console.ReadLine());
            return AmountPaid;
        }
        public int CalculateChangeDue(int sodaCost)
        {
            Console.WriteLine("Soda choice costs " + sodaCost + " cents.");
            TakeInMoney();
            int changeDue = 0;
            if (AmountPaid == sodaCost)
            {
                changeDue = 0;
            }
            else if (AmountPaid > sodaCost)
            {
                changeDue = (AmountPaid - sodaCost);
            }
            else if (AmountPaid < sodaCost)
            {
                GiveMoneyBack("Sorry.  That's not enough money.");
                changeDue = AmountPaid;
            }
            else
            {
                Console.WriteLine("Invalid entry.  Please enter valid amount in cents.");
                TakeInMoney();
            }
            Console.WriteLine("Change due:  " + changeDue + " cents.");
            return changeDue;
        }

        public void GiveMoneyBack(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            Console.WriteLine("Here's your money back.");
        }
    }
}

