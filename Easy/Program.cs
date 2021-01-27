using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    
        class Program
        {
            static void Main(string[] args)
            {
                List<string> employee = new List<string>();
                for (int i = 1; i <= 5; i++)
                {
                    employee.Add(Console.ReadLine());
                }
                Console.WriteLine(" List of employee names");
                foreach (var List in employee)
                {
                    Console.WriteLine(List + " ");
                }

                string name = Console.ReadLine();
                int index = employee.IndexOf(name);
                Console.WriteLine("{0} is the position {1} for promotion", name, index);

                Console.WriteLine("The current size of collction is" + employee.Capacity);
                employee.TrimExcess();
                Console.WriteLine("The size after removing extra space is" + employee.Capacity);

                Console.WriteLine("Promoted employee list");
                employee.Sort();
                foreach (var names in employee)
                {
                    Console.WriteLine(names + " ");
                }
                Console.ReadLine();
            }
        }
    }


