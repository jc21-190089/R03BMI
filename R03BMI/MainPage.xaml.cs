using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A28 外塚 成喜";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var height = heighit.Text;
            var weight = weighit.Text;
            try
            {
                double h = double.Parse(height);
                int w = int.Parse(weight);
                if (h > 10)
                {
                    h = h / 100;
                }
                double bmi = w / (h * h);
                double bmi2 = Math.Round(bmi, 2);



                result.Text = "身長" + h + "m体重" + w + "kgの人のBMIは" + bmi2;

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "!!!";
            }

        }
    }
}

