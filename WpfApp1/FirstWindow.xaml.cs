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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void List_Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Visit_WebPage_Click_1(object sender, RoutedEventArgs e)
        {
            SecondWindow objSecondWindow = new SecondWindow();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();

        }

        private void Back_Menu1_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();
        }

        int model;
        int fandg;
        int packet;
        int opsion;

        private void Clio1_Checked(object sender, RoutedEventArgs e)
        {
            model = 155000;
        }

        private void Megane1_Checked(object sender, RoutedEventArgs e)
        {
            model = 200000;
        }

        private void Talisman1_Checked(object sender, RoutedEventArgs e)
        {
            model = 465900;
        }

        private void joy_Checked(object sender, RoutedEventArgs e)
        {
            packet = 0;
        }

        private void touch_Checked(object sender, RoutedEventArgs e)
        {
            packet = 8000;
        }

        private void icon_Checked(object sender, RoutedEventArgs e)
        {
            packet = 20000;
        }

        private void gearbox_1_Checked(object sender, RoutedEventArgs e)
        {
            fandg = 0;
        }

        private void gearbox_2_Checked(object sender, RoutedEventArgs e)
        {
            fandg = 15000;
        }

        private void gearbox_3_Checked(object sender, RoutedEventArgs e)
        {
            fandg = 25000;
        }

        private void gearbox_4_Checked(object sender, RoutedEventArgs e)
        {
            fandg = 35000;
        }

        private void wheel_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 2000;
        }

        private void park_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 10000;
        }

        private void metallic_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 1250;
        }

        private void _fixed_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 2250;
        }

        private void rlink_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 4250;
        }

        private void gloss_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 250;
        }

        private void shock_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 3000;
        }

        private void _4control_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 9000;
        }

        private void cruise_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 1900;
        }

        private void panoramic_Checked(object sender, RoutedEventArgs e)
        {
            packet = packet + 8000;
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            Result_Text.Text = (model + fandg + packet + opsion).ToString() + " tl";
        }
    }
}
