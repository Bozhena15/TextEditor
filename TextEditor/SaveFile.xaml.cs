using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for SaveFile.xaml
    /// </summary>
    public partial class SaveFile : Window
    {
        private string _content;

        public SaveFile(string content)
        {
            InitializeComponent();

            _content = content;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                FileName = $"Name{extension.Text}",
                Filter = "Text file (*.txt)|*.txt|PDF file (*.pdf)|*.pdf|RTF file (*.rtf)|*.rtf"
            };

            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, _content);
        }
    }
}
