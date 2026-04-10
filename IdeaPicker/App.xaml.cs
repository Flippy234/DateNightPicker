using IdeaPicker.Models;

namespace IdeaPicker;

public partial class App : Application
{
    public static List<DateNight> DateList;
    public App()
    {
        InitializeComponent();
        DateList = new List<DateNight>();
        MainPage = new AppShell();
    }
}