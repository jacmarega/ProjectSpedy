using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Classificados.Models
{
    public class Classificados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }
    }
}