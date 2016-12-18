using System.Data.Entity.Migrations;
using KssAsyncCodeWeb.Data;
using KssAsyncCodeWeb.Data.Models;

namespace KssAsyncCodeWeb.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<KSSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KSSContext context)
        {
            for(int i = 0; i < 100000; i++)
            {
                context.Employees.AddOrUpdate(new Employee()
                {
                    Id = i,
                    Name = "Albert",
                    Surname = "Herd"
                });
            }
        }
    }
}
