﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class AccesoAutorizacion
    {
        public AccesoAutorizacion()
        {
            PermisosGenericos = new HashSet<PermisosGenericos>();
        }

        [Key]
        [Column("AccesolID")]
        public short AccesolId { get; set; }
        [Required]
        [StringLength(150)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column("esEditable")]
        public bool EsEditable { get; set; }

        [InverseProperty("Accesol")]
        public virtual ICollection<PermisosGenericos> PermisosGenericos { get; set; }
    }
}