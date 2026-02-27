namespace MauiApp1.Pages
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnToggledChanged(object sender, ToggledEventArgs e)
        {
            if(e.Value)
{
                Shell.Current.Resources["BackgroundMain"] = Color.FromHex("#800080");
                Shell.Current.Resources["BackgroundSecond"] = Color.FromHex("#FF0000");
                Shell.Current.Resources["ColorBase"] = Colors.Yellow;
                return;
            }

            Shell.Current.Resources["BackgroundMain"] = Color.FromHex("#FF0000");
            Shell.Current.Resources["BackgroundSecond"] = Color.FromHex("#FFC0CB");
            Shell.Current.Resources["ColorBase"] = Colors.Black;
            return;
        }
    }
}
