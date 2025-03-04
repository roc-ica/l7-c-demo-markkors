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

namespace WpfApp_Demo_Github;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    public enum Grade
    {
        hard,
        easy,
        medium
    }

    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

        int getal = int.TryParse(txtMyBox.Text, out getal) ? getal : 0;

        MessageBox.Show(getal.ToString());
        
        
        
    }

    private void txtMyBox_KeyDown(object sender, KeyEventArgs e)
    {
        //e.Handled = true; // this will prevent the user from typing in the textbox
        // only numbers
        e.Handled = !char.IsDigit((char)KeyInterop.VirtualKeyFromKey(e.Key));


    }
}