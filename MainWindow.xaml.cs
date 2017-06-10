using System.Windows;
using System.Timers;
using System;

namespace ClockGadget
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		System.Timers.Timer ticker = new System.Timers.Timer();

		public MainWindow()
		{
			InitializeComponent();
			ticker.Interval = 1000;
			ticker.Start();
			ticker.Elapsed += Ticker_Elapsed;
		}

		private void Ticker_Elapsed(object sender, ElapsedEventArgs e)
		{
			Dispatcher.Invoke((Action)delegate ()
			{
				lblTime.Content = DateTime.Now.ToString("hh:mm:ss tt");
				lblDate.Content = DateTime.Today.ToString("MM/dd/yyyy");
			});
		}
	}
}
