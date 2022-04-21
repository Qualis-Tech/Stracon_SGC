﻿using Pe.Stracon.SGC.Cross.Core.Base;
using Pe.Stracon.SGC.Infraestructura.CommandModel.Contractual;
using Pe.Stracon.SGC.Infraestructura.Core.CommandContract.Contractual;
using Pe.Stracon.SGC.Infraestructura.Core.Context;
using Pe.Stracon.SGC.Infraestructura.Repository.Base;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Pe.Stracon.SGC.Infraestructura.Repository.Command.Contractual
{
    /// <summary>
    /// Implementación del Repositorio de Contrato Documento Adjunto
    /// </summary>
    /// <remarks>
    /// Creación :      GMD 20151014 <br />
    /// Modificación :               <br />
    /// </remarks>
    public class ContratoDocumentoAdjuntoEntityRepository : ComandRepository<ContratoDocumentoAdjuntoEntity>, IContratoDocumentoAdjuntoEntityRepository
    {
    }
}