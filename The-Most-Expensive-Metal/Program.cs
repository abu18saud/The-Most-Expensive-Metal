using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace The_Most_Expensive_Metal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> metals = new Dictionary<string, int>();
            metals.Add("Platinum", 70);
            metals.Add("Iridium", 20);
            metals.Add("Palladium", 30);
            metals.Add("Scandium", 12);

            string metalName = Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());

            //add 5th metal details to dictionary
            metals.Add(metalName, price);

            int[] prices = metals.Values.ToArray();

            //your code goes here
            //var metal = metals.Values.Max();

            Console.WriteLine("The most expensive: "+ metals.Aggregate((l, r) => l.Value > r.Value ? l : r).Key);

            /*
		    Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Uno", 1);
            d.Add("One", 1);
            d.Add("Dos", 2);
            d.Add("Deux", 2);
            d.Remove("One");  // Remove key-value pair One, 1
            d.Remove("Dos");  // Remove key-value pair Dos, 2
            
            Console.WriteLine("Dictionary: ");
            foreach (string s in d.Keys)
                Console.WriteLine(s + ": " + d[s]);  // Uno: 1  Deux: 2
            Console.WriteLine("\nCount: {0}", d.Count); // 2 
             */

        }
    }
}
