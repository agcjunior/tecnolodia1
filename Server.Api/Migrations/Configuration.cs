namespace Server.Api.Migrations
{
    using Server.Api.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Server.Api.TecnolodiaCtx>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Server.Api.TecnolodiaCtx context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Ivianos.AddOrUpdate(
              p => p.Login,
              new Iviano {Login="Yann.braga", Nome = "Yann Braga", DataNascimento = new DateTime(1993,01,01)   }
            );
            
        }
    }
}
