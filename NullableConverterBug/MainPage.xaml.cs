using System.Globalization;
using CommunityToolkit.Maui.Converters;

namespace NullableConverterBug;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ViewModel();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        var converter = new IsListNullOrEmptyConverter() as IValueConverter;
        converter.Convert(new List<string>(), typeof(bool?), null, CultureInfo.CurrentCulture);
    }
}

public class ViewModel
{
    public List<string> Items { get; } = [];
}