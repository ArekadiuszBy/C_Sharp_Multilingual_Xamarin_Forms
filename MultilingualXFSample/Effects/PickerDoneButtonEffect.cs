using System.Linq;
using Xamarin.Forms;

namespace MultilingualXFSample.Effects
{
    public static class PickerDoneButtonEffect
    {
        public static BindableProperty DoneButtonTextProperty =
           BindableProperty.CreateAttached("DoneButtonText",
                                           typeof(string),
                                           typeof(PickerDoneButtonEffect),
                                           string.Empty,
                                           propertyChanged: OnDoneButtonPropertyPropertyChanged);

        public static string GetDoneButtonText(BindableObject element)
        {
            return (string)element.GetValue(DoneButtonTextProperty);
        }


        //przyciemnienie Buttonu "Save"
        public static void SetTintColor(BindableObject element, string value)
        {
            element.SetValue(DoneButtonTextProperty, value);
        }


        static void OnDoneButtonPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AttachEffect(bindable as View, $"{newValue}");
        }


        //Dodanie efektu do Buttona "Save"
        static void AttachEffect(View element, string buttonText)
        {
            var effect = element.Effects.FirstOrDefault(x => x is PickerDoneButton) as PickerDoneButton;

            if (effect != null)                      //jeśli efekt jest wykonywanu
            {
                element.Effects.Remove(effect);     //usuń efekt
            }

            element.Effects.Add(new PickerDoneButton(buttonText));
        }
            

        public class PickerDoneButton : RoutingEffect           //RoutingEffect - Efekt niezależny od platformy, który otacza efekt wewnętrzny, który jest zwykle specyficzny dla platformy. 
        {
            public string ButtonTitle { get; set; }             //Kompilator generuje zmienną składową ButtonTitle 

            public PickerDoneButton(string buttonTitle) : base($"MyCompany.{nameof(PickerDoneButton)}")
            {
                ButtonTitle = buttonTitle;
            }
        }
    }
}
