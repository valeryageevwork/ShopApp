namespace CourseProject.Model
{
    public class CheeseBread : BreadDecorator
    {
        public CheeseBread(Bread bread) : base(bread, bread.Name, "cheese", 21)
        {

        }

        public override void Weigh()
        {
           
        }
    }
}
