using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_Inheritance
{
    public class Teacher
    {
        private string name;
        private string address;
        private string contactAddress;
        private DateTime dateOfJoining;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ContactAddress
        {
            get { return contactAddress; }
            set { contactAddress = value; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }
    }
}

