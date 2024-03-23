namespace Navegacionweb.Paginas;

public partial class Detalle : ContentPage
{
	public Detalle( )
	{
		InitializeComponent();
    }

    

    private async void Button_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Appcita());
    }
}