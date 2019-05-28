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
using System.Windows.Shapes;
using training.Services;

namespace training
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public Game game { get; private set; }

        public StartWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel(new DefaultDialogService(), new JsonFileService());
        }

        //public StartWindow(Game g)
        //{
        //    InitializeComponent();
        //    game = g;
        //    this.DataContext = game;
        //}

        //
        // here must be  add commands for buttons
        //
    }
}
