using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainMenu : Page
	{
		public MainMenu()
		{
			this.InitializeComponent();
		}

		//open the simple calculator
		private void mathsCalcButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage));
		}

		//open the mortgage calculator
		private void mortgageCalcButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MortgageCalc));
		}

		//open the currency calculator
		private void currencyConvButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(CurrencyCalculatorPage));
		}

		//open the miscellaneous converter
		private void OpenMiscConverter_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MiscConverter));
		}

		private async void Trip_Click(object sender, RoutedEventArgs e)
		{
			var dialog = new ContentDialog()
			{
				Title = "Trip Calculator",
				Content = "Trip calculator c# code will be developed later.",
				CloseButtonText = "OK"
			};

			await dialog.ShowAsync();
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
