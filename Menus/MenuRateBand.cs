using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRateBand : Menu
    {



        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            ShowTitleOption("Rate the Band");
            Console.WriteLine("Write the band name that you want to rate:");
            string name = Console.ReadLine();

            if (registeredBand.ContainsKey(name))
            {
                Console.WriteLine($"Write the grade that band {name} deserves:");
                Review grade = Review.Parse(Console.ReadLine());
                registeredBand[name].AddGrade(grade);
                Console.WriteLine($"The grade: {grade.Grade} was sucessfully registered to the band: {name}");
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
