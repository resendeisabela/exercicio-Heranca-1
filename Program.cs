using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("\nEmployee #" + (i+1)+ "data:");
                Console.Write("Outsourced? (y/n) ");
                string aux = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double vph = double.Parse(Console.ReadLine());
                string outsrcd = aux.ToLower();

                if(outsrcd == "y")
                {
                    Console.Write("Additional charge: ");
                    double addcharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(name, hours, vph, addcharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, vph));
                }
            }

            Console.WriteLine("\nPAYMENTS:");

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name + " - $ " + e.Payment().ToString("F2"));
            }

            Console.ReadLine();
        }
    }
}
