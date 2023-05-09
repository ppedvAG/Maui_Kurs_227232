namespace MauiKurs.Bindings;

public partial class Bindings : ContentPage
{
	public Bindings()
	{
		InitializeComponent();
	}

    private async void Btn_Show_Clicked(object sender, EventArgs e)
    {
		Person person = Spl_BindingContextBsp.BindingContext as Person;
		await DisplayAlert("Person", $"{person.Name} ({person.Alter})", "ok");
    }

    private void Btn_Alter_Clicked(object sender, EventArgs e)
    {
        Person person = Spl_BindingContextBsp.BindingContext as Person;
        person.Alter++;
        person.UpdateGui();
    }

    private void Btn_Add_Clicked(object sender, EventArgs e)
    {
        Person person = Spl_BindingContextBsp.BindingContext as Person;

        person.WichtigeTage.Add(new DateTime(2023, 1, 15));
    }

    private void Btn_Delete_Clicked(object sender, EventArgs e)
    {
        Person person = Spl_BindingContextBsp.BindingContext as Person;

        if(Lsv_DateTime.SelectedItem!= null) 
        {
            person.WichtigeTage.Remove((DateTime)Lsv_DateTime.SelectedItem);
        }
    }
}