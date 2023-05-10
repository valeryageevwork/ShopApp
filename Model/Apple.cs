using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class Apple : Product
    {
        public Apple() : base("apple")
        {

        }

        public override void Weigh()
        {
            Random r = new Random();
            Weight = 0.1 + (r.NextDouble() * (0.5 - 0.1));
            Price = 10 + (r.NextDouble() * (60 - 10));
        }
    }
}
