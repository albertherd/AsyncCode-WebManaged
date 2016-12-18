namespace KssAsyncCodeWeb.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KSSContext : DbContext
    {
        // Your context has been configured to use a 'KSSContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KssAsyncCodeWeb.Data.KSSContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KSSContext' 
        // connection string in the application configuration file.
        public KSSContext()
            : base("name=KSSContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Employee> Employees { get; set; }
    }
}