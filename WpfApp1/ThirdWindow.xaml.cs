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
    /// Interaction logic for ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        string model;
        string fuelandtransmisson;
        string pack;
        string color;
        string year;
        int model1;
        int fuelandtransmisson1;
        int year1;



        private void _1_1_Checked(object sender, RoutedEventArgs e)
        {

            model = "model: clio";
            _1_1.Background = Brushes.Green;
            _1_2.Background = Brushes.Red;
            _1_3.Background = Brushes.Red;
            model1 = 700;
        }
        private void _1_2_Checked(object sender, RoutedEventArgs e)
        {
            model = "model: megane";
            _1_2.Background = Brushes.Green;
            _1_1.Background = Brushes.Red;
            _1_3.Background = Brushes.Red;
            model1 = 800;
        }

        private void _1_3_Checked(object sender, RoutedEventArgs e)
        {
            model = "model: talisman";
            _1_3.Background = Brushes.Green;
            _1_2.Background = Brushes.Red;
            _1_1.Background = Brushes.Red;
            model1 = 900;

        }
        private void _2_1_Checked(object sender, RoutedEventArgs e)
        {
            fuelandtransmisson = "fuel/gear: gasoline + manual";
            _2_1.Background = Brushes.Green;
            _2_2.Background = Brushes.Red;
            _2_3.Background = Brushes.Red;
            _2_4.Background = Brushes.Red;
            fuelandtransmisson1 = 0;
        }
        private void _2_2_Checked_1(object sender, RoutedEventArgs e)
        {
            fuelandtransmisson = "fuel/gear: gasoline + automatic";
            _2_2.Background = Brushes.Green;
            _2_1.Background = Brushes.Red;
            _2_3.Background = Brushes.Red;
            _2_4.Background = Brushes.Red;
            fuelandtransmisson1 = 150;
        }

        private void _2_3_Checked_1(object sender, RoutedEventArgs e)
        {
            fuelandtransmisson = "fuel/gear: diesel + manual";
            _2_3.Background = Brushes.Green;
            _2_2.Background = Brushes.Red;
            _2_1.Background = Brushes.Red;
            _2_4.Background = Brushes.Red;
            fuelandtransmisson1 = 100;
        }

        private void _2_4_Checked_1(object sender, RoutedEventArgs e)
        {
            fuelandtransmisson = "fuel/gear: diesel + automatic";
            _2_4.Background = Brushes.Green;
            _2_2.Background = Brushes.Red;
            _2_3.Background = Brushes.Red;
            _2_1.Background = Brushes.Red;
            fuelandtransmisson1 = 200;
        }

        private void _3_1_Checked_1(object sender, RoutedEventArgs e)
        {
            pack = "equipment package: joy";
            _3_1.Background = Brushes.Green;
            _3_2.Background = Brushes.Red;
            _3_3.Background = Brushes.Red;
            
        }

        private void _3_2_Checked_1(object sender, RoutedEventArgs e)
        {
            pack = "equipment package: touch";
            _3_2.Background = Brushes.Green;
            _3_1.Background = Brushes.Red;
            _3_3.Background = Brushes.Red;

        }

        private void _3_3_Checked_1(object sender, RoutedEventArgs e)
        {
            pack = "equipment package: icon";
            _3_3.Background = Brushes.Green;
            _3_2.Background = Brushes.Red;
            _3_1.Background = Brushes.Red;
        }

        private void _4_1_Checked_1(object sender, RoutedEventArgs e)
        {
            color = "vehicle color: white";
            _4_1.Background = Brushes.Green;
            _4_2.Background = Brushes.Red;
            _4_3.Background = Brushes.Red;
            _4_4.Background = Brushes.Red;
            _4_5.Background = Brushes.Red;

        }

        private void _4_2_Checked_1(object sender, RoutedEventArgs e)
        {
            color = "vehicle color: blue";
            _4_2.Background = Brushes.Green;
            _4_1.Background = Brushes.Red;
            _4_3.Background = Brushes.Red;
            _4_4.Background = Brushes.Red;
            _4_5.Background = Brushes.Red;
        }

        private void _4_3_Checked_1(object sender, RoutedEventArgs e)
        {
            color = "vehicle color: red";
            _4_3.Background = Brushes.Green;
            _4_2.Background = Brushes.Red;
            _4_1.Background = Brushes.Red;
            _4_4.Background = Brushes.Red;
            _4_5.Background = Brushes.Red;
        }

        private void _4_4_Checked_1(object sender, RoutedEventArgs e)
        {
            color = "vehicle color: grey";
            _4_4.Background = Brushes.Green;
            _4_2.Background = Brushes.Red;
            _4_3.Background = Brushes.Red;
            _4_1.Background = Brushes.Red;
            _4_5.Background = Brushes.Red;
        }

        private void _4_5_Checked_1(object sender, RoutedEventArgs e)
        {
            color = "vehicle color: black";
            _4_5.Background = Brushes.Green;
            _4_2.Background = Brushes.Red;
            _4_3.Background = Brushes.Red;
            _4_4.Background = Brushes.Red;
            _4_1.Background = Brushes.Red;
        }
        private void _5_1_Checked_1(object sender, RoutedEventArgs e)
        {
            year = "before 2005";
            _5_1.Background = Brushes.Green;
            _5_2.Background = Brushes.Red;
            _5_3.Background = Brushes.Red;
            _5_4.Background = Brushes.Red;
            _5_5.Background = Brushes.Red;
            year1 = 500;
        }

        private void _5_2_Checked_1(object sender, RoutedEventArgs e)
        {
            year = "vehicle model year: 2005 - 2009";
            _5_2.Background = Brushes.Green;
            _5_1.Background = Brushes.Red;
            _5_3.Background = Brushes.Red;
            _5_4.Background = Brushes.Red;
            _5_5.Background = Brushes.Red;
            year1 = 300;
        }

        private void _5_3_Checked_1(object sender, RoutedEventArgs e)
        {
            year = "vehicle model year: 2009 - 2013";
            _5_3.Background = Brushes.Green;
            _5_2.Background = Brushes.Red;
            _5_1.Background = Brushes.Red;
            _5_4.Background = Brushes.Red;
            _5_5.Background = Brushes.Red;
            year1 = 200;
        }

        private void _5_4_Checked_1(object sender, RoutedEventArgs e)
        {
            year = "vehicle model year: 2013 - 2017";
            _5_4.Background = Brushes.Green;
            _5_2.Background = Brushes.Red;
            _5_3.Background = Brushes.Red;
            _5_1.Background = Brushes.Red;
            _5_5.Background = Brushes.Red;
            year1 = 100;
        }

        private void _5_5_Checked_1(object sender, RoutedEventArgs e)
        {
            year = "vehicle model year: 2017 - 2021";
            _5_5.Background = Brushes.Green;
            _5_2.Background = Brushes.Red;
            _5_3.Background = Brushes.Red;
            _5_4.Background = Brushes.Red;
            _5_1.Background = Brushes.Red;
            year1 = 0;
        }










       

        private void Back_menu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();                           //It provides open main window
        }

        private void Show_car_Click(object sender, RoutedEventArgs e)
        {
            info_1.Text = model;
            info_2.Text = fuelandtransmisson;
            info_3.Text = pack;
            info_4.Text = color;
            info_5.Text = year;
        }

        private void routine_Click(object sender, RoutedEventArgs e)
        {

            info_6.Text = (model1 + fuelandtransmisson1 + year1).ToString() + " tl";



            /* model 
            
            (clio = 700 tl)
            (megane = 800 tl)
            (talisman = 900 tl)

            fuelandtransmission

             (gasoline + manual = 0 tl)
             (gasoline + automatic = 150 tl)
             (diesel + manual = 100 tl)
             (diesel + automatic = 200 tl)

            year

            (before 2005 = 500 tl)
            (2005 - 2009 = 300 tl)
            (2009 - 2013 = 200 tl)
            (2013 - 2017 = 100 tl)
            (2017 - 2021 =0 tl)

    
           */
        }

       
       
      
    }
}