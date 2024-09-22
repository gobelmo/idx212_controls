namespace MauiApp10;

public partial class ControlsDemo5 : ContentPage
{
	public ControlsDemo5()
	{
		InitializeComponent();
	}

	// CheckBox event
    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CheckBoxValueLabel.Text = e.Value ? "CheckBox is checked" : "CheckBox is unchecked";
    }

    // Slider event
    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        SliderValueLabel.Text = $"Slider Value: {e.NewValue:F0}";
    }

    // Stepper event
    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        StepperValueLabel.Text = $"Stepper Value: {e.NewValue:F0}";
    }

    // Switch event
    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        SwitchValueLabel.Text = e.Value ? "Switch is on" : "Switch is off";
    }

    // DatePicker event
    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePickerValueLabel.Text = $"Selected Date: {e.NewDate:MM/dd/yyyy}";
    }
}