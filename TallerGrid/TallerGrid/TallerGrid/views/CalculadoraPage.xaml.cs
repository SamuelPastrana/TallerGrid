using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerGrid.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "1";
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "2";
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "3";
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "4";
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "5";
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "6";
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "7";
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "8";
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "9";
        }

        private void ButtonX_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "*";
        }

        private void ButtonS_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "-";
        }

        private void ButtonA_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "+";
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "0";
        }

        private void ButtonP_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = ".";
        }

        private void ButtonIG_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "=";
        }
    }
}