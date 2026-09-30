using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class SzyfrCezara
    {
        public SzyfrCezara(string t, int k)
        {
            text = t;
            key = k;

            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    newText += ' ';
                    continue;
                }

                int newCharNumber = (char)text[i] + key;
                if (newCharNumber > 122)
                    newCharNumber = 97 + (newCharNumber - 123);
                else if (newCharNumber < 97)
                    newCharNumber = 122 - (96 - newCharNumber);
                newText += Convert.ToChar(newCharNumber);
            }

            result = newText;
        }

        public string result;
        string text;
        int key;
    }


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            int key = 0;
            int.TryParse(Key.Text, out key);
            SzyfrCezara szyfr = new SzyfrCezara(Text.Text, key);
            Result.Text = szyfr.result;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
                File.WriteAllText(dialog.FileName, Result.Text);
            
        }
    }
}