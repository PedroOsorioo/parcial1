//Se usarán las clases que se encuentran en la carpeta de nombre "Models"
using MauiApp1.Models;

//Dirección de la clase
namespace MauiApp1.Pages;

//Básicamente es el puente que conecta páginas, cuando desde otra pantalla se manda un objeto, automáticamente se asigna a esa propiedad en esta página sin tener que hacerlo manualmente. 
[QueryProperty(nameof(PresentationsModel), "Presentations")]

//Se define la clase, la cual puede ser usada desde otras partes del proyecto
public partial class PresentationsDetailPage : ContentPage
{
    //Se guarda de manera interna la presentación seleccionada 
    private PresentationsModel _presentationsModel;

    //En esta propiedad se recibe la presentación seleccionada 
    public PresentationsModel PresentationsModel
    {
        set
        {
            _presentationsModel = value;
        }
    }

    //Se crea el constructor para mostrar la interfaz gráfica 
    public PresentationsDetailPage()
	{
		InitializeComponent();
        _presentationsModel = new PresentationsModel();
    }

    //Este método se ejecuta justo cuando la página aparece en pantalla. Primero llama al comportamiento normal de la página, y después toma los datos guardados (la imagen, el nombre y la descripción de la presentación) y los coloca en los controles visuales que son los labels.
    override protected void OnAppearing()
    {
        base.OnAppearing();
        urlLabel.Source = _presentationsModel.Url;
        nameLabel.Text = _presentationsModel.Name;
        descriptionLabel.Text = _presentationsModel.Description;
    }

    //Este método se ejecuta cuando el usuario presiona el botón, es un evento asíncrono y lo único que hace es permitir navegar a otra página. 
    private async void OnAddContactClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ReservationPage));
    }
}