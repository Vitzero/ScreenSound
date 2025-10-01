using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRegisterBand : Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            ShowTitleOption("Register Band");
            Console.Write("Write the band name that you want to register: ");
            string BandName = Console.ReadLine()!;
            Band NewBand = new Band($"{BandName}");
            registeredBand.Add(BandName, NewBand);
            Console.WriteLine($"The Band {BandName} was registered");
            Console.ReadKey();
        }
    }
}
