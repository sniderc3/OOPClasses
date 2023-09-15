using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class Display
    {
        private string dvalue = " ";

        public void DisplayValue(string dv)
        {
            dvalue = dv;
            if(dv == "hello")
            {
                Console.WriteLine("Hello!!!");
            }
            else if(dvalue == "goodbye")
            {
                Console.WriteLine("Goodbye, sad to see you go");
            }
            else 
            { 
                Console.WriteLine("Sorry, I did not understand that input");
            }

        }
    }
}
