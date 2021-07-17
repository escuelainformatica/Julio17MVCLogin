using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Julio17MVC.Models
{
    public partial class Usuario
    {
        [Key]
        [Column("Usuario")]
        [StringLength(40)]
        [Unicode(false)]
        public string Usuario1 { get; set; }
        [StringLength(64)]
        [Unicode(false)]
        public string Clave { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string NombreCompleto { get; set; }
    }
}
