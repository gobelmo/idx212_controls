namespace MauiApp10;

public partial class ControlsDemo6 : ContentPage
{
	public ControlsDemo6()
	{
		InitializeComponent();
	}
	// Entry text changed event
    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        EntryValueLabel.Text = $"Entry Value: {e.NewTextValue}";
    }

    // Editor text changed event
    private void Editor_TextChanged(object sender, TextChangedEventArgs e)
    {
        EditorValueLabel.Text = $"Editor Value: {e.NewTextValue}";
    }
}