using HamburguesaThyaraVintimilla.Data;

namespace HamburguesaThyaraVintimilla;

public partial class App : Application
{
	public static TV_BurgerDatabase BurgerRepo { get; set; }

	public App(TV_BurgerDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		BurgerRepo = repo;
	}
}
