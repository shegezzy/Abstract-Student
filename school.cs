using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    // this is an abstract class
    internal abstract class School
    {
        // principal and role does not return any value
        public abstract void principal();
        public void role()
        {
            Console.WriteLine("Principal is: Head of the school");
        }
    }
    //This class was inherited from the class School
    class Student : School
    {
        public override void principal()
        {
            Console.WriteLine("Segun is: first student");
        }
    }

}
