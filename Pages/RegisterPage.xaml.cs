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

        // Alternar visibilidad de la contraseña
        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        }

        // Alternar visibilidad de la confirmación de contraseña
        private void ToggleConfirmPasswordVisibility(object sender, EventArgs e)
        {
            ConfirmPasswordEntry.IsPassword = !ConfirmPasswordEntry.IsPassword;
        }

        // Evento para aceptar términos y condiciones
        private async void OnTermsTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Términos y Condiciones", "Aquí se mostrarían los términos y condiciones...", "OK");
        }

        // Evento para el botón de registro
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
                await DisplayAlert("Error", "Las contraseñas no coinciden.", "OK");
                return;
            }

            if (!termsAccepted)
            {
                await DisplayAlert("Error", "Debes aceptar los términos y condiciones.", "OK");
                return;
            }

            // Simulación de registro
            await DisplayAlert("Registro exitoso", "Tu cuenta ha sido creada.", "OK");

            // Navegar a la pantalla de login
            await Navigation.PopAsync();
        }
    }
}
