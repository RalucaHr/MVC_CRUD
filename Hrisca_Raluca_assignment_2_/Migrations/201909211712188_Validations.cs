namespace Hrisca_Raluca_assignment_2_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trainers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Trainers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Trainers", "Subject", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trainers", "Subject", c => c.String());
            AlterColumn("dbo.Trainers", "LastName", c => c.String());
            AlterColumn("dbo.Trainers", "FirstName", c => c.String());
        }
    }
}
