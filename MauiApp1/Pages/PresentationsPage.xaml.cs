using MauiApp1.Models;

namespace MauiApp1.Pages;

public partial class PresentationsPage : ContentPage
{

    private List<PresentationsModel> _presentations = [

        new() { Url = "https://images.trvl-media.com/place/180033/963759af-444a-4d14-b5d1-bf34f97d47cf.jpg?impolicy=fcrop&w=450&h=280&q=medium", Name = "-Concierto en Cozumel-", Description = "Bajo el cielo estrellado del Caribe, Lana Del Rey llega a Cozumel para ofrecer un concierto íntimo y envolvente junto al mar. Su voz melancólica y su estilo cinematográfico se fusionan con la brisa tropical, creando una atmósfera única llena de nostalgia, romance y misterio. El público podrá disfrutar de sus más grandes éxitos y nuevas interpretaciones en un escenario iluminado por luces cálidas y el sonido de las olas, convirtiendo la noche en una experiencia inolvidable para los amantes de la música y los paisajes paradisíacos."},
        new() { Url = "https://images.contentstack.io/v3/assets/blt06f605a34f1194ff/bltbec5ed0e38b4d4b2/689dc29e8fd38cb92c169b65/iStock-2193434964-2-edited-HEADER_MOBILE.jpg?fit=crop&disable=upscale&auto=webp&quality=60&crop=smart", Name = "-Firma de discos en Guadalajara-", Description = "En una tarde especial para sus fans, Lana Del Rey llega a Guadalajara para una exclusiva firma de discos donde la cercanía y la emoción serán protagonistas. Los asistentes podrán conocerla en persona, obtener su álbum autografiado y compartir un momento único con la artista en un ambiente íntimo y elegante. Entre sonrisas, fotografías y dedicatorias personalizadas, este encuentro se convertirá en una experiencia inolvidable para quienes han acompañado su música a lo largo de los años."},
        new() { Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp-VXuSAWciF2sXnp1nWwlUmNxUSz9NKyaSQ&s", Name = "-Presentación en el Teatro Principal de Puebla-", Description = "En una noche llena de elegancia y emociones, Lana Del Rey se presenta en el majestuoso Teatro Principal de Puebla, ofreciendo un espectáculo íntimo y envolvente en uno de los recintos más emblemáticos de la ciudad. Su inconfundible voz y su atmósfera melancólica se fusionan con la arquitectura histórica del teatro, creando una experiencia única para el público poblano. El repertorio incluirá sus canciones más icónicas y versiones especiales pensadas para un escenario lleno de historia, arte y romanticismo."},
        new() { Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYjCyDbAyOu01jKQRDVJDnYHN5micAth9BGw&s", Name = "-Exposición de discos y firma de mercancía oficial-", Description = "En un evento especial para coleccionistas y fans, Lana Del Rey presenta una exclusiva exposición de su discografía, donde los asistentes podrán admirar ediciones especiales, vinilos de colección y material visual que recorre las distintas etapas de su carrera. Además, se llevará a cabo una firma de mercancía oficial, brindando la oportunidad de obtener artículos autografiados y recuerdos únicos directamente relacionados con la artista. Una experiencia imperdible para quienes disfrutan de su estética, su música y su universo artístico."},
        new() { Url = "https://content-viajes.nationalgeographic.com.es/medio/2024/10/02/times-square_cad653eb_241002174521_1200x799.jpg", Name = "-Concierto en Nueva York-", Description = "En el corazón de Nueva York, Lana Del Rey ofrece un concierto inolvidable en una de las ciudades más icónicas del mundo. Rodeada por luces urbanas y una atmósfera vibrante, su voz profunda y nostálgica envuelve al público en una experiencia cargada de emoción, romanticismo y estilo cinematográfico. El repertorio incluirá sus temas más representativos y versiones especiales pensadas para una noche única en la Gran Manzana, donde la música y la ciudad se fusionan en un espectáculo lleno de magia y melancolía."},
        new() { Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdD1ZZ8cNSA2Ttu8UVJXDNixJxWpGnTLJ0Ow&s", Name = "-Comienzo de gira por el mundo-", Description = "Con una producción espectacular y una atmósfera cargada de emoción, Lana Del Rey da inicio a su esperada gira por el mundo con un concierto que marca el comienzo de una nueva etapa en su carrera. Este primer show reúne lo mejor de su estilo melancólico y cinematográfico, combinando sus grandes éxitos con nuevas interpretaciones pensadas especialmente para esta travesía internacional. El escenario se convierte en el punto de partida de un viaje musical que recorrerá distintas ciudades y países, llevando su universo artístico a miles de fans alrededor del planeta en una experiencia única e inolvidable."},
        new() { Url = "https://s1.ticketm.net/dam/a/140/a593bad9-0bff-40d4-abb9-cb59b4f34140_CUSTOM.jpg", Name = "-Final de gira por el mundo-", Description = "En una noche cargada de nostalgia y emoción, Lana Del Rey cierra su gira mundial con un espectáculo especial que marca el final de un recorrido inolvidable. Este concierto reúne los momentos más icónicos de su tour, con un repertorio que mezcla sus grandes éxitos y versiones emotivas que celebran el vínculo creado con sus fans alrededor del mundo. Entre luces suaves, aplausos interminables y una atmósfera íntima, el escenario se convierte en el punto final de un viaje musical que quedará grabado en la memoria de todos los asistentes."},
        new() { Url = "https://mexico.quadratin.com.mx/www/wp-content/uploads/2022/12/Sin-titulo-1-6.jpg", Name = "-Anuncio de nuevo álbum-", Description = "Con un mensaje lleno de misterio y emoción, Lana Del Rey sorprende a sus fans al anunciar oficialmente el lanzamiento de su nuevo álbum. Esta nueva producción promete una etapa renovada en su carrera, manteniendo su esencia melancólica y cinematográfica mientras explora sonidos y emociones inéditas. El anuncio marca el inicio de una nueva era musical, generando gran expectativa entre sus seguidores, quienes esperan descubrir las historias, paisajes y sentimientos que darán forma a este esperado material discográfico."}

    ];

    private List<PresentationsModel> _filteredPresentations;
    public PresentationsPage()
	{
		InitializeComponent();
        _filteredPresentations = [.. _presentations];
        presentationsList.ItemsSource = _filteredPresentations;
    }

    private async void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
    {

        if (e.SelectedItem is PresentationsModel selectedContact)
        {
            await Shell.Current.GoToAsync(nameof(PresentationsDetailPage), new Dictionary<string, object>
            {
                { "Presentations", selectedContact }
            });

            presentationsList.SelectedItem = null;
        }

    }
}