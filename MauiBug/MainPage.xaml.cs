namespace MauiBug;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Resources.MergedDictionaries.Add(new OverrideColors());
        Resources.Add("Secondary", Colors.Yellow);

        Resources.TryGetValue("Primary", out var primaryColor);
        Resources.TryGetValue("Secondary", out var secondaryColor);

        ManualLabel.BackgroundColor = (Color)primaryColor!;
        ManualLabel.TextColor = (Color)secondaryColor!;
    }
}