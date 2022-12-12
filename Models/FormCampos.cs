﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class FormCampos
    {
        public FormCampos()
        {
            PermisoFormCampos = new HashSet<PermisoFormCampos>();
        }

        [Key]
        [Column("CamposID")]
        public int CamposId { get; set; }
        [Column("FormID")]
        public int FormId { get; set; }
        [Required]
        [StringLength(150)]
        [Unicode(false)]
        public string NameCampo { get; set; }
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Column("TypeControlID")]
        public short TypeControlId { get; set; }

        [ForeignKey("FormId")]
        [InverseProperty("FormCampos")]
        public virtual Form Form { get; set; }
        [ForeignKey("TypeControlId")]
        [InverseProperty("FormCampos")]
        public virtual TypeControl TypeControl { get; set; }
        [InverseProperty("Campos")]
        public virtual ICollection<PermisoFormCampos> PermisoFormCampos { get; set; }
    }
}