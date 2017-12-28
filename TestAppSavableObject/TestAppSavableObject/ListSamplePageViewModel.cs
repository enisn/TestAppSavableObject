using Plugin.LocalData.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAppSavableObject
{
    public class ListSamplePageViewModel : SavableObject, INotifyPropertyChanged
    {

        public ListSamplePageViewModel()
        {
            Load();
            ListData = new ObservableCollection<string>(ListData);
            AddCommand = new Command(AddToList);
            SaveCommand = new Command(Save);
        }
        IList<string> listData=new ObservableCollection<string>();
        string input;
        public IList<string> ListData
        {
            get => listData;
            set { listData = value; OnPropertyChanged(); }
        }
        public string Input
        {
            get => input;
            set { input = value; OnPropertyChanged(); }
        }
        [IgnoreSave]
        public Command AddCommand { get; set; }
        [IgnoreSave]
        public Command SaveCommand { get; set; }
        #region MVVM Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion


        void AddToList()
        {
            ListData.Add(input);
            Input = String.Empty;
        }
    }
}
