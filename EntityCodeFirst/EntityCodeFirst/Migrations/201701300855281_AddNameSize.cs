namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameSize : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
