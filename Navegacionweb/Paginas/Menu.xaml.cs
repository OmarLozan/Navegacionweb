namespace Navegacionweb.Paginas;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Detalle());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}