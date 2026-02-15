using MauiApp1.Models;


namespace MauiApp1.Pages;

public partial class DiscPage : ContentPage
{

    private List<DiscModel> _discs = [

        new() { Url = "https://i.scdn.co/image/ab67616d0000b2731624590458126fc8b8c64c2f", SongN = "Cruel World" ,Name = "Ultraviolence (deluxe)",Year = "2014" ,Description = "Álbum Ultraviolence en su versión deluxe de la cantante Lana Del Rey" },
        new() { Url ="https://i.scdn.co/image/ab67616d0000b2731624590458126fc8b8c64c2f", SongN = "Shades Of Cool" ,Name = "Ultraviolence (deluxe)", Year = "2014",Description = "Álbum Ultraviolence en su versión deluxe de la cantante Lana Del Rey" },
        new() { Url ="https://i.scdn.co/image/ab67616d0000b273879e9318cb9f4e05ee552ac9",SongN = "Venice Bitch", Name = "Norman Fucking Rockwell!", Year = "2019" ,Description = "Álbum Norman Fucking Rockwell! de la cantante Lana Del Rey" },
        new() { Url ="https://i.scdn.co/image/ab67616d0000b273879e9318cb9f4e05ee552ac9",SongN = "Love song", Name = "Norman Fucking Rockwell!", Year = "2019" ,Description = "Álbum Norman Fucking Rockwell! de la cantante Lana Del Rey" },
        new() { Url ="https://i.scdn.co/image/ab67616d0000b273a3b3f48ca81acacb3ad4ec8a",SongN = "Freak", Name = "Honeymoon", Year = "2015" ,Description = "Álbum Honeymoon de la cantante Lana Del Rey" },
        new() { Url ="https://i.scdn.co/image/ab67616d0000b273a3b3f48ca81acacb3ad4ec8a",SongN = "Art Deco", Name = "Honeymoon", Year = "2015" ,Description = "Álbum Honeymoon de la cantante Lana Del Rey" },
        new() { Url ="https://static.wikia.nocookie.net/lanadelrey/images/a/a2/Lust_for_Life.jpg/revision/latest?cb=20170428034833&path-prefix=es",SongN = "Cherry", Name = "Lust For Life", Year = "2017" ,Description = "Álbum Lust For Life de la cantante Lana Del Rey" },
        new() { Url ="https://static.wikia.nocookie.net/lanadelrey/images/a/a2/Lust_for_Life.jpg/revision/latest?cb=20170428034833&path-prefix=es",SongN = "13 beaches", Name = "Lust For Life", Year = "2017" ,Description = "ÁlbUm Lust For Life de la cantante Lana Del Rey" }
    ];

    private List<DiscModel> _filteredDiscs;





    public DiscPage()
	{
		InitializeComponent();
        _filteredDiscs = [.. _discs];
        discList.ItemsSource = _filteredDiscs;
    }

    private async void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
    {

        if (e.SelectedItem is DiscModel selectedContact)
        {
            await Shell.Current.GoToAsync(nameof(DiscDetailPage), new Dictionary<string, object>
            {
                { "Disc", selectedContact }
            });

            discList.SelectedItem = null;
        }

    }
}