﻿using Pe.Stracon.SGC.Infraestructura.Core.Base;
using Pe.Stracon.SGC.Infraestructura.QueryModel.Contractual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pe.Stracon.SGC.Infraestructura.Core.QueryContract.Contractual
{
    public interface IConsultaAdjuntoLogicRepository : IQueryRepository<ConsultaAdjuntoLogic>
    {
       /// <summary>
        /// Permite buscar los documentos adjuntos de una consulta
        /// </summary>
        /// <param name="codigoContratoDocumentoAdjunto">Código del Documento adjunto al contrato</param>
        /// <param name="codigoContrato">Código del Contrato</param>
        /// <param name="codigoArchivo">Código de Archivo</param>
        /// <param name="nombreArchivo">Nombre de Archivo</param>
        /// <param name="estadoRegistro">Estado de Registro</param>
        /// <returns>Lista documentos adjuntos del contrato</returns>
        List<ConsultaAdjuntoLogic> BuscarConsultaAdjunto(Guid? codigoConsultaAdjunto, Guid? codigoConsulta, int? codigoArchivo, string nombreArchivo, string estadoRegistro);
    }
}
