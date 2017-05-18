namespace CustomizingtableEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculty",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(maxLength: 50, unicode: false),
                        Teachers = c.String(maxLength: 50, unicode: false),
                        Faculty2_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculty", t => t.Faculty2_Id)
                .Index(t => t.Faculty2_Id);
            
            CreateTable(
                "dbo.StudentsInformation",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Surname = c.String(maxLength: 50, unicode: false),
                        Gender = c.String(maxLength: 50, unicode: false),
                        Birthdate = c.DateTime(storeType: "date"),
                        Email = c.String(maxLength: 50, unicode: false),
                        Phone = c.Int(),
                        Country = c.String(maxLength: 50, unicode: false),
                        City = c.String(maxLength: 50, unicode: false),
                        Enteringyear = c.DateTime(name: "Entering year", storeType: "date"),
                        GraduationYear = c.DateTime(name: "Graduation Year", storeType: "date"),
                        Group = c.String(maxLength: 50, unicode: false),
                        AverageMark = c.Double(name: "Average Mark"),
                        FacultyId = c.Int(),
                        Status = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.Id, t.Name });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faculty", "Faculty2_Id", "dbo.Faculty");
            DropIndex("dbo.Faculty", new[] { "Faculty2_Id" });
            DropTable("dbo.StudentsInformation");
            DropTable("dbo.Faculty");
        }
    }
}
