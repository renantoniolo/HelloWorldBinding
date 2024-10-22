using Com.Example.Helloworldlib;

namespace MauiHelloWorldApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        var helloWorld = new HelloWorld();
        string message = helloWorld.GetHelloWorld();
		CounterBtn.Text = message;
        //DisplayAlert("Hello from AAR", message, "OK");
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


