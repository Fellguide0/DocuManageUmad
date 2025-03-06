using Microsoft.Maui.Controls;
using System;

namespace DocuManageUmad.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // Alternar visibilidad de la contrase�a
        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        }

        // Evento para el bot�n de inicio de sesi�n con asignaci�n de rol
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Por favor, ingresa tu correo y contrase�a.", "OK");
                return;
            }

            // Simulaci�n de asignaci�n de roles
            if (email.Contains("alumno"))
            {
                App.UserRole = "Alumno";
                await Navigation.PushAsync(new StudentHomePage());
            }
            else if (email.Contains("padre"))
            {
                App.UserRole = "Padre";
                await Navigation.PushAsync(new ParentHomePage());
            }
            else
            {
                await DisplayAlert("Error", "Usuario no reconocido. Intenta con un email v�lido.", "OK");
            }
        }


        // Evento para navegar a la pantalla de registro
        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
