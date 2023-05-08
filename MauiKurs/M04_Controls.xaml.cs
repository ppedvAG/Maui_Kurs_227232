namespace MauiKurs;

public partial class Controls : ContentPage
{
	public Controls()
	{
		InitializeComponent();
    }

    //Eventhandler des Button.Clicked-Event
    private void Button_Clicked(object sender, EventArgs e)
    {
        //Verwendung des sender-Parameters (enthält Event-auslösendes Objekt; hier Button)
        (sender as Button).Text = "Clicked";
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        //Beispiele für DisplayAlert-Aufrufe (mit zwei bzw. einem Button)-->
        bool result = await DisplayAlert
            (
                "Löschen",
                "Soll dieser Eintrag wirklich gelöscht werden?",
                "Ja",
                "Nein"
            );

        if (result)
            await DisplayAlert("Cool", "Du hast auf ja geklickt", "ok");
    }
}