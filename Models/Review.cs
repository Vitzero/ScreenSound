using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class Review
    {
        public int Grade { get; }

        public Review(int grade)
        {
            if (grade > 10) Grade = 10;
            else if (grade < 0) Grade = 0;
            else Grade = grade;
        }

        public static Review Parse(string text)
        {
            int grade = int.Parse(text);
            return new Review(grade);
        }
    }
}
