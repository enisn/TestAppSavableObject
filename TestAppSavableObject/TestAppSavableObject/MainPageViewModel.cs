using Plugin.LocalData.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAppSavableObject
{
    public class MainPageViewModel : SavableObject, INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            Load();
            SaveCommand = new Command(()=>Save());
        }

        string name = "defaultName", surname = "defaultSurname";
        double age;
        bool isToggled;
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(); }
        }
        public string Surname
        {
            get => surname;
            set { surname = value; OnPropertyChanged(); }
        }
        public double Age
        {
            get => age;
            set { age = value; OnPropertyChanged(); }
        }
        public bool IsToggled
        {
            get => isToggled;
            set { isToggled = value; OnPropertyChanged(); }
        }
        [IgnoreSave]
        public Command SaveCommand { get; set; }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
