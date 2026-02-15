using MauiApp1.Models;

namespace MauiApp1.Pages;

[QueryProperty(nameof(DiscModel), "Disc")]
public partial class DiscDetailPage : ContentPage
{

    private DiscModel _discModel;

    public DiscModel DiscModel
    {
        set
        {
            _discModel = value;
        }
    }
    public DiscDetailPage()
	{
		InitializeComponent();
        _discModel = new DiscModel();
    }


    override protected void OnAppearing()
    {
        base.OnAppearing();
        urlLabel.Source = _discModel.Url;
        nameLabel.Text = _discModel.Name;
        yearLabel.Text = _discModel.Year;
        descriptionLabel.Text = _discModel.Description;
    }



}