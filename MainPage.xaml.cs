namespace PAM_MAUI_App;

public partial class MainPage : ContentPage
{
	int count = 0;
	string name = "Breno";
	int namen = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		namen = count % 2;

		if (namen == 0)
            NameTxt.Text = "Hello!";
		else
            NameTxt.Text = $"Hello {name}!";

        SemanticScreenReader.Announce(CounterBtn.Text);
	}

}


