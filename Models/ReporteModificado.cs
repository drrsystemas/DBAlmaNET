﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class ReporteModificado
    {
        [Column("ReportID")]
        public int ReportId { get; set; }
        public byte[] Reporte { get; set; }
        [Key]
        [Column("ReporteModifID")]
        public int ReporteModifId { get; set; }
        [Column("EmpresaID")]
        public int? EmpresaId { get; set; }

        [ForeignKey("ReportId")]
        [InverseProperty("ReporteModificado")]
        public virtual Reporte Report { get; set; }
    }
}