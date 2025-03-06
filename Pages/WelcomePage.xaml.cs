using Microsoft.Maui.Controls;

namespace DocuManageUmad.Pages
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage()); // Navega a la pantalla de login
        }



    }
}
