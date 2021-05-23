using Linq.Interface;
using LINQ.EntitiesModels;
using LINQ.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linq.Services
{
    public class LinqServices : ILinq
    {

        private LinqContext _linqContext;

        public LinqServices()
        {
            _linqContext = new LinqContext();
        }

        public dynamic CreateDepartment(DepartmentDTO department)
        {
            dynamic response = null;

            try {

                var mapData = JsonConvert.DeserializeObject<Department>(JsonConvert.SerializeObject(department));
                _linqContext.Departments.Add(mapData);
                _linqContext.SaveChanges();

                return response = mapData;
            }
            catch(Exception ex)
            {
                response = ex;
            }

            return response;
        }

        public dynamic GetDepartment(DepartmentDTO department)
        {
            dynamic response = null;
            try
            {
               response = _linqContext.Departments.Select(x=>x);
            }
            catch (Exception ex)
            {
                response = ex;
            }

            return response;
        }

        public dynamic GetEmployeebyDepartment(DepartmentDTO department)
        {
            dynamic response = null;
            try
            {
                response = (from employee in _linqContext.Employees
                           join departments in _linqContext.Departments on employee.DepartmentId equals departments.DepartmentId
                           where departments.DepartmentId.Equals(department.DepartmentId) || departments.DepartmentName.Equals(department.DepartmentName)
                           select employee).Take(1);
            }
            catch (Exception ex)
            {
                response = ex;
            }

            return response;
        }

    }
}
