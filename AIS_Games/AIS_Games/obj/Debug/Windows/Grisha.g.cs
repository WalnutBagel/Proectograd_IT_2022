﻿#pragma checksum "..\..\..\Windows\Grisha.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "22B7EF8A70C5E2B32FD6F74FB42D6FCCA64E29D981EE9FE73E137AE7F2335EBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AIS_Games.Windows;
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


namespace AIS_Games.Windows {
    
    
    /// <summary>
    /// Grisha
    /// </summary>
    public partial class Grisha : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Windows\Grisha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_Player;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\Grisha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_VS;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\Grisha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_PC;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\Grisha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rock;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\Grisha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Paper;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\Grisha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Scissors;
        
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
            System.Uri resourceLocater = new System.Uri("/AIS_Games;component/windows/grisha.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Grisha.xaml"
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
            
            #line 17 "..\..\..\Windows\Grisha.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.img_Player = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.img_VS = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.img_PC = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.Rock = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Windows\Grisha.xaml"
            this.Rock.Click += new System.Windows.RoutedEventHandler(this.Rock_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Paper = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Windows\Grisha.xaml"
            this.Paper.Click += new System.Windows.RoutedEventHandler(this.Paper_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Scissors = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Windows\Grisha.xaml"
            this.Scissors.Click += new System.Windows.RoutedEventHandler(this.Scissors_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

