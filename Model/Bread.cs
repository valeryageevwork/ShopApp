namespace CourseProject.Model
{
    public abstract class Bread : Product
    {
        protected Bread(string name, double price, string additives) : base (name)
        {
            Weight = 0.5;
            Price = price;
            Additives = additives;
        }
    }
}
