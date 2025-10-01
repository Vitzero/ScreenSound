using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class Menu
    {
        public virtual void Execute(Dictionary<string, Band> registeredBand) {
            Console.Clear();
        }

        public void ShowTitleOption(string titulo)
        {
            int qtdLetters = titulo.Length;
            string asteriscos = string.Empty.PadLeft(qtdLetters, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos);
            Console.WriteLine();
        }
    }
}
