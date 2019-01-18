using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinPractice
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Schedule> ScheduleListData = new ObservableCollection<Schedule>();
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

        public void ChangeFirstTitle(object sender, EventArgs e)
        {
            ScheduleListData[0].Title = "The Concert is Canceled!!!";
        }

        public void AppendNewData(object sender, EventArgs e)
        {
            ScheduleListData.Add(new Schedule("2019/01/29", "Enjoy Onsen Ryokan in Chichibu", "Chichibu, Saitama"));
        }
    }

    // リスト1件のデータを表すクラス
    public class Schedule : INotifyPropertyChanged
    {
        private string datestr;
        public string Datestr
        {
            get => this.datestr;
            set
            {
                this.datestr = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Datestr)));
            }
        }

        private string title;
        public string Title
        {
            get => this.title;
            set
            {
                this.title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        private string place;
        public string Place
        {
            get => this.place;
            set
            {
                this.place = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Place)));
            }
        }


        public Schedule(string Datestr, string Title, string Place)
        {
            this.Datestr = Datestr;
            this.Title = Title;
            this.Place = Place;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
