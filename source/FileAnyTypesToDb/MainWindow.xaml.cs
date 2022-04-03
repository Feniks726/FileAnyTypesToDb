using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace FileAnyTypesToDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _fileName;
        private string _fileExtention;
        private byte[] _fileDataArray;


        private string fileName
        {
            get => _fileName;
            set => _fileName = value;
        }

        private string fileExtention
        {
            get => _fileExtention;
            set => _fileExtention = value;
        }

        private byte[] fileDataArray
        {
            get => _fileDataArray;
            set => _fileDataArray = value;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog()
                {
                    Multiselect = false
                };
                if (openFileDialog.ShowDialog() != true) return;
                var tmp = openFileDialog.FileName;
                // Open the file, copy the contents of memoryStream to fileStream,
                // and close fileStream. Set the memoryStream.Position value to 0 
                // to copy the entire stream. 
                fileName = Path.GetFileNameWithoutExtension(tmp);
                fileExtention = Path.GetFileName(tmp);
                while (fileExtention.Contains('.'))
                {
                    fileExtention = fileExtention.Remove(0, fileExtention.IndexOf('.') > 0 ? fileExtention.IndexOf('.') : 1);
                }

                fileDataArray = File.ReadAllBytes(openFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
