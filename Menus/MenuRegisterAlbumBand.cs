using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRegisterAlbumBand : Menu
    {
        public override void Execute(Dictionary<string, Band> registeredBand)
        {
            base.Execute(registeredBand);
            ShowTitleOption("Album register");
            Console.WriteLine("Write the Band's album name that you want to register:");
            string nameBand = Console.ReadLine();

            if (registeredBand.ContainsKey(nameBand))
            {
                Console.WriteLine("Write the album's name that you want to register:");
                string titleAlbum = Console.ReadLine()!;
                registeredBand[nameBand].AddAlbum(new Album(titleAlbum));
            }
        }
    }
}
