using System.Runtime.InteropServices.JavaScript;
using IdeaPicker.Models;

namespace IdeaPicker;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        Title = "Idea Picker";
    }

    private void btnDatePicker_OnClicked(object sender, EventArgs e)
    {
        var newDateNight = new DateNight();
        newDateNight.Name = txtDateNight.Text;
        newDateNight.Description = txtDateDescription.Text;
    }
}