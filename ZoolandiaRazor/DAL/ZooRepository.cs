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
        //return Habitat name and animal counts
        public Dictionary<string, int> AnimalsInEachHabitat()
        {
            var returnList = Context.Animals.GroupBy(a => a.CurrentHabitat).Select(
                n => new
                {
                    HabitatKey = n.Key.HabitatName,
                    AnimalCount = n.Count()
                });
            
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var record in returnList)
            {
                dic.Add(record.HabitatKey, record.AnimalCount);
            }

            return dic;
        }

        //return how many animals in each habitat

        //return list of animals

        //return list of employee

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

        /* 
        Matt's Section End
        */
    }
}