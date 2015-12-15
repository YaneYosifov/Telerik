using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
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

namespace Flashback
{

    public class Verify_that_updated_information_is_shown_on_your_profile_page : BaseWebAiiTest
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
            
        [CodedStep(@"Verify 'TextContent' 'Contains' '25-02-1980' on 'РоденНа01Span' - DataDriven: [$(BirthDay)]")]
        public void BirthDay_CodedStep()
        {
            // Verify 'TextContent' 'Contains' '' on 'РоденНа01Span'
            DateTime datetime = Convert.ToDateTime(Data["BirthDay"].ToString().Substring(4, 11));
            string birthday = datetime.Month.ToString().PadLeft(2, '0') + "-" + datetime.Day.ToString().PadLeft(2, '0') + "-" + (datetime.Year + 50);
            Pages.ПрофилътНаBatman007.РоденНа01Span.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, birthday);
            
        }
    }
}
