using System.Data.Entity;
namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        static DatabaseContext()
        {
            // فقط به درد برنامه نويسان آنهم در زمان پياده سازی می خورد
            //System.Data.Entity.Database.SetInitializer
            //	(new System.Data.Entity.DropCreateDatabaseAlways<DatabaseContext>());

            // فقط به درد برنامه نويسان آنهم در زمان پياده سازی می خورد
            System.Data.Entity.Database.SetInitializer
                (new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());

            // به درد مشتری می خورد
            //System.Data.Entity.Database.SetInitializer
            //	(new System.Data.Entity.CreateDatabaseIfNotExists<DatabaseContext>());
        }

        public DatabaseContext()
            : base()
        {
        }

        public DbSet<AcademyDay> AcademyDays { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<Instrument> Instrumental { get; set; }
        public DbSet<JoinToCourse> JoinToCourses { get; set; }
        public DbSet<PaymentUniqueNumber> PaymentUniqueNumbers { get; set; }
        public DbSet<PaymentCourse> PaymentCourses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomsDay> RoomsDays { get; set; }
        public DbSet<RoomsFeature> RoomsFeatures { get; set; }
        public DbSet<TeachersInstrumental> TeachersInstrumental { get; set; }
        public DbSet<Institute> Institute { get; set; }


    }

}