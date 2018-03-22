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
            SetAllInvisible();
            Login.Visibility = Visibility.Visible;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp1.Visibility = Visibility.Visible;
        }

        private void SetAllInvisible()
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

        private void SetSetUpInvisible()
        {
            SetUp1.Visibility = Visibility.Hidden;
            SetUp2.Visibility = Visibility.Hidden;
            SetUp3.Visibility = Visibility.Hidden;
            SetUp4.Visibility = Visibility.Hidden;
            SetUp5.Visibility = Visibility.Hidden;
            SetUp6.Visibility = Visibility.Hidden;
        }

        private void SetDietPlanInvisible()
        {
            Diet.Visibility = Visibility.Hidden;
            Analysis.Visibility = Visibility.Hidden;
            Change.Visibility = Visibility.Hidden;
        }

        private void SetSleepCycleInvisible()
        {
            Today.Visibility = Visibility.Hidden;
            Week.Visibility = Visibility.Hidden;
        }


        private void aImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Login.Visibility = Visibility.Visible;

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp2.Visibility = Visibility.Visible;
        }

        private void left_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp1.Visibility = Visibility.Visible;
        }

        private void right_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp3.Visibility = Visibility.Visible;
        }

        private void left_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp2.Visibility = Visibility.Visible;
        }

        private void right_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp4.Visibility = Visibility.Visible;
        }

        private void left_Copy1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp3.Visibility = Visibility.Visible;
        }

        private void right_Copy1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp5.Visibility = Visibility.Visible;
        }

        private void left_Copy2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp4.Visibility = Visibility.Visible;
        }

        private void right_Copy2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp6.Visibility = Visibility.Visible;
        }

        private void left_Copy3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SetUp.Visibility = Visibility.Visible;
            SetSetUpInvisible();
            SetUp5.Visibility = Visibility.Visible;
        }

        private void right_Copy3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Home.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Home.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            DietPlan.Visibility = Visibility.Visible;
            SetDietPlanInvisible();
            Diet.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            DietPlan.Visibility = Visibility.Visible;
            SetDietPlanInvisible();
            Diet.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetAllInvisible();
            DietPlan.Visibility = Visibility.Visible;
            SetDietPlanInvisible();
            Analysis.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SleepCycle.Visibility = Visibility.Visible;
            SetSleepCycleInvisible();
            Today.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SleepCycle.Visibility = Visibility.Visible;
            SetSleepCycleInvisible();
            Today.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            SleepCycle.Visibility = Visibility.Visible;
            SetSleepCycleInvisible();
            Week.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Reminder.Visibility = Visibility.Visible;
        }
    }
}
