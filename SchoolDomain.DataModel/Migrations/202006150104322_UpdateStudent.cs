namespace SchoolDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudent : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "Course_Id", newName: "CourseId");
            RenameIndex(table: "dbo.Students", name: "IX_Course_Id", newName: "IX_CourseId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Students", name: "IX_CourseId", newName: "IX_Course_Id");
            RenameColumn(table: "dbo.Students", name: "CourseId", newName: "Course_Id");
        }
    }
}
