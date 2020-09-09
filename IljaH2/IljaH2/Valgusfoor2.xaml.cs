using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IljaH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        BoxView box1, box2, box3;
        Button btn, btn1;
        Label lbl1;
        bool sisse_valja;
        public Valgusfoor2()
        {
            sisse_valja = false;
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


            lbl1 = new Label()
            {
                FontSize = 30,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };


            btn = new Button()
            {
                Text = "Sisse",
                FontSize = 30,

            };

            btn.Clicked += Btn_Clicked;

            btn1 = new Button()
            {
                Text = "Välja",
                FontSize = 30,
            };

            btn1.Clicked += Btn1_Clicked;


            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box1.GestureRecognizers.Add(tap);
            box2.GestureRecognizers.Add(tap);
            box3.GestureRecognizers.Add(tap);




            StackLayout stackLayout = new StackLayout()
            {
                Children = {box1, box2, box3, lbl1}
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


        private void Tap_Tapped(object sender, EventArgs e)
        {
            BoxView fr = sender as BoxView;
            if (fr == box1) 
            {
                box1.Color = Color.Red;
                box2.Color = Color.White;
                box3.Color = Color.White;
                lbl1.Text = "Seisa ja oota!!!!";
            }
            if (fr == box2)
            {
                box2.Color = Color.Yellow;
                box1.Color = Color.White;
                box3.Color = Color.White;
                lbl1.Text = "Oota!";
            }
            if (fr == box3)
            {
                box3.Color = Color.Green;
                box2.Color = Color.White;
                box1.Color = Color.White;
                lbl1.Text = "Go!";
            }
            if (sisse_valja == false)
            {
                box1.Color = Color.White;
                box2.Color = Color.White;
                box3.Color = Color.White;
                lbl1.Text = " ";
                lbl1.FontSize = 30;

            }
            
        }


        int clik = 0;
        Random random = new Random();
        private void Btn1_Clicked(object sender, EventArgs e) // välja
        {
            if (sisse_valja == false)
            {
                lbl1.FontSize = 30;
            }
            sisse_valja = false;
            clik = 0;
            box1.Color = Color.White;
            box2.Color = Color.White;
            box3.Color = Color.White;
        }

        private void Btn_Clicked(object sender, EventArgs e) // sisse
        {
            sisse_valja = true;

            lbl1.FontSize++;


            clik++;
            int rand = random.Next(1, 4);
            if (sisse_valja == true)
            {
                if (rand == 1)
                {

                    lbl1.FontAttributes = FontAttributes.Bold;
                }
                else if (rand == 2)
                {
                    lbl1.FontAttributes = FontAttributes.Italic;
                }
                else if (rand == 3)
                {
                    lbl1.FontAttributes = FontAttributes.None;
                }
            }
            

        }
    }
}