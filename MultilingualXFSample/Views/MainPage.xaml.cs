using System.ComponentModel;
using MultilingualXFSample.Resources;
using MultilingualXFSample.Views;
using Xamarin.Forms;

namespace MultilingualXFSample
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ChangeLanguagePage());
        }
    }
}
