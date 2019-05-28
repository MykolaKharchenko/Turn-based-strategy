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

namespace training
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        //public Game game = new Game();

        public StartWindow(Game g)
        {
            InitializeComponent();

            //game = g;
            //this.DataContext = game;
        }


        //private void Accept_Click(object sender, RoutedEventArgs e)
        //{
        //    this.DialogResult = true;
        //}
    }
}
