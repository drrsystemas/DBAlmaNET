// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class PermisoForm
    {
        [Column("FormID")]
        public int FormId { get; set; }
        [Column("PermisoID")]
        public int PermisoId { get; set; }
        [Key]
        [Column("RegistroID")]
        public int RegistroId { get; set; }
        public short TipoAcceso { get; set; }

        [ForeignKey("FormId")]
        [InverseProperty("PermisoForm")]
        public virtual Form Form { get; set; }
        [ForeignKey("PermisoId")]
        [InverseProperty("PermisoForm")]
        public virtual Permiso Permiso { get; set; }
    }
}