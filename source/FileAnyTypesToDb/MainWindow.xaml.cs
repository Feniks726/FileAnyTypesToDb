using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using FileAnyTypesToDb.Domain.Models;
using FileAnyTypesToDb.Service.Services;
using Microsoft.Win32;

namespace FileAnyTypesToDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RefreshService _refreshService;
        private AddService _addService;
        private DeleteService _deleteService;

        private string _fileName;
        private string _fileExtention;
        private byte[] _fileDataArray;

        private FileData selectedRow = null;

        private FileData _selectedRow
        {
            get => selectedRow;
            set => selectedRow = value;
        }

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _refreshService = new RefreshService();

            var data = _refreshService.Get();

            Grid1.ItemsSource = data;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _addService = new AddService();
            try
            {
                var openFileDialog = new OpenFileDialog()
                {
                    Multiselect = false
                };
                if (openFileDialog.ShowDialog() != true) return;
                var tmp = openFileDialog.FileName;
                fileName = Path.GetFileNameWithoutExtension(tmp);

                fileDataArray = File.ReadAllBytes(openFileDialog.FileName);
                _addService.Execute(fileName, fileDataArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Button_Click_1(sender, e);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (_selectedRow == null)
            {
                return;
            }
            _deleteService  = new DeleteService();
            _deleteService.Execute(selectedRow.Id);
            Button_Click_1(sender, e);
        }

        private void Grid1_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                _selectedRow = (FileData) Grid1.SelectedItem;
            }
            catch { }
        }
    }
}
