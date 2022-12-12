﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class OperacionTipo
    {
        public OperacionTipo()
        {
            ComprobanteTipoOperacionTipo = new HashSet<ComprobanteTipoOperacionTipo>();
        }

        [Key]
        [Column("TipoOperacionID")]
        public byte TipoOperacionId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Abriviatura { get; set; }

        [InverseProperty("TipoOperacion")]
        public virtual ICollection<ComprobanteTipoOperacionTipo> ComprobanteTipoOperacionTipo { get; set; }
    }
}