using System;
using System.Linq;

namespace DistinctExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Волга", "Москвич", "Москвич", "Нива", "Газель" };
 
            // удалим дубликаты
            var uniqueCars = cars.Distinct();
 
            foreach (string v in uniqueCars)
                Console.WriteLine(v);
        }
    }
}