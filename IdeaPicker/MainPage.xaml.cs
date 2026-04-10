using System.Runtime.InteropServices.JavaScript;
using IdeaPicker.Models;

namespace IdeaPicker;

public partial class MainPage : ContentPage
{
    private readonly Repository _repo;

    public MainPage()
    {
        InitializeComponent();
        _repo = new Repository();
        Title = "Idea Picker";
    }

    private void btnDatePicker_OnClicked(object sender, EventArgs e)
    {
        var date = _repo.GetRandomDate();

        if (date == null)
        {
            txtDateNight.Text = "No Dates found...";
            txtDateDescription.Text = string.Empty;
            return;
        }

        txtDateNight.Text = date.Name;
        txtDateDescription.Text = date.Description;

    }
}