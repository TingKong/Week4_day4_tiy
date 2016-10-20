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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace eventhandler
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 360;
            da.Duration = new Duration(TimeSpan.FromSeconds(3));
            RotateTransform rt = new RotateTransform();
            text_animation.RenderTransform = rt;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);


        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation(100, TimeSpan.FromSeconds(1.0));
            text_animation.BeginAnimation(TextBlock.FontSizeProperty, animation);

        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation ThickAnimation = new ThicknessAnimation();

            ThickAnimation.From = new Thickness(0,75,10,0);
            ThickAnimation.To = new Thickness(0,75,1000,0);
            ThickAnimation.Duration = TimeSpan.FromSeconds(3);
            text_animation.BeginAnimation(TextBlock.MarginProperty, ThickAnimation);


        }
    }
}
