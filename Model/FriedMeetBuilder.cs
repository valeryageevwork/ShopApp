using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class FriedMeetBuilder : MeetBuilder
    {
        public override void SetFried()
        {
            this.MyMeet.Fried = true;
            this.MyMeet.Name = "fried meet";
        }
        public override void SetFat()
        {
            
        }
        public override void SetExotic()
        {
            
        }
    }
}
