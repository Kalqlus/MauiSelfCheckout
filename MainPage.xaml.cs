using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using MauiSelfCheckout.Resources.Controls;

namespace MauiSelfCheckout;

public partial class MainPage : ContentPage
{
    private CollectionView _collectionView;
    private ObservableCollection<ProductCardViewModel> _ListOfData;

    public MainPage()
    {
        
        InitializeComponent();
        _ListOfData = new ObservableCollection<ProductCardViewModel>();
        LoadMauiAsset();
        _collectionView = Panel;
       
        createProductCards();
    }
    
    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("ListOfProducts.json");
        using var reader = new StreamReader(stream);

        var contents = await reader.ReadToEndAsync();

        var options = new JsonSerializerOptions { WriteIndented = true, PropertyNameCaseInsensitive = true};
        
        var tempList = JsonSerializer.Deserialize<List<ProductCardViewModel>>(contents, options);

        foreach (var product in tempList)
        {
            _ListOfData.Add(product);
        }

        foreach (var VARIABLE in _ListOfData)
        {
            var vm = VARIABLE;
            helpie.Add(new Label{ Text = vm.Id});
            helpie.Add(new Label{ Text = vm.Path});
            helpie.Add(new Label{ Text = vm.Name});
            helpie.Add(new Label{ Text = vm.Price});
            helpie.Add(new Label{ Text = "===================="});
        }
        
    }

    private void createGridLayout()
    {
    }

    private void createProductCards()
    {
        _collectionView.ItemsSource = _ListOfData;
    }


}