using Foundation;
using System;
using UIKit;

namespace BMIiOS
{
    public partial class Deetzz : UIViewController
    {
        public float bmi = 21.5f;
        public Deetzz (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            EvaluateBMI();
        }
        void EvaluateBMI()
        {
            string result = String.Empty;

            if (bmi <= 16)
                result = "Its Very Low Doe";
            else if (bmi < 18.5)
                result = "Its Kinda Low Doe";
            else if (bmi < 26)
                result = "You Normal You OG";
            else if (bmi < 30)
                result = "Kinda High Doe";
            else
                result = "Higher than the Burj Khalifa";
            
            lookLabel.Text = result;
        }
    }
}