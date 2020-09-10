using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using Slider = Xamarin.Forms.Slider;

namespace IljaH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RGBModelPage : ContentPage
    {
        Slider redSlider, greenslider, blueSlider;
        BoxView boxView;
        Label redLable, greenLable, blueLable;
        Button btn;

        public RGBModelPage()
        {
            boxView = new BoxView()
            {
                Color = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            redSlider = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 0,
            };
            redSlider.ValueChanged += Slider1_ValueChanged;
            redLable = new Label()
            {

            };
            greenslider = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 0,
            };

            greenslider.ValueChanged += Slider1_ValueChanged;

            greenLable = new Label()
            {

            };

            blueSlider = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 0,
            };

            blueSlider.ValueChanged += Slider1_ValueChanged;

            blueLable = new Label()
            {

            };
            btn = new Button()
            {
                Text = "Press for a random color",
            };
            btn.Clicked += Btn_Clicked;

            StackLayout stackLayout = new StackLayout()
            {
                Margin = new Thickness(10),
                Children = {boxView, redSlider, redLable, greenslider, greenLable, blueSlider, blueLable, btn}
            };
            Content = stackLayout;

        }

        Random rnd = new Random();
        private void Btn_Clicked(object sender, EventArgs e)
        {
            int red = rnd.Next(256);
            int green = rnd.Next(256);
            int blue = rnd.Next(256);
            Color randomColor = Color.FromRgb(red, green, blue);
          
            boxView.Color = randomColor;
            redSlider.Value = red;
            greenslider.Value = green;
            blueSlider.Value = blue;

        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                boxView.Color = Color.FromRgb((int)redSlider.Value, (int)greenslider.Value, (int)blueSlider.Value);
            }
            if (sender == redSlider)
            {
                redLable.Text = String.Format("Red = {0:X2}", (int)e.NewValue);
            }
            else if (sender == greenslider)
            {
                greenLable.Text = String.Format("Green = {0:X2}", (int)e.NewValue);
            }
            else if (sender == blueSlider)
            {
                blueLable.Text = String.Format("Blue = {0:X2}", (int)e.NewValue);
            }
        }
    }
}