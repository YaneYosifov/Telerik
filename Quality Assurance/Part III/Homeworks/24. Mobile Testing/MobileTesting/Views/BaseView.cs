namespace FitnessApp.Views
{
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;

    public abstract class BaseView
    {
        private readonly AppiumDriver<AndroidElement> driver;

        protected BaseView(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        protected AppiumDriver<AndroidElement> Driver
        {
            get
            {
                return this.driver;
            }
        }
    }
}