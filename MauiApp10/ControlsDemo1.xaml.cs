namespace MauiApp10;

public partial class ControlsDemo1 : ContentPage
{
	public ControlsDemo1()
	{
		InitializeComponent();
	}

    private void btn1_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Alert title","Alert detail. Long message to display was here.","OK");
    }
}