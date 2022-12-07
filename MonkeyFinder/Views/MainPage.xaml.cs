namespace MonkeyFinder;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void onButtonClick(object sender, EventArgs e)
    {
        count++;

        var type = sender.GetType();
        var text = type.GetProperty("Text");
        text.SetValue(sender, $"Clicked {count} time");
    }

    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}
}

