using System;

namespace CourseProject.Model
{
    public class Tomato : Product
    {
        public Tomato() : base ("tomato")
        {

        }

        public override void Weigh()
        {
            Random r = new Random();
            Weight = 0.1 + (r.NextDouble() * (0.5 - 0.1));
            Price = 20 + (r.NextDouble() * (70 - 20));
        }
    }
}
