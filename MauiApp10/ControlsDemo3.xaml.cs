namespace MauiApp10;

public partial class ControlsDemo3 : ContentPage
{
	public ControlsDemo3()
	{
		InitializeComponent();
	}

    private void mySearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
		DisplayAlert("Searching" , $"searching : {mySearchBar.Text}" , "Ok");
    }
}