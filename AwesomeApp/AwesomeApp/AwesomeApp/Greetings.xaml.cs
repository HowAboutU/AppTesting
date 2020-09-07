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

            FormattedString formattedString = new FormattedString();
            NamedSize[] namedSizes =
            {
                NamedSize.Default,
                NamedSize.Micro,
                NamedSize.Small,
                NamedSize.Medium,
                NamedSize.Large
            };

            foreach (NamedSize namedSize in namedSizes)
            {
                double fontsize = Device.GetNamedSize(namedSize, typeof(Label));
                formattedString.Spans.Add(new Span
                {
                    Text = String.Format("Named Size = {0} ({1:F2})", 
                    namedSize, fontsize),
                    FontSize = fontsize
                });

                if (namedSize != namedSizes.Last())
                {
                    formattedString.Spans.Add(new Span
                    { 
                        Text = Environment.NewLine + Environment.NewLine
                    });

                }
            }

            //formattedString.Spans.Add(new Span
            //{
            //    Text = "I "
            //});

            //formattedString.Spans.Add(new Span {
            //    Text ="love",
            //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //    FontAttributes = FontAttributes.Bold
            //});

            //formattedString.Spans.Add(new Span {
            //    Text = " Xamarin.Forms!"
            //});

            Content = new Label
            {
                //Text = "\u201CGreetings, Xamarin.Forms",
                FormattedText = formattedString,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                //BackgroundColor = Color.FromRgb(1, 0, 0),
                //TextColor = Color.FromRgb(1.0, 0, 0),
                //FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                //FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            //Padding = new Thickness(5, Device.OnPlatform(20, 5, 5 ), 5, 5);
        }
    }
}