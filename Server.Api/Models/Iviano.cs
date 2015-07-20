﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Server.Api.Models
{
    [Table("Ivianos")]
    public class Iviano
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Login { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public ICollection<RegistroPonto> RegistrosPonto { get; set; }
    }
}