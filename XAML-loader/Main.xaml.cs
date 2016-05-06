using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace XAML_loader
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

        private void openFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                textBox.Text = openFileDialog.FileName;
        }

        private void showXaml(object sender, RoutedEventArgs e)
        {
          //  Window newWindow;
            try { 
            var xmlReader = XmlReader.Create(textBox.Text);
            var newWindow = XamlReader.Load(xmlReader) as Window;
            newWindow.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something very bad happened!..." + ex.Message);
            }
            
        }
    }
}
