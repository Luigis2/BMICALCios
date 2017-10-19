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
                result = "very lowzzzzz";
            else if (bmi < 18.5)
                result = "lowzzzzz";
            else if (bmi < 26)
                result = "normalzzzzz";
            else if (bmi < 30)
                result = "highzzzz";
            else
                result = "too highzzz";
            
            lookLabel.Text = result;
        }
    }
}