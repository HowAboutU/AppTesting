using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Greetings : ContentPage
    {
        public Greetings()
        {
            InitializeComponent();

            Content = new Label
            {
                Text = "\u201CGreetings, Xamarin.Forms",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromRgb(1, 0, 0),
                TextColor = Color.FromRgb(1.0, 0, 0),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5 ), 5, 5);
        }
    }
}