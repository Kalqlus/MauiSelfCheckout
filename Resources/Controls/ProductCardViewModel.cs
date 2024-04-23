using System.ComponentModel;

namespace MauiSelfCheckout.Resources.Controls;

public class ProductCardViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    
    
    private string path, name, price;
    
    public string ImagePath
    {
        get => path;
        set
        {
            path = value;
            OnPropertyChanged(path);
        }
    }

    public string Name
    {
        get => name;
        set
        {
            name = value;
            OnPropertyChanged(name);
        }
    }

    public string Price
    {
        get => price;
        set
        {
            price = value;
            OnPropertyChanged(price);
        }
    }

    private void OnPropertyChanged(string arg)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(arg));
    }
}