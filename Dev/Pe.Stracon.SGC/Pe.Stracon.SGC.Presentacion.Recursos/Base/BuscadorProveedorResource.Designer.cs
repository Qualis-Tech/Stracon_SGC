﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pe.Stracon.SGC.Presentacion.Recursos.Base {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class BuscadorProveedorResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BuscadorProveedorResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pe.Stracon.SGC.Presentacion.Recursos.Base.BuscadorProveedorResource", typeof(BuscadorProveedorResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to RUC/NOMBRE.
        /// </summary>
        public static string EtiquetaRucNombreProveedor {
            get {
                return ResourceManager.GetString("EtiquetaRucNombreProveedor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ingrese mínimo tres caracteres.
        /// </summary>
        public static string EtiquetaRucNombreProveedorMinimoTresLetras {
            get {
                return ResourceManager.GetString("EtiquetaRucNombreProveedorMinimoTresLetras", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Buscar Proveedor.
        /// </summary>
        public static string EtiquetaTitulo {
            get {
                return ResourceManager.GetString("EtiquetaTitulo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nombre.
        /// </summary>
        public static string GridNombreProveedor {
            get {
                return ResourceManager.GetString("GridNombreProveedor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ruc.
        /// </summary>
        public static string GridRucProveedor {
            get {
                return ResourceManager.GetString("GridRucProveedor", resourceCulture);
            }
        }
    }
}