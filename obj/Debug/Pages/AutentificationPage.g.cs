#pragma checksum "..\..\..\Pages\AutentificationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0DA1FAA2C13BCACE229EA55CCC177770DBCC3103B2E3AA1706C29A79913E2508"
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
using Wpf_ogm.Pages;


namespace Wpf_ogm.Pages {
    
    
    /// <summary>
    /// AutentificationPage
    /// </summary>
    public partial class AutentificationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\AutentificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_login;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\AutentificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Tb_pass;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\AutentificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_pass_2;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\AutentificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_vhod;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\AutentificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_pk_pass;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_ogm;component/pages/autentificationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AutentificationPage.xaml"
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
            this.Tb_login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Tb_pass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.Tb_pass_2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Btn_vhod = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Pages\AutentificationPage.xaml"
            this.Btn_vhod.Click += new System.Windows.RoutedEventHandler(this.Btn_vhod_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Btn_pk_pass = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Pages\AutentificationPage.xaml"
            this.Btn_pk_pass.Click += new System.Windows.RoutedEventHandler(this.Btn_pk_pass_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

