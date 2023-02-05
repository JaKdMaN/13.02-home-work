using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Models
{
    class Employer : Person
    {
        public string company;



        public override void Action()
        {
            Console.WriteLine($"Здравствуйте  меня зовут {name}, я предстовитель компании {company}, сегодня я буду вас собеседовать");
        }
    }
}
