namespace CourseProject.Model
{
    public abstract class BreadDecorator : Bread
    {
        protected Bread bread;
        protected BreadDecorator(Bread bread, string name, string additives, double price) : base(name, bread.Price + price, bread.Additives + " " + additives)
        {
            this.bread = bread;
        }
    }
}
