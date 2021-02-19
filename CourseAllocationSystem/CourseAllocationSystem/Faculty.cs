using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CourseAllocationSystem
{
    [DataContract]
    public class Faculty
    {
        private int ID;
        private string uname;
        private string fname;
        private string lname;
        private int exp;
        private string pass;

       

        [DataMember]
        public string username
        {
            get { return uname; }
            set { uname = value; }
        }

        [DataMember]
        public string firstname
        {
            get { return fname; }
            set { fname = value; }
        }

        [DataMember]
        public string lastname
        {
            get { return lname; }
            set { lname = value; }
        }

        [DataMember]
        public string  password
        {
            get { return pass; }
            set { pass = value; }
        }

        [DataMember]
        public int Experience
        {
            get { return exp; }
            set { exp = value; }
        }
    }
}
