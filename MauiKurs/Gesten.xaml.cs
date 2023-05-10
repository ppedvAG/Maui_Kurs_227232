namespace MauiKurs;

public partial class Gesten : ContentPage
{
	public Gesten()
	{
		InitializeComponent();
	}

    private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
    {
        e.Data.Text = ((sender as DragGestureRecognizer).Parent as Label).Text;
    }

    private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
    {
        ((sender as DropGestureRecognizer).Parent as Label).Text = e.Data.GetTextAsync().ToString();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        (sender as Label).Text = "TAPPED";
    }
}