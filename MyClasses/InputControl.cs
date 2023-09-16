using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class InputControl
    {
        private string? message;

        public string GetMessage()
        {
            Console.WriteLine("Type in your message: ");
            message = Console.ReadLine();
            if (message == null)
            {
                return "none";
            }
            else
            {
                return message.ToLower();
            }            
        }
    }
}
