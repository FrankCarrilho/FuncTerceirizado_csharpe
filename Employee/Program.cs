using System;
using System.Globalization;
using System.Collections.Generic;
using Employee.Entitis;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employe> list = new List<Employe>();

            Console.Write("ENTER THE NUMBER OF EMPLOYEE: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"EMPLOYEE #{i} DATA: ");
                Console.Write("OUTSOURCED (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("NAME: ");
                string name = Console.ReadLine();
                Console.Write("HOURS: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("VALUE PER HOUR: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("ADDITIONAL CHARGE: ");
                    double add = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name,hour,valuePerHour,add));
                }
                else
                {
                    list.Add(new Employe(name, hour, valuePerHour));
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employe employee in list)
            {
                Console.WriteLine(employee.Name 
                    + " - R$ " 
                    + employee.Payment().ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}
