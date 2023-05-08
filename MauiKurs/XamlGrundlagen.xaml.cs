namespace MauiKurs;

public partial class XamlGrundlagen : ContentPage
{
	public XamlGrundlagen()
	{
		InitializeComponent();
	}

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
		if(await DisplayAlert("FRAGE", "Soll was passieren?", "Ja", "Nein"))

			(sender as Button).Text = "Button wurde geklickt";
    }
}