namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		Group1Panel.BindingContext = new ViewModel();
		Group2Panel.BindingContext = new ViewModel();
	}
}

public class ViewModel : BindableObject
{
	private bool boolValue = true;

	public bool BoolValue
	{
		get => boolValue;
		set 
		{
			boolValue = value;
			OnPropertyChanged();
		}
	}
}

