using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class SweetBread : BreadDecorator
    {
        public SweetBread(Bread bread) : base(bread, bread.Name, "sugar", 17) 
        {

        }

        public override void Weigh()
        {
            
        }
    }
}
