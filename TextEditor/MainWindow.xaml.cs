
using System.Windows;


namespace TextEditor
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

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            SaveFile saveFile = new SaveFile(textBox.Text);
            saveFile.Show();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Contains(fileSearch.Text))
            {
                var index = textBox.Text.ToLower().IndexOf(fileSearch.Text.ToLower());
                textBox.Select(index, fileSearch.Text.Length);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
