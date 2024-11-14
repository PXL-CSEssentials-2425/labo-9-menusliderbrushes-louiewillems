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

namespace Labo_9___MenuSliderBrushes
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

        public void MenuItemClicked(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            switch (menuItem.Name)
            {
                case "menuItemAfsluiten":
                    MessageBoxResult msg = MessageBox.Show("Wil je het programma afsluiten?", "Exit", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                    if (msg == MessageBoxResult.Yes)
                    {
                        this.Close();
                    }
                    break;
                case "menuItemEersteGetal":
                    numberOneTextBox.Text = "2";
                    sliderOneText.Value = 2;
                        break;
                case "menuItemTweedeGetal":
                    numberTwoTextBox.Text = "2";
                    sliderTwoText.Value = 2;
                    break;
            }
        }

        private void sliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            if (sender is Slider slider && double.TryParse(slider.Value.ToString(), out double value))
            {
                switch (slider.Name)
                {
                    case "sliderOneText":
                        numberOneTextBox.Text = value.ToString();
                        break;
                    case "sliderTwoText":
                        numberTwoTextBox.Text = value.ToString();
                        break;
                }
            }

        }

        private void TextInputChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox box && int.TryParse(box.Text, out int value) 
                && value >= 1 && value <= 5)
            {
                switch (box.Name)
                {
                    case "numberOneTextBox":
                        sliderOneText.Value = value;
                        break;
                    case "numberTwoTextBox":
                        sliderTwoText.Value = value;
                        break;
                }
            }
        }
    }
}