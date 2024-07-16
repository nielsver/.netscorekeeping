namespace Projectm;

public partial class Welcome : ContentPage
{
	public Welcome()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		 Navigation.PushAsync(new MainPage());
    }
}