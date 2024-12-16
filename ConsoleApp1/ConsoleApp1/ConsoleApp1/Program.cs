using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Output(ArrayList kol)
        {
            foreach (var e in kol)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            ArrayList line = new ArrayList();
            line.Add(3);
            line.Add("Строковое");
            line.Add(true);
            line.Add(2.76);
            line.Add(-23);
            line.Add(-4.23);
            Output(line);
            Console.WriteLine();
            int kolvo = line.Count;
            Console.WriteLine($"Количесво веществ: {kolvo}");
            Console.WriteLine();
            line.Insert(2, "чтото новое");
            Output(line);
            Console.WriteLine();
            line.RemoveAt(0);
            Output(line);
            Console.WriteLine();
            line.Reverse();
            Output(line);
            Console.WriteLine();
            string[] massivArray = { "Тут1", "Тут2", "Тут3" };
            line.AddRange(massivArray);
            Output(line);
            Console.ReadKey();


        }
    }
}
