namespace FitnessApp
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Views.MainView;

    [TestClass]
    public class FitnessAppTests : BaseTest
    {
        [TestMethod]
        public void SwitchVibrateAndSoundSwitchesToOff()
        {
            this.MainView.TurnOffVibrateSwtich();
            this.MainView.TurnOffSoundSwtich();

            this.MainView.AssertVibrateSwtichIsTurnedOff();
            this.MainView.AssertSoundSwtichIsTurnedOff();
            this.MainView.AssertSliderIsDisabled();
        }

        [TestMethod]
        public void EditHeightAndWeight()
        {
            const string HeightValue = "170";
            const string WidthValue = "65";

            this.MainView.ClearHeightField();
            this.MainView.EnterNewValueInHeightField(HeightValue);
            this.MainView.AssertHeightFieldValue(HeightValue);

            this.MainView.ClearWidthField();
            this.MainView.EnterNewValueInWidthField(WidthValue);
            this.MainView.AssertWidthFieldValue(WidthValue);

            Driver.BackgroundApp(10);
            this.MainView.AssertHeightFieldValue(HeightValue);
            this.MainView.AssertWidthFieldValue(WidthValue);
        }

        [TestMethod]
        public void EditName()
        {
            const string NewName = "Telerik Student";
            this.MainView.TapNameButton();

            this.PromptView.ClearNameField();
            this.PromptView.EnterNewName(NewName);

            this.PromptView.TapOkButton();
            this.MainView.AssertNameText(NewName);

            Driver.BackgroundApp(10);
            this.MainView.AssertNameText(NewName);
        }
    }
}