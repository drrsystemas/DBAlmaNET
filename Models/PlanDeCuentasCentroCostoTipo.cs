// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class PlanDeCuentasCentroCostoTipo
    {
        [Key]
        [Column("TipoCentroCostoID")]
        public short TipoCentroCostoId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string Descripcion { get; set; }
    }
}