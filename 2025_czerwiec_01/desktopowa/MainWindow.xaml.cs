using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            double[] values = { Slider1?.Value ?? 0.0, Slider2?.Value ?? 0.0, Slider3?.Value ?? 0.0 };
            Label.Background = new SolidColorBrush(
                Color.FromRgb(
                    (byte)values[0],
                    (byte)values[1],
                    (byte)values[2]
                )
            );
            Label.Content = $"{(byte)values[0]}, {(byte)values[1]}, {(byte)values[2]}";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double[] values = { Slider1?.Value ?? 0.0, Slider2?.Value ?? 0.0, Slider3?.Value ?? 0.0 };
            Rectangle.Fill = new SolidColorBrush(
                Color.FromRgb(
                    (byte)values[0],
                    (byte)values[1],
                    (byte)values[2]
                )
            );

            if (Value1 == null || Value2 == null || Value3 == null) 
                return;

            Value1.Text = ((byte)values[0]).ToString();
            Value2.Text = ((byte)values[1]).ToString();
            Value3.Text = ((byte)values[2]).ToString();
        }
    }
}