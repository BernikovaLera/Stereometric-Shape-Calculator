﻿#pragma checksum "..\..\Window_Celinder.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6C493E2F836BB5A2E5C56DF18617F4AF7DB58BD6"
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


namespace up_pr1 {
    
    
    /// <summary>
    /// Window_Celinder
    /// </summary>
    public partial class Window_Celinder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Window_Celinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxR1;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Window_Celinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxH;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Window_Celinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chet;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Window_Celinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockSocn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Window_Celinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockSboc;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Window_Celinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockSob;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window_Celinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockV;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window_Celinder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nazad;
        
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
            System.Uri resourceLocater = new System.Uri("/up_pr1;component/window_celinder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window_Celinder.xaml"
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
            this.TextBoxR1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBoxH = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Chet = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Window_Celinder.xaml"
            this.Chet.Click += new System.Windows.RoutedEventHandler(this.Chet_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBlockSocn = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TextBlockSboc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TextBlockSob = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TextBlockV = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.nazad = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Window_Celinder.xaml"
            this.nazad.Click += new System.Windows.RoutedEventHandler(this.nazad_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

