﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pe.Stracon.SGC.Presentacion.Recursos.Contractual {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ReporteTiempoEjecucionResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ReporteTiempoEjecucionResource() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pe.Stracon.SGC.Presentacion.Recursos.Contractual.ReporteTiempoEjecucionResource", typeof(ReporteTiempoEjecucionResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Contratos Generados Desde.
        /// </summary>
        public static string EtiquetaContratosGeneradosDesde {
            get {
                return ResourceManager.GetString("EtiquetaContratosGeneradosDesde", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Contratos Generados Hasta.
        /// </summary>
        public static string EtiquetaContratosGeneradosHasta {
            get {
                return ResourceManager.GetString("EtiquetaContratosGeneradosHasta", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Reporte de Tiempo de Ejecución.
        /// </summary>
        public static string EtiquetaTitulo {
            get {
                return ResourceManager.GetString("EtiquetaTitulo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Unidad Operativa.
        /// </summary>
        public static string EtiquetaUnidadOperativa {
            get {
                return ResourceManager.GetString("EtiquetaUnidadOperativa", resourceCulture);
            }
        }
    }
}