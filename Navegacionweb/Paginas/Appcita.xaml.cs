
namespace Navegacionweb.Paginas;

public partial class Appcita : ContentPage
{
	public Appcita ()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {


		await Navigation.PushAsync(new Menu());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
       
        await Navigation.PushAsync(new Cita3());
    }
}