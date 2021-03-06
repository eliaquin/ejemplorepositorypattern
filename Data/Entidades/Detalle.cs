﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entidades
{
    public class Detalle
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; }
        public int MaestroId { get; set; }
        public Maestro Maestro { get; set; }
    }
}
