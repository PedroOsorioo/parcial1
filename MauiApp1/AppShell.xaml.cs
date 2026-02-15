using MauiApp1.Pages;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DiscDetailPage), typeof(DiscDetailPage));
            Routing.RegisterRoute(nameof(PresentationsDetailPage), typeof(PresentationsDetailPage));
            Routing.RegisterRoute(nameof(ReservationPage), typeof(ReservationPage));
        }
    }
}
