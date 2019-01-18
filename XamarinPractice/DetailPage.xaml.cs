using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinPractice
{
    public partial class DetailPage : ContentPage
    {
        // TODO: データバインディングを使うように要修正
        public DetailPage(Schedule schedule)
        {
            InitializeComponent();

            dateValue.Text = schedule.Datestr;
            titleValue.Text = schedule.Title;
            placeValue.Text = schedule.Place;
        }
    }
}
