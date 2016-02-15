namespace FitnessApp.Views.MainView
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class MainViewAsserter
    {
        internal static void AssertVibrateSwtichIsTurnedOff(this MainView mainView)
        {
            Assert.AreEqual(mainView.SwitchVibrate.GetAttribute("checked"), "false");
            Assert.AreEqual(mainView.SwitchVibrate.Text, "OFF");
        }

        internal static void AssertSoundSwtichIsTurnedOff(this MainView mainView)
        {
            Assert.AreEqual(mainView.SwitchSound.GetAttribute("checked"), "false");
            Assert.AreEqual(mainView.SwitchSound.Text, "OFF");
        }

        internal static void AssertSliderIsDisabled(this MainView mainView)
        {
            Assert.AreEqual(mainView.SeekBar.GetAttribute("clickable"), "false");
            Assert.AreEqual(mainView.SeekBar.GetAttribute("enabled"), "false");
            Assert.AreEqual(mainView.SeekBar.GetAttribute("scrollable"), "false");
        }

        internal static void AssertHeightFieldValue(this MainView mainView, string heightValue)
        {
            Assert.AreEqual(mainView.HeightField.Text, heightValue);
        }

        internal static void AssertWidthFieldValue(this MainView mainView, string widthValue)
        {
            Assert.AreEqual(mainView.WidthField.Text, widthValue);
        }

        internal static void AssertNameText(this MainView mainView, string newName)
        {
            Assert.AreEqual(mainView.NameButton.Text, newName);
        }
    }
}