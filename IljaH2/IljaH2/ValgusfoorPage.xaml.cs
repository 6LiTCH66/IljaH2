using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading;

namespace IljaH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValgusfoorPage : ContentPage
    {
        public ValgusfoorPage()
        {
            InitializeComponent();
        }
        int clik = 0;
        Random random = new Random();
        private void btn_Clicked(object sender, EventArgs e)
        {
            clik++;
            int rand = random.Next(0, 4);
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

        private void btn_Clicked_1(object sender, EventArgs e)
        {
            clik = 0;
            box1.Color = Color.White;
            box2.Color = Color.White;
            box3.Color = Color.White;
        }
    }
}