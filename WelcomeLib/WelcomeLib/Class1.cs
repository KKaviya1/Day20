using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeLib
{
    public class Welcome
    {
        public void Display(string fname, string lname)
        {
            Console.WriteLine("Welcome to Library Mr.\\Ms. " + fname + "" +lname);
        }
    }
}
