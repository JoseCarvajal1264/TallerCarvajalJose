namespace TallerCarvajalJose
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Boton1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stack());

        }
    }

}
