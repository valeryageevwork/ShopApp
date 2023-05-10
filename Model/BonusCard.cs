using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class BonusCard
    {
        public string Name { get; set; }
        public double Scores { get; set; }

        public BonusCard(string name, double scores) 
        {
            Name = name;
            Scores = scores;
        }
    }
}
