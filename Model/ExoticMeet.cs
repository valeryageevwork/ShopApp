using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class ExoticMeetBuilder : MeetBuilder
    {
        public override void SetExotic()
        {
            this.MyMeet.Exotic = true;
            this.MyMeet.Name = "exotic meet";
        }
        public override void SetFried()
        {
           
        }
        public override void SetFat()
        {
            
        }
    }
}
