using Xamarin.Forms;

namespace MultilingualXFSample
{
    //Klasa App rozszerza klasę Application, pozwalając nam robić rzeczy na poziomie aplikacji 
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
