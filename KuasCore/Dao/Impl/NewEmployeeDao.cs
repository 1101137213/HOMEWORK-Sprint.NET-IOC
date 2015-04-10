using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    class NewEmployeeDao : GenericDao<Employee>, IEmployeeDao
    {
        override protected IRowMapper<Employee> GetRowMapper()
        {
            return new EmployeeRowMapper();
        }

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Id = "001";
            employee1.Name = "謝文川";
            employee1.Age = 35;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Id = "002";
            employee2.Name = "汪維揚";
            employee2.Age = 40;
            employees.Add(employee2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employee = null;

            if ("001".Equals(id))
            {
                employee = new Employee();
                employee.Id = "001";
                employee.Name = "謝文川";
                employee.Age = 35;
            }

            return employee;
        }
    }
}
