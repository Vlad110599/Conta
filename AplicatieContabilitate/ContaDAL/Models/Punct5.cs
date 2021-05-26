using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDAL.Models
{
    [Table("Point5")]
    public class Punct5
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public double Venituri { get; set; }

        public double Cheltuieli { get; set; }

        public double Profit { get; set; }

        public int Status { get; set; }
    }
}
