using System;
using System.Collections.Generic;

#nullable disable

namespace LINQ.EntitiesModels
{
    public partial class Employee
    {
        public Employee()
        {
            Accounts = new HashSet<Account>();
        }

        public decimal EmployeeId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public decimal? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
