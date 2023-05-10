using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class Fish : Product
    {
        public Fish() : base("fish")
        {
            Price = 600;
            Weight = 700;
        }

        public override void Weigh()
        {

        }
    }
}
