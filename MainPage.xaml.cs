namespace MauiMaterial3CustomizationSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		CheckupDatePicker.Date = new DateTime(2026, 5, 21);
		ReminderTimePicker.Time = new TimeSpan(7, 30, 0);
		GoalPicker.SelectedIndex = 2;
	}
}
