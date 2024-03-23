namespace Navegacionweb.Paginas;

public partial class Cita3 : ContentPage
{
	public Cita3()
	{
		InitializeComponent();
	}

    private  async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Menu());
    }
}