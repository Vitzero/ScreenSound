using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class Album
    {

        private List<Song> Song = new List<Song>();

        public Album(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int TotalDuration => Song.Sum(m => m.Duration);
        public List<Song> Songs => Song;

        public void AdicionarMusica(Song music)
        {
            Song.Add(music);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Songs from album: {Name}:\n");
            foreach (var singleSong in Songs)
            {
                Console.WriteLine($"Song: {singleSong.Name}");
            }
            Console.WriteLine($"\nTo listen all this album is necessary: {TotalDuration}");
        }
    }
}
