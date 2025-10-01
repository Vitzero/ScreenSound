using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRateAlbum : Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            ShowTitleOption("Rate the Album");
            Console.WriteLine("Write the band name that you want rate the album:");
            string name = Console.ReadLine();

            if (registeredBand.ContainsKey(name))
            {
                Console.WriteLine($"Write the Album title that you want to rate:");
                string title = Console.ReadLine()!;

                if (registeredBand[name].Albuns.Any(a => a.Name.Equals(title)))
                {
                    Album album = registeredBand[name].Albuns.First(a => a.Name.Equals(title));
                    Console.WriteLine($"Write the rate for album '{title}':");
                    Review grade = Review.Parse(Console.ReadLine()!);
                    album.AddGrade(grade);

                    Console.WriteLine($"The grade: {grade.Grade} was sucessfully registered to {title} from {name}!");
                }
                else
                {
                    Console.WriteLine($"The title '{name}' was not found, please try again.");
                }
            }
            else
            {
                Console.WriteLine($"The Band name '{name}' is wrong, please try again.");
            }
            Console.WriteLine("Click any bind to return.");
            Console.ReadKey();
        }
    }
}