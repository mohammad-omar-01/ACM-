using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public String LastName { get; set; }
        public String Email { get; set; }
        public String FirstName { get; set; }
        public String FullName
        {
            get
            {
                return FirstName + (FirstName!=null && LastName!=null ?", ":"") + LastName;
            }
        }

    }
}
