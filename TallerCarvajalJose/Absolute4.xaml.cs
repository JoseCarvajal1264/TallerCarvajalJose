namespace TallerCarvajalJose;

public partial class Absolute4 : ContentPage
{
	public Absolute4()
	{
		InitializeComponent();
	}

    private void Boton0_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());

    }
}