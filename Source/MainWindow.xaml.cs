using Bogus;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;

namespace Source;

public partial class MainWindow : Window
{
    public List<User> Users { get; set; }


    public MainWindow()
    {
        InitializeComponent();

        DataContext = this;


        // Bogus
        // Faker

        Users = new Faker<User>()
            .RuleFor(u => u.Firstname, f => f.Person.FirstName)
            .RuleFor(u => u.Lastname, f => f.Person.LastName)
            .RuleFor(u => u.Gender, f => f.Person.Gender.ToString())
            .RuleFor(u => u.Phone, f => f.Person.Phone)
            .RuleFor(u => u.ImageUrl, f => f.Person.Avatar)
            .RuleFor(u => u.Email, f => f.Person.Email)
            .RuleFor(u => u.Address, f => f.Person.Address.City)
            .RuleFor(u => u.DateOfBirth, f => f.Person.DateOfBirth)
            .Generate(15);


    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        // // listView.Items.Add(new User { Firstname = "Resul" });
        // 
        // listView.ItemsSource = null;
        // Users.Add(new User { Firstname = "Resul" });
        // listView.ItemsSource = Users;
    }




    private void Button_Click_Template(object sender, RoutedEventArgs e)
    {
        var btn = sender as Button;

        Grid grid = btn.Parent as Grid;
        StackPanel sp = grid.Children[1] as StackPanel;


        // foreach (TextBlock item in sp.Children)
        // {
        //     MessageBox.Show(item.Text);
        // }

        MessageBox.Show((sp.Children[0] as TextBlock).Text);


    }
}
