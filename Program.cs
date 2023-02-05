using System;
using ConsoleApp6.Models;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Employer1 = new Employer { name = "Владимир ", company = "Лукойл" };
            Person Workers1 = new Worker { name = "Максим", Experience = 3, developer = "Фронтенд" };


            Person[] People = new Person[] { Employer1, Workers1 };
            foreach (Person visible in People)
            {
                visible.Action();
            }
        }

    }
}