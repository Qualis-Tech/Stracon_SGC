﻿/// <summary>
/// Script de controlador de Parametro.
/// </summary>
/// <remarks>
/// Creacion: 	GMD(SYS) 24/03/2015
/// </remarks>
ns('Pe.Stracon.Politicas.Presentacion.General.SeccionParametro.Index');
try {

    $(document).ready(function () {
        'use strict';
        Pe.Stracon.Politicas.Presentacion.General.SeccionParametro.Index.Vista = new Pe.Stracon.Politicas.Presentacion.General.SeccionParametro.Index.Controller();
        Pe.Stracon.Politicas.Presentacion.General.SeccionParametro.Index.Vista.Ini();
    });
} catch (ex) {
    //Belcorp.Planit.RegistrarError(ex);
}