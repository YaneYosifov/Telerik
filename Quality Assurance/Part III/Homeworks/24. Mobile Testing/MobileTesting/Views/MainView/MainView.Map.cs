namespace FitnessApp.Views.MainView
{
    using System.Collections.ObjectModel;
    using OpenQA.Selenium.Appium.Android;

    public partial class MainView
    {
        internal ReadOnlyCollection<AndroidElement> Switches
        {
            get
            {
                return this.Driver.FindElementsByClassName("android.widget.Switch");
            }
        }

        internal AndroidElement SwitchVibrate
        {
            get
            {
                return this.Switches[0];
            }
        }

        internal AndroidElement SwitchSound
        {
            get
            {
                return this.Switches[1];
            }
        }

        internal AndroidElement SeekBar
        {
            get
            {
                return this.Driver.FindElementByClassName("android.widget.SeekBar");
            }
        }

        internal ReadOnlyCollection<AndroidElement> TextFields
        {
            get
            {
                return this.Driver.FindElementsByClassName("android.widget.EditText");
            }
        }

        internal AndroidElement HeightField
        {
            get
            {
                return this.TextFields[0];
            }
        }

        internal AndroidElement WidthField
        {
            get
            {
                return this.TextFields[1];
            }
        }

        internal AndroidElement NameButton
        {
            get
            {
                return this.Driver.FindElementByClassName("android.widget.Button");
            }
        }
    }
}