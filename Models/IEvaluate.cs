using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal interface IEvaluate
    {
        void AddGrade(Review grade);
        
        double Average { get; }

    }
}
