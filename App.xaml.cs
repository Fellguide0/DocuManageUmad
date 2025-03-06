using Microsoft.Maui.Controls;

namespace DocuManageUmad
{
    public partial class App : Application
    {
        // Variable estática para almacenar el rol del usuario
        public static string UserRole { get; set; } = string.Empty;

        public App()
        {
            InitializeComponent();

            // Comienza en la página de bienvenida
            MainPage = new NavigationPage(new Pages.WelcomePage());
        }
    }
}
