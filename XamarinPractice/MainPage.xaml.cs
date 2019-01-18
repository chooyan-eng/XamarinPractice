using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinPractice
{
    public partial class MainPage : ContentPage
    {
        private List<Schedule> ScheduleListData = new List<Schedule>();
        public MainPage()
        {
            InitializeComponent();

            // 初期データを準備
            ScheduleListData.Add(new Schedule("2019/01/03", "New Year Concert", "Orchard Hall"));
            ScheduleListData.Add(new Schedule("2019/01/07", "Shigoto hajime", "office"));
            ScheduleListData.Add(new Schedule("2019/01/20", "New Year Party", "John's place"));
            ScheduleListData.Add(new Schedule("2019/01/26", "Trip to Nagano", "Nagano"));

            // ListViewにデータソースをセット
            scheduleList.ItemsSource = ScheduleListData;
        }
    }

    // リスト1件のデータを表すクラス
    public class Schedule
    {
        public string Datestr { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }

        public Schedule(string Datestr, string Title, string Place)
        {
            this.Datestr = Datestr;
            this.Title = Title;
            this.Place = Place;
        }
    }
}
