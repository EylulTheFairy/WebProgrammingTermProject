using System;
using System.Data.Entity;
using System.Linq;

namespace Hospital4.Models
{
    public class hospitalDB : DbContext
    {
        // Your context has been configured to use a 'hospitalDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Hospital4.Models.hospitalDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'hospitalDB' 
        // connection string in the application configuration file.
        public hospitalDB()
            : base("name=hospitalDB")
        {
        }
        public System.Data.Entity.DbSet<Hospital4.Models.appointment> appointments { get; set; }
        public System.Data.Entity.DbSet<Hospital4.Models.bill> bills { get; set; }
        public System.Data.Entity.DbSet<Hospital4.Models.doctor> doctors { get; set; }
        public System.Data.Entity.DbSet<Hospital4.Models.nurse> nurses { get; set; }
        public System.Data.Entity.DbSet<Hospital4.Models.patient> patients { get; set; }
        public System.Data.Entity.DbSet<Hospital4.Models.room> rooms { get; set; }
        public System.Data.Entity.DbSet<Hospital4.Models.treatment> treatments { get; set; }



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}