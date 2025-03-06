using DocuManageUmad.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace DocuManageUmad.Pages
{
    public partial class ReviewDocumentsPage : ContentPage
    {
        public ObservableCollection<Document> Documents { get; set; }

        public ReviewDocumentsPage()
        {
            InitializeComponent();
            Documents = new ObservableCollection<Document>
            {
                new Document { Name = "Docu 1", Image = "document_placeholder.png" },
                new Document { Name = "Docu 2", Image = "document_placeholder.png" },
                new Document { Name = "Docu 3", Image = "document_placeholder.png" },
                new Document { Name = "Docu 4", Image = "document_placeholder.png" },
                new Document { Name = "Docu 5", Image = "document_placeholder.png" },
            };

            BindingContext = this;
        }

        // Evento de búsqueda (solo simulado)
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // Aquí se podría filtrar la lista de documentos
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

        // Evento para simular la subida de documentos
        private async void OnUploadClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Subir Documento", "Función de subida en desarrollo.", "OK");
        }
    }

}
