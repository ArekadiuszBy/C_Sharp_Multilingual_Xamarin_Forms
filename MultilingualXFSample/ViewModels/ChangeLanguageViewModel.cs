using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using MultilingualXFSample.Helpers;
using MultilingualXFSample.Models;
using MultilingualXFSample.Resources;
using Xamarin.Forms;

namespace MultilingualXFSample.ViewModels
{
    // klasa ChangeLanguageViewModel implementuje interfejs IPropertyChange. 
    public class ChangeLanguageViewModel: INotifyPropertyChanged
    {
        //Dynamiczna kolekcja danych, która dostarcza powiadomienia, gdy elementy zostaną dodane, usunięte lub gdy cała lista zostanie odświeżona 
        public ObservableCollection<Language> Languages { get; set; }
        public Language SelectedLanguage { get; set; }

        //polecenie zapewniające zachowanie dla elementów interfejsu użytkownika, takich jak przycisk XAML środowiska wykonawczego systemu Windows, aw szczególności AppBarButton
        public ICommand ChangeLangugeCommand { get; set; }


        //
        public ChangeLanguageViewModel()
        {
            LoadLanguage();

            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
            ChangeLangugeCommand = new Command(async() =>
            {
                //CultureInfo - nazwy kultury, system pisania, używany kalendarz, kolejność sortowania ciągów oraz formatowanie dat i liczb 
                LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo(SelectedLanguage.CI));
                LoadLanguage();
                await App.Current.MainPage.DisplayAlert(AppResources.LanguageChanged, "", AppResources.Done);
            });

        }

        //Załadowanie wartości językowych (lista języków)
        void LoadLanguage()
        {
            Languages = new ObservableCollection<Language>()
            {
                {new Language(AppResources.English, "en") },
                {new Language(AppResources.Spanish, "es") },
                {new Language(AppResources.French, "fr") }
            };
            SelectedLanguage = Languages.FirstOrDefault(pro => pro.CI == LocalizationResourceManager.Instance.CurrentCulture.TwoLetterISOLanguageName);
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
