// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class PermisoWebForm
    {
        [Column("PermisoID")]
        public int PermisoId { get; set; }
        [Column("WebFormID")]
        public int WebFormId { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        public short TipoAcceso { get; set; }

        [ForeignKey("PermisoId")]
        [InverseProperty("PermisoWebForm")]
        public virtual Permiso Permiso { get; set; }
        [ForeignKey("WebFormId")]
        [InverseProperty("PermisoWebForm")]
        public virtual WebForm WebForm { get; set; }
    }
}