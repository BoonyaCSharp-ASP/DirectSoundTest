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

namespace DirectsoundTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        private DirectSound recorder = null;    // 录音 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // 

            // 录音设置 

            // 

            recorder = new DirectSound();

            string wavfile = null;

            wavfile = "test.wav";

            recorder.SetFileName(wavfile);

            recorder.RecStart();

            button.IsEnabled = false;
            button1.IsEnabled = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            recorder.RecStop();

            recorder = null;

            button1.IsEnabled = false;
            button.IsEnabled = true;
        }
    }
}
