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

        // Alternar visibilidad de la contraseña
        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        }

        // Evento para el botón de inicio de sesión con asignación de rol
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Por favor, ingresa tu correo y contraseña.", "OK");
                return;
            }

            // Simulación de asignación de roles
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
                await DisplayAlert("Error", "Usuario no reconocido. Intenta con un email válido.", "OK");
            }
        }


        // Evento para navegar a la pantalla de registro
        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
