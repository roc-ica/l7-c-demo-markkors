using System.Diagnostics;
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
using WpfApp_Demo_Github.Models;

namespace WpfApp_Demo_Github;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    
    
    private Viewmodel vm = new Viewmodel();

    public MainWindow()
    {
        InitializeComponent();

        // DEMO DATA
        //vm.Persons.Add(new Person { name = "John", age = 25 });
        //vm.Persons.Add(new Person { name = "Jane", age = 30 });

        this.DataContext = vm;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        string username = txtValue1.Text;
        string age = txtValue2.Text;

        Person p = new Person();
        p.name = username;
        p.age = int.Parse(age);
        vm.Persons.Add(p);
       
    }

    

    private void txtValue2_KeyDown(object sender, KeyEventArgs e)
    {
        // check if the key pressed is a number
        e.Handled = !char.IsDigit((char)KeyInterop.VirtualKeyFromKey(e.Key));
    }

    private void Button_Item_Selected(object sender, RoutedEventArgs e)
    {
        
        Person selected_person = (Person)lstPersons.SelectedItem;
        vm.Persons.Remove(selected_person);



    }
}