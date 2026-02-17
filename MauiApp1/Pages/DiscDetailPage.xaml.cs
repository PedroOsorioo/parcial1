//Se usarán las clases que se encuentran en la carpeta de nombre "Models"
using MauiApp1.Models;

//Dirección de la clase
namespace MauiApp1.Pages;

//Básicamente es el puente que conecta páginas, cuando desde otra pantalla se manda un objeto, automáticamente se asigna a esa propiedad en esta página sin tener que hacerlo manualmente. 
[QueryProperty(nameof(DiscModel), "Disc")]

//Se define la clase, la cual puede ser usada desde otras partes del proyecto
public partial class DiscDetailPage : ContentPage
{
    //Se guarda de manera interna la canción seleccionada
    private DiscModel _discModel;

    //En esta propiedad se recibe la canción seleccionada
    public DiscModel DiscModel
    {
        set
        {
            _discModel = value;
        }
    }

    //Se crea el constructor para mostrar la interfaz gráfica
    public DiscDetailPage()
	{
		InitializeComponent();
        _discModel = new DiscModel();
    }

    ////Este método se ejecuta justo cuando la página aparece en pantalla. Primero llama al comportamiento normal de la página, y después toma los datos guardados y los coloca en los controles visuales que son los labels.
    override protected void OnAppearing()
    {
        base.OnAppearing();
        urlLabel.Source = _discModel.Url;
        nameLabel.Text = _discModel.Name;
        yearLabel.Text = _discModel.Year;
        descriptionLabel.Text = _discModel.Description;
    }



}