namespace SchoolDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfStudents = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        NumberOfCourses = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Area = c.String(),
                        CourseId = c.Int(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.CourseId)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Age = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Subjects", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "SchoolId", "dbo.Schools");
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropIndex("dbo.Subjects", new[] { "Student_Id" });
            DropIndex("dbo.Subjects", new[] { "CourseId" });
            DropIndex("dbo.Courses", new[] { "SchoolId" });
            DropTable("dbo.Students");
            DropTable("dbo.Subjects");
            DropTable("dbo.Schools");
            DropTable("dbo.Courses");
        }
    }
}
