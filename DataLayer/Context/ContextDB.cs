using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Models;

namespace DataLayer
{
    public class ContextDB : IdentityDbContext<Person>
    {

        public ContextDB()
          : base("DefaultConnection")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<UserCMS>().ToTable("UserCMS");
            //modelBuilder.Entity<Category>().Property(x => x.Title).IsRequired();

            modelBuilder.Entity<JoinToCourse>().HasRequired(i => i.Person).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<JoinToCourse>().HasRequired(i => i.Course).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<Person>().HasRequired(i => i.JoinToCourse).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<Course>().HasRequired(i => i.JoinToCourse).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<Person>().HasRequired(i => i.PaymentCourse).WithMany().WillCascadeOnDelete(false);


            base.OnModelCreating(modelBuilder);

        }

        #region Add Constructor Identity Classes

        static ContextDB()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            // Database.SetInitializer<ContextDB>(new ApplicationDbInitializer());
        }

        public static ContextDB Create()
        {
            return new ContextDB();
        }

        #endregion


        #region Map To Database
        public DbSet<Course> Courses { get; set; }
        public DbSet<AcademyDay> AcademyDays { get; set; }
        
        public DbSet<Feature> Feature { get; set; }
        public DbSet<Instrument> Instrumental { get; set; }
        public DbSet<JoinToCourse> JoinToCourses { get; set; }
        public DbSet<PaymentUniqueNumber> PaymentUniqueNumbers { get; set; }
        public DbSet<PaymentCourse> PaymentCourses { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomsDay> RoomsDays { get; set; }
        public DbSet<RoomsFeature> RoomsFeatures { get; set; }
        public DbSet<TeachersInstrumental> TeachersInstrumental { get; set; }
        public DbSet<Institute> Institute { get; set; }

        #endregion
    }
}
