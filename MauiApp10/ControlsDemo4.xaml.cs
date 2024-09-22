namespace MauiApp10;

public partial class ControlsDemo4 : ContentPage
{
	public ControlsDemo4()
	{
		InitializeComponent();
	}

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
		DisplayAlert("SwipeView","Element swiped","OK");
    }
}