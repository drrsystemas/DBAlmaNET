// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class AplicacionLicenciaModulo
    {
        [Key]
        [Column("LicenciaModuloID")]
        public int LicenciaModuloId { get; set; }
        [Column("ItemVentaID")]
        public int? ItemVentaId { get; set; }
        [Column("VentaID")]
        public int? VentaId { get; set; }
        [Column("LicenciaID")]
        public int LicenciaId { get; set; }
        [StringLength(500)]
        public string Modulo { get; set; }
        [Column("ModuloID")]
        public short ModuloId { get; set; }

        [ForeignKey("LicenciaId")]
        [InverseProperty("AplicacionLicenciaModulo")]
        public virtual AplicacionLicencia Licencia { get; set; }
        [ForeignKey("ModuloId")]
        [InverseProperty("AplicacionLicenciaModulo")]
        public virtual AplicacionModulo ModuloNavigation { get; set; }
    }
}