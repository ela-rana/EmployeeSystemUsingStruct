using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemUsingStruct
{
    /// <summary>
    /// A list of all departments in an organization, that each Employee can be assigned to
    /// </summary>
    enum Department
    {
        IT=1,
        Finance,
        HR,
        Marketing,
        Executive
    }

    struct Employee
    {
        public int Eid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public Department Dept { get; set; }
    }
}
