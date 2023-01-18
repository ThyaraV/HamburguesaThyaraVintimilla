using HamburguesaThyaraVintimilla.Views;

namespace HamburguesaThyaraVintimilla;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(BurgerItemPage), typeof(BurgerItemPage));
    }
}
