using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace OddEvenApp.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        //throw new System.NotImplementedException();
        if (TextBoxString.Text != null && int.Parse(TextBoxString.Text) < 10000 )//<= sizeof(int))
        {
            if (int.Parse(TextBoxString.Text) % 2 == 0)
                TextBoxRes.Text = "Even";
            else
                TextBoxRes.Text = "Odd";
        }
        else if (TextBoxString.Text == null)
        {
            TextBoxString.Text = "";
        }
        else
        {
            TextBoxRes.Text = "Error! Overflow";
        }
    }

    private void Button_OnClick_Exit(object? sender, RoutedEventArgs e)
    {
        System.Environment.Exit(0);
    }

    private void Button_OnClick_Clear(object? sender, RoutedEventArgs e)
    {
        TextBoxRes.Text = "";
        TextBoxString.Text = "";
        //throw new System.NotImplementedException();
    }
}