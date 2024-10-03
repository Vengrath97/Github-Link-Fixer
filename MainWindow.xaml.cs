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

namespace WpfApp4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // Sample input URL
            //string inputUrl = sampleurl.Text;
            string inputUrl = Clipboard.GetText();
            sampleurl.Text = inputUrl;
            // Step 1: Replace 'github.com' with 'raw.githubusercontent.com'
            string modifiedUrl = inputUrl.Replace("https://github.com", "https://raw.githubusercontent.com");

            // Step 2: Remove '/blob' from the URL
            modifiedUrl = modifiedUrl.Replace("/blob", "");
            newurl.Text = modifiedUrl;
            // Step 3: Copy the modified URL to the clipboard using TextCopy
            Clipboard.SetText(modifiedUrl);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
