namespace CourseProject.Model
{
    public class FatMeetBuilder : MeetBuilder
    {
        public override void SetFat()
        {
            this.MyMeet.Fat = true;
            this.MyMeet.Name = "fat meet";
        }
        public override void SetExotic()
        {
            
        }
        public override void SetFried()
        {
            
        }
    }
}
