﻿#pragma checksum "..\..\WndCadastrarPessoa.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CD49F46A161C2E855C14E8D6C44D5D575018EEF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using CadatroPessoas.WPF;
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


namespace CadatroPessoas.WPF {
    
    
    /// <summary>
    /// WndCadastrarPessoa
    /// </summary>
    public partial class WndCadastrarPessoa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\WndCadastrarPessoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNome;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WndCadastrarPessoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbIdade;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WndCadastrarPessoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbEndereco;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WndCadastrarPessoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalvarPessoa;
        
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
            System.Uri resourceLocater = new System.Uri("/CadatroPessoas.WPF;component/wndcadastrarpessoa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WndCadastrarPessoa.xaml"
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
            this.txbNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbIdade = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txbEndereco = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnSalvarPessoa = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\WndCadastrarPessoa.xaml"
            this.btnSalvarPessoa.Click += new System.Windows.RoutedEventHandler(this.btnSalvarPessoa_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

