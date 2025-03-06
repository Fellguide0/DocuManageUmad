using Microsoft.Maui.Controls;
using System;

namespace DocuManageUmad.Pages
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        // Alternar visibilidad de la contrase�a
        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        }

        // Alternar visibilidad de la confirmaci�n de contrase�a
        private void ToggleConfirmPasswordVisibility(object sender, EventArgs e)
        {
            ConfirmPasswordEntry.IsPassword = !ConfirmPasswordEntry.IsPassword;
        }

        // Evento para aceptar t�rminos y condiciones
        private async void OnTermsTapped(object sender, EventArgs e)
        {
            await DisplayAlert("T�rminos y Condiciones", "Aqu� se mostrar�an los t�rminos y condiciones...", "OK");
        }

        // Evento para el bot�n de registro
        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string fullName = FullNameEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;
            bool termsAccepted = TermsCheckBox.IsChecked;

            // Validaciones
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                await DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
                return;
            }

            if (password != confirmPassword)
            {
                await DisplayAlert("Error", "Las contrase�as no coinciden.", "OK");
                return;
            }

            if (!termsAccepted)
            {
                await DisplayAlert("Error", "Debes aceptar los t�rminos y condiciones.", "OK");
                return;
            }

            // Simulaci�n de registro
            await DisplayAlert("Registro exitoso", "Tu cuenta ha sido creada.", "OK");

            // Navegar a la pantalla de login
            await Navigation.PopAsync();
        }
    }
}
