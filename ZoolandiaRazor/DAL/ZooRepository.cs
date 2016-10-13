using System;
using System.Collections.Generic;
using ZoolandiaRazor.Models;
using System.Linq;
using System.Web;
using System.Data.Entity;

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
        //return Habitat name and animal counts. The method I used before, I just don't want to delete it
        //public Dictionary<string, int> AnimalCountInEachHabitat()
        //{
        //    var returnList = Context.Animals.GroupBy(a => a.CurrentHabitat).Select(
        //        n => new
        //        {
        //            HabitatKey = n.Key.HabitatName,
        //            AnimalCount = n.Count()
        //        });
            

        //    Dictionary<string, int> dic = new Dictionary<string, int>();
        //    foreach (var record in returnList)
        //    {
        //        dic.Add(record.HabitatKey, record.AnimalCount);
        //    }

        //    return dic;
        //}
        

        //return HabitatWholeTable
        public List<Habitat> GetAllHabitats()
        {
            return Context.Habitats.ToList();
        }

        //return Individual Habitat
        public Habitat IndividualHabitat(int id)
        {
            //try
            //{
                var ctx = Context.Habitats.FirstOrDefault(h => h.HabitatId == id);
                return ctx;
            //}
            //catch()
            //{
            //    return Context.Habitats.FirstOrDefault(h => h.HabitatId == 1);
            //}
            
        }

        //Add a new habitat from form
        public void AddHabitat(Habitat habitat)
        {
            Context.Habitats.Add(habitat);
            Context.SaveChanges();
        }

        //Update Habitat
        public void UpdateHabitat(Habitat habitat)
        {
            Context.Entry(habitat).State = EntityState.Modified;
            Context.SaveChanges();
        }
        

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