﻿using System.Collections.Generic;
using Pe.Stracon.SGC.Aplicacion.Core.Base;
using Pe.Stracon.SGC.Aplicacion.TransferObject.Request.Contractual;
using Pe.Stracon.SGC.Aplicacion.TransferObject.Response.Contractual;
using System;

namespace Pe.Stracon.SGC.Application.Core.ServiceContract
{
    /// <summary>
    /// Interfaz que define el servicio de plantilla
    /// </summary>
    /// <remarks>
    /// Creación:       <br />
    /// Modificación:                <br />
    /// </remarks>
    public interface IPlantillaRequerimientoService : IGenericService

    {
        /// <summary>
        /// Realiza la búsqueda de plantillas
        /// </summary>
        /// <param name="filtro">Filtro de búsqueda</param>
        /// <returns>Lista de plantillas</returns>
        ProcessResult<List<PlantillaRequerimientoResponse>> BuscarPlantilla(PlantillaRequerimientoRequest filtro);

        /// <summary>
        /// Registra o actualiza una plantilla
        /// </summary>
        /// <param name="data">Datos a registrar</param>
        /// <returns>Indicador con el resultado de la operación</returns>
        ProcessResult<object> RegistrarPlantilla(PlantillaRequerimientoRequest data);

        /// <summary>
        /// Eliminar una o muchas plantillas
        /// </summary>
        /// <param name="listaCodigosPlantilla">Lista de Códigos de Plantilla a eliminar</param>
        /// <returns>Indicador con el resultado de la operación</returns>
        ProcessResult<object> EliminarPlantilla(List<object> listaCodigosPlantilla);

        /// <summary>
        /// Realiza la búsqueda de plantilla párrafo
        /// </summary>
        /// <param name="filtro">Filtro de búsqueda</param>
        /// <returns>Lista de plantilla párrafo</returns>
        ProcessResult<List<PlantillaRequerimientoParrafoResponse>> BuscarPlantillaParrafo(PlantillaRequerimientoParrafoRequest filtro);

        /// <summary>
        /// Registra o actualiza un párrafo
        /// </summary>
        /// <param name="data">Datos a registrar</param>
        /// <returns>Indicador con el resultado de la operación</returns>
        ProcessResult<object> RegistrarPlantillaParrafo(PlantillaRequerimientoParrafoRequest data);

        /// <summary>
        /// Realiza la búsqueda de variables globales
        /// </summary>
        /// <param name="codigoPlantilla">Código de Plantilla</param>
        /// <returns>Lista de variables globales</returns>
        ProcessResult<List<VariableResponse>> BuscarVariableGlobal(string codigoPlantilla);

        /// <summary>
        /// Eliminar una o muchas plantilla párrafo
        /// </summary>
        /// <param name="listaCodigosPlantillaParrafo">Lista de Códigos de Plantilla Párrafo a eliminar</param>
        /// <returns>Indicador con el resultado de la operación</returns>
        ProcessResult<object> EliminarPlantillaParrafo(List<object> listaCodigosPlantillaParrafo);

        /// <summary>
        /// Realiza la búsqueda de plantilla párrafo variable
        /// </summary>
        /// <param name="filtro">Filtro de búsqueda</param>
        /// <returns>Lista de plantilla párrafo variable</returns>
        ProcessResult<List<PlantillaRequerimientoParrafoVariableResponse>> BuscarPlantillaParrafoVariableCodigoPlantillaParrafo(PlantillaRequerimientoParrafoVariableRequest filtro);

        /// <summary>
        /// Realiza la búsqueda de notas al pie por plantilla
        /// </summary>
        /// <param name="filtro">Filtro de búsqueda</param>
        /// <returns>Listado de notas al pie</returns>
        ProcessResult<List<PlantillaRequerimientoNotaPieResponse>> BuscarNotasPiePorPlantilla(PlantillaRequerimientoNotaPieRequest filtro);

        /// <summary>
        /// Registra o actualiza una nota al pie
        /// </summary>
        /// <param name="data">Datos a registrar</param>
        /// <returns>Indicador con el resultado de la operación</returns>
        ProcessResult<object> RegistrarNotaPie(PlantillaRequerimientoNotaPieRequest data);

        /// <summary>
        /// Elimina uno o muchas notas al pie
        /// </summary>
        /// <param name="listaCodigosNotas">Lista de notas a eliminar</param>
        /// <returns>Indicador con el resultado de la operación</returns>
        ProcessResult<object> EliminarNotas(List<Guid> listaCodigosNotas);
        
    }
}
