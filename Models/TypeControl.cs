// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class TypeControl
    {
        public TypeControl()
        {
            FormCampos = new HashSet<FormCampos>();
        }

        [Key]
        [Column("TypeControlID")]
        public short TypeControlId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string NameControl { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string Descripcion { get; set; }

        [InverseProperty("TypeControl")]
        public virtual ICollection<FormCampos> FormCampos { get; set; }
    }
}