// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class BancoSucursal
    {
        [Key]
        [Column("BancoSucursalID")]
        public int BancoSucursalId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Column("BancoID")]
        public int? BancoId { get; set; }
        public int CiudadId { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Web { get; set; }
        [Column("ContactoE_mail")]
        [StringLength(250)]
        [Unicode(false)]
        public string ContactoEMail { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ContactoTel { get; set; }
        [Unicode(false)]
        public string Detalle { get; set; }
        public int CodigoSucursal { get; set; }

        [ForeignKey("BancoId")]
        [InverseProperty("BancoSucursal")]
        public virtual Banco Banco { get; set; }
        [ForeignKey("CiudadId")]
        [InverseProperty("BancoSucursal")]
        public virtual PaisProvinciaEstadoCiudad Ciudad { get; set; }
    }
}