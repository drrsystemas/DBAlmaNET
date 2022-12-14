// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class AplicacionLicenciaActividad
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Detalle { get; set; }
        [Column("LicenciaID")]
        public int LicenciaId { get; set; }
        [Column("TipoActividadID")]
        public byte TipoActividadId { get; set; }
        [Key]
        [Column("RegActividadID")]
        public int RegActividadId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("ItemVentaID")]
        public int? ItemVentaId { get; set; }

        [ForeignKey("LicenciaId")]
        [InverseProperty("AplicacionLicenciaActividad")]
        public virtual AplicacionLicencia Licencia { get; set; }
    }
}