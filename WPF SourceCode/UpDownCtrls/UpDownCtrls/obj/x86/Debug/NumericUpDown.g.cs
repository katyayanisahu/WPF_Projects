﻿#pragma checksum "..\..\..\NumericUpDown.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "625C91B12F30E625175DC28A22E755AC1D7A3A517161412C7A263B4D441C684D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using UpDownCtrls;


namespace UpDownCtrls {
    
    
    /// <summary>
    /// NumericUpDown
    /// </summary>
    public partial class NumericUpDown : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\NumericUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UpDownCtrls.NumericUpDown Root;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\NumericUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCtrl;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\NumericUpDown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UpDownCtrls.UpDownButtons UpDown;
        
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
            System.Uri resourceLocater = new System.Uri("/UpDownCtrls;component/numericupdown.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NumericUpDown.xaml"
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
            this.Root = ((UpDownCtrls.NumericUpDown)(target));
            
            #line 11 "..\..\..\NumericUpDown.xaml"
            this.Root.Loaded += new System.Windows.RoutedEventHandler(this.Root_Loaded);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\NumericUpDown.xaml"
            this.Root.IsEnabledChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Root_IsEnabledChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxCtrl = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\NumericUpDown.xaml"
            this.TextBoxCtrl.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBoxCtrl_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\NumericUpDown.xaml"
            this.TextBoxCtrl.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBoxCtrl_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\NumericUpDown.xaml"
            this.TextBoxCtrl.PreviewDragOver += new System.Windows.DragEventHandler(this.TextBoxCtrl_PreviewDragOver);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\NumericUpDown.xaml"
            this.TextBoxCtrl.PreviewDrop += new System.Windows.DragEventHandler(this.TextBoxCtrl_PreviewDrop);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\NumericUpDown.xaml"
            this.TextBoxCtrl.PreviewQueryContinueDrag += new System.Windows.QueryContinueDragEventHandler(this.TextBoxCtrl_PreviewQueryContinueDrag);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\NumericUpDown.xaml"
            this.TextBoxCtrl.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.TextBoxCtrl_PreviewMouseWheel);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\NumericUpDown.xaml"
            this.TextBoxCtrl.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TextBoxCtrl_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 30 "..\..\..\NumericUpDown.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Command_Cut_CanExecute);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\NumericUpDown.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CommandBinding_CutExecuted);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 31 "..\..\..\NumericUpDown.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Command_Paste_CanExecute);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\NumericUpDown.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CommandBinding_PasteExecuted);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UpDown = ((UpDownCtrls.UpDownButtons)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
