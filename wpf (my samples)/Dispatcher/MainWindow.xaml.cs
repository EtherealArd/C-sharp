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
using System.Windows.Threading;

namespace Projwpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();     

        }
        private void buttonNewThread_Click(object sender, RoutedEventArgs e)
        {

            Thread th = new Thread(UpdateTextRight);
            th.Start();
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString());
        }

        private void UpdateTextRight()
        {

            Thread.Sleep(TimeSpan.FromSeconds(5));

            // v1.0
            ThreadStart threadStart = new ThreadStart(WorkerMethod);
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, threadStart);

            // v2.0
            txt.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (Action)delegate () { txt.Text = "Text"; });
        }


        private void WorkerMethod()
        {
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString());
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            txt.Text = "Test";
        }


    }
}
