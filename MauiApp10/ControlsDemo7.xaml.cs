namespace MauiApp10;

public partial class ControlsDemo7 : ContentPage
{
	public ControlsDemo7()
	{
		InitializeComponent();
	}
	// Start ActivityIndicator
    private void OnStartActivity(object sender, EventArgs e)
    {
        ActivityIndicatorControl.IsRunning = true;
    }
    // Stop ActivityIndicator
    private void OnStopActivity(object sender, EventArgs e)
    {
        ActivityIndicatorControl.IsRunning = false;
    }
    // Increase ProgressBar Progress
	private double _progress = 0.0;
    private void OnIncreaseProgress(object sender, EventArgs e)
    {
        _progress += 0.1;
        if (_progress > 1.0)
        {
            _progress = 0.0;
        }
        ProgressBarControl.Progress = _progress;
    }
}