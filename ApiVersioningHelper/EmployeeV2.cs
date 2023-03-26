using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiVersioningHelper
{
    public class EmployeeV2:Employee
    {
        public EmployeeV2()
        {
            Address = new Address();
        }
        public Address Address { get; set; }
    }
}
