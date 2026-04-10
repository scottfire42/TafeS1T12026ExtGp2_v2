using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Calculator
{
	public sealed partial class MiscConverter : Page
	{
		public MiscConverter()
		{
			this.InitializeComponent();
		}

		private void ConvertDistance_Click(object sender, RoutedEventArgs e)
		{
			double meter = Convert.ToDouble(txtMeter.Text);
			double foot = meter / 0.3048;
			lblDistanceResult.Text = foot.ToString("F2") + " ft";
		}

		private void ConvertMass_Click(object sender, RoutedEventArgs e)
		{
			double kilogram = Convert.ToDouble(txtKilogram.Text);
			double pound = kilogram / 0.45359237;
			lblMassResult.Text = pound.ToString("F2") + " lbs";
		}

		private void ConvertTemperature_Click(object sender, RoutedEventArgs e)
		{
			double celsius = Convert.ToDouble(txtCelsius.Text);
			double fahrenheit = (celsius * 1.8) + 32;
			lblTempResult.Text = fahrenheit.ToString("F2") + " °F";
		}

		private void ConvertPressure_Click(object sender, RoutedEventArgs e)
		{
			double kpa = Convert.ToDouble(txtKpa.Text);
			double psi = kpa / 6.89475729;
			lblPressureResult.Text = psi.ToString("F2") + " PSI";
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainMenu));
		}

	}
}