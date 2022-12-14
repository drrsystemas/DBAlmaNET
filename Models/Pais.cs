// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class Pais
    {
        public Pais()
        {
            PaisCuit = new HashSet<PaisCuit>();
            PaisProvinciaEstado = new HashSet<PaisProvinciaEstado>();
        }

        [Key]
        [Column("PaisID")]
        public short PaisId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string Abreviatura { get; set; }
        [Column("PaisIDER")]
        public short? PaisIder { get; set; }

        [InverseProperty("Pais")]
        public virtual ICollection<PaisCuit> PaisCuit { get; set; }
        [InverseProperty("Pais")]
        public virtual ICollection<PaisProvinciaEstado> PaisProvinciaEstado { get; set; }
    }
}