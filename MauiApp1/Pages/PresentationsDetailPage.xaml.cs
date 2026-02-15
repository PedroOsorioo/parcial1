using MauiApp1.Models;

namespace MauiApp1.Pages;

[QueryProperty(nameof(PresentationsModel), "Presentations")]

public partial class PresentationsDetailPage : ContentPage
{

    private PresentationsModel _presentationsModel;

    public PresentationsModel PresentationsModel
    {
        set
        {
            _presentationsModel = value;
        }
    }

    public PresentationsDetailPage()
	{
		InitializeComponent();
        _presentationsModel = new PresentationsModel();
    }

    override protected void OnAppearing()
    {
        base.OnAppearing();
        urlLabel.Source = _presentationsModel.Url;
        nameLabel.Text = _presentationsModel.Name;
        descriptionLabel.Text = _presentationsModel.Description;
    }

    private async void OnAddContactClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ReservationPage));
    }
}