﻿#pragma checksum "..\..\AddEditWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64095E99856786508B742B3AC48F267D6B0149D151D8FCF0C27B4010B6969BEA"
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
using TimerzyanovLanguage;


namespace TimerzyanovLanguage {
    
    
    /// <summary>
    /// AddEditWindow
    /// </summary>
    public partial class AddEditWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IDText;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatronymicBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker BirthdayDate;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GenderCodeBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PhotoImage;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangePictureBtn;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\AddEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientSave;
        
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
            System.Uri resourceLocater = new System.Uri("/TimerzyanovLanguage;component/addeditwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEditWindow.xaml"
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
            this.IDText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.IDBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FirstNameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\AddEditWindow.xaml"
            this.FirstNameBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FirstNameBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LastNameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\AddEditWindow.xaml"
            this.LastNameBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LastNameBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PatronymicBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\AddEditWindow.xaml"
            this.PatronymicBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PatronymicBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EmailBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\AddEditWindow.xaml"
            this.EmailBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.EmailBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PhoneBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\AddEditWindow.xaml"
            this.PhoneBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PhoneBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BirthdayDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.GenderCodeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.PhotoImage = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.ChangePictureBtn = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\AddEditWindow.xaml"
            this.ChangePictureBtn.Click += new System.Windows.RoutedEventHandler(this.ChangePictureBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ClientSave = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\AddEditWindow.xaml"
            this.ClientSave.Click += new System.Windows.RoutedEventHandler(this.ClientSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

