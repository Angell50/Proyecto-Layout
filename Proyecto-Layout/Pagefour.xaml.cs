namespace Proyecto_Layout;

public partial class Pagefour : ContentPage
{
	public Pagefour()
	{
		InitializeComponent();
	}

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pagetwo());
    }

}