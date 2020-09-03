using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IljaH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        BoxView box1, box2, box3;
        public Valgusfoor2()
        {
            //InitializeComponent();
            box1 = new BoxView()
            {
                Color = Color.White,
                CornerRadius = 100,
                WidthRequest = 160,
                HeightRequest = 160,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            box2 = new BoxView()
            {
                Color = Color.White,
                CornerRadius = 100,
                WidthRequest = 160,
                HeightRequest = 160,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            box3 = new BoxView()
            {
                Color = Color.White,
                CornerRadius = 100,
                WidthRequest = 160,
                HeightRequest = 160,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            Button btn = new Button()
            {
                Text = "ON",
                FontSize = 30,

            };
            btn.Clicked += Btn_Clicked;
            Button btn1 = new Button()
            {
                Text = "OFF",
                FontSize = 30,

            };
            btn1.Clicked += Btn1_Clicked;

            StackLayout stackLayout = new StackLayout()
            {
                Children = {box1, box2, box3}
            };

            stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;

            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { btn, btn1 }
            };

            stackLayout1.Orientation = StackOrientation.Horizontal;
            Content = stackLayout1;


            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { stackLayout, stackLayout1 }
            };
            Content = stackLayout2;

        }
        int clik = 0;
        Random random = new Random();
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            clik = 0;
            box1.Color = Color.White;
            box2.Color = Color.White;
            box3.Color = Color.White;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            clik++;
            int rand = random.Next(1, 4);
            if (rand == 1)
            {

                box1.Color = Color.Red;
            }
            else if (rand == 2)
            {
                box2.Color = Color.Yellow;
            }
            else if (rand == 3)
            {

                box3.Color = Color.Green;
            }

        }
    }
}