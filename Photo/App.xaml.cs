using Xamarin.Forms;

namespace Photo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PhotoPage();
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
