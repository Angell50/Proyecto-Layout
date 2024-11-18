namespace Proyecto_Layout;

public partial class Pageone : ContentPage
{
	public Pageone()
	{
		InitializeComponent();
	}
    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pagetwo());
    }

}