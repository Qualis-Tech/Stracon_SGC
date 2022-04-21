﻿using Pe.Stracon.SGC.Aplicacion.TransferObject.Response.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pe.Stracon.SGC.Aplicacion.TransferObject.Response.Contractual
{
    /// <summary>
    /// Representa el objeto response de Reporte de Observado / Aprobado
    /// </summary>
    /// <remarks>
    /// Creación :      GMD 20160712 <br />
    /// Modificación :               <br />
    /// </remarks>
    public class ReporteRequerimientoObservadoAprobadoResponse : BaseResponse
    {
        /// <summary>
        /// Código de Unidad Operativa
        /// </summary>
        public Guid? CodigoUnidadOperativa { get; set; }
        /// <summary>
        /// Nombre de Unidad Operativa
        /// </summary>
        public string NombreUnidadOperativa { get; set; }
        /// <summary>
        /// CodigoRequerimiento
        /// </summary>
        public Guid? CodigoRequerimiento { get; set; }
        /// <summary>
        /// NumeroRequerimiento
        /// </summary>
        public string NumeroRequerimiento { get; set; }
        /// <summary>
        /// DescripcionRequerimiento
        /// </summary>
        public string DescripcionRequerimiento { get; set; }
        /// <summary>
        /// NumeroAdenda
        /// </summary>
        public string NumeroAdenda { get; set; }
        /// <summary>
        /// Tipo de Acción
        /// </summary>
        public string TipoAccion { get; set; }
        /// <summary>
        /// Fecha de Consulta Desde en cadena de texto
        /// </summary>
        public DateTime FechaConsultaDesde { get; set; }
        /// <summary>
        /// Fecha de Consulta Hasta en cadena de texto
        /// </summary>
        public DateTime FechaConsultaHasta { get; set; }
        /// <summary>
        /// Fecha de Consulta Desde en cadena de texto
        /// </summary>
        public string FechaConsultaDesdeString { get; set; }
        /// <summary>
        /// Fecha de Consulta Hasta en cadena de texto
        /// </summary>
        public string FechaConsultaHastaString { get; set; }
        /// <summary>
        /// MontoRequerimiento
        /// </summary>
        public decimal MontoRequerimiento { get; set; }
        /// <summary>
        /// Usuario de creación
        /// </summary>
        public string AccionPor { get; set; }
        /// <summary>
        /// ComentarioObservacion
        /// </summary>
        public string Comentario { get; set; }
        /// <summary>
        /// FechaObservacion
        /// </summary>
        public string FechaAccion { get; set; }
        /// <summary>
        /// Respuesta
        /// </summary>
        public string Respuesta { get; set; }
        /// <summary>
        /// FechaRespuesta
        /// </summary>
        public string FechaRespuesta { get; set; }
        /// <summary>
        /// UsuarioRespuesta
        /// </summary>
        public string UsuarioRespuesta { get; set; }
    }
}