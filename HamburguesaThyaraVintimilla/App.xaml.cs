﻿using HamburguesaThyaraVintimilla.Data;

namespace HamburguesaThyaraVintimilla;

public partial class App : Application
{
	public static BurgerDatabase BurgerRepo { get; set; }

	public App(BurgerDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		BurgerRepo = repo;
	}
}
