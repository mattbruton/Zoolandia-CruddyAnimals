using System;
using System.Collections.Generic;
using ZoolandiaRazor.Models;
using System.Linq;
using System.Web;

namespace ZoolandiaRazor.DAL
{
    public class ZooRepository
    {
        public ZooContext Context { get; set; }
        public ZooRepository()
        {
            Context = new ZooContext();
        }
        public ZooRepository(ZooContext _context)
        {
            Context = _context;
        }

        /* 
         Sylvia's Section Beginning
        */

        /* 
        Sylvia's Section End
        */

        /* 
        Odi's Section Beginning
        */

        /* 
        Odi's Section End
        */

        /* 
        Matt's Section Beginning
        */

        public List<Employee> GetAllEmployees()
        {
            return Context.Employees.ToList();
        }

        public Employee GetSingleEmployee(int empId)
        {
            Employee selected_employee = Context.Employees.FirstOrDefault(e => e.EmployeeId == empId);
            return selected_employee;
        }

        /* 
        Matt's Section End
        */
    }
}