using MultilingualXFSample.ViewModels;
using Xamarin.Forms;

namespace MultilingualXFSample.Views
{
    public partial class ChangeLanguagePage : ContentPage
    {
        public ChangeLanguagePage()
        {
            InitializeComponent();                               // metoda napisana automatycznie przez Form Designer podczas tworzenia / zmiany formularzy
            BindingContext = new ChangeLanguageViewModel();     //związanie widoku

            //Binding to powiązanie wywołań funkcji z obiektem. Powiązanie funkcji składowej, która jest wywoływana w obiekcie i jest nazywana czasem kompilatora,
            //typem statycznym lub wczesnym wiązaniem. Wszystkie metody nazywane są obiektami lub nazwami klasy i są przykładami powiązań w czasie kompilacji. 
        }
    }
}
