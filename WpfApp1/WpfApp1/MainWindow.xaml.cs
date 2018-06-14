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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
            
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
           this.Width = 400;
            this.Height = 400;
        }

        private void TreeViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            this.Width = 400;
            this.Height = 400;
        }

        private void TreeViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            this.Width = 400;
            this.Height = 400;
        }

        private void TreeViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            this.Width = 400;
            this.Height = 400;
        }
    }
}
