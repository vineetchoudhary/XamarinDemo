using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo
{
    public partial class QuotesPage : ContentPage
    {
		int currentQuoteIndex = 0;
		String[] quotes = new String[] { "Hello frome the other side.", 
			"I must've called a thousand times.", 
			"To go over everything", 
			"They say that time's supposed to heal ya", 
			"But I ain't done much healing", 
			"Hello frome the other side \nI must've called a thousand times \nTo go over everything \nThey say that time's supposed to heal ya \nBut I ain't done much healing"};
        public QuotesPage()
        {
            InitializeComponent();
			showQuote();
        }

		void NextQuoteButton_Handle_Clicked(object sender, System.EventArgs e)
		{
			showQuote();
		}

		void showQuote()
		{
			QuoteLabel.Text = quotes[currentQuoteIndex];
            currentQuoteIndex = (currentQuoteIndex == (quotes.Length - 1)) ? 0 : (currentQuoteIndex + 1);
		}
    }
}
