﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DRR.Core.DBAlmaNET.Models
{
    [Table("ConfiguracionNET")]
    public partial class ConfiguracionNet
    {
        [Column("MembreteDRR")]
        public byte[] MembreteDrr { get; set; }
        [Column("WebPublicidadDRR")]
        [StringLength(500)]
        [Unicode(false)]
        public string WebPublicidadDrr { get; set; }
        [Key]
        [Column("RegistroID")]
        public short RegistroId { get; set; }
        [Column("FechaPadronAFIP", TypeName = "datetime")]
        public DateTime? FechaPadronAfip { get; set; }
        [Column("FechaPadronARBA", TypeName = "datetime")]
        public DateTime? FechaPadronArba { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaModificacionImpuesto { get; set; }
        [Column("AFIP_TicketAcceso")]
        [Unicode(false)]
        public string AfipTicketAcceso { get; set; }
        [Column("AFIP_Certificado_CAE")]
        public byte[] AfipCertificadoCae { get; set; }
    }
}