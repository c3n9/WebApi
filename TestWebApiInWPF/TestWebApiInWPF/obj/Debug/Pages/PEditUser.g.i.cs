﻿#pragma checksum "..\..\..\Pages\PEditUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4A53E5BF8133112EC8F0E54DA467D31813A6307C0561B0D1039AA85E6D9D46B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TestWebApiInWPF.Pages;


namespace TestWebApiInWPF.Pages {
    
    
    /// <summary>
    /// PEditUser
    /// </summary>
    public partial class PEditUser : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\PEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\PEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBAge;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\PEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBCity;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\PEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBRole;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\PEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBGender;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\PEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSave;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\PEditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TestWebApiInWPF;component/pages/pedituser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PEditUser.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\Pages\PEditUser.xaml"
            ((TestWebApiInWPF.Pages.PEditUser)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBAge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBCity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CBRole = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.CBGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.BSave = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Pages\PEditUser.xaml"
            this.BSave.Click += new System.Windows.RoutedEventHandler(this.BSave_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BCancel = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Pages\PEditUser.xaml"
            this.BCancel.Click += new System.Windows.RoutedEventHandler(this.BCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

