using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using DocuManageUmad.Models;

namespace DocuManageUmad.Pages
{
    public partial class ManageExpedientPage : ContentPage
    {
        public ObservableCollection<Expedient> Expedients { get; set; }
        private ObservableCollection<Expedient> _allExpedients;

        public ManageExpedientPage()
        {
            InitializeComponent();

            // Simulación de expedientes
            _allExpedients = new ObservableCollection<Expedient>
            {
                new Expedient { Name = "Certificado de Ingles", Location = "Olinda, Brazil", Status = "Completo", StatusColor = "Green", Icon = "users_icon.png" },
                new Expedient { Name = "Constancia de estudios", Location = "Recife, Brazil", Status = "Pendiente", StatusColor = "Orange", Icon = "config_icon.png" },
                new Expedient { Name = "Boleta de calificaciones", Location = "Olinda, Brazil", Status = "En Revisión", StatusColor = "Blue", Icon = "maintenance_icon.png" },
                new Expedient { Name = "CURP", Location = "Recife, Brazil", Status = "Completo", StatusColor = "Green", Icon = "expedient_icon.png" }
            };

            Expedients = new ObservableCollection<Expedient>(_allExpedients);
            BindingContext = this;
        }

        // Búsqueda de expedientes
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue?.ToLower() ?? "";
            Expedients.Clear();

            var filtered = _allExpedients.Where(x => x.Name.ToLower().Contains(searchText)).ToList();
            foreach (var item in filtered)
            {
                Expedients.Add(item);
            }
        }

        // Evento de ordenamiento (simulado)
        private async void OnSortClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Ordenar", "Función de ordenamiento en desarrollo.", "OK");
        }

        // Evento de filtrado (simulado)
        private async void OnFilterClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Filtrar", "Función de filtrado en desarrollo.", "OK");
        }
    }

   
}
