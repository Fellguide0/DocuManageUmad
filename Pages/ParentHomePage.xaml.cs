using Microsoft.Maui.Controls;
using System;

namespace DocuManageUmad.Pages
{
    public partial class ParentHomePage : ContentPage
    {
        public ParentHomePage()
        {
            InitializeComponent();
        }

        // Evento para cerrar sesión
        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            App.UserRole = string.Empty; // Resetear rol
            await Navigation.PopToRootAsync(); // Volver a la pantalla de login
        }
    }
}
