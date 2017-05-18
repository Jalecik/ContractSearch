namespace Books.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50, unicode: false),
                        PublishDate = c.String(maxLength: 10, unicode: false),
                        Price = c.Int(nullable: false),
                        Language = c.String(maxLength: 10, unicode: false),
                        Publisher = c.String(),
                        Genre = c.String(maxLength: 6, unicode: false),
                        EditionAmount = c.String(maxLength: 6, unicode: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(maxLength: 30, unicode: false),
                        Email = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Authors");
            DropTable("dbo.Books");
        }
    }
}
