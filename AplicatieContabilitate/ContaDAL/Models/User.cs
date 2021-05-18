using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContaDAL.Models
{
    [Table("Utilizator")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Password { get; set; }


    }
}
