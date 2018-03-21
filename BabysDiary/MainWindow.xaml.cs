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

namespace BabysDiary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setAllInvisible();
            Login.Visibility = Visibility.Visible;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            setAllInvisible();
            Home.Visibility = Visibility.Visible;
        }

        private void setAllInvisible()
        {
            Login.Visibility = Visibility.Hidden;
            Register.Visibility = Visibility.Hidden;
            SetUp.Visibility = Visibility.Hidden;
            Home.Visibility = Visibility.Hidden;
            DietPlan.Visibility = Visibility.Hidden;
            SleepCycle.Visibility = Visibility.Hidden;
            Reminder.Visibility = Visibility.Hidden;
            Record.Visibility = Visibility.Hidden;
            Report.Visibility = Visibility.Hidden;
            Camera.Visibility = Visibility.Hidden;
            Profile.Visibility = Visibility.Hidden;
            Memory.Visibility = Visibility.Hidden;
            Album.Visibility = Visibility.Hidden;
            Setting.Visibility = Visibility.Hidden;
            Loading.Visibility = Visibility.Hidden;
            RealTimeDiet.Visibility = Visibility.Hidden;
        }


        private void aImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            setAllInvisible();
            Login.Visibility = Visibility.Visible;

        }
    }
}
