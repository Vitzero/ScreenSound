using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuShowDetails : Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        { 
            base.Execute(registeredBand);
            ShowTitleOption("Average of Band");

            Console.WriteLine("Write the band name that you wises see the average review");
            string name = Console.ReadLine();

            if (registeredBand.ContainsKey(name))
            {
                double average = registeredBand[name].Average;
                Console.WriteLine($"The average review of Band {name} is {average:F2}.");

                Console.WriteLine("\nDiscography:");
                foreach (Album album in registeredBand[name].Albuns)
                {
                    Console.WriteLine($"{album.Name} - > {album.Average}");
                }
            }
            else
            {
                Console.WriteLine("The name is wrong, check-up and retry.");
            }
                Console.WriteLine("Click some bind to return.");
                Console.ReadKey();
            
        }
    }
}
