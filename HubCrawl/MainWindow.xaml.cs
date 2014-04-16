using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HubCrawl
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowsFormsHost formHost = new WindowsFormsHost();
            this.LayoutRoot.Children.Add(formHost);
            System.Windows.Forms.Panel hostPanel = new System.Windows.Forms.Panel();
            ProcessStartInfo psi = new ProcessStartInfo("notepad.exe");
            psi.WindowStyle = ProcessWindowStyle.Normal;
            Process pr = Process.Start(psi);
            pr.WaitForInputIdle();
            
        }
    }
}
