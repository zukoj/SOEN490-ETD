﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETD_Statistic.Properties {
    using System;
    
    
    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, formatting them, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilderEx class via the ResXFileCodeGeneratorEx custom tool.
    // To add or remove a member, edit your .ResX file then rerun the ResXFileCodeGeneratorEx custom tool or rebuild your VS.NET project.
    // Copyright (c) Dmytro Kryvko 2006-2015 (http://dmytro.kryvko.googlepages.com/)
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("DMKSoftware.CodeGenerators.Tools.StronglyTypedResourceBuilderEx", "2.6.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
#if !SILVERLIGHT
    [global::System.Reflection.ObfuscationAttribute(Exclude=true, ApplyToMembers=true)]
#endif
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
    public partial class Resources {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        /// <summary>
        /// Initializes a Resources object.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public Resources() {
        }
        
        /// <summary>
        /// Thread safe lock object used by this class.
        /// </summary>
        public static object InternalSyncObject {
            get {
                if (object.ReferenceEquals(_internalSyncObject, null)) {
                    global::System.Threading.Interlocked.CompareExchange(ref _internalSyncObject, new object(), null);
                }
                return _internalSyncObject;
            }
        }
        
        /// <summary>
        /// Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(_resourceManager, null)) {
                    global::System.Threading.Monitor.Enter(InternalSyncObject);
                    try {
                        if (object.ReferenceEquals(_resourceManager, null)) {
                            global::System.Threading.Interlocked.Exchange(ref _resourceManager, new global::System.Resources.ResourceManager("ETD_Statistic.Properties.Resources", typeof(Resources).Assembly));
                        }
                    }
                    finally {
                        global::System.Threading.Monitor.Exit(InternalSyncObject);
                    }
                }
                return _resourceManager;
            }
        }
        
        /// <summary>
        /// Overrides the current thread's CurrentUICulture property for all
        /// resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return _resourceCulture;
            }
            set {
                _resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Export to PDF'.
        /// </summary>
        public static string Button_ExportPDF {
            get {
                return ResourceManager.GetString(ResourceNames.Button_ExportPDF, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Load Statistic'.
        /// </summary>
        public static string Button_LoadStatistic {
            get {
                return ResourceManager.GetString(ResourceNames.Button_LoadStatistic, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Submit'.
        /// </summary>
        public static string Button_LoginSubmit {
            get {
                return ResourceManager.GetString(ResourceNames.Button_LoginSubmit, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'View Previous Operations'.
        /// </summary>
        public static string Button_ViewPreviousOperations {
            get {
                return ResourceManager.GetString(ResourceNames.Button_ViewPreviousOperations, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Password: '.
        /// </summary>
        public static string Label_Password {
            get {
                return ResourceManager.GetString(ResourceNames.Label_Password, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Username: '.
        /// </summary>
        public static string Label_Username {
            get {
                return ResourceManager.GetString(ResourceNames.Label_Username, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Invalid username or password'.
        /// </summary>
        public static string MessageBox_Notification_InvalidCredentials {
            get {
                return ResourceManager.GetString(ResourceNames.MessageBox_Notification_InvalidCredentials, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Finance and Meals'.
        /// </summary>
        public static string TextBlock_Finance {
            get {
                return ResourceManager.GetString(ResourceNames.TextBlock_Finance, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Organization Followup'.
        /// </summary>
        public static string TextBlock_OrganizationFollowUp {
            get {
                return ResourceManager.GetString(ResourceNames.TextBlock_OrganizationFollowUp, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Particular Situation and Interventions'.
        /// </summary>
        public static string TextBlock_ParticularSituation {
            get {
                return ResourceManager.GetString(ResourceNames.TextBlock_ParticularSituation, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Supervisor/Responsible Invidual Followup'.
        /// </summary>
        public static string TextBlock_SupervisorFollowUp {
            get {
                return ResourceManager.GetString(ResourceNames.TextBlock_SupervisorFollowUp, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Material and Vehicles'.
        /// </summary>
        public static string TextBlock_Vehicle {
            get {
                return ResourceManager.GetString(ResourceNames.TextBlock_Vehicle, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Volunteer Followup'.
        /// </summary>
        public static string TextBlock_VolunteerFollowUp {
            get {
                return ResourceManager.GetString(ResourceNames.TextBlock_VolunteerFollowUp, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Lists all the resource names as constant string fields.
        /// </summary>
        public class ResourceNames {
            
            /// <summary>
            /// Stores the resource name 'Button_ExportPDF'.
            /// </summary>
            public const string Button_ExportPDF = "Button_ExportPDF";
            
            /// <summary>
            /// Stores the resource name 'Button_LoadStatistic'.
            /// </summary>
            public const string Button_LoadStatistic = "Button_LoadStatistic";
            
            /// <summary>
            /// Stores the resource name 'Button_LoginSubmit'.
            /// </summary>
            public const string Button_LoginSubmit = "Button_LoginSubmit";
            
            /// <summary>
            /// Stores the resource name 'Button_ViewPreviousOperations'.
            /// </summary>
            public const string Button_ViewPreviousOperations = "Button_ViewPreviousOperations";
            
            /// <summary>
            /// Stores the resource name 'Label_Password'.
            /// </summary>
            public const string Label_Password = "Label_Password";
            
            /// <summary>
            /// Stores the resource name 'Label_Username'.
            /// </summary>
            public const string Label_Username = "Label_Username";
            
            /// <summary>
            /// Stores the resource name 'MessageBox_Notification_InvalidCredentials'.
            /// </summary>
            public const string MessageBox_Notification_InvalidCredentials = "MessageBox_Notification_InvalidCredentials";
            
            /// <summary>
            /// Stores the resource name 'TextBlock_Finance'.
            /// </summary>
            public const string TextBlock_Finance = "TextBlock_Finance";
            
            /// <summary>
            /// Stores the resource name 'TextBlock_OrganizationFollowUp'.
            /// </summary>
            public const string TextBlock_OrganizationFollowUp = "TextBlock_OrganizationFollowUp";
            
            /// <summary>
            /// Stores the resource name 'TextBlock_ParticularSituation'.
            /// </summary>
            public const string TextBlock_ParticularSituation = "TextBlock_ParticularSituation";
            
            /// <summary>
            /// Stores the resource name 'TextBlock_SupervisorFollowUp'.
            /// </summary>
            public const string TextBlock_SupervisorFollowUp = "TextBlock_SupervisorFollowUp";
            
            /// <summary>
            /// Stores the resource name 'TextBlock_Vehicle'.
            /// </summary>
            public const string TextBlock_Vehicle = "TextBlock_Vehicle";
            
            /// <summary>
            /// Stores the resource name 'TextBlock_VolunteerFollowUp'.
            /// </summary>
            public const string TextBlock_VolunteerFollowUp = "TextBlock_VolunteerFollowUp";
        }
    }
}
