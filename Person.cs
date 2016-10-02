using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndDerivedClasses
{
    class Person
    {
        private string firstname;
        private string lastname;
        private string idnum;

        //Constructor empty
        public Person()
        {
            firstname = string.Empty;
            lastname = string.Empty;
            idnum = "222333";
        }

        //Constructor - all
        public Person(string fname, string lname, string id)
        {
            firstname = fname;
            lastname = lname;
            idnum = id;
        }

        //Properties.......
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        //.......read only
        public string IdNum
        {
            get
            {
                return idnum;
            }
            /*set
            {
                idnum = value;
            }*/
        }

    }
}
