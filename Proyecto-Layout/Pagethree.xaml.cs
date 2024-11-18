namespace Proyecto_Layout;

public partial class Pagethree : ContentPage
{
	public Pagethree()
	{
		InitializeComponent();
	}

    private async void OnImageTapped(object sender, EventArgs e)
    {
        var image = sender as Image;
        var pageType = image?.GestureRecognizers[0] as TapGestureRecognizer;
        var targetPage = pageType?.CommandParameter as string;

        if (targetPage == "PageUno")
        {
            await Navigation.PushAsync(new Pageone());
        }
    }

}