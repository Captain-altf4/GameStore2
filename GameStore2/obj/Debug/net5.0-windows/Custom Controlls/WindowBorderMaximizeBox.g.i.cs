﻿#pragma checksum "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48F0CF056E1CCFA6CECBDF6074665D8B113168C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GameStore2.Custom_Controlls;
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


namespace GameStore2.Custom_Controlls {
    
    
    /// <summary>
    /// WindowBorderMaximizeBox
    /// </summary>
    public partial class WindowBorderMaximizeBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_MinimizeBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_MaximizeBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Close;
        
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
            System.Uri resourceLocater = new System.Uri("/GameStore2;component/custom%20controlls/windowbordermaximizebox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml"
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
            
            #line 12 "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml"
            ((GameStore2.Custom_Controlls.WindowBorderMaximizeBox)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDown);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml"
            ((GameStore2.Custom_Controlls.WindowBorderMaximizeBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.b_MinimizeBox = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml"
            this.b_MinimizeBox.Click += new System.Windows.RoutedEventHandler(this.b_MinimizeBox_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.b_MaximizeBox = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml"
            this.b_MaximizeBox.Click += new System.Windows.RoutedEventHandler(this.b_MaximizeBox_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.b_Close = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Custom Controlls\WindowBorderMaximizeBox.xaml"
            this.b_Close.Click += new System.Windows.RoutedEventHandler(this.b_Close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

