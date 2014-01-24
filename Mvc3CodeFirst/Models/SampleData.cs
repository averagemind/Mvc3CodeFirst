using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Mvc3CodeFirst.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ViewCounts { get; set; }
        public int CommentCounts { get; set; }
        public int Category { get; set; }
        public int LikertScale { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Seniority { get; set; }
        public string Affiliation { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }

    public class SampleDataContext : DbContext
    {
        public SampleDataContext()
            : base("name=SampleDataContext")
        {
            //#if DEBUG
            //Database.SetInitializer<SampleDataContext>(new DropCreateIfChangeInitializer());
            //#endif
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Activity> Activities { get; set; }

/*
        public void Seed(SampleDataContext context)
        {
            #if DEBUG
            Mvc3CodeFirst.Migrations.Configuration.AddActivities(context);
            Mvc3CodeFirst.Migrations.Configuration.AddStudents(context);
            #endif

            // Normal seeding goes here
            context.SaveChanges();
        }

        public class DropCreateIfChangeInitializer : DropCreateDatabaseIfModelChanges<SampleDataContext>
        {
            protected override void Seed(SampleDataContext context)
            {
                context.Seed(context);
                base.Seed(context);
            }
        }

        public class CreateInitializer : CreateDatabaseIfNotExists<SampleDataContext>
        {
            protected override void Seed(SampleDataContext context)
            {
                context.Seed(context);
                base.Seed(context);
            }
        }
 */
    }
}