using HamburguesaThyaraVintimilla.Data;
using HamburguesaThyaraVintimilla.Models;
namespace HamburguesaThyaraVintimilla.Views;
[QueryProperty("Item","Item")]
public partial class BurgerItemPage : ContentPage
{
    //Burger Item = new Burger();
    //bool _flag;
    public TV_Burger Item
    {
        get => BindingContext as TV_Burger;
        set => BindingContext = value;
    }
    public BurgerItemPage()
    {
        InitializeComponent();
    }
    private void OnSaveClicked(object sender, EventArgs e)
    {
        //Item.Name = nameB.Text;
        //Item.Description = descB.Text;
        //Item.WithExtraCheese = _flag;

        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void DeletedClicked(object sender, EventArgs e)
    {
        App.BurgerRepo.DeleteItem(Item);
    }
    // private void OnCheckBoxCheckedChanged(object sender,
    //CheckedChangedEventArgs e)
    // {
    // _flag = e.Value;
    //}


}