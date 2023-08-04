using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toshiba;
using LG;


namespace Vendor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV obj = new TV();
            obj.Display();
            LG.WashingMachine machine = new LG.WashingMachine();
            machine.Display();
            Toshiba.WashingMachine  tmachine = new Toshiba.WashingMachine();
            machine.Display();



            Console.ReadKey();
        }
    }
}
