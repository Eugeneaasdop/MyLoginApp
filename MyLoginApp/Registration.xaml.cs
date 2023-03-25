using MyLoginApp.ViewModel;

namespace MyLoginApp;

public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushModalAsync(new LoginPage());
    }
}