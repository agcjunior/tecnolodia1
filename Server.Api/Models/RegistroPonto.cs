using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Api.Models
{
    public class RegistroPonto
    {
        public int Id { get; set; }
        public int IvianoId { get; set; }
        public Iviano Iviano { get; set; }
        public DateTime DataHoraRegistro { get; set; }

    }
}