﻿#pragma checksum "..\..\StorekeeperSide.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5E65BEC6A41222BCD27AFE4B0776BCF6B82BFCBAFD96BAC4B14842EDD3D165A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Factory;
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


namespace Factory {
    
    
    /// <summary>
    /// StorekeeperSide
    /// </summary>
    public partial class StorekeeperSide : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\StorekeeperSide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\StorekeeperSide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReceiptOfMaterial;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\StorekeeperSide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Listfabric;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\StorekeeperSide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ListFurniche;
        
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
            System.Uri resourceLocater = new System.Uri("/Factory;component/storekeeperside.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StorekeeperSide.xaml"
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
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\StorekeeperSide.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ReceiptOfMaterial = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\StorekeeperSide.xaml"
            this.ReceiptOfMaterial.Click += new System.Windows.RoutedEventHandler(this.ReceiptOfMaterial_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Listfabric = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\StorekeeperSide.xaml"
            this.Listfabric.Click += new System.Windows.RoutedEventHandler(this.Listfabric_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListFurniche = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\StorekeeperSide.xaml"
            this.ListFurniche.Click += new System.Windows.RoutedEventHandler(this.ListFurniche_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

