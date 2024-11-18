namespace Proyecto_Layout;

public partial class Pagetwo : ContentPage
{
	public Pagetwo()
	{
		InitializeComponent();
	}

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pagefour());
    }
}