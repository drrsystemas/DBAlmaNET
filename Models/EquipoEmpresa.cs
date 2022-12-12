﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class EquipoEmpresa
    {
        public EquipoEmpresa()
        {
            UsuarioAlmaNetequipo = new HashSet<UsuarioAlmaNetequipo>();
        }

        [Key]
        public int IdEquipo { get; set; }
        [StringLength(50)]
        public string Denominacion { get; set; }
        [Column("DireccionIPRemoto")]
        [StringLength(20)]
        [Unicode(false)]
        public string DireccionIpremoto { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string NombreEquipoLocal { get; set; }
        [Column("EmpresaID")]
        public int? EmpresaId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string ConexionSoporte { get; set; }

        [InverseProperty("IdEquipoNavigation")]
        public virtual ICollection<UsuarioAlmaNetequipo> UsuarioAlmaNetequipo { get; set; }
    }
}