namespace CourseProject.Model
{
    public class Bucher
    {
        public Meet GetMeet(MeetBuilder meetBuilder)
        {
            meetBuilder.CreateMeet();
            meetBuilder.SetFried();
            meetBuilder.SetFat();
            meetBuilder.SetExotic();

            return meetBuilder.MyMeet;
        }
    }
}
