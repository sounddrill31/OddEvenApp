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
        string str1, str2;
        int str1len, vcount = 0;
        str1 = TextBoxString.Text;
        str1len = str1.Length;

        for (int i = 0; i < str1len; i++)
        {
            str2 = str1.Substring(i, 1);
            if ((str2 == "a") || (str2 == "e") || (str2 == "i") || (str2 == "o") || (str2 == "u") || (str2 == "A") ||
                (str2 == "E") || (str2 == "I") || (str2 == "O") || (str2 == "U"))
            {
                vcount++;
            }
        }
        TextBoxRes.Text = vcount.ToString();
    }

    private void Button_OnClick_Exit(object? sender, RoutedEventArgs e)
    {
        System.Environment.Exit(0);
    }
}