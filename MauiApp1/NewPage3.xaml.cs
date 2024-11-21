namespace MauiApp1;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}
    private void btn1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage4());
    }
}