namespace MauiKurs;

public partial class Layouts : ContentPage
{
	public Layouts()
	{
		InitializeComponent();
	}

    private void Btn_Verschieben_Clicked(object sender, EventArgs e)
    {
		Grid.SetColumn(Btn_Verschieben, 1);
    }
}