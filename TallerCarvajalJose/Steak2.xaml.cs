namespace TallerCarvajalJose;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}

    private void Boton2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Flex3());
		
    }
}