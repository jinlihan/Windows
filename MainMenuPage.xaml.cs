using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTest.UI.Menu
{
    /// <summary>
    /// TopMenuPage.xaml 的交互逻辑
    /// </summary>
    public partial class MainMenuPage : ChildPage
    {
       
          //声明热键(选中的lable),并且定义选定时和未选定的。
        Label lableHot;
        Brush brush_hot = new SolidColorBrush(Color.FromRgb(0, 255, 0));
        Brush brush_normal = new SolidColorBrush(Color.FromRgb(255, 250, 250));


        public MainMenuPage()
        {
            InitializeComponent();
            //初始化label的背景颜色
            label2.Background = brush_hot;
            lableHot = label2;
        }

        private void label1_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter0");
            lableHot.Background = brush_normal;
        }

        private void label2_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter1");
            //前一选定恢复原色，选定变色
            lableHot.Background = brush_normal;
            label2.Background = brush_hot;
            lableHot = label2;
        }

        private void label3_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter2");
            lableHot.Background = brush_normal;
            label3.Background = brush_hot;
            lableHot = label3;
        }

        private void label4_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter3");
            lableHot.Background = brush_normal;
            label4.Background = brush_hot;
            lableHot = label4;
        }

        private void label5_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter4");
            lableHot.Background = brush_normal;
            label5.Background = brush_hot;
            lableHot = label5;
        }

        private void label6_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter5");
            lableHot.Background = brush_normal;
            label6.Background = brush_hot;
            lableHot = label6;
        }

        private void label7_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter6");
            lableHot.Background = brush_normal;
            label7.Background = brush_hot;
            lableHot = label7;
        }

        private void label8_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter7");
            lableHot.Background = brush_normal;
            label8.Background = brush_hot;
            lableHot = label8;
        }

        private void label9_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter8");
            lableHot.Background = brush_normal;
            label9.Background = brush_hot;
            lableHot = label9;
        }

        private void ChildPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            parentWindow.createLeftMenuPage("chapter1");
        }
    }
}
