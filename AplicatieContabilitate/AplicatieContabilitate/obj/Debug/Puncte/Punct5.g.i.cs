﻿#pragma checksum "..\..\..\Puncte\Punct5.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "250280BC735B426B64DDCD9B9B90998DE057EEBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AplicatieContabilitate.Puncte;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace AplicatieContabilitate.Puncte {
    
    
    /// <summary>
    /// Punct5
    /// </summary>
    public partial class Punct5 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Puncte\Punct5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBarTitle;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Puncte\Punct5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Puncte\Punct5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Puncte\Punct5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVenit;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Puncte\Punct5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCheltuieli;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Puncte\Punct5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddVenit;
        
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
            System.Uri resourceLocater = new System.Uri("/AplicatieContabilitate;component/puncte/punct5.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Puncte\Punct5.xaml"
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
            this.GridBarTitle = ((System.Windows.Controls.Grid)(target));
            
            #line 18 "..\..\..\Puncte\Punct5.xaml"
            this.GridBarTitle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridBarTitle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Puncte\Punct5.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.txtVenit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCheltuieli = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnAddVenit = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Puncte\Punct5.xaml"
            this.btnAddVenit.Click += new System.Windows.RoutedEventHandler(this.btnAddVenit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

