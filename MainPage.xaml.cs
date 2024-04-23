using System.Collections.ObjectModel;
using MauiSelfCheckout.Resources.Controls;

namespace MauiSelfCheckout;

public partial class MainPage : ContentPage
{
    private CollectionView _collectionView;
    private ObservableCollection<ProductCardViewModel> ListOfData;
        public MainPage()
    {
        InitializeComponent();
        ListOfData = new ObservableCollection<ProductCardViewModel>
        {
            new()
            {
                ImagePath = "",
                Name = "imie 1",
                Price = "5.50"
            },
            new()
            {
                ImagePath = "",
                Name = "imie 2",
                Price = "3.99"
            },
            new()
            {
                ImagePath = "",
                Name = "imie 3",
                Price = "4.50"
            },
            new()
            {
                ImagePath = "",
                Name = "imie 4",
                Price = "4.50"
            }
        };
        _collectionView = Panel;
        createProductCards();
    }

    private void createProductCards()
    {
        _collectionView.ItemsSource = ListOfData;

    }


}