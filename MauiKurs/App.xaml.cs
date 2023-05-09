using System.Diagnostics;

namespace MauiKurs;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Resources_Styles();
	}

    //Override der CreateWindow() um Zugriff auf globale shared Lifecycle-Events zu haben (für OS-spezifische LC-Events siehe MauiProgram.cs)
    protected override Window CreateWindow(IActivationState activationState)
    {
		Window wnd = base.CreateWindow(activationState);

		wnd.Created += (s, e) => Debug.Print("SharedCreated");
		wnd.Stopped += (s, e) => Debug.Print("SharedStopped");

		return wnd;
    }
}
