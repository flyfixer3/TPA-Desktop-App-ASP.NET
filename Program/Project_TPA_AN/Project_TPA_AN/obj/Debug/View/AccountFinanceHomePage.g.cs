﻿#pragma checksum "..\..\..\View\AccountFinanceHomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1C07A65623F99B66A235C3283DB04C439B5DE618"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_TPA_AN.View;
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


namespace Project_TPA_AN.View {
    
    
    /// <summary>
    /// AccountFinanceHomePage
    /// </summary>
    public partial class AccountFinanceHomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\View\AccountFinanceHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EventTable;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\AccountFinanceHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idText;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\AccountFinanceHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\AccountFinanceHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NameLabel;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\AccountFinanceHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AcceptButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\View\AccountFinanceHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RejectButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Project_TPA_AN;component/view/accountfinancehomepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AccountFinanceHomePage.xaml"
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
            this.EventTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.idText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.searchButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\View\AccountFinanceHomePage.xaml"
            this.searchButton.Click += new System.Windows.RoutedEventHandler(this.Search);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.AcceptButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\View\AccountFinanceHomePage.xaml"
            this.AcceptButton.Click += new System.Windows.RoutedEventHandler(this.AcceptButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RejectButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\View\AccountFinanceHomePage.xaml"
            this.RejectButton.Click += new System.Windows.RoutedEventHandler(this.RejectButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

