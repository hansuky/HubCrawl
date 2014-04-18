using HubCrawl.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HubCrawl.Controls
{
    /// <summary>
    /// ConsoleControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ConsoleControl : UserControl
    {
        ConsoleContent dc = new ConsoleContent();

        public ConsoleControl()
        {
            InitializeComponent();
            DataContext = dc;
            this.Loaded += ConsoleControl_Loaded;
        }

        void ConsoleControl_Loaded(object sender, RoutedEventArgs e)
        {
            InputBlock.KeyDown += InputBlock_KeyDown;
            InputBlock.Focus();
        }

        void InputBlock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                dc.ConsoleInput = InputBlock.Text;
                dc.RunCommand();
                InputBlock.Focus();
                Scroller.ScrollToBottom();
            }
        }
    }
}
