﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OwnerDraw.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OwnerDraw.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;C1FlexPivotPage&gt;
        ///  &lt;C1FlexPivotEngine ShowZeros=&quot;False&quot; ShowTotalsColumn=&quot;True&quot; ShowTotalsRows=&quot;Subtotals&quot;&gt;
        ///    &lt;Fields&gt;
        ///      &lt;Field name=&quot;Address&quot; subtotal=&quot;Count&quot; /&gt;
        ///      &lt;Field name=&quot;City&quot; subtotal=&quot;Count&quot; width=&quot;148&quot; /&gt;
        ///      &lt;Field name=&quot;Country&quot; subtotal=&quot;Count&quot; /&gt;
        ///      &lt;Field name=&quot;CustomerID&quot; subtotal=&quot;Count&quot; /&gt;
        ///      &lt;Field name=&quot;Customers.CompanyName&quot; subtotal=&quot;Count&quot; /&gt;
        ///      &lt;Field name=&quot;Discount&quot; subtotal=&quot;Sum&quot; format=&quot;n0&quot; /&gt;
        ///      &lt;Field name=&quot;ExtendedPrice&quot; subtotal=&quot;Sum&quot; format= [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultView {
            get {
                return ResourceManager.GetString("DefaultView", resourceCulture);
            }
        }
    }
}
