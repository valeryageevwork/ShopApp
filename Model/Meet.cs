using System;

namespace CourseProject.Model
{
    public class Meet : Product
    {
        public bool Fried { get; set; }
        public bool Fat { get; set; }
        public bool Exotic { get; set; }

        public Meet() : base("meet")
        {

        }

        public override void Weigh()
        {
            Random r = new Random();
            if (Exotic)
            {
                Weight = 1 + (r.NextDouble() * (5 - 1));
                Price += 600 + (r.NextDouble() * (1000 - 600));
            }
            else if (Fried)
            {
                Weight = 1 + (r.NextDouble() * (5 - 1));
                Price += 500 + (r.NextDouble() * (600 - 500));
            }
            else if (Fat)
            {
                Weight = 2 + (r.NextDouble() * (6 - 2));
                Price += 500 + (r.NextDouble() * (600 - 500));
            }
            else
            {
                Weight = 1 + (r.NextDouble() * (5 - 1));
                Price += 300 + (r.NextDouble() * (400 - 300));
            }
        }
    }
}
