﻿#pragma checksum "..\..\..\..\Views\RegWIndow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47659558C6EA7CB595895078D538744D5CD7125D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GameStore2.Views;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace GameStore2.Views {
    
    
    /// <summary>
    /// RegWindow
    /// </summary>
    public partial class RegWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Views\RegWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\RegWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ContentGrid;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\RegWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_Welcome;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\RegWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Login;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\RegWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Mail;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\RegWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pb_Password1;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\RegWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pb_Password2;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Views\RegWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Reg;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Views\RegWIndow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Join;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GameStore2;component/views/regwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\RegWIndow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ContentGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.l_Welcome = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.tb_Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\..\..\Views\RegWIndow.xaml"
            this.tb_Login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_Login_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_Mail = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\..\..\Views\RegWIndow.xaml"
            this.tb_Mail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_Mail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pb_Password1 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 81 "..\..\..\..\Views\RegWIndow.xaml"
            this.pb_Password1.PasswordChanged += new System.Windows.RoutedEventHandler(this.pb_Password1_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pb_Password2 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 90 "..\..\..\..\Views\RegWIndow.xaml"
            this.pb_Password2.PasswordChanged += new System.Windows.RoutedEventHandler(this.pb_Password2_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.b_Reg = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.b_Join = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

