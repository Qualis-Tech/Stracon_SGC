﻿/// <summary>
/// Script del Layout de la aplicación
/// </summary>
/// <remarks>
/// Creacion: 	GMD 20150614
/// </remarks>
ns('Pe.Stracon.SGC.Presentacion.Contractual.VariablePlantilla.Index');
try {
    $(document).ready(function () {
        'use strict';
        Pe.Stracon.SGC.Presentacion.Contractual.VariablePlantilla.Index.Vista = new Pe.Stracon.SGC.Presentacion.Contractual.VariablePlantilla.Index.Controller();
        Pe.Stracon.SGC.Presentacion.Contractual.VariablePlantilla.Index.Vista.Ini();
    });
} catch (ex) {
    
}