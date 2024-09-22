namespace MauiApp10;

public partial class ControlsDemo2 : ContentPage
{
	public ControlsDemo2()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		var radioButton = (RadioButton)sender;
        if (radioButton.IsChecked)
        {
            SelectedGradeLabel.Text = $"Selected Grade: {radioButton.Value}";
        }
    }
}