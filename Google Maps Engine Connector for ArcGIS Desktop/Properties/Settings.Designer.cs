﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.google.mapsengine.connectors.arcgis.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string oauth2_settings_client_secret {
            get {
                return ((string)(this["oauth2_settings_client_secret"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string oauth2_settings_clientId {
            get {
                return ((string)(this["oauth2_settings_clientId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://accounts.google.com/o/oauth2/token")]
        public string oauth2_settings_token_url {
            get {
                return ((string)(this["oauth2_settings_token_url"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://accounts.google.com/o/oauth2/auth")]
        public string oauth2_settings_auth_url {
            get {
                return ((string)(this["oauth2_settings_auth_url"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.github.com/googlemaps/mapsengine-arcgis-connector/master/updatecheck." +
            "json")]
        public string extension_update_check_uri {
            get {
                return ((string)(this["extension_update_check_uri"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GoogleMapsEngineDataLocal.gdb")]
        public string extension_gdb_workspacename {
            get {
                return ((string)(this["extension_gdb_workspacename"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime oauth2_user_expires_on {
            get {
                return ((global::System.DateTime)(this["oauth2_user_expires_on"]));
            }
            set {
                this["oauth2_user_expires_on"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string oauth2_user_refresh_token {
            get {
                return ((string)(this["oauth2_user_refresh_token"]));
            }
            set {
                this["oauth2_user_refresh_token"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string oauth2_user_token_type {
            get {
                return ((string)(this["oauth2_user_token_type"]));
            }
            set {
                this["oauth2_user_token_type"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int oauth2_user_expires_in {
            get {
                return ((int)(this["oauth2_user_expires_in"]));
            }
            set {
                this["oauth2_user_expires_in"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string oauth2_user_code {
            get {
                return ((string)(this["oauth2_user_code"]));
            }
            set {
                this["oauth2_user_code"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool gme_api_includepublic {
            get {
                return ((bool)(this["gme_api_includepublic"]));
            }
            set {
                this["gme_api_includepublic"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string gme_api_cidfilter {
            get {
                return ((string)(this["gme_api_cidfilter"]));
            }
            set {
                this["gme_api_cidfilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string oauth2_user_access_token {
            get {
                return ((string)(this["oauth2_user_access_token"]));
            }
            set {
                this["oauth2_user_access_token"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.google.com/gadgets/directory?synd=earth&preview=on")]
        public string google_map_gallery_url {
            get {
                return ((string)(this["google_map_gallery_url"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool gplus_is_enabled {
            get {
                return ((bool)(this["gplus_is_enabled"]));
            }
            set {
                this["gplus_is_enabled"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sign in to Google Maps Engine")]
        public string dialogs_OAuth2AuthForm_Text {
            get {
                return ((string)(this["dialogs_OAuth2AuthForm_Text"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Google Maps Engine")]
        public string dialogs_GoogleMapsEngineDirectoryListing_Text {
            get {
                return ((string)(this["dialogs_GoogleMapsEngineDirectoryListing_Text"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https")]
        public string gme_api_protocol {
            get {
                return ((string)(this["gme_api_protocol"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("www.googleapis.com")]
        public string gme_api_domain {
            get {
                return ((string)(this["gme_api_domain"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mapsengine")]
        public string gme_api_service {
            get {
                return ((string)(this["gme_api_service"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("v1")]
        public string gme_api_version {
            get {
                return ((string)(this["gme_api_version"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string gme_api_key {
            get {
                return ((string)(this["gme_api_key"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string temp_storage_location {
            get {
                return ((string)(this["temp_storage_location"]));
            }
            set {
                this["temp_storage_location"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool gme_api_cidfilter_hasBeenPrompted {
            get {
                return ((bool)(this["gme_api_cidfilter_hasBeenPrompted"]));
            }
            set {
                this["gme_api_cidfilter_hasBeenPrompted"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://mapsengine.google.com/{mapId}-4/wms/{authTokenPlusSlash}?Request=GetCapab" +
            "ilities&Version=1.3.0")]
        public string gme_wms_GetCapabilities {
            get {
                return ((string)(this["gme_wms_GetCapabilities"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://mapsengine.google.com/admin/#{place}:cid={projectId}&v={view}&aid={assetI" +
            "d}")]
        public string gme_url_admin {
            get {
                return ((string)(this["gme_url_admin"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://mapsengine.google.com/{mapId}-4/mapview/")]
        public string gme_url_mapwidget {
            get {
                return ((string)(this["gme_url_mapwidget"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.googleapis.com/auth/mapsengine")]
        public string gme_auth_editscopes {
            get {
                return ((string)(this["gme_auth_editscopes"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool oauth2_user_isViewOnly {
            get {
                return ((bool)(this["oauth2_user_isViewOnly"]));
            }
            set {
                this["oauth2_user_isViewOnly"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Upload a dataset to Google Maps Engine")]
        public string dialogs_uploadFilestoGoogleMapsEngine {
            get {
                return ((string)(this["dialogs_uploadFilestoGoogleMapsEngine"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("About the Google Maps Engine Connector for ArcGIS Desktop")]
        public string dialogs_aboutTitle {
            get {
                return ((string)(this["dialogs_aboutTitle"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("create_tt")]
        public string gme_api_version_createTT {
            get {
                return ((string)(this["gme_api_version_createTT"]));
            }
        }
    }
}
