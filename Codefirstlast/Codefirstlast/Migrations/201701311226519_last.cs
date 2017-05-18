namespace Codefirstlast.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Students", newName: "Student");
            RenameTable(name: "dbo.Subjects", newName: "Subject");
            RenameColumn(table: "dbo.Student", name: "Name", newName: "FirstName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Student", name: "FirstName", newName: "Name");
            RenameTable(name: "dbo.Subject", newName: "Subjects");
            RenameTable(name: "dbo.Student", newName: "Students");
        }
    }
}
