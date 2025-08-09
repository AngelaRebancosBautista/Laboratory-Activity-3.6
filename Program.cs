using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            Console.WriteLine("Enter city names (type 'exit' to finish):");

            while (true)
           
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }
                if (!string.IsNullOrWhiteSpace(input))
                {
                    cities.Add(input);
                }
            }
            var distinctCities = cities.Distinct().ToList();
            distinctCities.Sort();

            Console.WriteLine("\nCities in alphabetical order:");
            foreach (string city in distinctCities)
            {
                Console.WriteLine(city);

            }
        }
    }
}
                
            
        
    
                
            
        

    

