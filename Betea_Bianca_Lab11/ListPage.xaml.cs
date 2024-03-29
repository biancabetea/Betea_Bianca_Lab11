using Betea_Bianca_Lab11.Models;
namespace Betea_Bianca_Lab11;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
	    InitializeComponent();
	}

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShopList)BindingContext;
        slist.Date = DateTime.UtcNow;
        await App.Database.SaveShopListAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShopList)BindingContext;
        await App.Database.DeleteShopListAsync(slist);
        await Navigation.PopAsync();
    }
}