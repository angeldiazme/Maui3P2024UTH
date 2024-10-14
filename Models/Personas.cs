using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Maui3P2024UTH.Models
{
    [Table("Personas")]
    public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(1000)]
        public string Nombres { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string Apellido { get; set; } = string.Empty;

        public DateTime Fecha { get; set; } = DateTime.Now;

        [MaxLength(1000)]
        public string Telefono { get; set; } = string.Empty;


    }
    
}
