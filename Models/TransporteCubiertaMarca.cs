﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class TransporteCubiertaMarca
    {
        [Key]
        [Column("MarcaID")]
        public short MarcaId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
    }
}