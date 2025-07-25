using Microsoft.Maui.Controls;
namespace Profinder_1._0.Pages;

[QueryProperty(nameof(Id), "id")]
public partial class DetailPage : ContentPage
{
    private string id;

    public string Id
    {
        get => id;
        set
        {
            id = value;
            IdLabel.Text = $"ID recibido: {id}";
        }
    }

    public DetailPage()
    {
        InitializeComponent();
    }
}