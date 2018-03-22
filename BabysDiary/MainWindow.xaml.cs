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
            message.Visibility = Visibility.Hidden;
            messageText.Visibility = Visibility.Hidden;
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

        private void SetRecordInvisible()
        {
            HeightAndWeight.Visibility = Visibility.Hidden;
            Nutrition.Visibility = Visibility.Hidden;
            Sleeping.Visibility = Visibility.Hidden;
        }

        private void SetReportInvisible()
        {
            ReportH.Visibility = Visibility.Hidden;
            ReportW.Visibility = Visibility.Hidden;
            ReportResult.Visibility = Visibility.Hidden;
            ReportEval.Visibility = Visibility.Hidden;
        }

        private void SetCameraInvisible()
        {
            TakePhoto.Visibility = Visibility.Hidden;
            SavePhoto.Visibility = Visibility.Hidden;
        }

        private void SetMemoryInvisible()
        {
            Msit.Visibility = Visibility.Hidden;
            Mcrawl.Visibility = Visibility.Hidden;
            Mstand.Visibility = Visibility.Hidden;
            Mwalk.Visibility = Visibility.Hidden;
        }


        private void SetSettingInvisible()
        {
            Set.Visibility = Visibility.Hidden;
            Theme.Visibility = Visibility.Hidden;
            Supp.Visibility = Visibility.Hidden;
            About.Visibility = Visibility.Hidden;
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

        private void Image_MouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Record.Visibility = Visibility.Visible;
            SetRecordInvisible();
            HeightAndWeight.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_9(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Record.Visibility = Visibility.Visible;
            SetRecordInvisible();
            Nutrition.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_10(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Record.Visibility = Visibility.Visible;
            SetRecordInvisible();
            HeightAndWeight.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_11(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Record.Visibility = Visibility.Visible;
            SetRecordInvisible();
            Nutrition.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_12(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Record.Visibility = Visibility.Visible;
            SetRecordInvisible();
            Sleeping.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SetAllInvisible();
            Loading.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_13(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Report.Visibility = Visibility.Visible;
            SetReportInvisible();
            ReportW.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_14(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Report.Visibility = Visibility.Visible;
            SetReportInvisible();
            ReportResult.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_15(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Report.Visibility = Visibility.Visible;
            SetReportInvisible();
            ReportEval.Visibility = Visibility.Visible;
        }

        private void left1_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Report.Visibility = Visibility.Visible;
            SetReportInvisible();
            ReportH.Visibility = Visibility.Visible;
        }

        private void left1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Report.Visibility = Visibility.Visible;
            SetReportInvisible();
            ReportW.Visibility = Visibility.Visible;
        }

        private void left1_Copy1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Report.Visibility = Visibility.Visible;
            SetReportInvisible();
            ReportResult.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SetAllInvisible();
            Home.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_16(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Camera.Visibility = Visibility.Visible;
            SetCameraInvisible();
            TakePhoto.Visibility = Visibility.Visible;
        }

        private void CameraIcon_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Home.Visibility = Visibility.Visible;
        }

        private void CameraIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Camera.Visibility = Visibility.Visible;
            SetCameraInvisible();
            SavePhoto.Visibility = Visibility.Visible;
        }

        private void back_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Camera.Visibility = Visibility.Visible;
            SetCameraInvisible();
            TakePhoto.Visibility = Visibility.Visible;
        }

        private void album_icon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Album.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_17(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Memory.Visibility = Visibility.Visible;
            SetMemoryInvisible();
            Mcrawl.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_18(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Memory.Visibility = Visibility.Visible;
            SetMemoryInvisible();
            Mstand.Visibility = Visibility.Visible;
        }

        private void left2_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Memory.Visibility = Visibility.Visible;
            SetMemoryInvisible();
            Msit.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_19(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Memory.Visibility = Visibility.Visible;
            SetMemoryInvisible();
            Mwalk.Visibility = Visibility.Visible;
        }

        private void left2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Memory.Visibility = Visibility.Visible;
            SetMemoryInvisible();
            Mcrawl.Visibility = Visibility.Visible;
        }

        private void left2_Copy1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Memory.Visibility = Visibility.Visible;
            SetMemoryInvisible();
            Mstand.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_20(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Memory.Visibility = Visibility.Visible;
            SetMemoryInvisible();
            Msit.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_21(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Memory.Visibility = Visibility.Visible;
            SetMemoryInvisible();
            Msit.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SetAllInvisible();
            Setting.Visibility = Visibility.Visible;
            SetSettingInvisible();
            Theme.Visibility = Visibility.Visible;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SetAllInvisible();
            Setting.Visibility = Visibility.Visible;
            SetSettingInvisible();
            Supp.Visibility = Visibility.Visible;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SetAllInvisible();
            Setting.Visibility = Visibility.Visible;
            SetSettingInvisible();
            About.Visibility = Visibility.Visible;
        }

        private void back_Copy9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Setting.Visibility = Visibility.Visible;
            SetSettingInvisible();
            Set.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_22(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Setting.Visibility = Visibility.Visible;
            SetSettingInvisible();
            Set.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_23(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Report.Visibility = Visibility.Visible;
            SetReportInvisible();
            ReportH.Visibility = Visibility.Visible;
        }

        private void message_MouseEnter(object sender, MouseEventArgs e)
        {
            message.Visibility = Visibility.Visible;
            messageText.Visibility = Visibility.Visible;
        }

        private void message_MouseLeave(object sender, MouseEventArgs e)
        {
            message.Visibility = Visibility.Hidden;
            messageText.Visibility = Visibility.Hidden;
        }

        private void Image_MouseLeftButtonDown_24(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            RealTimeDiet.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_25(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Home.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_26(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            Profile.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_27(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            DietPlan.Visibility = Visibility.Visible;
            SetDietPlanInvisible();
            Diet.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown_28(object sender, MouseButtonEventArgs e)
        {
            SetAllInvisible();
            DietPlan.Visibility = Visibility.Visible;
            SetDietPlanInvisible();
            Change.Visibility = Visibility.Visible;
        }
    }
}
