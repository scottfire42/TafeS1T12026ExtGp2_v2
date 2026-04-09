/*

	Title: ICTICT449 Version Control Assignment 2, Feature1 Mortgage Calculator (Version 2, electric boogaloo)
	Created By: Scott Harris
	Create Date: 09-Apr-2026
	Team: TafeS1T12026ExtGp2
	
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
	public sealed partial class MortgageCalc : Page
	{
		public MortgageCalc()
		{
			this.InitializeComponent();
		}

		private void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			double principalBorrowed = 0.00D;
			double years = 0.00D;
			double months = 0.00D;
			double totalMonths = 0.00D;
			double annualInterestRate = 0.0000D;
			double monthlyInterestRate = 0.0000D;
			double monthlyRepayment = 0.0000D;

			//simple blank test for principalBorrowedInputBox
			if (principalBorrowedInputBox.Text == "")
			{
				principalBorrowedInputBox.Text = "0";
				principalBorrowed = 0.00D;
			}
			else
			{
				principalBorrowed = double.Parse(principalBorrowedInputBox.Text);
			}

			//simple blank test for yearsInputBox
			if (yearsInputBox.Text == "")
			{
				yearsInputBox.Text = "0";
				years = 0.00D;
			}
			else
			{
				years = double.Parse(yearsInputBox.Text);
			}

			//simple blank test for monthsInputBox
			if (monthsInputBox.Text == "")
			{
				monthsInputBox.Text = "0";
				months = 0.00D;
			}
			else
			{
				months = double.Parse(monthsInputBox.Text);
			}

			totalMonths = months + (12.0 * years);

			//simple blank test for annualInterestRateInputBox
			if (annualInterestRateInputBox.Text == "")
			{
				annualInterestRateInputBox.Text = "0";
				annualInterestRate = 0.0000D;

			}
			else
			{
				annualInterestRate = double.Parse(annualInterestRateInputBox.Text);
			}

			monthlyInterestRate = ((annualInterestRate / 100) / 12);
			monthlyInterestRateInputBox.Text = "";
			monthlyInterestRateInputBox.Text = (monthlyInterestRate * 100).ToString("0.00") + "%";

			monthlyRepayment = principalBorrowed * (monthlyInterestRate * (Math.Pow((1.00D + monthlyInterestRate), (totalMonths)))) / ((Math.Pow((1.0D + monthlyInterestRate), totalMonths) - 1.0D));
			monthlyRepaymentInputBox.Text = "";
			monthlyRepaymentInputBox.Text = monthlyRepayment.ToString("C2");
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
	}
}
