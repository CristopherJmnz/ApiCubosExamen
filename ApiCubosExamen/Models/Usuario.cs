﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCubosExamen.Models
{
    [Table("USUARIOCUBOS")]
    public class Usuario
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("imagen")]
        public string Imagen{ get; set; }
    }
}