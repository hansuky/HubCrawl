﻿#pragma checksum "..\..\App.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB0911371DEBF772E711C8BEE7FF36EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.18444
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using System.Windows.Forms.Integration;
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


namespace HubCrawl {
    
    
    /// <summary>
    /// App
    /// </summary>
    public partial class App : System.Windows.Application {
        
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
            
            #line 4 "..\..\App.xaml"
            this.Startup += new System.Windows.StartupEventHandler(this.Application_Startup);
            
            #line default
            #line hidden
            
            #line 5 "..\..\App.xaml"
            this.Activated += new System.EventHandler(this.Application_Activated);
            
            #line default
            #line hidden
            
            #line 6 "..\..\App.xaml"
            this.Deactivated += new System.EventHandler(this.Application_Deactivated);
            
            #line default
            #line hidden
            
            #line 7 "..\..\App.xaml"
            this.DispatcherUnhandledException += new System.Windows.Threading.DispatcherUnhandledExceptionEventHandler(this.Application_DispatcherUnhandledException);
            
            #line default
            #line hidden
            
            #line 8 "..\..\App.xaml"
            this.Exit += new System.Windows.ExitEventHandler(this.Application_Exit);
            
            #line default
            #line hidden
            
            #line 9 "..\..\App.xaml"
            this.FragmentNavigation += new System.Windows.Navigation.FragmentNavigationEventHandler(this.Application_FragmentNavigation);
            
            #line default
            #line hidden
            
            #line 10 "..\..\App.xaml"
            this.LoadCompleted += new System.Windows.Navigation.LoadCompletedEventHandler(this.Application_LoadCompleted);
            
            #line default
            #line hidden
            
            #line 11 "..\..\App.xaml"
            this.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.Application_Navigated);
            
            #line default
            #line hidden
            
            #line 12 "..\..\App.xaml"
            this.Navigating += new System.Windows.Navigation.NavigatingCancelEventHandler(this.Application_Navigating);
            
            #line default
            #line hidden
            
            #line 13 "..\..\App.xaml"
            this.NavigationFailed += new System.Windows.Navigation.NavigationFailedEventHandler(this.Application_NavigationFailed);
            
            #line default
            #line hidden
            
            #line 14 "..\..\App.xaml"
            this.NavigationProgress += new System.Windows.Navigation.NavigationProgressEventHandler(this.Application_NavigationProgress);
            
            #line default
            #line hidden
            
            #line 15 "..\..\App.xaml"
            this.NavigationStopped += new System.Windows.Navigation.NavigationStoppedEventHandler(this.Application_NavigationStopped);
            
            #line default
            #line hidden
            
            #line 16 "..\..\App.xaml"
            this.SessionEnding += new System.Windows.SessionEndingCancelEventHandler(this.Application_SessionEnding);
            
            #line default
            #line hidden
            
            #line 17 "..\..\App.xaml"
            this.StartupUri = new System.Uri("MainWindow.xaml", System.UriKind.Relative);
            
            #line default
            #line hidden
            System.Uri resourceLocater = new System.Uri("/HubCrawl;component/app.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\App.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main() {
            HubCrawl.App app = new HubCrawl.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}

