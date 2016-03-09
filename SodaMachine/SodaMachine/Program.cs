using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MySodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            SodaMachine machine1 = new SodaMachine();
            machine1.DispenseSoda();


            Console.ReadKey();
        }
    }
}
