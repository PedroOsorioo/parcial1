//Se usarán las clases que se encuentran en la carpeta de nombre "Models"
using MauiApp1.Models;

//Dirección de la clase
namespace MauiApp1.Pages;

//Se define la clase, la cual puede ser usada desde otras partes del proyecto
public partial class DiscPage : ContentPage
{
    //Lista principal de las canciones del artista, en ella se crean para su posterior uso en la ejecución del programa
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

    //Se filtra la lista
    private List<DiscModel> _filteredDiscs;


    //Se crea el constructor haciendo uso de la lista filtrada, se hace uso de la copia original para que se pueda mostrar en la pantalla
    public DiscPage()
	{
		InitializeComponent();
        _filteredDiscs = [.. _discs];
        discList.ItemsSource = _filteredDiscs;
    }

    //Este método se ejecuta cuando el usuario selecciona una canción de la lista, primero verifica que el elemento seleccionado sea realmente un objeto, si lo es, navega a la página DiscDetailPage y le envía como parámetro el objeto seleccionado para que muestre sus detalles, al final, limpia la selección para que el elemento no quede marcado visualmente después de tocarlo.
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