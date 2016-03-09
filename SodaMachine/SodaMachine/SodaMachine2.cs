using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySodaMachine
{
    public class SodaMachine2
    {     
        public List<Coin> CreateStartingTill()
        {
            List<Coin> sodaMachineTill = new List<Coin>();
            sodaMachineTill.Add(new Quarters(20));
            sodaMachineTill.Add(new Dimes(10));
            sodaMachineTill.Add(new Nickels(20));
            sodaMachineTill.Add(new Pennies(10));
            return sodaMachineTill;
        }
        public List<Soda> FillSodaMachine()
        {
            List<Soda> sodasInMachine = new List<Soda>();
            sodasInMachine.Add(new GrapeSoda(10));
            sodasInMachine.Add(new OrangeSoda(4));
            sodasInMachine.Add(new MeatSoda(1));
            return sodasInMachine;
        }
        public void DisplaySodaChoices()
        {
            int i = 1;
            foreach (Soda sodaFlavor in FillSodaMachine())
            {
                Console.WriteLine("(" + (i++) + ")" + " " + sodaFlavor.name + ": " + sodaFlavor.cost + " cents");
            }
        }
        public string GetSodaChoice()
        {            
            DisplaySodaChoices();
            string userResponse = Console.ReadLine();
            string sodaChoice = null;
            return sodaChoice;
        }
    }
}
