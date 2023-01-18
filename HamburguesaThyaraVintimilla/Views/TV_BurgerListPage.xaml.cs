using HamburguesaThyaraVintimilla.Models;

namespace HamburguesaThyaraVintimilla.Views;

public partial class BurgerListPage : ContentPage
{
    public BurgerListPage()
    {
        InitializeComponent();
        actualizarDatos();
        BindingContext = this;

    }

    protected override void OnAppearing()
    {
        actualizarDatos();
    }

    private void actualizarDatos()
    {
        List<TV_Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
    //async void OnItemAdded(object sender, EventArgs e)
    //{
        // await Shell.Current.GoToAsync(nameof(BurgerItemPage));
    //}

    public void OnItemAdded(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new TV_Burger()
        });
    }

    private void TV_CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        TV_Burger burgerTV = e.CurrentSelection.FirstOrDefault() as TV_Burger;
        if (burgerTV == null) return;
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            {"Item",burgerTV }
        });
        ((CollectionView)sender).SelectedItem = null;
    }
}