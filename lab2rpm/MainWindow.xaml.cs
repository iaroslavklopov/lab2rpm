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

namespace lab2rpm
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int a = BgChanged.SelectedIndex;
            switch (a)
            {
                case 0:
                    {
                        App.Current.MainWindow.Background = Brushes.White;
                        break;
                    }
                case 1:
                    {
                        App.Current.MainWindow.Background = Brushes.LightGray;
                        break;
                    }
                case 2:
                    {
                        App.Current.MainWindow.Background = Brushes.DarkGray;
                        break;
                    }
                case 3:
                    {
                        App.Current.MainWindow.Background = Brushes.Black;
                        break;
                    }
            }
        }
        private void AboutUs(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aidar & Yaroslav", "About Us");
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void AboutUsbtn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aidar & Yaroslav", "About Us");
        }

        private void Closebtn(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }
        int b = 0;
        private void Zalivkabtn(object sender, RoutedEventArgs e)
        {
            b += 1;
            if (b == 4)
            {
                b = 0;
            }
            switch (b)
            {
                case 0:
                    {
                        App.Current.MainWindow.Background = Brushes.White;
                        break;
                    }
                case 1:
                    {
                        App.Current.MainWindow.Background = Brushes.LightGray;
                        break;
                    }
                case 2:
                    {
                        App.Current.MainWindow.Background = Brushes.DarkGray;
                        break;
                    }
                case 3:
                    {
                        App.Current.MainWindow.Background = Brushes.Black;
                        break;
                    }
            }
        }

        private void BgEnter(object sender, MouseEventArgs e)
        {
            TextStrSost.Text = "Backgruund color changed";
        }

        private void BgLeave(object sender, MouseEventArgs e)
        {
            TextStrSost.Text = "";
        }

        private void AboutUsEnter(object sender, MouseEventArgs e)
        {
            TextStrSost.Text = "All about us";
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            TextStrSost.Text = "";
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            TextStrSost.Text = "Close Application";
        }

        private void MenuItem_MouseLeave_1(object sender, MouseEventArgs e)
        {
            TextStrSost.Text = "";
        }
    }
}
