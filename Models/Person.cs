using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Models
{
    abstract class Person
    {
        public string name = "";

        public virtual void Action()
        {
            Console.WriteLine(name);
        }
    }
}
