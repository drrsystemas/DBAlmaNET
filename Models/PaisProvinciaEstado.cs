﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class PaisProvinciaEstado
    {
        public PaisProvinciaEstado()
        {
            PaisProvinciaEstadoCiudad = new HashSet<PaisProvinciaEstadoCiudad>();
        }

        [Column("PaisID")]
        public short PaisId { get; set; }
        [Key]
        [Column("EstadoProvinciaID")]
        public int EstadoProvinciaId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string DescripcionProvinciaEstado { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string AbreviaturaPcia { get; set; }
        public int? CodigoProvinciaRenta { get; set; }

        [ForeignKey("PaisId")]
        [InverseProperty("PaisProvinciaEstado")]
        public virtual Pais Pais { get; set; }
        [InverseProperty("EstadoProvincia")]
        public virtual ICollection<PaisProvinciaEstadoCiudad> PaisProvinciaEstadoCiudad { get; set; }
    }
}