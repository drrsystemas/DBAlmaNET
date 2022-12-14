// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class TransporteCubiertaDiseno
    {
        [Key]
        [Column("DiseñoCubiertaID")]
        public short DiseñoCubiertaId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Diseño { get; set; }
        [Column("CodigoID")]
        public int? CodigoId { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? KmPromedio { get; set; }
    }
}