using MauiApp1.Models;

namespace MauiApp1.Pages;

public partial class PresentationsPage : ContentPage
{

    private List<PresentationsModel> _presentations = [

        new() { Url = "https://i.scdn.co/image/ab67616d0000b2731624590458126fc8b8c64c2f", Name = "Cruel World",Description = "Álbum Ultraviolence en su versión deluxe de la cantante Lana Del Rey"  }
        
        
        
    ];

    private List<PresentationsModel> _filteredPresentations;
    public PresentationsPage()
	{
		InitializeComponent();
        _filteredPresentations = [.. _presentations];
        presentationsList.ItemsSource = _filteredPresentations;
    }

    private void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }
}