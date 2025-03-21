﻿using System.Collections.ObjectModel;
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
    
    private ObservableCollection<Sum> Sommen = new ObservableCollection<Sum>();

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
        // voor nu haal dit even weg
        //string username = txtValue1.Text;
        //string age = txtValue2.Text;
        //Person p = new Person();
        //p.name = username;
        //p.age = int.Parse(age);
        //vm.Persons.Add(p);

        // en hier het sum deel
       
        for (int i = 0; i < 10; i++)
        {
            Sum s = new Sum();
            s.generate();
            Sommen.Add(s);
        } 
        vm.MySums = Sommen;





        //vm.TestProp = $"{s.firstPart} {s.OperatorSign} {s.secondPart} = {s.result}";

    }

    

    private void txtValue2_KeyDown(object sender, KeyEventArgs e)
    {
        // check if the key pressed is a number
        e.Handled = !char.IsDigit((char)KeyInterop.VirtualKeyFromKey(e.Key));
    }

    private void Button_Item_Selected(object sender, RoutedEventArgs e)
    {
        // get the selected item (converteer expliciet naar Person)
        Person selected_person = (Person)lstPersons.SelectedItem;
        // remove the selected item from the list
        vm.Persons.Remove(selected_person);



    }
}