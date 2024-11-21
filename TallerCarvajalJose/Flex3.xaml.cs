namespace TallerCarvajalJose;

public partial class Flex3 : ContentPage
{
	public Flex3()
	{
		InitializeComponent();
	}

    

    private async void GoToAbsoluteLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Absolute4());
    }

    private async void OnImageTapped(object sender, EventArgs e)
    {
        if (sender is Image image && image.BindingContext is string imageName)
        {
            await DisplayAlert("Imagen Tapped", $"Has tocado: {imageName}", "OK");
            await Navigation.PushAsync(new Absolute4());
        }
    }
}