namespace ZoolandiaRazor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        AnimalId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CommonName = c.String(),
                        ScientificName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        CurrentHabitat_HabitatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AnimalId)
                .ForeignKey("dbo.Habitats", t => t.CurrentHabitat_HabitatId, cascadeDelete: true)
                .Index(t => t.CurrentHabitat_HabitatId);
            
            CreateTable(
                "dbo.Habitats",
                c => new
                    {
                        HabitatId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.HabitatId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        IsLicensedGorillaHandler = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EmployeeHabitats",
                c => new
                    {
                        Employee_EmployeeId = c.Int(nullable: false),
                        Habitat_HabitatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_EmployeeId, t.Habitat_HabitatId })
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Habitats", t => t.Habitat_HabitatId, cascadeDelete: true)
                .Index(t => t.Employee_EmployeeId)
                .Index(t => t.Habitat_HabitatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "CurrentHabitat_HabitatId", "dbo.Habitats");
            DropForeignKey("dbo.EmployeeHabitats", "Habitat_HabitatId", "dbo.Habitats");
            DropForeignKey("dbo.EmployeeHabitats", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmployeeHabitats", new[] { "Habitat_HabitatId" });
            DropIndex("dbo.EmployeeHabitats", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.Animals", new[] { "CurrentHabitat_HabitatId" });
            DropTable("dbo.EmployeeHabitats");
            DropTable("dbo.Employees");
            DropTable("dbo.Habitats");
            DropTable("dbo.Animals");
        }
    }
}
