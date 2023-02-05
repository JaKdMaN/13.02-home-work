using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Models
{
    class Worker : Person
    {

        private int experience;
        public string developer;
        int test = 3;
        string text = "";
        public int Experience
        {
            set
            {
                if (value >= test)
                {
                    experience = value;
                    text = "Вы нам подходите";
                }
                else
                {
                    experience = value;
                    text = "Вы нам не подходите";
                }


            }

        }
        public override void Action()
        {
            Console.WriteLine($"Я {name} хочу найти работу на должность {developer},мой опыт работы равен {experience}");
            Console.WriteLine(text);
        }
    }
}
