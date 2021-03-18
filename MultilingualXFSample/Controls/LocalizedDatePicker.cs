using System;
using Xamarin.Forms;

namespace MultilingualXFSample.Controls
{
	//Implementacja Klasy DatePicker

		//Wyświetla datę przy użyciu nieskróconych nazw dni tygodnia i miesięcy.
		//Ogranicza rozwijany kalendarz do wyświetlania dat tylko w roku 2009
		//Wyświetla poniedziałek jako pierwszy dzień tygodnia.

	public class LocalizedDatePicker : DatePicker
    {
		//Celem właściwości możliwych do powiązania (bindable properties) jest zapewnienie systemu (właściwości), który obsługuje powiązania danych, styli, szablonów i wartości ustawianych za pośrednictwem relacji parent-child.
		//Ponadto bindable properties mogą zawierać wartości domyślne, sprawdzanie poprawności wartości właściwości i wywołania zwrotne, które monitorują zmiany właściwości. 

		//Ustawiamy daty
		public static readonly BindableProperty PositiveActionTextProperty = BindableProperty.Create(nameof(PositiveActionText), typeof(string), typeof(LocalizedDatePicker), "Set");

		public string PositiveActionText
		{
			get { return (string)GetValue(PositiveActionTextProperty); }
			set
			{
				SetValue(PositiveActionTextProperty, value);
			}
		}

		//Anulowanie ustawienia daty
		public static readonly BindableProperty NegativeActionTextProperty = BindableProperty.Create(nameof(NegativeActionText), typeof(string), typeof(LocalizedDatePicker), "Cancel");

		public string NegativeActionText
		{
			get { return (string)GetValue(NegativeActionTextProperty); }
			set
			{
				SetValue(NegativeActionTextProperty, value);
			}
		}
	}
}
