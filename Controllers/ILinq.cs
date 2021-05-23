using LINQ.EntitiesModels;
using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linq.Interface
{
    public interface ILinq
    {
        dynamic CreateDepartment(DepartmentDTO department);
        dynamic GetDepartment(DepartmentDTO department);
        dynamic GetEmployeebyDepartment(DepartmentDTO department);
    }
}
