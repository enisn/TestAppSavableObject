using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestAppSavableObject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new TestAppSavableObject.MainPage());
            (MainPage as NavigationPage).ToolbarItems.Add(new ToolbarItem { Text = "List", Command = new Command(()=> 
            {
                MainPage.Navigation.PushAsync(new ListSamplePage());
            })});
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
