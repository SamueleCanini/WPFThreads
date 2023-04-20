using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

namespace conti.maurizio._4i.wpfThreads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //IncrementCounterProva();

            Thread thread1 = new Thread(IncrementCounter1);
            thread1.Start();
        }

        private void IncrementCounter1()
        {
            for (int i = 0; i < 1000; i++)
            {
                _counter++;
                Thread.Sleep(10);

                Dispatcher.Invoke(

                    () =>

                    {
                        lblCounter1.Foreground = Brushes.LightBlue;
                        lblCounter1.Text = _counter.ToString();
                    }
                
                );
            }
        }
        private void IncrementCounterProva()
        {
            for (int i = 0; i < 200; i++)
            {
                _counter++;

                lblCounter1.Foreground = Brushes.LightBlue;
                lblCounter1.Text = _counter.ToString();

                Thread.Sleep( 10 );

            }

        }

    }
}
