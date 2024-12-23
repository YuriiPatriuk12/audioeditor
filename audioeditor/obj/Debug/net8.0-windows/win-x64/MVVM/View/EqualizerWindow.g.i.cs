﻿#pragma checksum "..\..\..\..\..\..\MVVM\View\EqualizerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3574F9D5B0D145ADC26E56BBD2B690B8129DD0D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Audioeditor.MVVM.View;
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


namespace Audioeditor.MVVM.View {
    
    
    /// <summary>
    /// EqualizerWindow
    /// </summary>
    public partial class EqualizerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\..\MVVM\View\EqualizerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider LowFreqSlider;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\MVVM\View\EqualizerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider MidFreqSlider;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\..\MVVM\View\EqualizerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider HighFreqSlider;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/audioeditor;component/mvvm/view/equalizerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\MVVM\View\EqualizerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LowFreqSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 20 "..\..\..\..\..\..\MVVM\View\EqualizerWindow.xaml"
            this.LowFreqSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.LowFreqSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MidFreqSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 28 "..\..\..\..\..\..\MVVM\View\EqualizerWindow.xaml"
            this.MidFreqSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.MidFreqSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HighFreqSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 36 "..\..\..\..\..\..\MVVM\View\EqualizerWindow.xaml"
            this.HighFreqSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.HighFreqSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

