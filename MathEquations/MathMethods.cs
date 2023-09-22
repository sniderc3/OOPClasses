using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathEquations
{
    class MathMethods
    {
        //Note: There are multiple implementations of the AddValues() method.
        //This is an example of polymorphism in C#.
        public int AddValues(int x, int y)
        {
            int z = x + y;
            return z;
        }

        public float AddValues(float x, float y)
        {
            float z = x + y;
            return z;
        }

        public string AddValues(string x, string y)
        { 
            string z = x + y;
            return z; 
        }
    }
}
