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
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();
        }
        int clik = 0;
        private void btn_Clicked(object sender, EventArgs e)
        {
            clik++;
            btn.Text = clik.ToString();

            if (clik % 5 == 0)
            {
                lbl.Text = " ";
            }
            else
            {
                //lbl.IsVisible = true;
                lbl.Text = "Nupp!";
            }

        }
        private void btn2_Clicked_1(object sender, EventArgs e)
        {
            clik = 0;
            btn.Text = clik.ToString();
        }
    }
}