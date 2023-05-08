namespace MauiKurs;

public partial class XamlGrundlagen : ContentPage
{
	public XamlGrundlagen()
    {
        //Dies verweist auf eine Methode in der (versteckten) automatisch generierten zweiten Klassen-Datei (*.g.i.cs),
        //welche f�r das Rendering des XAML-Codes verantwortlich ist. InitializeComponent() erstellt die
        //Steuerelement-Objekte und muss daher als erste Methode des Konstruktors bestehen bleiben
        InitializeComponent();
    }

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "Button wurde geklickt";

        //Mittels eines DisplayAlerts k�nnen kleine (asynkrone) Aussagen und Abfragen an den Benutzer ausgegeben
        if (await DisplayAlert("FRAGE", "Soll was gemacht werden?", "Ja", "Nein"))
        //Ver�ndern der Text-Eigenschaft (angezeigter Text) des Buttons
        {
            (sender as Button).Text = "Button wurde geklickt";
            Lbl_Output.Text = "Button wurde geklickt";
        }
    }
}

