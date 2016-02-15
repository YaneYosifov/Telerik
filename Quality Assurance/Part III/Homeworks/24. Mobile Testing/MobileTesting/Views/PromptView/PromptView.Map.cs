namespace FitnessApp.Views.PromptView
{
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;

    public partial class PromptView
    {
        internal AppiumWebElement NameField
        {
            get
            {
                return this.Driver.FindElementById("android:id/custom")
                    .FindElementByClassName("android.widget.EditText");
            }
        }

        internal AndroidElement ButtonOk
        {
            get
            {
                return this.Driver.FindElementById("android:id/button1");
            }
        }
    }
}