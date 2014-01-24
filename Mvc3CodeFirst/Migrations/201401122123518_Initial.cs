namespace Mvc3CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Seniority = c.String(),
                        Affiliation = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ViewCounts = c.Int(nullable: false),
                        CommentCounts = c.Int(nullable: false),
                        Category = c.Int(nullable: false),
                        LikertScale = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Activities");
            DropTable("dbo.Students");
        }
    }
}
