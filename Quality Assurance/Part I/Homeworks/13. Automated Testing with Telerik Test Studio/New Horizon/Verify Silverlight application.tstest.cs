using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace New_Horizon
{

    public class Verify_Silverlight_application : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Verify 'TodayTextblock' text Same 'Today'", RequiresSilverlight=true)]
        public void Verify_Silverlight_application_CodedStep()
        {
            // Verify 'TodayTextblock' text Same 'Today'
            DateTime date = DateTime.Now;
            Assert.IsTrue((ArtOfTest.Common.CompareUtils.StringCompare(Pages.TelerikGaugeForSilverlight0.SilverlightApp.TodayTextblock.Text, date.ToString("MMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US")).ToUpper(), ArtOfTest.Common.StringCompareType.Same)), string.Format("Verify \'TodayTextblock\' text Same \'Today\' failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.TodayTextblock.Text));
            
        }
    }
}
