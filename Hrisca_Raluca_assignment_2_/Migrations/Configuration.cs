namespace Hrisca_Raluca_assignment_2_.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hrisca_Raluca_assignment_2_.DAL.HRI_CollegeDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Hrisca_Raluca_assignment_2_.DAL.HRI_CollegeDb";
        }

        protected override void Seed(Hrisca_Raluca_assignment_2_.DAL.HRI_CollegeDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
