namespace ZoolandiaRazor.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZoolandiaRazor.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZoolandiaRazor.DAL.ZooContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ZoolandiaRazor.DAL.ZooContext context)
        {
            var animal1 = new Animal {  CommonName= "T-Rex", ScientificName="Tyrannosaurus Rex", BirthDate = new DateTime(2000, 2, 3), Name = "T-Rex" };
            var animal2 = new Animal { CommonName = "Triceratops", ScientificName = "Triceratops Horridus", BirthDate = new DateTime(2000, 2, 3), Name = "Triceratops" };
            var animal3 = new Animal { CommonName = "Pterodactyl", ScientificName = "Pterodactylus Kochi", BirthDate = new DateTime(2000, 2, 3), Name = "Pterodactyl" };
            var animal4 = new Animal { CommonName = "Dog", ScientificName = "Canis Lupus Familiaries", BirthDate = new DateTime(2000, 2, 3), Name = "Dog" };
            var animal5 = new Animal { CommonName = "Cat", ScientificName = "Felis Catus", BirthDate = new DateTime(2000, 2, 3), Name = "Cat" };

            var employee1 = new Employee { EmployeeId=1, FirstName = "Rita", LastName = "Repulsa", BirthDate = new DateTime(2000, 2, 3), IsLicensedGorillaHandler = true };
            var employee2 = new Employee { EmployeeId=2, FirstName = "Lord", LastName = "Zedd", BirthDate = new DateTime(2000, 4, 20),  IsLicensedGorillaHandler = false };
            
                

            var habitat1 = new Habitat {  HabitatName = "ZordorForest", HabitatType = "Forest", AnimalList= new List<Animal>() {animal1, animal2 }, EmployeeList=new List<Employee>() {employee1, employee2 } };
            var habitat2 = new Habitat {  HabitatName = "NorthAmericaShore", HabitatType = "Shore", AnimalList = new List<Animal>() { animal3 }, EmployeeList = new List<Employee>() { employee1} };
            var habitat3 = new Habitat {  HabitatName = "Swamp1", HabitatType = "Swamp", AnimalList = new List<Animal>() { animal4, animal5 }, EmployeeList = new List<Employee>() { employee2 } };

            

            context.Animals.AddOrUpdate(
                a => a.Name,
                animal1,
                animal2,
                animal3,
                animal4,
                animal5
                );

            context.Employees.AddOrUpdate(
                e => e.FirstName, employee1, employee2);

            context.Habitats.AddOrUpdate(
                h => h.HabitatName,
                habitat1,
                habitat2,
                habitat3
                );

            
            
        }
    }
}
