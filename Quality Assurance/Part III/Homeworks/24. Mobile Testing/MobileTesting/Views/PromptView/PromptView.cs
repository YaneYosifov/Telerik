namespace FitnessApp.Views.PromptView
{
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;

    public partial class PromptView : BaseView
    {
        public PromptView(AppiumDriver<AndroidElement> driver)
            : base(driver)
        {
        }

        internal void ClearNameField()
        {
            this.NameField.Clear();
        }

        internal void EnterNewName(string newName)
        {
            this.NameField.SendKeys(newName);
        }

        internal void TapOkButton()
        {
            this.ButtonOk.Tap(1, 200);
        }
    }
}