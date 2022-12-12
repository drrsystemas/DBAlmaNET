﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    public partial class ImpuestoEmisionComprobante
    {
        public ImpuestoEmisionComprobante()
        {
            ImpuestoPorEmisionComprobante = new HashSet<ImpuestoPorEmisionComprobante>();
        }

        [Key]
        [Column("EmisionID")]
        public short EmisionId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Descripcion { get; set; }
        [Column("CompradorCategoriaImpuestoID")]
        public byte CompradorCategoriaImpuestoId { get; set; }
        [Column("VendedorCategoriaImpuestoID")]
        public byte VendedorCategoriaImpuestoId { get; set; }
        [Column("RegCompOperID")]
        public int? RegCompOperId { get; set; }

        [ForeignKey("CompradorCategoriaImpuestoId")]
        [InverseProperty("ImpuestoEmisionComprobanteCompradorCategoriaImpuesto")]
        public virtual ImpuestoCategoria CompradorCategoriaImpuesto { get; set; }
        [ForeignKey("RegCompOperId")]
        [InverseProperty("ImpuestoEmisionComprobante")]
        public virtual ComprobanteTipoOperacionTipo RegCompOper { get; set; }
        [ForeignKey("VendedorCategoriaImpuestoId")]
        [InverseProperty("ImpuestoEmisionComprobanteVendedorCategoriaImpuesto")]
        public virtual ImpuestoCategoria VendedorCategoriaImpuesto { get; set; }
        [InverseProperty("Emision")]
        public virtual ICollection<ImpuestoPorEmisionComprobante> ImpuestoPorEmisionComprobante { get; set; }
    }
}