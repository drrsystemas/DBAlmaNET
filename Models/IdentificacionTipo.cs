﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class IdentificacionTipo
    {
        [Key]
        public byte TipoNroIdentificacion { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Column("FormatoNroID")]
        [StringLength(50)]
        [Unicode(false)]
        public string FormatoNroId { get; set; }
        [Column("TipoNroIdentificacionER")]
        public byte? TipoNroIdentificacionEr { get; set; }
    }
}