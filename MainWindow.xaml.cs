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

namespace MarafonBorisevich
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double BMIindex;
        string pol;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBoxHeight.Clear();
            TextBoxWeigh.Clear();
        }

        private void ImageMan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Diagnos.Source = ImageMan.Source;
            pol = "мужской";
        }

        private void ImageWoman_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Diagnos.Source = ImageWoman.Source;
            pol = "женский";
        }

        private void ButtonBMIindex_Click(object sender, RoutedEventArgs e)
        {
            double ves = Convert.ToDouble(TextBoxWeigh.Text);
            double rost = Convert.ToDouble(TextBoxHeight.Text)/100;
            BMIindex = Math.Round(Convert.ToDouble(ves / (rost * rost)),2);
            LabelBMIindex.Content = BMIindex.ToString();
            if (BMIindex<10)
            {
                LabelDiagnos.Content = "недостаточный вес";
                SliderBMIindex.Value = 10;
            }
            if (BMIindex <= 18.5)
            {
                LabelDiagnos.Content = "недостаточный вес";
                SliderBMIindex.Value = Math.Floor(BMIindex);
            }
            if ((BMIindex > 18.6)&&(BMIindex <24.9))
            {
                LabelDiagnos.Content = "здоровый вес";
                SliderBMIindex.Value = Math.Floor(BMIindex);
            }
            if ((BMIindex > 25) &&(BMIindex <= 29.9))
            {
                LabelDiagnos.Content = "Избыточный вес";
                SliderBMIindex.Value = Math.Floor(BMIindex);
            }
            if ((BMIindex > 30) && (BMIindex <= 40))
            {
                LabelDiagnos.Content = "Ожирение";
                SliderBMIindex.Value = 40;
            }
            if (BMIindex > 40)
            {
                LabelDiagnos.Content = "Ожирение";
                SliderBMIindex.Value = 40;
            }
        }
    }
}
