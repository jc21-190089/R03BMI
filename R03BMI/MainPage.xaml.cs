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
                string zyotai=null;
                if (h >= 10)
                {
                    h = h / 100;
                }
                if(w>=10000)
                {
                    w = w / 1000;
                }
                double bmi = w / (h * h);
                double bmi2 = Math.Round(bmi, 1);
                if(bmi2<18.5)
                {
                    zyotai = "低体重(痩せ)";
                }
                if(bmi2>=18.5&&bmi2<25.0)
                {
                    zyotai = "普通体重";
                }
                if(bmi2>=25.0&&bmi2<30.0)
                {
                    zyotai = "肥満(1度)";
                }
                if(bmi2>=30.0&&bmi2<35.0)
                {
                    zyotai = "肥満(2度)";
                }
                if(bmi2>=35.0&&bmi2<40.0)
                {
                    zyotai = "肥満(3度)";
                }
                if(bmi2>=40.0)
                {
                    zyotai = "肥満(4度)";
                }

                result.Text = "身長" + h + "m体重" + w + "kgの人のBMIは" + bmi2+" "+zyotai+"です";

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "数字を入力してください";
            }

        }
    }
}

