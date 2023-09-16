using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class Display : InputControl
    {
        private string dvalue = " ";

        public void DisplayValue(string dv)
        {
            dvalue = dv.ToLower();

            if(dvalue == "hello")
            {
                Console.WriteLine("Hello!!!");
            }
            else if(dvalue == "goodbye")
            {
                Console.WriteLine("Goodbye, sad to see you go");
            }
            else if(dvalue == "exit")
            {
                Console.WriteLine("System shutdown...");
            }
            else 
            { 
                Console.WriteLine("Sorry, I did not understand that input");
            }

        }
    }
}
