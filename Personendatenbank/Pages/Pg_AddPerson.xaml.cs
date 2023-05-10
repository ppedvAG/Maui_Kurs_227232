using Personendatenbank.Model;

namespace Personendatenbank.Pages;

public partial class Pg_AddPerson : ContentPage
{
    public Pg_AddPerson()
    {
        InitializeComponent();

        Dpr_Birthdate.Date = DateTime.Now;
    }

    #region Lab03
    //private void Btn_ClickMe_Clicked(object sender, EventArgs e)
    //{
    //    Lbl_Output.TextColor = (Lbl_Output.TextColor == Colors.Red) ? Colors.Green : Colors.Red;
    //}
    #endregion

    #region Lab04

    private async void Btn_Add_Clicked(object sender, EventArgs e)
    {
        Model.Person person = this.BindingContext as Model.Person;

        if (await DisplayAlert
            (
                   $"{person.Name} hinzufügen?",
                   $"Soll diese Person gespeichert werden?\n{person.Name} ({person.Gender})\nGeboren am {person.Birthdate.ToShortDateString()}\n{(person.IsMarried ? "" : "Nicht ")}Verheiratet",
                   "Ja",
                   "Nein"
            )
        )
        {
            this.BindingContext = new Model.Person();
        }
    }
    private void Ety_Name_Completed(object sender, EventArgs e) => Dpr_Birthdate.Focus();
    private void Dpr_Birthdate_DateSelected(object sender, DateChangedEventArgs e) => Pkr_Gender.Focus();

    #endregion
}