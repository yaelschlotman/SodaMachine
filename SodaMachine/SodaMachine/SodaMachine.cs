using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySodaMachine
{
    public class SodaMachine
    {
        public int GrapeSodaPrice = 65;
        public int OrangeSodaPrice = 35;
        public int MeatSodaPrice = 6;
        public string SodaChoice;
        MoneyHandling moneyHandling = new MoneyHandling();
        public string GetSodaChoice()
        {
            Console.WriteLine("Choose Soda Flavor");
            Console.WriteLine("(1) Grape, 65 cents");
            Console.WriteLine("(2) Orange, 35 cents");
            Console.WriteLine("(3) Meat, 6 cents");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    SodaChoice = "Grape";
                    Console.WriteLine("Thank you for choosing " + SodaChoice);
                    break;
                case "2":
                    SodaChoice = "Orange";
                    Console.WriteLine("Thank you for choosing " + SodaChoice);
                    break;
                case "3":
                    SodaChoice = "Meat";
                    Console.WriteLine("Thank you for choosing " + SodaChoice);
                    break;
                default:
                    Console.WriteLine("Sorry, that's not an option.");
                    GetSodaChoice();
                    break;
            }
            return SodaChoice;
        }
        public void DispenseSoda()
        {
            SodaChoice = GetSodaChoice();
            switch (SodaChoice)
            {
                case "Grape":
                    moneyHandling.CalculateChangeDue(GrapeSodaPrice);
                    break;
                case "Orange":
                    moneyHandling.CalculateChangeDue(OrangeSodaPrice);
                    break;
                case "Meat":
                    moneyHandling.GiveMoneyBack("Sorry. We're all out of that flavor.");
                    break;
                default:

                    break;
            }
        }
    }
}
