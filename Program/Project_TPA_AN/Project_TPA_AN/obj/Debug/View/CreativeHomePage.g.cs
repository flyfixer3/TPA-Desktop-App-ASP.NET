﻿#pragma checksum "..\..\..\View\CreativeHomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BA3140A861AE2739842C3FF0E0952687C3FE1C2D"
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
    /// CreativeHomePage
    /// </summary>
    public partial class CreativeHomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\View\CreativeHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button manageAllRideButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\CreativeHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button manageAllAttractionButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\View\CreativeHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button requestPurchaseButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\View\CreativeHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button requestFundButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\View\CreativeHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewManagerResponseButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\View\CreativeHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button leavingPermissionButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\View\CreativeHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createResignLetterButton;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\View\CreativeHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Project_TPA_AN;component/view/creativehomepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CreativeHomePage.xaml"
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
            this.manageAllRideButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\View\CreativeHomePage.xaml"
            this.manageAllRideButton.Click += new System.Windows.RoutedEventHandler(this.ManageAllRide);
            
            #line default
            #line hidden
            return;
            case 2:
            this.manageAllAttractionButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\View\CreativeHomePage.xaml"
            this.manageAllAttractionButton.Click += new System.Windows.RoutedEventHandler(this.ManageAllAttraction);
            
            #line default
            #line hidden
            return;
            case 3:
            this.requestPurchaseButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\View\CreativeHomePage.xaml"
            this.requestPurchaseButton.Click += new System.Windows.RoutedEventHandler(this.PurchaseRequest);
            
            #line default
            #line hidden
            return;
            case 4:
            this.requestFundButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\View\CreativeHomePage.xaml"
            this.requestFundButton.Click += new System.Windows.RoutedEventHandler(this.FundRequest);
            
            #line default
            #line hidden
            return;
            case 5:
            this.viewManagerResponseButton = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\View\CreativeHomePage.xaml"
            this.viewManagerResponseButton.Click += new System.Windows.RoutedEventHandler(this.ViewManagerResponse);
            
            #line default
            #line hidden
            return;
            case 6:
            this.leavingPermissionButton = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\View\CreativeHomePage.xaml"
            this.leavingPermissionButton.Click += new System.Windows.RoutedEventHandler(this.LeavingPermission);
            
            #line default
            #line hidden
            return;
            case 7:
            this.createResignLetterButton = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\View\CreativeHomePage.xaml"
            this.createResignLetterButton.Click += new System.Windows.RoutedEventHandler(this.DoResignLetter);
            
            #line default
            #line hidden
            return;
            case 8:
            this.logoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\View\CreativeHomePage.xaml"
            this.logoutButton.Click += new System.Windows.RoutedEventHandler(this.Logout);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
