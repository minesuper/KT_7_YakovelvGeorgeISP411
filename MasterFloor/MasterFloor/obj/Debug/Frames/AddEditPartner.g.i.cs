﻿#pragma checksum "..\..\..\Frames\AddEditPartner.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A97319E7B18135CF2E278182EF3BD251CDD8AD1247C79CDDEFB905482B291A4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MasterFloor.Frames;
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


namespace MasterFloor.Frames {
    
    
    /// <summary>
    /// AddEditPartner
    /// </summary>
    public partial class AddEditPartner : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Frames\AddEditPartner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Frames\AddEditPartner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Frames\AddEditPartner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RatingTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Frames\AddEditPartner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AdressTextBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Frames\AddEditPartner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FIOTextBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Frames\AddEditPartner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Frames\AddEditPartner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Frames\AddEditPartner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Frames\AddEditPartner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MasterFloor;component/frames/addeditpartner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Frames\AddEditPartner.xaml"
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
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.RatingTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AdressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.FIOTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PhoneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Frames\AddEditPartner.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\Frames\AddEditPartner.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

