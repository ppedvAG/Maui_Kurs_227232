namespace MauiKurs.Navi;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("routeTarget", typeof(Navi.RouteTargetPage));
	}
}