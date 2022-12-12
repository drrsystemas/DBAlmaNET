﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class UsuarioWeb
    {
        [Column("AlmaUserID")]
        public int? AlmaUserId { get; set; }
        [Column("EmpresaID")]
        public int EmpresaId { get; set; }
        [Column("IDRealcionado")]
        public int? Idrealcionado { get; set; }
        [StringLength(10)]
        public string CodigoAcceso { get; set; }
        [Column("TipoAccesoID")]
        public byte? TipoAccesoId { get; set; }
        public byte TipoNroIdentificacion { get; set; }
        public long NroIdentificacion { get; set; }


        //[Column("EMail")]
        //[StringLength(150)]
        //[Unicode(false)]
        //public string Email { get; set; }


        //[StringLength(150)]
        //[Unicode(false)]
        //public string Contrasena { get; set; }




        [Key]
        [Column("WebUserID")]
        public int WebUserId { get; set; }
        public bool Inhabilitado { get; set; }
        
        
        
        /// <summary>
        /// Guarda una configuracion x Usuario
        /// </summary>
        [Column(TypeName = "xml")]
        public string Configuracion { get; set; }




        [Column("SectorID")]
        public short? SectorId { get; set; }
        [Column("EntidadSucID")]
        public int? EntidadSucId { get; set; }
        [Column("TipoEntidadID")]
        public byte? TipoEntidadId { get; set; }

        [ForeignKey("AlmaUserId")]
        [InverseProperty("UsuarioWeb")]
        public virtual UsuarioAlmaNet AlmaUser { get; set; }
    }
}