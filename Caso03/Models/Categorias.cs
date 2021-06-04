using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caso03.Models
{
    [Table("categorias")]
    public class Categorias{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id{get; set;}

        [Required]
        [MaxLength(100)]
        public string nombre{get; set;} 

    }
}