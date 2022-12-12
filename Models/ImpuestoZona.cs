﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class ImpuestoZona
    {
        public ImpuestoZona()
        {
            ImpuestoPorZonaComprador = new HashSet<ImpuestoPorZonaComprador>();
            ImpuestoPorZonaVendedor = new HashSet<ImpuestoPorZonaVendedor>();
        }

        [Key]
        [Column("ZonaImpuestoID")]
        public short ZonaImpuestoId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string DescripcionZona { get; set; }
        [Required]
        [StringLength(60)]
        [Unicode(false)]
        public string ZonaHierarchy { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CodigoImpuesto { get; set; }
        public int? CiudadId { get; set; }
        public int? EstadoProvinciaId { get; set; }

        [InverseProperty("ZonaImpuesto")]
        public virtual ICollection<ImpuestoPorZonaComprador> ImpuestoPorZonaComprador { get; set; }
        [InverseProperty("ZonaImpuesto")]
        public virtual ICollection<ImpuestoPorZonaVendedor> ImpuestoPorZonaVendedor { get; set; }
    }
}