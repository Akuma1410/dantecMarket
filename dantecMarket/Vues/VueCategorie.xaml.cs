using dantecMarket.Modeles;
using dantecMarket.Services;
using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Linq;

namespace dantecMarket.Vues
{
    public partial class VueCategorie : ContentPage
    {
        private readonly Apis _apis = new Apis();

        public VueCategorie()
        {
            InitializeComponent();
            LoadCategories();
        }

        private async void LoadCategories()
        {
            var categories = await _apis.GetAllCategoriesAsync();
            CategoriesCollectionView.ItemsSource = categories;
        }

        // Gestion du tap sur une cat�gorie
        private void OnCategoryTapped(object sender, EventArgs e)
        {
            // Trouver le Label qui a �t� tap�
            var tappedLabel = (Label)sender;

            // Trouver le StackLayout parent
            var parentStackLayout = tappedLabel.Parent as StackLayout;

            // Trouver la StackLayout contenant les sous-cat�gories dans le parent
            var subCategoryContainer = parentStackLayout?.Children.OfType<StackLayout>().FirstOrDefault();

            // Si les sous-cat�gories existent, on inverse la visibilit�
            if (subCategoryContainer != null)
            {
                subCategoryContainer.IsVisible = !subCategoryContainer.IsVisible;
            }
        }
    }
}
