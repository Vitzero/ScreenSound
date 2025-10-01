using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuAllBandsRegistereds : Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            ShowTitleOption("Registered Bands");
            foreach (string band in registeredBand.Keys)
            {
                Console.WriteLine($"-> {band}");
            }
            Console.WriteLine("\nClick some key to return to the menu.");
            Console.ReadLine();
        }
    }
}
