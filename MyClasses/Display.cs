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
        private int count = 0;

        public int Count
        { get { return count; } }

        public void DisplayValue(string dv)
        {
            dvalue = dv.ToLower();

            if(dvalue == "hello")
            {
                Console.WriteLine("Hello!!!"); 
                count++;
            }
            else if(dvalue == "goodbye")
            {
                Console.WriteLine("Goodbye, sad to see you go");
                count++;
            }
            else if(dvalue == "exit")
            {
                Console.WriteLine("System shutdown...");
                count++;
            }
            else 
            { 
                Console.WriteLine("Sorry, I did not understand that input");
                count++;
            }
        }
    }
}
