using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace TextEditor2
{
    /// <summary>
    /// Interaction logic for CreateFile.xaml
    /// </summary>
    public partial class CreateFile : Window
    {
        private string _content;
        public CreateFile(string content)
        {
            InitializeComponent();
            _content = content;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog createFileDialog = new OpenFileDialog();
            //if(createFileDialog.ShowDialog() == true)
                //File.WriteAllText(createFileDialog.FileName, _content);
        }
    }
}
