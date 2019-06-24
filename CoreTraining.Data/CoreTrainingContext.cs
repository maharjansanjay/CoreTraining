using CoreTraining.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTraining.Data
{

    public class CoreTrainingContext: DbContext
    {
        public CoreTrainingContext(DbContextOptions<CoreTrainingContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=localhost\\SQLDEV;Database=CoreTraining;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
