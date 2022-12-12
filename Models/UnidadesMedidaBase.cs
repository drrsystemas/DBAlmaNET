﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class UnidadesMedidaBase
    {
        [Key]
        [Column("UnidadMedidaID")]
        public short UnidadMedidaId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string DescripcionCorta { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal CoefContenido { get; set; }
        [Required]
        [StringLength(250)]
        [Unicode(false)]
        public string UnidadMedidaHierarchy { get; set; }
    }
}