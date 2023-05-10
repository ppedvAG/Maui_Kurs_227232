namespace MauiKurs.Navi;

public partial class NavPageBsp : ContentPage
{
	public NavPageBsp()
	{
		InitializeComponent();
	}

    private void Btn_Main_Clicked(object sender, EventArgs e)
    {
        //Mittels PushAsync kann innerhalb einer NavigatinPage zu der nächsten Seite navigiert werden.
        //Vorherige Pages werden für die Back-Navigation auf den NavigationStack gelegt.
        Navigation.PushAsync(new XamlGrundlagen());
    }

    private void Btn_Controls_Clicked(object sender, EventArgs e)
    {
        //Modal-Pushes verhindern die Anzeige von Titelleiste und Software-Back-Button bei der nächsten Seite und kann auch ohne NavigationPage verwendet werden
        Navigation.PushModalAsync(new Controls());
    }
}