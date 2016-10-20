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
            if (increase_font.Content.ToString() == "increase font")
            {
                DoubleAnimation animation = new DoubleAnimation(100, TimeSpan.FromSeconds(1.0));
                text_animation.BeginAnimation(TextBlock.FontSizeProperty, animation);
                increase_font.Content = "decrease font";
            }
           else if (increase_font.Content.ToString() == "decrease font")
            {
                DoubleAnimation animation2 = new DoubleAnimation(48, TimeSpan.FromSeconds(1.0));
                text_animation.BeginAnimation(TextBlock.FontSizeProperty, animation2);
                increase_font.Content = "increase font";

            }
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation ThickAnimation = new ThicknessAnimation();

            ThickAnimation.From = new Thickness(0,75,-300,0);
            ThickAnimation.To = new Thickness(0,75, 119, 0);
            ThickAnimation.Duration = TimeSpan.FromSeconds(3);
            text_animation.BeginAnimation(TextBlock.MarginProperty, ThickAnimation);


        }

     

        private void button_hover1(object sender, MouseEventArgs e)
        {
            rotate_text.Opacity = 1;
        }

        private void text_hover(object sender, MouseEventArgs e)
        {

        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            text_animation.Content = "peace";

        }

        private void peace_unchecked(object sender, RoutedEventArgs e)
        {
            text_animation.Content = "Hello World";

        }
    }
}
