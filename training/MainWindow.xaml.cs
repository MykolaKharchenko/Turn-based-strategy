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
using training.Services;
using training.Models;
using training.ViewModel;

namespace training
{
    public partial class MainWindow : Window
    {
        public MainWindow( IDialogService _dialogService, IFileService _fileService, Game game = null)
        {
            InitializeComponent();
            DataContext = new GameDriveViewModel( _dialogService, _fileService, game);
        }

        //private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    MessageBox.Show("Справка по приложению");
        //}

        //private void WindowBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    skeleton.Background = Brushes.DarkGreen;
        //    //MessageBox.Show("Вызов справки");            
        //}
    }
}
