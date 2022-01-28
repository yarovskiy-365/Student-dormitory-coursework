using Ex.Classes;
using System;
using System.Data.Entity;
using System.Linq;

namespace Ex
{
    public class ModelDormitoryContext : DbContext
    {
        public ModelDormitoryContext() : base("ModelDormitoryContext") { }

        static ModelDormitoryContext()
        {
            Database.SetInitializer<ModelDormitoryContext>(new MyContextInitializer());
        }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Intruder> Intruders { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Olympics>().HasMany(e => e.Sports).WithMany().MapToStoredProcedures();
            //modelBuilder.Entity<Olympics>().HasMany(e => e.Sports).WithOptional().WillCascadeOnDelete();
        }
    }

    //CreateDatabaseIfNotExists
    //DropCreateDatabaseIfModelChanges
    //DropCreateDatabaseAlways
    class MyContextInitializer : DropCreateDatabaseAlways<ModelDormitoryContext>
    {
        protected override void Seed(ModelDormitoryContext db)
        {

        }
    }
}