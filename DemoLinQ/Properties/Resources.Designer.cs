﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoLinQ.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DemoLinQ.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Contactos&gt;
        ///	&lt;Contacto&gt;
        ///    &lt;NOMBRE&gt;David&lt;/NOMBRE&gt;
        ///    &lt;EDAD&gt;39&lt;/EDAD&gt;
        ///    &lt;DNI&gt;12345678A&lt;/DNI&gt;
        ///	&lt;/Contacto&gt;
        ///  &lt;Contacto&gt;
        ///    &lt;NOMBRE&gt;Daniel&lt;/NOMBRE&gt;
        ///    &lt;EDAD&gt;23&lt;/EDAD&gt;
        ///    &lt;DNI&gt;87654321Z&lt;/DNI&gt;
        ///	&lt;/Contacto&gt;
        ///  &lt;Contacto&gt;
        ///    &lt;NOMBRE&gt;Laura&lt;/NOMBRE&gt;
        ///    &lt;EDAD&gt;19&lt;/EDAD&gt;
        ///    &lt;DNI&gt;34761898J&lt;/DNI&gt;
        ///  &lt;/Contacto&gt;
        ///  &lt;Contacto&gt;
        ///    &lt;NOMBRE&gt;Lázaro&lt;/NOMBRE&gt;
        ///    &lt;EDAD&gt;32&lt;/EDAD&gt;
        ///    &lt;DNI&gt;88336712H&lt;/DNI&gt;
        ///	&lt;/Contacto&gt;
        ///  &lt;Contacto&gt;
        ///    &lt;NOMBRE&gt;Carlos&lt;/NOMBRE&gt;
        ///   [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string Info {
            get {
                return ResourceManager.GetString("Info", resourceCulture);
            }
        }
    }
}
