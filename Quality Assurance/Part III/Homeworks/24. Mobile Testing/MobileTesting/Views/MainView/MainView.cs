namespace FitnessApp.Views.MainView
{
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;

    public partial class MainView : BaseView
    {
        public MainView(AppiumDriver<AndroidElement> driver)
            : base(driver)
        {
        }

        internal void TurnOffVibrateSwtich()
        {
            this.SwitchVibrate.Tap(1, 200);
        }

        internal void TurnOffSoundSwtich()
        {
            this.SwitchSound.Tap(1, 200);
        }

        internal void ClearHeightField()
        {
            this.HeightField.Clear();
        }

        internal void EnterNewValueInHeightField(string heightValue)
        {
            this.HeightField.SendKeys(heightValue);
        }

        internal void ClearWidthField()
        {
            this.WidthField.Clear();
        }

        internal void EnterNewValueInWidthField(string widthValue)
        {
            this.WidthField.SendKeys(widthValue);
        }

        internal void TapNameButton()
        {
            this.NameButton.Tap(1, 200);
        }
    }
}