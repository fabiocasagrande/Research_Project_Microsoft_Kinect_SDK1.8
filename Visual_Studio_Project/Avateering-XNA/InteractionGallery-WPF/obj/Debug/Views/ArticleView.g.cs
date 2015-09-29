﻿#pragma checksum "..\..\..\Views\ArticleView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F3A8E19E11A7CE72AEDA6315DDB44978"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
using Microsoft.Samples.Kinect.InteractionGallery.Controls;
using Microsoft.Samples.Kinect.InteractionGallery.Navigation;
using Microsoft.Samples.Kinect.InteractionGallery.Utilities;
using Microsoft.Samples.Kinect.InteractionGallery.ViewModels;
using Microsoft.Samples.Kinect.InteractionGallery.Views;
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


namespace Microsoft.Samples.Kinect.InteractionGallery.Views {
    
    
    /// <summary>
    /// ArticleView
    /// </summary>
    public partial class ArticleView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Views\ArticleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Samples.Kinect.InteractionGallery.Views.ArticleView ArticleViewControl;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\ArticleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectScrollViewer ArticleScrollViewer;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\ArticleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid OverlayGrid;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Views\ArticleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.VisualStateGroup TransitionStates;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Views\ArticleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.VisualState Normal;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Views\ArticleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.VisualState FadeIn;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Views\ArticleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.VisualState FadeOut;
        
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
            System.Uri resourceLocater = new System.Uri("/InteractionGallery-WPF;component/views/articleview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ArticleView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.ArticleViewControl = ((Microsoft.Samples.Kinect.InteractionGallery.Views.ArticleView)(target));
            return;
            case 2:
            
            #line 44 "..\..\..\Views\ArticleView.xaml"
            ((Microsoft.Kinect.Toolkit.Controls.KinectItemsControl)(target)).ItemClick += new System.Windows.RoutedEventHandler(this.OnDisplayFullImage);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ArticleScrollViewer = ((Microsoft.Kinect.Toolkit.Controls.KinectScrollViewer)(target));
            return;
            case 4:
            this.OverlayGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.TransitionStates = ((System.Windows.VisualStateGroup)(target));
            return;
            case 6:
            this.Normal = ((System.Windows.VisualState)(target));
            return;
            case 7:
            this.FadeIn = ((System.Windows.VisualState)(target));
            return;
            case 8:
            this.FadeOut = ((System.Windows.VisualState)(target));
            return;
            case 9:
            
            #line 123 "..\..\..\Views\ArticleView.xaml"
            ((Microsoft.Kinect.Toolkit.Controls.KinectCircleButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCloseFullImage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

