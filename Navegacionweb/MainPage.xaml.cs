
using Navegacionweb.Paginas;
using System.Formats.Asn1;

namespace Navegacionweb
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }
        

     

        private  async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }
    }
}