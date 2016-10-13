using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZoolandiaRazor.Models;
using System.Data.Entity;
using ZoolandiaRazor.DAL;
using System.Collections.Generic;
using System.Linq;

namespace ZoolandiaRazor.Tests.DAL
{
    [TestClass]
    public class ZooRepositoryTests
    {

        private Mock<ZooContext> myContext { get; set; }

        
        
        [TestMethod]
        public void TestMethod1()
        {
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

        public void ConnectingToDatabase()
        {
            //Create your Mock DbSets that will be used for testing.
            Mock<DbSet<Animal>> mockAnimals = new Mock<DbSet<Animal>>();

            //Create a list for your DbSet that will be used for testing.
            List<Animal> AnimalList = new List<Animal>()
        {
            new Animal {Name = "Rex", BirthDate = new DateTime(2020, 10, 2) }
        };
            var queryAnimals = AnimalList.AsQueryable();

            //Lie to LINQ make it think that our new Queryable List is a Database table.
            mockAnimals.As<IQueryable<Animal>>().Setup(m => m.Provider).Returns(queryAnimals.Provider);
            mockAnimals.As<IQueryable<Animal>>().Setup(m => m.Expression).Returns(queryAnimals.Expression);
            mockAnimals.As<IQueryable<Animal>>().Setup(m => m.ElementType).Returns(queryAnimals.ElementType);
            mockAnimals.As<IQueryable<Animal>>().Setup(m => m.GetEnumerator()).Returns(() => (queryAnimals.GetEnumerator()));

            //Here, I am setting up the Mock Context to return my DbSet.
            myContext.Setup(c => c.Animals).Returns(mockAnimals.Object);
        }
        //Test to see if you can get all aniamls
        [TestMethod]
        public void CanIMakeAnInstanceOfAnimalClass()
        {
            Mock<DbSet<Animal>> newanimals = new Mock<DbSet<Animal>>();
            Assert.IsNotNull(newanimals);
        }

        [TestMethod]
        public void CanIMakeANewRepository()
        {
            myContext = new Mock<ZooContext>();
            ZooRepository repo = new ZooRepository(myContext.Object);
            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void CanIGetMyAnimals()
        {
            //Create your Mock DbSets that will be used for testing.
            Mock<DbSet<Animal>> mockAnimals;

            //Create a list for your DbSet that will be used for testing.
            List<Animal> AnimalList = new List<Animal>()
        {
            new Animal {Name = "Rex", BirthDate = new DateTime(2020, 10, 2) }
        };

            myContext = new Mock<ZooContext>();
            ZooRepository repo = new ZooRepository(myContext.Object);
            mockAnimals = new Mock<DbSet<Animal>>();
            ConnectingToDatabase();

            List<Animal> myanimals = repo.GetAnimals();
            Assert.AreEqual(myanimals.Count, 1);
        }

        [TestMethod]
        public void CanIGetMyAnimalsByName()
        {
            //Create your Mock DbSets that will be used for testing.
            Mock<DbSet<Animal>> mockAnimals;

            //Create a list for your DbSet that will be used for testing.
            List<Animal> AnimalList = new List<Animal>()
        {
            new Animal {Name = "Rex", BirthDate = new DateTime(2020, 10, 2) }
        };

            myContext = new Mock<ZooContext>();
            ZooRepository repo = new ZooRepository(myContext.Object);
            mockAnimals = new Mock<DbSet<Animal>>();
            ConnectingToDatabase();

            Animal foundAnimal = repo.GetAnimals("Rex");
            Assert.AreEqual(foundAnimal.Name, "Rex");
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
