namespace CourseProject.Model
{
    public abstract class MeetBuilder
    {
        public Meet MyMeet { get; private set; }
        public void CreateMeet()
        {
            MyMeet = new Meet();
        }
        public abstract void SetFat();
        public abstract void SetFried();
        public abstract void SetExotic();
    }
}
