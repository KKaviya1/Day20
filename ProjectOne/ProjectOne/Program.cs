using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpLib;

namespace ProjectOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpCollection.AddEmp();
            EmpCollection.DisplayList();
            Console.ReadKey();
        }
    }
}
