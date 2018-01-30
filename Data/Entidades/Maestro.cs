using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entidades
{
    public class Maestro
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        public IList<Detalle> Detalles { get; set; }
    }
}
