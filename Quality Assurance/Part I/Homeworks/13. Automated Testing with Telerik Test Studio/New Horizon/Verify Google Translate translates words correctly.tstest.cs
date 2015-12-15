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

namespace New_Horizon
{

    public class Verify_Google_Translate_translates_words_correctly : BaseWebAiiTest
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
    
        //[CodedStep(@"Verify 'TextContent' 'Exact' '' on 'SourceTextArea' - DataDriven: [$(English)]")]
        //public void Create_Automated_Web_Tests_CodedStep()
        //{
            //// Verify 'TextContent' 'Exact' '$(English)' on 'SourceTextArea' - DataDriven: [$(English)]
            //Pages.GoogleTranslate1.SourceTextArea.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Exact, ((string)(System.Convert.ChangeType(Data["German"], typeof(string)))));
            
        //}
    
        [CodedStep(@"Verify 'TextContent' 'Exact' '' on 'BuchSpan' - DataDriven: [$(German)]")]
        public void Create_Automated_Web_Tests_CodedStep1()
        {
            // Verify 'TextContent' 'Exact' '$(German)' on 'BuchSpan' - DataDriven: [$(German)]
            Pages.GoogleTranslate0.BuchSpan.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Exact, ((string)(System.Convert.ChangeType(Data["German"], typeof(string)))));
            
        }
    }
}
