using Microsoft.Maui.Controls;
using System;

namespace DocuManageUmad.Pages
{
    public partial class StudentHomePage : ContentPage
    {
        public StudentHomePage()
        {
            InitializeComponent();
        }

        private async void OnReviewDocumentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReviewDocumentsPage());
        }

        private async void OnManageExpedientsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManageExpedientPage());
        }

        private async void OnGenerateReportsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GenerateReportsPage());
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Regresar a la pantalla de Login y resetear rol
            App.UserRole = string.Empty;
            await Navigation.PopToRootAsync();
        }
    }
}
