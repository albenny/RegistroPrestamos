﻿#pragma checksum "..\..\..\..\..\UI\Registros\rPersonas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7D31F34F992DC3ACA47645D2149CA89D656E26A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RegistroPrestamos.UI.Registros;
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


namespace RegistroPrestamos.UI.Registros {
    
    
    /// <summary>
    /// rPersonas
    /// </summary>
    public partial class rPersonas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PersonasIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuscarButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NombresTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BalanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaDatePicker;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NuevoButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GuardarButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EliminarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RegistroPrestamos;component/ui/registros/rpersonas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PersonasIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BuscarButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
            this.BuscarButton.Click += new System.Windows.RoutedEventHandler(this.BuscarButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NombresTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BalanceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.FechaDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.NuevoButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
            this.NuevoButton.Click += new System.Windows.RoutedEventHandler(this.NuevoButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GuardarButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
            this.GuardarButton.Click += new System.Windows.RoutedEventHandler(this.GuardarButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EliminarButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\..\UI\Registros\rPersonas.xaml"
            this.EliminarButton.Click += new System.Windows.RoutedEventHandler(this.EliminarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
