using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Server.Api.Models;

namespace Server.Api
{
    public class TecnolodiaCtx : DbContext
    {
        public TecnolodiaCtx() : base("Name=TecnolodiaCtx")
        {

        }

        public DbSet<Iviano> Ivianos { get; set; }
        public DbSet<RegistroPonto> RegistrosPonto { get; set; }
    }
}