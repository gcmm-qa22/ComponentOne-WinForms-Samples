﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WordPad.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool QatBelowRibbon {
            get {
                return ((bool)(this["QatBelowRibbon"]));
            }
            set {
                this["QatBelowRibbon"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsSerializeAs(global::System.Configuration.SettingsSerializeAs.Xml)]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public System.Collections.Generic.List<RecentDocumentItem> OpenedFiles
        {
            get
            {
                return this["OpenedFiles"] as System.Collections.Generic.List<RecentDocumentItem>;
            }
            set
            {
                this["OpenedFiles"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsSerializeAs(global::System.Configuration.SettingsSerializeAs.Xml)]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public System.Collections.Generic.List<RecentDocumentItem> SavedFiles
        {
            get
            {
                return this["SavedFiles"] as System.Collections.Generic.List<RecentDocumentItem>;
            }
            set
            {
                this["SavedFiles"] = value;
            }
        }
    }
}
