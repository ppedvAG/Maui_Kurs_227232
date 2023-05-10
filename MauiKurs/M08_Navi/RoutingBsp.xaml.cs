namespace MauiKurs.Navi;

public partial class RoutingBsp : ContentPage
{
	public RoutingBsp()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("//grundlagen/controls");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//routeTarget");
    }
}