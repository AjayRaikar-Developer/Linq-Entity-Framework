using System;
using System.Collections.Generic;

#nullable disable

namespace LINQ.EntitiesModels
{
    public partial class Account
    {
        public decimal AccountId { get; set; }
        public decimal? EmployeeId { get; set; }
        public decimal? Salary { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
