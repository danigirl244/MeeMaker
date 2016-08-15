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

namespace MeeMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //Show attribute boxes
        private void FaceBoxShow(object sender, RoutedEventArgs e)
        {
            FaceBox.Visibility = Visibility.Visible;
            HairBox.Visibility = Visibility.Hidden;
            EyebrowBox.Visibility = Visibility.Hidden;
            EyesBox.Visibility = Visibility.Hidden;
            NoseBox.Visibility = Visibility.Hidden;
            MouthBox.Visibility = Visibility.Hidden;

        }
        private void HairBoxShow(object sender, RoutedEventArgs e)
        {
            FaceBox.Visibility = Visibility.Hidden;
            HairBox.Visibility = Visibility.Visible;
            EyebrowBox.Visibility = Visibility.Hidden;
            EyesBox.Visibility = Visibility.Hidden;
            NoseBox.Visibility = Visibility.Hidden;
            MouthBox.Visibility = Visibility.Hidden;

        }
        private void EyebrowBoxShow(object sender, RoutedEventArgs e)
        {
            FaceBox.Visibility = Visibility.Hidden;
            HairBox.Visibility = Visibility.Hidden;
            EyebrowBox.Visibility = Visibility.Visible;
            EyesBox.Visibility = Visibility.Hidden;
            NoseBox.Visibility = Visibility.Hidden;
            MouthBox.Visibility = Visibility.Hidden;

        }
        private void EyesBoxShow(object sender, RoutedEventArgs e)
        {
            FaceBox.Visibility = Visibility.Hidden;
            HairBox.Visibility = Visibility.Hidden;
            EyebrowBox.Visibility = Visibility.Hidden;
            EyesBox.Visibility = Visibility.Visible;
            NoseBox.Visibility = Visibility.Hidden;
            MouthBox.Visibility = Visibility.Hidden;

        }
        private void NoseBoxShow(object sender, RoutedEventArgs e)
        {
            FaceBox.Visibility = Visibility.Hidden;
            HairBox.Visibility = Visibility.Hidden;
            EyebrowBox.Visibility = Visibility.Hidden;
            EyesBox.Visibility = Visibility.Hidden;
            NoseBox.Visibility = Visibility.Visible;
            MouthBox.Visibility = Visibility.Hidden;

        }
        private void MouthBoxShow(object sender, RoutedEventArgs e)
        {
            FaceBox.Visibility = Visibility.Hidden;
            HairBox.Visibility = Visibility.Hidden;
            EyebrowBox.Visibility = Visibility.Hidden;
            EyesBox.Visibility = Visibility.Hidden;
            NoseBox.Visibility = Visibility.Hidden;
            MouthBox.Visibility = Visibility.Visible;

        }

        //Switch Noses
        private void ChooseOvalNose(object sender, RoutedEventArgs e)
        {
            OvalNose.Visibility = Visibility.Visible;
            RectangleNose.Visibility = Visibility.Hidden;
            CircleNose.Visibility = Visibility.Hidden;
        }
        private void ChooseRectangleNose(object sender, RoutedEventArgs e)
        {
            OvalNose.Visibility = Visibility.Hidden;
            RectangleNose.Visibility = Visibility.Visible;
            CircleNose.Visibility = Visibility.Hidden;
        }
        private void ChooseCircleNose(object sender, RoutedEventArgs e)
        {
            OvalNose.Visibility = Visibility.Hidden;
            RectangleNose.Visibility = Visibility.Hidden;
            CircleNose.Visibility = Visibility.Visible;
        }


        //Switch Hair
        private void Style1Show(object sender, RoutedEventArgs e)
        {
            Style1.Visibility = Visibility.Visible;
            Style1L.Visibility = Visibility.Visible;
            Style1R.Visibility = Visibility.Visible;

            Style2.Visibility = Visibility.Hidden;
            Style2L.Visibility = Visibility.Hidden;

            Style3.Visibility = Visibility.Hidden;
            Style3a.Visibility = Visibility.Hidden;
            Style3b.Visibility = Visibility.Hidden;

            Style5.Visibility = Visibility.Hidden;
            Style5a.Visibility = Visibility.Hidden;

            Style6a.Visibility = Visibility.Hidden;
            Style6b.Visibility = Visibility.Hidden;
            Style6c.Visibility = Visibility.Hidden;
            Style6d.Visibility = Visibility.Hidden;
            Style6e.Visibility = Visibility.Hidden;
            Style6f.Visibility = Visibility.Hidden;
            Style6g.Visibility = Visibility.Hidden;
        }
        private void Style2Show(object sender, RoutedEventArgs e)
        {
            Style1.Visibility = Visibility.Hidden;
            Style1L.Visibility = Visibility.Hidden;
            Style1R.Visibility = Visibility.Hidden;

            Style2.Visibility = Visibility.Visible;
            Style2L.Visibility = Visibility.Visible;

            Style3.Visibility = Visibility.Hidden;
            Style3a.Visibility = Visibility.Hidden;
            Style3b.Visibility = Visibility.Hidden;

            Style4L.Visibility = Visibility.Hidden;
            Style4R.Visibility = Visibility.Hidden;

            Style5.Visibility = Visibility.Hidden;
            Style5a.Visibility = Visibility.Hidden;

            Style6a.Visibility = Visibility.Hidden;
            Style6b.Visibility = Visibility.Hidden;
            Style6c.Visibility = Visibility.Hidden;
            Style6d.Visibility = Visibility.Hidden;
            Style6e.Visibility = Visibility.Hidden;
            Style6f.Visibility = Visibility.Hidden;
            Style6g.Visibility = Visibility.Hidden;
        }
        private void Style3Show(object sender, RoutedEventArgs e)
        {
            Style1.Visibility = Visibility.Hidden;
            Style1L.Visibility = Visibility.Hidden;
            Style1R.Visibility = Visibility.Hidden;

            Style2.Visibility = Visibility.Hidden;
            Style2L.Visibility = Visibility.Hidden;

            Style3.Visibility = Visibility.Visible;
            Style3a.Visibility = Visibility.Visible;
            Style3b.Visibility = Visibility.Visible;

            Style4L.Visibility = Visibility.Hidden;
            Style4R.Visibility = Visibility.Hidden;

            Style5.Visibility = Visibility.Hidden;
            Style5a.Visibility = Visibility.Hidden;

            Style6a.Visibility = Visibility.Hidden;
            Style6b.Visibility = Visibility.Hidden;
            Style6c.Visibility = Visibility.Hidden;
            Style6d.Visibility = Visibility.Hidden;
            Style6e.Visibility = Visibility.Hidden;
            Style6f.Visibility = Visibility.Hidden;
            Style6g.Visibility = Visibility.Hidden;
        }
        private void Style4Show(object sender, RoutedEventArgs e)
        {
            Style1.Visibility = Visibility.Hidden;
            Style1L.Visibility = Visibility.Hidden;
            Style1R.Visibility = Visibility.Hidden;

            Style2.Visibility = Visibility.Hidden;
            Style2L.Visibility = Visibility.Hidden;

            Style3.Visibility = Visibility.Hidden;
            Style3a.Visibility = Visibility.Hidden;
            Style3b.Visibility = Visibility.Hidden;

            Style4L.Visibility = Visibility.Visible;
            Style4R.Visibility = Visibility.Visible;

            Style5.Visibility = Visibility.Hidden;
            Style5a.Visibility = Visibility.Hidden;

            Style6a.Visibility = Visibility.Hidden;
            Style6b.Visibility = Visibility.Hidden;
            Style6c.Visibility = Visibility.Hidden;
            Style6d.Visibility = Visibility.Hidden;
            Style6e.Visibility = Visibility.Hidden;
            Style6f.Visibility = Visibility.Hidden;
            Style6g.Visibility = Visibility.Hidden;
        }
        private void Style5Show(object sender, RoutedEventArgs e)
        {
            Style1.Visibility = Visibility.Hidden;
            Style1L.Visibility = Visibility.Hidden;
            Style1R.Visibility = Visibility.Hidden;

            Style2.Visibility = Visibility.Hidden;
            Style2L.Visibility = Visibility.Hidden;

            Style3.Visibility = Visibility.Hidden;
            Style3a.Visibility = Visibility.Hidden;
            Style3b.Visibility = Visibility.Hidden;

            Style4L.Visibility = Visibility.Hidden;
            Style4R.Visibility = Visibility.Hidden;

            Style5.Visibility = Visibility.Visible;
            Style5a.Visibility = Visibility.Visible;

            Style6a.Visibility = Visibility.Hidden;
            Style6b.Visibility = Visibility.Hidden;
            Style6c.Visibility = Visibility.Hidden;
            Style6d.Visibility = Visibility.Hidden;
            Style6e.Visibility = Visibility.Hidden;
            Style6f.Visibility = Visibility.Hidden;
            Style6g.Visibility = Visibility.Hidden;
        }
        private void Style6Show(object sender, RoutedEventArgs e)
        {
            Style1.Visibility = Visibility.Hidden;
            Style1L.Visibility = Visibility.Hidden;
            Style1R.Visibility = Visibility.Hidden;

            Style2.Visibility = Visibility.Hidden;
            Style2L.Visibility = Visibility.Hidden;

            Style3.Visibility = Visibility.Hidden;
            Style3a.Visibility = Visibility.Hidden;
            Style3b.Visibility = Visibility.Hidden;

            Style4L.Visibility = Visibility.Hidden;
            Style4R.Visibility = Visibility.Hidden;

            Style5.Visibility = Visibility.Hidden;
            Style5a.Visibility = Visibility.Hidden;

            Style6a.Visibility = Visibility.Visible;
            Style6b.Visibility = Visibility.Visible;
            Style6c.Visibility = Visibility.Visible;
            Style6d.Visibility = Visibility.Visible;
            Style6e.Visibility = Visibility.Visible;
            Style6f.Visibility = Visibility.Visible;
            Style6g.Visibility = Visibility.Visible;
        }
    }
}
