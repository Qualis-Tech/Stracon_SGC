﻿using Pe.Stracon.SGC.Infraestructura.CommandModel.Base;
using Pe.Stracon.SGC.Infraestructura.CommandModel.Contractual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pe.Stracon.SGC.Infraestructura.CommandModel.Mapping.Contractual
{
    /// <summary>
    /// Implementación del mapeo de la entidad ConsultaUsuario
    /// </summary>
    /// <remarks>
    /// Creación:   GMD 20150527 <br />
    /// Modificación:            <br />
    /// </remarks>
    public class ConsultaTrazabilidadMapping : BaseEntityMapping<ConsultaTrazabilidadEntity>
    {
        public ConsultaTrazabilidadMapping()
            : base()
        {
            HasKey(x => x.CodigoConsultaTrazabilidad).ToTable("CONSULTA_TRAZABILIDAD", "CTR");
            Property(u => u.CodigoConsultaTrazabilidad).HasColumnName("CODIGO_CONSULTA_TRAZABILIDAD");
            Property(u => u.CodigoConsulta).HasColumnName("CODIGO_CONSULTA");
            Property(u => u.CodigoRemitente).HasColumnName("CODIGO_REMITENTE");
            Property(u => u.CodigoDestinatario).HasColumnName("CODIGO_DESTINATARIO");
            Property(u => u.FechaEnvio).HasColumnName("FECHA_ENVIO");
            Property(u => u.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");
            Property(u => u.UsuarioCreacion).HasColumnName("USUARIO_CREACION");
            Property(u => u.FechaCreacion).HasColumnName("FECHA_CREACION");
            Property(u => u.TerminalCreacion).HasColumnName("TERMINAL_CREACION");
            Property(u => u.UsuarioModificacion).HasColumnName("USUARIO_MODIFICACION");
            Property(u => u.FechaModificacion).HasColumnName("FECHA_MODIFICACION");
            Property(u => u.TerminalModificacion).HasColumnName("TERMINAL_MODIFICACION");
        }
    }
}