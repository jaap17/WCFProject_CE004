using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CourseAllocationSystem
{
    [DataContract]
    public class CourseAllocation
    {
        private string name;
        private string allocation1;
        private string allocation2;

        [DataMember]
        public string FacultyName
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Subject1
        {
            get { return allocation1; }
            set { allocation1 = value; }
        }

        [DataMember]
        public string Subject2
        {
            get { return allocation2; }
            set { allocation2 = value; }
        }


    }
}
