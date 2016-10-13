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
            //Method for Getting Animals
             public List<Animal> GetAnimals()
             {
                return Context.Animals.ToList();
             }
            
             //Method for Getting Animals by Name
             public Animal GetAnimals(string name)
               {
            //Get all of the animals in the list and return the value of the anmial that matches the string name that the user commands.

            Animal found_animal = Context.Animals.FirstOrDefault(animals => animals.Name.ToLower() == name.ToLower());

            return found_animal;
        }

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