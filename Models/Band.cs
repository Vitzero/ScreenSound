using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class Band
    {
        private List<Album> albuns = new List<Album>();
        private List<Review> grades = new List<Review>();

        public Band(string nome)
        {
            Name = nome;
        }

        public string Name { get; }
        public double Average
        {
            get
            {
                if (grades.Count == 0) return 0;
                else return grades.Average(a => a.Grade);
            }
        }

        public List<Album> Albuns => albuns;

        public void AddAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void AddGrade(Review grade)
        {
            grades.Add(grade);
        }

        public void ShowDiscography()
        {
            Console.WriteLine($"Band Discography: {Name}");
            foreach (Album album in albuns)
            {
                Console.WriteLine($"Album: {album.Name} ({album.TotalDuration})");
            }
        }
    }
}
