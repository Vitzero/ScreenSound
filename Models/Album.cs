using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class Album : IEvaluate
    {
        private List<Song> Song = new List<Song>();
        private List<Review> gradesMusic = new List<Review>();

        public Album(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int TotalDuration => Song.Sum(m => m.Duration);
        public List<Song> Songs => Song;

        public double Average
        {
            get
            {
                if (gradesMusic.Count <= 0) return 0;
                else return gradesMusic.Average(a => a.Grade);
            }
        }

        public void AddGrade(Review grade)
        {
            gradesMusic.Add(grade);
        }

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
