using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndDerivedClasses
{
    public class DisPerson : Person
    {
        private string theDisAb;

        public DisPerson()
            : base()
        {
            
        }

        public DisPerson(string tda)
            : base(fname, lname, id)
        {
            theDisAb = tda;
        }

        public string TheDisAb
        {
            get
            {
                return theDisAb;
            }
            set
            {
                theDisAb = value;
            }
        }
    }
}
