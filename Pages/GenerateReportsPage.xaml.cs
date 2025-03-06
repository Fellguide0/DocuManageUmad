using DocuManageUmad.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace DocuManageUmad.Pages
{
    public partial class GenerateReportsPage : ContentPage
    {
        public ObservableCollection<Report> Reports { get; set; }
        public string SelectedTab { get; set; } = "Completed";

        public GenerateReportsPage()
        {
            InitializeComponent();
            Reports = new ObservableCollection<Report>();
            BindingContext = this;
        }

        private async void OnSearchClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Buscar", "Función de búsqueda en desarrollo.", "OK");
        }

        private async void OnTabSelected(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            SelectedTab = selectedButton.Text;

            // Simular cambio de estado en los reportes
            Reports.Clear();
            if (SelectedTab == "Completado")
            {
                Reports.Add(new Report { Title = "Reporte de Calificaciones", Date = "02/03/2024" });
                Reports.Add(new Report { Title = "Reporte de Inscripción", Date = "28/02/2024" });
            }

            // Mostrar u ocultar la vista vacía
            EmptyState.IsVisible = Reports.Count == 0;
            ReportsList.IsVisible = Reports.Count > 0;
        }

        private async void OnCreateReportClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Nuevo Reporte", "Generando nuevo reporte...", "OK");

            // Simulación de un reporte generado
            Reports.Add(new Report { Title = "Nuevo Reporte", Date = DateTime.Now.ToString("dd/MM/yyyy") });

            // Actualizar visibilidad
            EmptyState.IsVisible = false;
            ReportsList.IsVisible = true;
        }
    }

   
}
