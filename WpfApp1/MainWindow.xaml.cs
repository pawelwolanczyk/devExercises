using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _bRun = false;
        string _text;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ButtonCounter1_Click(object sender, RoutedEventArgs e)
        {
            _bRun = !_bRun;

            Button b1 = FindName("B1") as Button;
            Button b2 = FindName("B2") as Button;

            b1.Content = b2.Content = _bRun ? "Stop" : "Start";

            if (_bRun)
                await StartCountingAsync();
            else
            {
                TextBox tBox = FindName("Counter") as TextBox;
                if (tBox == null)
                    return;

                tBox.Text = CounterHandler.GetInstance().Counter.ToString();
            }
        }

        private void ButtonCounter2_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button == null)
                return;

            _bRun = !_bRun;

            Button b1 = FindName("B1") as Button;
            Button b2 = FindName("B2") as Button;

            b1.Content = b2.Content = _bRun ? "Start" : "Stop";

            if (_bRun)
                StartCounting();
            else
            {
                TextBox tBox = FindName("Counter") as TextBox;
                if (tBox == null)
                    return;

                tBox.Text = CounterHandler.GetInstance().Counter.ToString();
            }
        }

        public string CounterText
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }

        private async Task StartCountingAsync()
        {
            await Task.Run(() =>
            {
                while (_bRun)
                {
                    CounterHandler s = CounterHandler.GetInstance();
                    s.IncrementCounter();
                }
            });
        }

        private void StartCounting()
        {
            while(_bRun)
            {
                CounterHandler s = CounterHandler.GetInstance();
                s.IncrementCounter();
            }
        }
    }
}
