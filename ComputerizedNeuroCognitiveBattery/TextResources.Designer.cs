﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerizedNeuroCognitiveBattery {
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
    internal class TextResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TextResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ComputerizedNeuroCognitiveBattery.TextResources", typeof(TextResources).Assembly);
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
        ///   Looks up a localized string similar to באיזה יום בחודש אנו נמצאים?.
        /// </summary>
        internal static string CurrentDayQuestion {
            get {
                return ResourceManager.GetString("CurrentDayQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to באיזה חודש אנו נמצאים?.
        /// </summary>
        internal static string CurrentMonthQuestion {
            get {
                return ResourceManager.GetString("CurrentMonthQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to מהי השנה הנוכחית?.
        /// </summary>
        internal static string CurrentYearQuestion {
            get {
                return ResourceManager.GetString("CurrentYearQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to שאלה {0}: {1} שניות.
        /// </summary>
        internal static string QuestionResultTemplate {
            get {
                return ResourceManager.GetString("QuestionResultTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to תאריך: {0} שעה: {1).
        /// </summary>
        internal static string TestTimeTemplate {
            get {
                return ResourceManager.GetString("TestTimeTemplate", resourceCulture);
            }
        }
    }
}
