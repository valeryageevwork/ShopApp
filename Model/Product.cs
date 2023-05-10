namespace CourseProject.Model
{
    public abstract class Product
    {
        private static int counter = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public string Additives { get; set; }
        protected Product(string name)
        {
            Id = counter++;
            Name = name;
        }

        public abstract void Weigh();
    }
}
