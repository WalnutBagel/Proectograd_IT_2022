// Updated by XamlIntelliSenseFileGenerator 21.06.2022 17:53:35
#pragma checksum "..\..\..\Windows\Flappybird.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "970AE2CBA191F3649BF8ABABF4CE2ADCA4C6029E67250B5A05EA006BB817572A"
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


namespace AIS_Games.Windows
{


    /// <summary>
    /// Flappybird
    /// </summary>
    public partial class Flappybird : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 9 "..\..\..\Windows\Flappybird.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas MyCanvas;

#line default
#line hidden


#line 30 "..\..\..\Windows\Flappybird.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtScore;

#line default
#line hidden


#line 31 "..\..\..\Windows\Flappybird.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start;

#line default
#line hidden


#line 32 "..\..\..\Windows\Flappybird.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;

#line default
#line hidden


#line 33 "..\..\..\Windows\Flappybird.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image flappyBird;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AIS_Games;component/windows/flappybird.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Windows\Flappybird.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.MyCanvas = ((System.Windows.Controls.Canvas)(target));

#line 9 "..\..\..\Windows\Flappybird.xaml"
                    this.MyCanvas.KeyDown += new System.Windows.Input.KeyEventHandler(this.KeyIsDown);

#line default
#line hidden

#line 9 "..\..\..\Windows\Flappybird.xaml"
                    this.MyCanvas.KeyUp += new System.Windows.Input.KeyEventHandler(this.KeyIsUp);

#line default
#line hidden
                    return;
                case 2:
                    this.txtScore = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.Start = ((System.Windows.Controls.Button)(target));

#line 31 "..\..\..\Windows\Flappybird.xaml"
                    this.Start.Click += new System.Windows.RoutedEventHandler(this.Start_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.Exit = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\..\Windows\Flappybird.xaml"
                    this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.flappyBird = ((System.Windows.Controls.Image)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Image a;
        internal System.Windows.Controls.Image b;
        internal System.Windows.Controls.Image c;
        internal System.Windows.Controls.Image d;
        internal System.Windows.Controls.Image e;
    }
}

