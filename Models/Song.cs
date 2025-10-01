using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class Song
    {
        public Song(Band artist, string name)
        {
            Artist = artist;
            Name = name;
        }

        public string Name { get; }
        public Band Artist { get; }
        public int Duration { get; set; }
        public bool Available { get; set; }
        public string Descrition => $"The song {Name} belongs to {Artist}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artist: {Artist.Name}");
            Console.WriteLine($"Duration: {Duration}");
            if (Available)
            {
                Console.WriteLine("Available in normal version.");
            }
            else
            {
                Console.WriteLine("Just available on the Plus+ version.");
            }
        }
    }
}
