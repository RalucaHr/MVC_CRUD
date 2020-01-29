using Hrisca_Raluca_assignment_2_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hrisca_Raluca_assignment_2_.DAL
{
    public class HRI_CollegeDb : DbContext 
    {
        public HRI_CollegeDb() : base ("name = MyConnection")
        {

        } 

        public DbSet<Trainer> trainers { get; set; }
        
    }
}