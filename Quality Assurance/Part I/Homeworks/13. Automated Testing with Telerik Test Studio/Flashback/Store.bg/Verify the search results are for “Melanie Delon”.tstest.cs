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

    public class Verify_the_search_results_are_for__Melanie_Delon_ : BaseWebAiiTest
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
    
        //[CodedStep(@"Verify 'InnerMarkup' 'Contains' 'Melanie Delon'

 //<table width=100% cellpadding=0 cellspacing=0 class=mc-page-list-container data-screenadapt=main-block>
 //<tbody><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell align=left valign=top><a href=http://www.puzzle.store.bg/p171487/zad-maskata-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '171487 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/171487/zad-maskata-melani-delon-melanie-delon-.jpg width=96 height=68 border=0 style=display:block; alt=Зад маската - Мелани Делон (Melanie Delon) -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.puzzle.store.bg/p171487/zad-maskata-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '171487 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><span class=prdnames prdnames-list itemprop=name>Зад маската</span><br><span class=prdsubnames prdsubnames-list>Мелани Делон (Melanie Delon)</span></a><br>
 //<span class=stext vvftext>Heye</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цена: &nbsp;</span><span class=prices-values-list>25.<span class=prices-valuessupper>80</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=https://www.store.bg/cgi-bin/order.cgi method=get style=display: inline;><input type=submit value=Поръчай class=forms-buttons-order-list onclick=st_updateCartCookie(event, false, st_itemAdded, st_alreadyExists)><input type=hidden name=cartaction value=add><input type=hidden name=contenttype value=p><input type=hidden name=contentid value=220369><input type=hidden name=p value=cart><input type=hidden name=forcetostore value=book><input type=hidden name=srchstr value=Melanie Delon><input type=hidden name=sin value=0><input type=hidden name=sinstore value=2></form></div>
 //<div style=position: relative; float: right;></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <span class=tooltip-activator style=border-bottom-width: 1px; border-bottom-style: dashed; border-bottom-color: rgb(128, 255, 255); cursor: help;><b>Delon</b></span><div class=tooltip><div class=tooltip-type1 data-tooltip-coordinates=(-17;-3)><div class=tooltip-type1-content style=text-align: left; width: 180px><span style=color: #959595>Точно съвпадение:</span> Delon<br><span style=color: #959595>Близки съвпадения:</span> делон</div><div class=tooltip-type1-tl></div><div class=tooltip-type1-t></div><div class=tooltip-type1-tr></div><div class=tooltip-type1-l></div><div class=tooltip-type1-r></div><div class=tooltip-type1-bl></div><div class=tooltip-type1-b></div><div class=tooltip-type1-br></div></div></div> <br></span></td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell align=left valign=top><a href=http://www.puzzle.store.bg/p171488/tri-prystena-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '171488 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/171488/tri-prystena-melani-delon-melanie-delon-.jpg width=77 height=110 border=0 style=display:block; alt=Три пръстена - Мелани Делон (Melanie Delon) -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.puzzle.store.bg/p171488/tri-prystena-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '171488 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><span class=prdnames prdnames-list itemprop=name>Три пръстена</span><br><span class=prdsubnames prdsubnames-list>Мелани Делон (Melanie Delon)</span></a><br>
 //<span class=stext vvftext>Heye</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цена: &nbsp;</span><span class=prices-values-list>25.<span class=prices-valuessupper>80</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=https://www.store.bg/cgi-bin/order.cgi method=get style=display: inline;><input type=submit value=Поръчай class=forms-buttons-order-list onclick=st_updateCartCookie(event, false, st_itemAdded, st_alreadyExists)><input type=hidden name=cartaction value=add><input type=hidden name=contenttype value=p><input type=hidden name=contentid value=220370><input type=hidden name=p value=cart><input type=hidden name=forcetostore value=book><input type=hidden name=srchstr value=Melanie Delon><input type=hidden name=sin value=0><input type=hidden name=sinstore value=2></form></div>
 //<div style=position: relative; float: right;></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <span class=tooltip-activator style=border-bottom-width: 1px; border-bottom-style: dashed; border-bottom-color: rgb(128, 255, 255); cursor: help;><b>Delon</b></span><div class=tooltip><div class=tooltip-type1 data-tooltip-coordinates=(-17;-3)><div class=tooltip-type1-content style=text-align: left; width: 180px><span style=color: #959595>Точно съвпадение:</span> Delon<br><span style=color: #959595>Близки съвпадения:</span> делон</div><div class=tooltip-type1-tl></div><div class=tooltip-type1-t></div><div class=tooltip-type1-tr></div><div class=tooltip-type1-l></div><div class=tooltip-type1-r></div><div class=tooltip-type1-bl></div><div class=tooltip-type1-b></div><div class=tooltip-type1-br></div></div></div> <br></span></td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell align=left valign=top><a href=http://www.puzzle.store.bg/p113345/peperudeni-krile-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '113345 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/113345/peperudeni-krile-melani-delon-melanie-delon-.jpg width=96 height=68 border=0 style=display:block; alt=Пеперудени криле - Мелани Делон (Melanie Delon) -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.puzzle.store.bg/p113345/peperudeni-krile-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '113345 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><span class=prdnames prdnames-list itemprop=name>Пеперудени криле</span><br><span class=prdsubnames prdsubnames-list>Мелани Делон (Melanie Delon)</span></a><br>
 //<span class=stext vvftext>Heye</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цена: &nbsp;</span><span class=prices-values-list>25.<span class=prices-valuessupper>80</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=https://www.store.bg/cgi-bin/order.cgi method=get style=display: inline;><input type=submit value=Поръчай class=forms-buttons-order-list onclick=st_updateCartCookie(event, false, st_itemAdded, st_alreadyExists)><input type=hidden name=cartaction value=add><input type=hidden name=contenttype value=p><input type=hidden name=contentid value=142760><input type=hidden name=p value=cart><input type=hidden name=forcetostore value=book><input type=hidden name=srchstr value=Melanie Delon><input type=hidden name=sin value=0><input type=hidden name=sinstore value=2></form></div>
 //<div style=position: relative; float: right;></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <span class=tooltip-activator style=border-bottom-width: 1px; border-bottom-style: dashed; border-bottom-color: rgb(128, 255, 255); cursor: help;><b>Delon</b></span><div class=tooltip><div class=tooltip-type1 data-tooltip-coordinates=(-17;-3)><div class=tooltip-type1-content style=text-align: left; width: 180px><span style=color: #959595>Точно съвпадение:</span> Delon<br><span style=color: #959595>Близки съвпадения:</span> делон</div><div class=tooltip-type1-tl></div><div class=tooltip-type1-t></div><div class=tooltip-type1-tr></div><div class=tooltip-type1-l></div><div class=tooltip-type1-r></div><div class=tooltip-type1-bl></div><div class=tooltip-type1-b></div><div class=tooltip-type1-br></div></div></div> <br></span></td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell align=left valign=top><a href=http://www.puzzle.store.bg/p88238/otrazhenie-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '88238 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/88238/otrazhenie-melani-delon-melanie-delon-.jpg width=38 height=110 border=0 style=display:block; alt=Отражение - Мелани Делон (Melanie Delon) -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.puzzle.store.bg/p88238/otrazhenie-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '88238 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><span class=prdnames prdnames-list itemprop=name>Отражение</span><br><span class=prdsubnames prdsubnames-list>Мелани Делон (Melanie Delon)</span></a><br>
 //<span class=stext vvftext>Heye</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цена: &nbsp;</span><span class=prices-values-list>28.<span class=prices-valuessupper>00</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=https://www.store.bg/cgi-bin/order.cgi method=get style=display: inline;><input type=submit value=Поръчай class=forms-buttons-order-list onclick=st_updateCartCookie(event, false, st_itemAdded, st_alreadyExists)><input type=hidden name=cartaction value=add><input type=hidden name=contenttype value=p><input type=hidden name=contentid value=107932><input type=hidden name=p value=cart><input type=hidden name=forcetostore value=book><input type=hidden name=srchstr value=Melanie Delon><input type=hidden name=sin value=0><input type=hidden name=sinstore value=2></form></div>
 //<div style=position: relative; float: right;></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <span class=tooltip-activator style=border-bottom-width: 1px; border-bottom-style: dashed; border-bottom-color: rgb(128, 255, 255); cursor: help;><b>Delon</b></span><div class=tooltip><div class=tooltip-type1 data-tooltip-coordinates=(-17;-3)><div class=tooltip-type1-content style=text-align: left; width: 180px><span style=color: #959595>Точно съвпадение:</span> Delon<br><span style=color: #959595>Близки съвпадения:</span> делон</div><div class=tooltip-type1-tl></div><div class=tooltip-type1-t></div><div class=tooltip-type1-tr></div><div class=tooltip-type1-l></div><div class=tooltip-type1-r></div><div class=tooltip-type1-bl></div><div class=tooltip-type1-b></div><div class=tooltip-type1-br></div></div></div> <br></span></td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell align=left valign=top><a href=http://www.puzzle.store.bg/p43693/gora-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '43693 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/43693/gora-melani-delon-melanie-delon-.jpg width=77 height=110 border=0 style=display:block; alt=Гора - Мелани Делон (Melanie Delon) -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.puzzle.store.bg/p43693/gora-melani-delon-melanie-delon-.html onclick=st_Set_Cookie('search_product_data_transfer', '43693 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED', 30, '.store.bg','/', 0, 0);><span class=prdnames prdnames-list itemprop=name>Гора</span><br><span class=prdsubnames prdsubnames-list>Мелани Делон (Melanie Delon)</span></a><br>
 //<span class=stext vvftext>Heye</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цена: &nbsp;</span><span class=prices-values-list>25.<span class=prices-valuessupper>80</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=https://www.store.bg/cgi-bin/order.cgi method=get style=display: inline;><input type=submit value=Поръчай class=forms-buttons-order-list onclick=st_updateCartCookie(event, false, st_itemAdded, st_alreadyExists)><input type=hidden name=cartaction value=add><input type=hidden name=contenttype value=p><input type=hidden name=contentid value=45801><input type=hidden name=p value=cart><input type=hidden name=forcetostore value=book><input type=hidden name=srchstr value=Melanie Delon><input type=hidden name=sin value=0><input type=hidden name=sinstore value=2></form></div>
 //<div style=position: relative; float: right;></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <span class=tooltip-activator style=border-bottom-width: 1px; border-bottom-style: dashed; border-bottom-color: rgb(128, 255, 255); cursor: help;><b>Delon</b></span><div class=tooltip><div class=tooltip-type1 data-tooltip-coordinates=(-17;-3)><div class=tooltip-type1-content style=text-align: left; width: 180px><span style=color: #959595>Точно съвпадение:</span> Delon<br><span style=color: #959595>Близки съвпадения:</span> делон</div><div class=tooltip-type1-tl></div><div class=tooltip-type1-t></div><div class=tooltip-type1-tr></div><div class=tooltip-type1-l></div><div class=tooltip-type1-r></div><div class=tooltip-type1-bl></div><div class=tooltip-type1-b></div><div class=tooltip-type1-br></div></div></div> <br></span></td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr><td colspan=1 style=font-size: 16px;>Следват резултати с непряко съвпадение на Вашето търсене.</td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell-store align=left valign=top><a href=http://www.book.store.bg/p166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166519 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.jpg width=96 height=135 border=0 style=display:block; alt=Prepare! - Ниво 2 (A2): Учебник : Учебна система по английски език - First Edition - Joanna Kosta, Melanie Williams, Annette Capel -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.book.store.bg/p166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166519 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><h3 itemprop=name>Prepare! - Ниво 2 (A2): Учебник<br>Учебна система по английски език - First Edition</h3><br><span class=prdsubnames-store prdsubnames-list><span itemprop=author>Joanna Kosta</span>, <span itemprop=author>Melanie Williams</span>, <span itemprop=author>Annette Capel</span></span></a><br>
 //<span class=stext vvftext>Cambridge University Press</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цени: &nbsp;</span><span class=prices-values-list>33.<span class=prices-valuessupper>90</span><span style=margin-left: 3px; margin-right: 5px;>÷</span>55.<span class=prices-valuessupper>90</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=http://www.book.store.bg/p166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166519 1201777365 Melanie', 30, '.store.bg','/', 0, 0); method=get style=display: inline;><input type=submit value=Виж още class=forms-buttons-moreinfo-list></form></div>
 //<div style=position: relative; float: right;><a href=http://www.book.store.bg/p166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166519 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><img src=http://bg1.base.msrv.stor.bg/b-images/ht-listicons-pages-list.gif width=60 height=45 style=position: relative; margin-top: -8px; float: left; z-index: 222; alt=Тази книга е представена със сканирани страници!></a></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <del style=color: #AAAAAA>Delon</del> <br>Учебникът подготвя за изпита Key English Test. ... Съдържанието на учебника от всяко ниво осигурява материал за 60 до 80 учебни часа. С помощта на допълнителните компоненти от системата учебните часове може да се разширят в интервал от 110 до 160 часа. Всеки учебник в различните нива се състои от уроци, които представят актуални теми и текстове, за да предизвикат интереса на учениците и дори да предизвикат дискусии. Едновременно с това са включени необходимите граматични и лексикални правила. Част от учебния материал са и практическите упражнения, които са разработени с помощта на примери, предоставени от Корпуса за обучение на  <span style=padding-top: 3px; width: 15px; text-align: left;><a href=http://www.book.store.bg/p166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166519 1201777365 Melanie', 30, '.store.bg','/', 0, 0); class=links-readmore-text-store>...<img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=13 height=13 style=display: inline; border=0 alt= class=links-readmore-btn-store></a></span></span></td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell-store align=left valign=top><a href=http://www.book.store.bg/p166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166549 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.jpg width=96 height=135 border=0 style=display:block; alt=Prepare! - Ниво 3 (A2): Учебник : Учебна система по английски език - First Edition - Joanna Kosta, Melanie Williams, Annette Capel -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.book.store.bg/p166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166549 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><h3 itemprop=name>Prepare! - Ниво 3 (A2): Учебник<br>Учебна система по английски език - First Edition</h3><br><span class=prdsubnames-store prdsubnames-list><span itemprop=author>Joanna Kosta</span>, <span itemprop=author>Melanie Williams</span>, <span itemprop=author>Annette Capel</span></span></a><br>
 //<span class=stext vvftext>Cambridge University Press</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цени: &nbsp;</span><span class=prices-values-list>33.<span class=prices-valuessupper>90</span><span style=margin-left: 3px; margin-right: 5px;>÷</span>69.<span class=prices-valuessupper>90</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=http://www.book.store.bg/p166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166549 1201777365 Melanie', 30, '.store.bg','/', 0, 0); method=get style=display: inline;><input type=submit value=Виж още class=forms-buttons-moreinfo-list></form></div>
 //<div style=position: relative; float: right;><a href=http://www.book.store.bg/p166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166549 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><img src=http://bg1.base.msrv.stor.bg/b-images/ht-listicons-pages-list.gif width=60 height=45 style=position: relative; margin-top: -8px; float: left; z-index: 222; alt=Тази книга е представена със сканирани страници!></a></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <del style=color: #AAAAAA>Delon</del> <br>Учебникът подготвя за изпита Key English Test. ... Съдържанието на учебника от всяко ниво осигурява материал за 60 до 80 учебни часа. С помощта на допълнителните компоненти от системата учебните часове може да се разширят в интервал от 110 до 160 часа. Всеки учебник в различните нива се състои от уроци, които представят актуални теми и текстове, за да предизвикат интереса на учениците и дори да предизвикат дискусии. Едновременно с това са включени необходимите граматични и лексикални правила. Част от учебния материал са и практическите упражнения, които са разработени с помощта на примери, предоставени от Корпуса за обучение на  <span style=padding-top: 3px; width: 15px; text-align: left;><a href=http://www.book.store.bg/p166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166549 1201777365 Melanie', 30, '.store.bg','/', 0, 0); class=links-readmore-text-store>...<img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=13 height=13 style=display: inline; border=0 alt= class=links-readmore-btn-store></a></span></span></td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell-store align=left valign=top><a href=http://www.book.store.bg/p166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166458 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.jpg width=96 height=135 border=0 style=display:block; alt=Prepare! - Ниво 1 (A1): Учебник : Учебна система по английски език - First Edition - Joanna Kosta, Melanie Williams, Annette Capel -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.book.store.bg/p166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166458 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><h3 itemprop=name>Prepare! - Ниво 1 (A1): Учебник<br>Учебна система по английски език - First Edition</h3><br><span class=prdsubnames-store prdsubnames-list><span itemprop=author>Joanna Kosta</span>, <span itemprop=author>Melanie Williams</span>, <span itemprop=author>Annette Capel</span></span></a><br>
 //<span class=stext vvftext>Cambridge University Press</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цени: &nbsp;</span><span class=prices-values-list>33.<span class=prices-valuessupper>90</span><span style=margin-left: 3px; margin-right: 5px;>÷</span>55.<span class=prices-valuessupper>90</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=http://www.book.store.bg/p166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166458 1201777365 Melanie', 30, '.store.bg','/', 0, 0); method=get style=display: inline;><input type=submit value=Виж още class=forms-buttons-moreinfo-list></form></div>
 //<div style=position: relative; float: right;><a href=http://www.book.store.bg/p166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166458 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><img src=http://bg1.base.msrv.stor.bg/b-images/ht-listicons-pages-list.gif width=60 height=45 style=position: relative; margin-top: -8px; float: left; z-index: 222; alt=Тази книга е представена със сканирани страници!></a></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <del style=color: #AAAAAA>Delon</del> <br>Съдържанието на учебника от всяко ниво осигурява материал за 60 до 80 учебни часа. С помощта на допълнителните компоненти от системата учебните часове може да се разширят в интервал от 110 до 160 часа. Всеки учебник в различните нива се състои от уроци, които представят актуални теми и текстове, за да предизвикат интереса на учениците и дори да предизвикат дискусии. Едновременно с това са включени необходимите граматични и лексикални правила. Част от учебния материал са и практическите упражнения, които са разработени с помощта на примери, предоставени от Корпуса за обучение на Кеймбридж. Задачите се фокусират върху ключови проблемни сфери,  <span style=padding-top: 3px; width: 15px; text-align: left;><a href=http://www.book.store.bg/p166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166458 1201777365 Melanie', 30, '.store.bg','/', 0, 0); class=links-readmore-text-store>...<img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=13 height=13 style=display: inline; border=0 alt= class=links-readmore-btn-store></a></span></span></td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell-store align=left valign=top><a href=http://www.book.store.bg/p57793/kid-s-box-uchebna-sistema-po-anglijski-ezik-nivo-6-rykovodstvo-za-uchitelia-melanie-williams-caroline-nixon-michael-tomlinson.html onclick=st_Set_Cookie('search_product_data_transfer', '57793 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/57793/kid-s-box-uchebna-sistema-po-anglijski-ezik-nivo-6-rykovodstvo-za-uchitelia-melanie-williams-caroline-nixon-michael-tomlinson.jpg width=96 height=120 border=0 style=display:block; alt=Kid's Box: Учебна система по английски език : Ниво 6: Ръководство за учителя - Melanie Williams, Caroline Nixon, Michael Tomlinson -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.book.store.bg/p57793/kid-s-box-uchebna-sistema-po-anglijski-ezik-nivo-6-rykovodstvo-za-uchitelia-melanie-williams-caroline-nixon-michael-tomlinson.html onclick=st_Set_Cookie('search_product_data_transfer', '57793 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><h3 itemprop=name>Kid's Box: Учебна система по английски език<br>Ниво 6: Ръководство за учителя</h3><br><span class=prdsubnames-store prdsubnames-list><span itemprop=author>Melanie Williams</span>, <span itemprop=author>Caroline Nixon</span>, <span itemprop=author>Michael Tomlinson</span></span></a><br>
 //<span class=stext vvftext>Cambridge University Press</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цена: &nbsp;</span><span class=prices-values-list>32.<span class=prices-valuessupper>90</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=https://www.store.bg/cgi-bin/order.cgi method=get style=display: inline;><input type=submit value=Поръчай class=forms-buttons-order-list onclick=st_updateCartCookie(event, false, st_itemAdded, st_alreadyExists)><input type=hidden name=cartaction value=add><input type=hidden name=contenttype value=p><input type=hidden name=contentid value=60883><input type=hidden name=p value=cart><input type=hidden name=forcetostore value=book><input type=hidden name=srchstr value=Melanie Delon><input type=hidden name=sin value=0><input type=hidden name=sinstore value=2></form></div>
 //<div style=position: relative; float: right;><a href=http://www.book.store.bg/p57793/kid-s-box-uchebna-sistema-po-anglijski-ezik-nivo-6-rykovodstvo-za-uchitelia-melanie-williams-caroline-nixon-michael-tomlinson.html onclick=st_Set_Cookie('search_product_data_transfer', '57793 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><img src=http://bg1.base.msrv.stor.bg/b-images/ht-listicons-pages-list.gif width=60 height=45 style=position: relative; margin-top: -8px; float: left; z-index: 222; alt=Тази книга е представена със сканирани страници!></a></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <del style=color: #AAAAAA>Delon</del> <br>За Kid's BoxKid's Box е учебна система по английски език, одобрена от МОМН със Заповед №РД 09-219/27.02.2013 г. и подходяща за обучение на учениците от 1. до 4. клас. Напълно съвместима с Общата европейска езикова рамка, тя целенасочено подготвя за сертификатните тестове YLE (Young Learners English Tests).Учебната система се състои от следните нива:ниво 1 – подходящо за начинаещи без никакви познания по езиканиво 2 – извежда до А1 и учениците натрупват основни знанияниво 3 – покрива А1ниво 4 – покрива А1 докрайниво 5 – покрива А2ниво 6 – покрива А2 докрайВсяко от нивата предоставя практическа подготовка за  <span style=padding-top: 3px; width: 15px; text-align: left;><a href=http://www.book.store.bg/p57793/kid-s-box-uchebna-sistema-po-anglijski-ezik-nivo-6-rykovodstvo-za-uchitelia-melanie-williams-caroline-nixon-michael-tomlinson.html onclick=st_Set_Cookie('search_product_data_transfer', '57793 1201777365 Melanie', 30, '.store.bg','/', 0, 0); class=links-readmore-text-store>...<img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=13 height=13 style=display: inline; border=0 alt= class=links-readmore-btn-store></a></span></span></td></tr><tr class=mc-page-list-delimiter><td style=position: relative; clear: both;><div class=mc-page-list-delimiter-t1><img src=http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif height=1 class=mc-page-product-delimiter-img></div></td></tr><tr data-screenadapt=row><td data-screenadapt=cell align=left valign=top style=padding-right: 47px;> <table cellpadding=0 cellspacing=0 style=width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;><tbody><tr><td valign=middle align=center><table cellpadding=0 cellspacing=0><tbody><tr><td class=product-image-cell-store align=left valign=top><a href=http://www.book.store.bg/p166539/prepare-nivo-3-a2-2-cd-s-audiomateriali-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166539 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><img src=http://bg1.ms01.st.msrv.stor.bg/lstimg/166539/prepare-nivo-3-a2-2-cd-s-audiomateriali-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.jpg width=96 height=95 border=0 style=display:block; alt=Prepare! - Ниво 3 (A2): 2 CD с аудиоматериали : Учебна система по английски език - First Edition - Joanna Kosta, Melanie Williams, Annette Capel -  data-screenadapt=box-product-img></a></td><td class=product-image-cell-r align=left valign=top></td></tr><tr><td class=product-image-cell-b align=left valign=top></td><td class=product-image-cell-br align=left valign=top><img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=2 height=2 style=display:block; alt=></td></tr></tbody></table></td></tr></tbody></table>
 //<a href=http://www.book.store.bg/p166539/prepare-nivo-3-a2-2-cd-s-audiomateriali-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166539 1201777365 Melanie', 30, '.store.bg','/', 0, 0);><h3 itemprop=name>Prepare! - Ниво 3 (A2): 2 CD с аудиоматериали<br>Учебна система по английски език - First Edition</h3><br><span class=prdsubnames-store prdsubnames-list><span itemprop=author>Joanna Kosta</span>, <span itemprop=author>Melanie Williams</span>, <span itemprop=author>Annette Capel</span></span></a><br>
 //<span class=stext vvftext>Cambridge University Press</span>
 //<div style=margin: 7px 0px 55px 0px;>
 //<div style=position: relative; float: left; width: 270px;><span class=prices-texts-list>Цена при носител <b>CD</b>: &nbsp;</span><span class=prices-values-list>32.<span class=prices-valuessupper>90</span></span><span class=prices-texts-list> лв.</span></div>
 //<div style=margin-top: 8px; float: left;><form action=https://www.store.bg/cgi-bin/order.cgi method=get style=display: inline;><input type=submit value=Поръчай class=forms-buttons-order-list onclick=st_updateCartCookie(event, false, st_itemAdded, st_alreadyExists)><input type=hidden name=cartaction value=add><input type=hidden name=contenttype value=p><input type=hidden name=contentid value=214457><input type=hidden name=p value=cart><input type=hidden name=forcetostore value=book><input type=hidden name=srchstr value=Melanie Delon><input type=hidden name=sin value=0><input type=hidden name=sinstore value=2></form></div>
 //<div style=position: relative; float: right;></div>
 //</div>
 //<span class=ftext style=margin-right: 5px;><span style=color: #000000>Съвпадение за:</span> <b>Melanie</b> <del style=color: #AAAAAA>Delon</del> <br>Аудиодисковете подготвят за изпита Key English Test. ... Необходимите аудиоматериали за всички задачи за слушане и правилно произношение в учебника са включени в настоящия комплект от 2 CD-та, които пълноценно допълват учебната дейност на обучаващите се по системата Prepare!.

//Учебната система Prepare! - First Edition се състои от:

//учебник
//учебна тетрадка
//книга за учителя + DVD
//2 CD с аудиоматериали
 //<span style=padding-top: 3px; width: 15px; text-align: left;><a href=http://www.book.store.bg/p166539/prepare-nivo-3-a2-2-cd-s-audiomateriali-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html onclick=st_Set_Cookie('search_product_data_transfer', '166539 1201777365 Melanie', 30, '.store.bg','/', 0, 0); class=links-readmore-text-store>...<img src=http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif width=13 height=13 style=display: inline; border=0 alt= class=links-readmore-btn-store></a></span></span></td></tr>
 //</tbody></table>
 //' on 'Div'")]
        //public void Verify_the_search_results_are_for_Melanie_Delon_CodedStep()
        //{
            //// Verify 'InnerMarkup' 'Contains' 'Melanie Delon'
            //Pages.StoreBgКнигиMelanie.Div.AssertContent().InnerMarkup(ArtOfTest.Common.StringCompareType.Contains, "Melanie Delon\n\n <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" class=\"mc-pag" +
                            //"e-list-container\" data-screenadapt=\"main-block\">\n <tbody><tr data-screenadapt=\"r" +
                            //"ow\"><td data-screenadapt=\"cell\" align=\"left\" valign=\"top\" style=\"padding-right: " +
                            //"47px;\"> <table cellpadding=\"0\" cellspacing=\"0\" style=\"width: 100px; height: 100p" +
                            //"x; margin: 0px 20px 10px 0px; border: 0px; padding: 0px; float: left;\"><tbody><t" +
                            //"r><td valign=\"middle\" align=\"center\"><table cellpadding=\"0\" cellspacing=\"0\"><tbo" +
                            //"dy><tr><td class=\"product-image-cell\" align=\"left\" valign=\"top\"><a href=\"http://" +
                            //"www.puzzle.store.bg/p171487/zad-maskata-melani-delon-melanie-delon-.html\" onclic" +
                            //"k=\"st_Set_Cookie(\'search_product_data_transfer\', \'171487 1201777365 Melanie%20De" +
                            //"lon%20%E4%E5%EB%EE%ED\', 30, \'.store.bg\',\'/\', 0, 0);\"><img src=\"http://bg1.ms01.s" +
                            //"t.msrv.stor.bg/lstimg/171487/zad-maskata-melani-delon-melanie-delon-.jpg\" width=" +
                            //"\"96\" height=\"68\" border=\"0\" style=\"display:block;\" alt=\"Зад маската - Мелани Дел" +
                            //"он (Melanie Delon) - \" data-screenadapt=\"box-product-img\"></a></td><td class=\"pr" +
                            //"oduct-image-cell-r\" align=\"left\" valign=\"top\"></td></tr><tr><td class=\"product-i" +
                            //"mage-cell-b\" align=\"left\" valign=\"top\"></td><td class=\"product-image-cell-br\" al" +
                            //"ign=\"left\" valign=\"top\"><img src=\"http://bg1.base.msrv.stor.bg/b-images/quad-tra" +
                            //"nsp.gif\" width=\"2\" height=\"2\" style=\"display:block;\" alt=\"\"></td></tr></tbody></" +
                            //"table></td></tr></tbody></table>\n <a href=\"http://www.puzzle.store.bg/p171487/za" +
                            //"d-maskata-melani-delon-melanie-delon-.html\" onclick=\"st_Set_Cookie(\'search_produ" +
                            //"ct_data_transfer\', \'171487 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED\', 30, \'." +
                            //"store.bg\',\'/\', 0, 0);\"><span class=\"prdnames prdnames-list\" itemprop=\"name\">Зад " +
                            //"маската</span><br><span class=\"prdsubnames prdsubnames-list\">Мелани Делон (Melan" +
                            //"ie Delon)</span></a><br>\n <span class=\"stext vvftext\">Heye</span>\n <div style=\"m" +
                            //"argin: 7px 0px 55px 0px;\">\n <div style=\"position: relative; float: left; width: " +
                            //"270px;\"><span class=\"prices-texts-list\">Цена: &nbsp;</span><span class=\"prices-v" +
                            //"alues-list\">25.<span class=\"prices-valuessupper\">80</span></span><span class=\"pr" +
                            //"ices-texts-list\"> лв.</span></div>\n <div style=\"margin-top: 8px; float: left;\"><" +
                            //"form action=\"https://www.store.bg/cgi-bin/order.cgi\" method=\"get\" style=\"display" +
                            //": inline;\"><input type=\"submit\" value=\"Поръчай\" class=\"forms-buttons-order-list\"" +
                            //" onclick=\"st_updateCartCookie(event, false, st_itemAdded, st_alreadyExists)\"><in" +
                            //"put type=\"hidden\" name=\"cartaction\" value=\"add\"><input type=\"hidden\" name=\"conte" +
                            //"nttype\" value=\"p\"><input type=\"hidden\" name=\"contentid\" value=\"220369\"><input ty" +
                            //"pe=\"hidden\" name=\"p\" value=\"cart\"><input type=\"hidden\" name=\"forcetostore\" value" +
                            //"=\"book\"><input type=\"hidden\" name=\"srchstr\" value=\"Melanie Delon\"><input type=\"h" +
                            //"idden\" name=\"sin\" value=\"0\"><input type=\"hidden\" name=\"sinstore\" value=\"2\"></for" +
                            //"m></div>\n <div style=\"position: relative; float: right;\"></div>\n </div>\n <span c" +
                            //"lass=\"ftext\" style=\"margin-right: 5px;\"><span style=\"color: #000000\">Съвпадение " +
                            //"за:</span> <b>Melanie</b> <span class=\"tooltip-activator\" style=\"border-bottom-w" +
                            //"idth: 1px; border-bottom-style: dashed; border-bottom-color: rgb(128, 255, 255);" +
                            //" cursor: help;\"><b>Delon</b></span><div class=\"tooltip\"><div class=\"tooltip-type" +
                            //"1\" data-tooltip-coordinates=\"(-17;-3)\"><div class=\"tooltip-type1-content\" style=" +
                            //"\"text-align: left; width: 180px\"><span style=\"color: #959595\">Точно съвпадение:<" +
                            //"/span> Delon<br><span style=\"color: #959595\">Близки съвпадения:</span> делон</di" +
                            //"v><div class=\"tooltip-type1-tl\"></div><div class=\"tooltip-type1-t\"></div><div cl" +
                            //"ass=\"tooltip-type1-tr\"></div><div class=\"tooltip-type1-l\"></div><div class=\"tool" +
                            //"tip-type1-r\"></div><div class=\"tooltip-type1-bl\"></div><div class=\"tooltip-type1" +
                            //"-b\"></div><div class=\"tooltip-type1-br\"></div></div></div> <br></span></td></tr>" +
                            //"<tr class=\"mc-page-list-delimiter\"><td style=\"position: relative; clear: both;\">" +
                            //"<div class=\"mc-page-list-delimiter-t1\"><img src=\"http://bg1.base.msrv.stor.bg/b-" +
                            //"images/ht-mc-page-list-delimiter-t1-h.gif\" height=\"1\" class=\"mc-page-product-del" +
                            //"imiter-img\"></div></td></tr><tr data-screenadapt=\"row\"><td data-screenadapt=\"cel" +
                            //"l\" align=\"left\" valign=\"top\" style=\"padding-right: 47px;\"> <table cellpadding=\"0" +
                            //"\" cellspacing=\"0\" style=\"width: 100px; height: 100px; margin: 0px 20px 10px 0px;" +
                            //" border: 0px; padding: 0px; float: left;\"><tbody><tr><td valign=\"middle\" align=\"" +
                            //"center\"><table cellpadding=\"0\" cellspacing=\"0\"><tbody><tr><td class=\"product-ima" +
                            //"ge-cell\" align=\"left\" valign=\"top\"><a href=\"http://www.puzzle.store.bg/p171488/t" +
                            //"ri-prystena-melani-delon-melanie-delon-.html\" onclick=\"st_Set_Cookie(\'search_pro" +
                            //"duct_data_transfer\', \'171488 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED\', 30, " +
                            //"\'.store.bg\',\'/\', 0, 0);\"><img src=\"http://bg1.ms01.st.msrv.stor.bg/lstimg/171488" +
                            //"/tri-prystena-melani-delon-melanie-delon-.jpg\" width=\"77\" height=\"110\" border=\"0" +
                            //"\" style=\"display:block;\" alt=\"Три пръстена - Мелани Делон (Melanie Delon) - \" da" +
                            //"ta-screenadapt=\"box-product-img\"></a></td><td class=\"product-image-cell-r\" align" +
                            //"=\"left\" valign=\"top\"></td></tr><tr><td class=\"product-image-cell-b\" align=\"left\"" +
                            //" valign=\"top\"></td><td class=\"product-image-cell-br\" align=\"left\" valign=\"top\"><" +
                            //"img src=\"http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif\" width=\"2\" height" +
                            //"=\"2\" style=\"display:block;\" alt=\"\"></td></tr></tbody></table></td></tr></tbody><" +
                            //"/table>\n <a href=\"http://www.puzzle.store.bg/p171488/tri-prystena-melani-delon-m" +
                            //"elanie-delon-.html\" onclick=\"st_Set_Cookie(\'search_product_data_transfer\', \'1714" +
                            //"88 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED\', 30, \'.store.bg\',\'/\', 0, 0);\"><" +
                            //"span class=\"prdnames prdnames-list\" itemprop=\"name\">Три пръстена</span><br><span" +
                            //" class=\"prdsubnames prdsubnames-list\">Мелани Делон (Melanie Delon)</span></a><br" +
                            //">\n <span class=\"stext vvftext\">Heye</span>\n <div style=\"margin: 7px 0px 55px 0px" +
                            //";\">\n <div style=\"position: relative; float: left; width: 270px;\"><span class=\"pr" +
                            //"ices-texts-list\">Цена: &nbsp;</span><span class=\"prices-values-list\">25.<span cl" +
                            //"ass=\"prices-valuessupper\">80</span></span><span class=\"prices-texts-list\"> лв.</" +
                            //"span></div>\n <div style=\"margin-top: 8px; float: left;\"><form action=\"https://ww" +
                            //"w.store.bg/cgi-bin/order.cgi\" method=\"get\" style=\"display: inline;\"><input type=" +
                            //"\"submit\" value=\"Поръчай\" class=\"forms-buttons-order-list\" onclick=\"st_updateCart" +
                            //"Cookie(event, false, st_itemAdded, st_alreadyExists)\"><input type=\"hidden\" name=" +
                            //"\"cartaction\" value=\"add\"><input type=\"hidden\" name=\"contenttype\" value=\"p\"><inpu" +
                            //"t type=\"hidden\" name=\"contentid\" value=\"220370\"><input type=\"hidden\" name=\"p\" va" +
                            //"lue=\"cart\"><input type=\"hidden\" name=\"forcetostore\" value=\"book\"><input type=\"hi" +
                            //"dden\" name=\"srchstr\" value=\"Melanie Delon\"><input type=\"hidden\" name=\"sin\" value" +
                            //"=\"0\"><input type=\"hidden\" name=\"sinstore\" value=\"2\"></form></div>\n <div style=\"p" +
                            //"osition: relative; float: right;\"></div>\n </div>\n <span class=\"ftext\" style=\"mar" +
                            //"gin-right: 5px;\"><span style=\"color: #000000\">Съвпадение за:</span> <b>Melanie</" +
                            //"b> <span class=\"tooltip-activator\" style=\"border-bottom-width: 1px; border-botto" +
                            //"m-style: dashed; border-bottom-color: rgb(128, 255, 255); cursor: help;\"><b>Delo" +
                            //"n</b></span><div class=\"tooltip\"><div class=\"tooltip-type1\" data-tooltip-coordin" +
                            //"ates=\"(-17;-3)\"><div class=\"tooltip-type1-content\" style=\"text-align: left; widt" +
                            //"h: 180px\"><span style=\"color: #959595\">Точно съвпадение:</span> Delon<br><span s" +
                            //"tyle=\"color: #959595\">Близки съвпадения:</span> делон</div><div class=\"tooltip-t" +
                            //"ype1-tl\"></div><div class=\"tooltip-type1-t\"></div><div class=\"tooltip-type1-tr\">" +
                            //"</div><div class=\"tooltip-type1-l\"></div><div class=\"tooltip-type1-r\"></div><div" +
                            //" class=\"tooltip-type1-bl\"></div><div class=\"tooltip-type1-b\"></div><div class=\"t" +
                            //"ooltip-type1-br\"></div></div></div> <br></span></td></tr><tr class=\"mc-page-list" +
                            //"-delimiter\"><td style=\"position: relative; clear: both;\"><div class=\"mc-page-lis" +
                            //"t-delimiter-t1\"><img src=\"http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-" +
                            //"delimiter-t1-h.gif\" height=\"1\" class=\"mc-page-product-delimiter-img\"></div></td>" +
                            //"</tr><tr data-screenadapt=\"row\"><td data-screenadapt=\"cell\" align=\"left\" valign=" +
                            //"\"top\" style=\"padding-right: 47px;\"> <table cellpadding=\"0\" cellspacing=\"0\" style" +
                            //"=\"width: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: " +
                            //"0px; float: left;\"><tbody><tr><td valign=\"middle\" align=\"center\"><table cellpadd" +
                            //"ing=\"0\" cellspacing=\"0\"><tbody><tr><td class=\"product-image-cell\" align=\"left\" v" +
                            //"align=\"top\"><a href=\"http://www.puzzle.store.bg/p113345/peperudeni-krile-melani-" +
                            //"delon-melanie-delon-.html\" onclick=\"st_Set_Cookie(\'search_product_data_transfer\'" +
                            //", \'113345 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED\', 30, \'.store.bg\',\'/\', 0," +
                            //" 0);\"><img src=\"http://bg1.ms01.st.msrv.stor.bg/lstimg/113345/peperudeni-krile-m" +
                            //"elani-delon-melanie-delon-.jpg\" width=\"96\" height=\"68\" border=\"0\" style=\"display" +
                            //":block;\" alt=\"Пеперудени криле - Мелани Делон (Melanie Delon) - \" data-screenada" +
                            //"pt=\"box-product-img\"></a></td><td class=\"product-image-cell-r\" align=\"left\" vali" +
                            //"gn=\"top\"></td></tr><tr><td class=\"product-image-cell-b\" align=\"left\" valign=\"top" +
                            //"\"></td><td class=\"product-image-cell-br\" align=\"left\" valign=\"top\"><img src=\"htt" +
                            //"p://bg1.base.msrv.stor.bg/b-images/quad-transp.gif\" width=\"2\" height=\"2\" style=\"" +
                            //"display:block;\" alt=\"\"></td></tr></tbody></table></td></tr></tbody></table>\n <a " +
                            //"href=\"http://www.puzzle.store.bg/p113345/peperudeni-krile-melani-delon-melanie-d" +
                            //"elon-.html\" onclick=\"st_Set_Cookie(\'search_product_data_transfer\', \'113345 12017" +
                            //"77365 Melanie%20Delon%20%E4%E5%EB%EE%ED\', 30, \'.store.bg\',\'/\', 0, 0);\"><span cla" +
                            //"ss=\"prdnames prdnames-list\" itemprop=\"name\">Пеперудени криле</span><br><span cla" +
                            //"ss=\"prdsubnames prdsubnames-list\">Мелани Делон (Melanie Delon)</span></a><br>\n <" +
                            //"span class=\"stext vvftext\">Heye</span>\n <div style=\"margin: 7px 0px 55px 0px;\">\n" +
                            //" <div style=\"position: relative; float: left; width: 270px;\"><span class=\"prices" +
                            //"-texts-list\">Цена: &nbsp;</span><span class=\"prices-values-list\">25.<span class=" +
                            //"\"prices-valuessupper\">80</span></span><span class=\"prices-texts-list\"> лв.</span" +
                            //"></div>\n <div style=\"margin-top: 8px; float: left;\"><form action=\"https://www.st" +
                            //"ore.bg/cgi-bin/order.cgi\" method=\"get\" style=\"display: inline;\"><input type=\"sub" +
                            //"mit\" value=\"Поръчай\" class=\"forms-buttons-order-list\" onclick=\"st_updateCartCook" +
                            //"ie(event, false, st_itemAdded, st_alreadyExists)\"><input type=\"hidden\" name=\"car" +
                            //"taction\" value=\"add\"><input type=\"hidden\" name=\"contenttype\" value=\"p\"><input ty" +
                            //"pe=\"hidden\" name=\"contentid\" value=\"142760\"><input type=\"hidden\" name=\"p\" value=" +
                            //"\"cart\"><input type=\"hidden\" name=\"forcetostore\" value=\"book\"><input type=\"hidden" +
                            //"\" name=\"srchstr\" value=\"Melanie Delon\"><input type=\"hidden\" name=\"sin\" value=\"0\"" +
                            //"><input type=\"hidden\" name=\"sinstore\" value=\"2\"></form></div>\n <div style=\"posit" +
                            //"ion: relative; float: right;\"></div>\n </div>\n <span class=\"ftext\" style=\"margin-" +
                            //"right: 5px;\"><span style=\"color: #000000\">Съвпадение за:</span> <b>Melanie</b> <" +
                            //"span class=\"tooltip-activator\" style=\"border-bottom-width: 1px; border-bottom-st" +
                            //"yle: dashed; border-bottom-color: rgb(128, 255, 255); cursor: help;\"><b>Delon</b" +
                            //"></span><div class=\"tooltip\"><div class=\"tooltip-type1\" data-tooltip-coordinates" +
                            //"=\"(-17;-3)\"><div class=\"tooltip-type1-content\" style=\"text-align: left; width: 1" +
                            //"80px\"><span style=\"color: #959595\">Точно съвпадение:</span> Delon<br><span style" +
                            //"=\"color: #959595\">Близки съвпадения:</span> делон</div><div class=\"tooltip-type1" +
                            //"-tl\"></div><div class=\"tooltip-type1-t\"></div><div class=\"tooltip-type1-tr\"></di" +
                            //"v><div class=\"tooltip-type1-l\"></div><div class=\"tooltip-type1-r\"></div><div cla" +
                            //"ss=\"tooltip-type1-bl\"></div><div class=\"tooltip-type1-b\"></div><div class=\"toolt" +
                            //"ip-type1-br\"></div></div></div> <br></span></td></tr><tr class=\"mc-page-list-del" +
                            //"imiter\"><td style=\"position: relative; clear: both;\"><div class=\"mc-page-list-de" +
                            //"limiter-t1\"><img src=\"http://bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-deli" +
                            //"miter-t1-h.gif\" height=\"1\" class=\"mc-page-product-delimiter-img\"></div></td></tr" +
                            //"><tr data-screenadapt=\"row\"><td data-screenadapt=\"cell\" align=\"left\" valign=\"top" +
                            //"\" style=\"padding-right: 47px;\"> <table cellpadding=\"0\" cellspacing=\"0\" style=\"wi" +
                            //"dth: 100px; height: 100px; margin: 0px 20px 10px 0px; border: 0px; padding: 0px;" +
                            //" float: left;\"><tbody><tr><td valign=\"middle\" align=\"center\"><table cellpadding=" +
                            //"\"0\" cellspacing=\"0\"><tbody><tr><td class=\"product-image-cell\" align=\"left\" valig" +
                            //"n=\"top\"><a href=\"http://www.puzzle.store.bg/p88238/otrazhenie-melani-delon-melan" +
                            //"ie-delon-.html\" onclick=\"st_Set_Cookie(\'search_product_data_transfer\', \'88238 12" +
                            //"01777365 Melanie%20Delon%20%E4%E5%EB%EE%ED\', 30, \'.store.bg\',\'/\', 0, 0);\"><img s" +
                            //"rc=\"http://bg1.ms01.st.msrv.stor.bg/lstimg/88238/otrazhenie-melani-delon-melanie" +
                            //"-delon-.jpg\" width=\"38\" height=\"110\" border=\"0\" style=\"display:block;\" alt=\"Отра" +
                            //"жение - Мелани Делон (Melanie Delon) - \" data-screenadapt=\"box-product-img\"></a>" +
                            //"</td><td class=\"product-image-cell-r\" align=\"left\" valign=\"top\"></td></tr><tr><t" +
                            //"d class=\"product-image-cell-b\" align=\"left\" valign=\"top\"></td><td class=\"product" +
                            //"-image-cell-br\" align=\"left\" valign=\"top\"><img src=\"http://bg1.base.msrv.stor.bg" +
                            //"/b-images/quad-transp.gif\" width=\"2\" height=\"2\" style=\"display:block;\" alt=\"\"></" +
                            //"td></tr></tbody></table></td></tr></tbody></table>\n <a href=\"http://www.puzzle.s" +
                            //"tore.bg/p88238/otrazhenie-melani-delon-melanie-delon-.html\" onclick=\"st_Set_Cook" +
                            //"ie(\'search_product_data_transfer\', \'88238 1201777365 Melanie%20Delon%20%E4%E5%EB" +
                            //"%EE%ED\', 30, \'.store.bg\',\'/\', 0, 0);\"><span class=\"prdnames prdnames-list\" itemp" +
                            //"rop=\"name\">Отражение</span><br><span class=\"prdsubnames prdsubnames-list\">Мелани" +
                            //" Делон (Melanie Delon)</span></a><br>\n <span class=\"stext vvftext\">Heye</span>\n " +
                            //"<div style=\"margin: 7px 0px 55px 0px;\">\n <div style=\"position: relative; float: " +
                            //"left; width: 270px;\"><span class=\"prices-texts-list\">Цена: &nbsp;</span><span cl" +
                            //"ass=\"prices-values-list\">28.<span class=\"prices-valuessupper\">00</span></span><s" +
                            //"pan class=\"prices-texts-list\"> лв.</span></div>\n <div style=\"margin-top: 8px; fl" +
                            //"oat: left;\"><form action=\"https://www.store.bg/cgi-bin/order.cgi\" method=\"get\" s" +
                            //"tyle=\"display: inline;\"><input type=\"submit\" value=\"Поръчай\" class=\"forms-button" +
                            //"s-order-list\" onclick=\"st_updateCartCookie(event, false, st_itemAdded, st_alread" +
                            //"yExists)\"><input type=\"hidden\" name=\"cartaction\" value=\"add\"><input type=\"hidden" +
                            //"\" name=\"contenttype\" value=\"p\"><input type=\"hidden\" name=\"contentid\" value=\"1079" +
                            //"32\"><input type=\"hidden\" name=\"p\" value=\"cart\"><input type=\"hidden\" name=\"forcet" +
                            //"ostore\" value=\"book\"><input type=\"hidden\" name=\"srchstr\" value=\"Melanie Delon\"><" +
                            //"input type=\"hidden\" name=\"sin\" value=\"0\"><input type=\"hidden\" name=\"sinstore\" va" +
                            //"lue=\"2\"></form></div>\n <div style=\"position: relative; float: right;\"></div>\n </" +
                            //"div>\n <span class=\"ftext\" style=\"margin-right: 5px;\"><span style=\"color: #000000" +
                            //"\">Съвпадение за:</span> <b>Melanie</b> <span class=\"tooltip-activator\" style=\"bo" +
                            //"rder-bottom-width: 1px; border-bottom-style: dashed; border-bottom-color: rgb(12" +
                            //"8, 255, 255); cursor: help;\"><b>Delon</b></span><div class=\"tooltip\"><div class=" +
                            //"\"tooltip-type1\" data-tooltip-coordinates=\"(-17;-3)\"><div class=\"tooltip-type1-co" +
                            //"ntent\" style=\"text-align: left; width: 180px\"><span style=\"color: #959595\">Точно" +
                            //" съвпадение:</span> Delon<br><span style=\"color: #959595\">Близки съвпадения:</sp" +
                            //"an> делон</div><div class=\"tooltip-type1-tl\"></div><div class=\"tooltip-type1-t\">" +
                            //"</div><div class=\"tooltip-type1-tr\"></div><div class=\"tooltip-type1-l\"></div><di" +
                            //"v class=\"tooltip-type1-r\"></div><div class=\"tooltip-type1-bl\"></div><div class=\"" +
                            //"tooltip-type1-b\"></div><div class=\"tooltip-type1-br\"></div></div></div> <br></sp" +
                            //"an></td></tr><tr class=\"mc-page-list-delimiter\"><td style=\"position: relative; c" +
                            //"lear: both;\"><div class=\"mc-page-list-delimiter-t1\"><img src=\"http://bg1.base.ms" +
                            //"rv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif\" height=\"1\" class=\"mc-pag" +
                            //"e-product-delimiter-img\"></div></td></tr><tr data-screenadapt=\"row\"><td data-scr" +
                            //"eenadapt=\"cell\" align=\"left\" valign=\"top\" style=\"padding-right: 47px;\"> <table c" +
                            //"ellpadding=\"0\" cellspacing=\"0\" style=\"width: 100px; height: 100px; margin: 0px 2" +
                            //"0px 10px 0px; border: 0px; padding: 0px; float: left;\"><tbody><tr><td valign=\"mi" +
                            //"ddle\" align=\"center\"><table cellpadding=\"0\" cellspacing=\"0\"><tbody><tr><td class" +
                            //"=\"product-image-cell\" align=\"left\" valign=\"top\"><a href=\"http://www.puzzle.store" +
                            //".bg/p43693/gora-melani-delon-melanie-delon-.html\" onclick=\"st_Set_Cookie(\'search" +
                            //"_product_data_transfer\', \'43693 1201777365 Melanie%20Delon%20%E4%E5%EB%EE%ED\', 3" +
                            //"0, \'.store.bg\',\'/\', 0, 0);\"><img src=\"http://bg1.ms01.st.msrv.stor.bg/lstimg/436" +
                            //"93/gora-melani-delon-melanie-delon-.jpg\" width=\"77\" height=\"110\" border=\"0\" styl" +
                            //"e=\"display:block;\" alt=\"Гора - Мелани Делон (Melanie Delon) - \" data-screenadapt" +
                            //"=\"box-product-img\"></a></td><td class=\"product-image-cell-r\" align=\"left\" valign" +
                            //"=\"top\"></td></tr><tr><td class=\"product-image-cell-b\" align=\"left\" valign=\"top\">" +
                            //"</td><td class=\"product-image-cell-br\" align=\"left\" valign=\"top\"><img src=\"http:" +
                            //"//bg1.base.msrv.stor.bg/b-images/quad-transp.gif\" width=\"2\" height=\"2\" style=\"di" +
                            //"splay:block;\" alt=\"\"></td></tr></tbody></table></td></tr></tbody></table>\n <a hr" +
                            //"ef=\"http://www.puzzle.store.bg/p43693/gora-melani-delon-melanie-delon-.html\" onc" +
                            //"lick=\"st_Set_Cookie(\'search_product_data_transfer\', \'43693 1201777365 Melanie%20" +
                            //"Delon%20%E4%E5%EB%EE%ED\', 30, \'.store.bg\',\'/\', 0, 0);\"><span class=\"prdnames prd" +
                            //"names-list\" itemprop=\"name\">Гора</span><br><span class=\"prdsubnames prdsubnames-" +
                            //"list\">Мелани Делон (Melanie Delon)</span></a><br>\n <span class=\"stext vvftext\">H" +
                            //"eye</span>\n <div style=\"margin: 7px 0px 55px 0px;\">\n <div style=\"position: relat" +
                            //"ive; float: left; width: 270px;\"><span class=\"prices-texts-list\">Цена: &nbsp;</s" +
                            //"pan><span class=\"prices-values-list\">25.<span class=\"prices-valuessupper\">80</sp" +
                            //"an></span><span class=\"prices-texts-list\"> лв.</span></div>\n <div style=\"margin-" +
                            //"top: 8px; float: left;\"><form action=\"https://www.store.bg/cgi-bin/order.cgi\" me" +
                            //"thod=\"get\" style=\"display: inline;\"><input type=\"submit\" value=\"Поръчай\" class=\"" +
                            //"forms-buttons-order-list\" onclick=\"st_updateCartCookie(event, false, st_itemAdde" +
                            //"d, st_alreadyExists)\"><input type=\"hidden\" name=\"cartaction\" value=\"add\"><input " +
                            //"type=\"hidden\" name=\"contenttype\" value=\"p\"><input type=\"hidden\" name=\"contentid\"" +
                            //" value=\"45801\"><input type=\"hidden\" name=\"p\" value=\"cart\"><input type=\"hidden\" n" +
                            //"ame=\"forcetostore\" value=\"book\"><input type=\"hidden\" name=\"srchstr\" value=\"Melan" +
                            //"ie Delon\"><input type=\"hidden\" name=\"sin\" value=\"0\"><input type=\"hidden\" name=\"s" +
                            //"instore\" value=\"2\"></form></div>\n <div style=\"position: relative; float: right;\"" +
                            //"></div>\n </div>\n <span class=\"ftext\" style=\"margin-right: 5px;\"><span style=\"col" +
                            //"or: #000000\">Съвпадение за:</span> <b>Melanie</b> <span class=\"tooltip-activator" +
                            //"\" style=\"border-bottom-width: 1px; border-bottom-style: dashed; border-bottom-co" +
                            //"lor: rgb(128, 255, 255); cursor: help;\"><b>Delon</b></span><div class=\"tooltip\">" +
                            //"<div class=\"tooltip-type1\" data-tooltip-coordinates=\"(-17;-3)\"><div class=\"toolt" +
                            //"ip-type1-content\" style=\"text-align: left; width: 180px\"><span style=\"color: #95" +
                            //"9595\">Точно съвпадение:</span> Delon<br><span style=\"color: #959595\">Близки съвп" +
                            //"адения:</span> делон</div><div class=\"tooltip-type1-tl\"></div><div class=\"toolti" +
                            //"p-type1-t\"></div><div class=\"tooltip-type1-tr\"></div><div class=\"tooltip-type1-l" +
                            //"\"></div><div class=\"tooltip-type1-r\"></div><div class=\"tooltip-type1-bl\"></div><" +
                            //"div class=\"tooltip-type1-b\"></div><div class=\"tooltip-type1-br\"></div></div></di" +
                            //"v> <br></span></td></tr><tr class=\"mc-page-list-delimiter\"><td style=\"position: " +
                            //"relative; clear: both;\"><div class=\"mc-page-list-delimiter-t1\"><img src=\"http://" +
                            //"bg1.base.msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif\" height=\"1\" cl" +
                            //"ass=\"mc-page-product-delimiter-img\"></div></td></tr><tr><td colspan=\"1\" style=\"f" +
                            //"ont-size: 16px;\">Следват резултати с непряко съвпадение на Вашето търсене.</td><" +
                            //"/tr><tr class=\"mc-page-list-delimiter\"><td style=\"position: relative; clear: bot" +
                            //"h;\"><div class=\"mc-page-list-delimiter-t1\"><img src=\"http://bg1.base.msrv.stor.b" +
                            //"g/b-images/ht-mc-page-list-delimiter-t1-h.gif\" height=\"1\" class=\"mc-page-product" +
                            //"-delimiter-img\"></div></td></tr><tr data-screenadapt=\"row\"><td data-screenadapt=" +
                            //"\"cell\" align=\"left\" valign=\"top\" style=\"padding-right: 47px;\"> <table cellpaddin" +
                            //"g=\"0\" cellspacing=\"0\" style=\"width: 100px; height: 100px; margin: 0px 20px 10px " +
                            //"0px; border: 0px; padding: 0px; float: left;\"><tbody><tr><td valign=\"middle\" ali" +
                            //"gn=\"center\"><table cellpadding=\"0\" cellspacing=\"0\"><tbody><tr><td class=\"product" +
                            //"-image-cell-store\" align=\"left\" valign=\"top\"><a href=\"http://www.book.store.bg/p" +
                            //"166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-editio" +
                            //"n-joanna-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Cookie(\'sear" +
                            //"ch_product_data_transfer\', \'166519 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, " +
                            //"0);\"><img src=\"http://bg1.ms01.st.msrv.stor.bg/lstimg/166519/prepare-nivo-2-a2-u" +
                            //"chebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-wil" +
                            //"liams-annette-capel.jpg\" width=\"96\" height=\"135\" border=\"0\" style=\"display:block" +
                            //";\" alt=\"Prepare! - Ниво 2 (A2): Учебник : Учебна система по английски език - Fir" +
                            //"st Edition - Joanna Kosta, Melanie Williams, Annette Capel - \" data-screenadapt=" +
                            //"\"box-product-img\"></a></td><td class=\"product-image-cell-r\" align=\"left\" valign=" +
                            //"\"top\"></td></tr><tr><td class=\"product-image-cell-b\" align=\"left\" valign=\"top\"><" +
                            //"/td><td class=\"product-image-cell-br\" align=\"left\" valign=\"top\"><img src=\"http:/" +
                            //"/bg1.base.msrv.stor.bg/b-images/quad-transp.gif\" width=\"2\" height=\"2\" style=\"dis" +
                            //"play:block;\" alt=\"\"></td></tr></tbody></table></td></tr></tbody></table>\n <a hre" +
                            //"f=\"http://www.book.store.bg/p166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-p" +
                            //"o-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html\"" +
                            //" onclick=\"st_Set_Cookie(\'search_product_data_transfer\', \'166519 1201777365 Melan" +
                            //"ie\', 30, \'.store.bg\',\'/\', 0, 0);\"><h3 itemprop=\"name\">Prepare! - Ниво 2 (A2): Уч" +
                            //"ебник<br>Учебна система по английски език - First Edition</h3><br><span class=\"p" +
                            //"rdsubnames-store prdsubnames-list\"><span itemprop=\"author\">Joanna Kosta</span>, " +
                            //"<span itemprop=\"author\">Melanie Williams</span>, <span itemprop=\"author\">Annette" +
                            //" Capel</span></span></a><br>\n <span class=\"stext vvftext\">Cambridge University P" +
                            //"ress</span>\n <div style=\"margin: 7px 0px 55px 0px;\">\n <div style=\"position: rela" +
                            //"tive; float: left; width: 270px;\"><span class=\"prices-texts-list\">Цени: &nbsp;</" +
                            //"span><span class=\"prices-values-list\">33.<span class=\"prices-valuessupper\">90</s" +
                            //"pan><span style=\"margin-left: 3px; margin-right: 5px;\">÷</span>55.<span class=\"p" +
                            //"rices-valuessupper\">90</span></span><span class=\"prices-texts-list\"> лв.</span><" +
                            //"/div>\n <div style=\"margin-top: 8px; float: left;\"><form action=\"http://www.book." +
                            //"store.bg/p166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-fi" +
                            //"rst-edition-joanna-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Co" +
                            //"okie(\'search_product_data_transfer\', \'166519 1201777365 Melanie\', 30, \'.store.bg" +
                            //"\',\'/\', 0, 0);\" method=\"get\" style=\"display: inline;\"><input type=\"submit\" value=" +
                            //"\"Виж още\" class=\"forms-buttons-moreinfo-list\"></form></div>\n <div style=\"positio" +
                            //"n: relative; float: right;\"><a href=\"http://www.book.store.bg/p166519/prepare-ni" +
                            //"vo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-me" +
                            //"lanie-williams-annette-capel.html\" onclick=\"st_Set_Cookie(\'search_product_data_t" +
                            //"ransfer\', \'166519 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, 0);\"><img src=\"ht" +
                            //"tp://bg1.base.msrv.stor.bg/b-images/ht-listicons-pages-list.gif\" width=\"60\" heig" +
                            //"ht=\"45\" style=\"position: relative; margin-top: -8px; float: left; z-index: 222;\"" +
                            //" alt=\"Тази книга е представена със сканирани страници!\"></a></div>\n </div>\n <spa" +
                            //"n class=\"ftext\" style=\"margin-right: 5px;\"><span style=\"color: #000000\">Съвпаден" +
                            //"ие за:</span> <b>Melanie</b> <del style=\"color: #AAAAAA\">Delon</del> <br>Учебник" +
                            //"ът подготвя за изпита \"Key English Test\". ... Съдържанието на учебника от всяко " +
                            //"ниво осигурява материал за 60 до 80 учебни часа. С помощта на допълнителните ком" +
                            //"поненти от системата учебните часове може да се разширят в интервал от 110 до 16" +
                            //"0 часа. Всеки учебник в различните нива се състои от уроци, които представят акт" +
                            //"уални теми и текстове, за да предизвикат интереса на учениците и дори да предизв" +
                            //"икат дискусии. Едновременно с това са включени необходимите граматични и лексика" +
                            //"лни правила. Част от учебния материал са и практическите упражнения, които са ра" +
                            //"зработени с помощта на примери, предоставени от Корпуса за обучение на  <span st" +
                            //"yle=\"padding-top: 3px; width: 15px; text-align: left;\"><a href=\"http://www.book." +
                            //"store.bg/p166519/prepare-nivo-2-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-fi" +
                            //"rst-edition-joanna-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Co" +
                            //"okie(\'search_product_data_transfer\', \'166519 1201777365 Melanie\', 30, \'.store.bg" +
                            //"\',\'/\', 0, 0);\" class=\"links-readmore-text-store\">...<img src=\"http://bg1.base.ms" +
                            //"rv.stor.bg/b-images/quad-transp.gif\" width=\"13\" height=\"13\" style=\"display: inli" +
                            //"ne;\" border=\"0\" alt=\"\" class=\"links-readmore-btn-store\"></a></span></span></td><" +
                            //"/tr><tr class=\"mc-page-list-delimiter\"><td style=\"position: relative; clear: bot" +
                            //"h;\"><div class=\"mc-page-list-delimiter-t1\"><img src=\"http://bg1.base.msrv.stor.b" +
                            //"g/b-images/ht-mc-page-list-delimiter-t1-h.gif\" height=\"1\" class=\"mc-page-product" +
                            //"-delimiter-img\"></div></td></tr><tr data-screenadapt=\"row\"><td data-screenadapt=" +
                            //"\"cell\" align=\"left\" valign=\"top\" style=\"padding-right: 47px;\"> <table cellpaddin" +
                            //"g=\"0\" cellspacing=\"0\" style=\"width: 100px; height: 100px; margin: 0px 20px 10px " +
                            //"0px; border: 0px; padding: 0px; float: left;\"><tbody><tr><td valign=\"middle\" ali" +
                            //"gn=\"center\"><table cellpadding=\"0\" cellspacing=\"0\"><tbody><tr><td class=\"product" +
                            //"-image-cell-store\" align=\"left\" valign=\"top\"><a href=\"http://www.book.store.bg/p" +
                            //"166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-editio" +
                            //"n-joanna-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Cookie(\'sear" +
                            //"ch_product_data_transfer\', \'166549 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, " +
                            //"0);\"><img src=\"http://bg1.ms01.st.msrv.stor.bg/lstimg/166549/prepare-nivo-3-a2-u" +
                            //"chebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-wil" +
                            //"liams-annette-capel.jpg\" width=\"96\" height=\"135\" border=\"0\" style=\"display:block" +
                            //";\" alt=\"Prepare! - Ниво 3 (A2): Учебник : Учебна система по английски език - Fir" +
                            //"st Edition - Joanna Kosta, Melanie Williams, Annette Capel - \" data-screenadapt=" +
                            //"\"box-product-img\"></a></td><td class=\"product-image-cell-r\" align=\"left\" valign=" +
                            //"\"top\"></td></tr><tr><td class=\"product-image-cell-b\" align=\"left\" valign=\"top\"><" +
                            //"/td><td class=\"product-image-cell-br\" align=\"left\" valign=\"top\"><img src=\"http:/" +
                            //"/bg1.base.msrv.stor.bg/b-images/quad-transp.gif\" width=\"2\" height=\"2\" style=\"dis" +
                            //"play:block;\" alt=\"\"></td></tr></tbody></table></td></tr></tbody></table>\n <a hre" +
                            //"f=\"http://www.book.store.bg/p166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-p" +
                            //"o-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html\"" +
                            //" onclick=\"st_Set_Cookie(\'search_product_data_transfer\', \'166549 1201777365 Melan" +
                            //"ie\', 30, \'.store.bg\',\'/\', 0, 0);\"><h3 itemprop=\"name\">Prepare! - Ниво 3 (A2): Уч" +
                            //"ебник<br>Учебна система по английски език - First Edition</h3><br><span class=\"p" +
                            //"rdsubnames-store prdsubnames-list\"><span itemprop=\"author\">Joanna Kosta</span>, " +
                            //"<span itemprop=\"author\">Melanie Williams</span>, <span itemprop=\"author\">Annette" +
                            //" Capel</span></span></a><br>\n <span class=\"stext vvftext\">Cambridge University P" +
                            //"ress</span>\n <div style=\"margin: 7px 0px 55px 0px;\">\n <div style=\"position: rela" +
                            //"tive; float: left; width: 270px;\"><span class=\"prices-texts-list\">Цени: &nbsp;</" +
                            //"span><span class=\"prices-values-list\">33.<span class=\"prices-valuessupper\">90</s" +
                            //"pan><span style=\"margin-left: 3px; margin-right: 5px;\">÷</span>69.<span class=\"p" +
                            //"rices-valuessupper\">90</span></span><span class=\"prices-texts-list\"> лв.</span><" +
                            //"/div>\n <div style=\"margin-top: 8px; float: left;\"><form action=\"http://www.book." +
                            //"store.bg/p166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-fi" +
                            //"rst-edition-joanna-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Co" +
                            //"okie(\'search_product_data_transfer\', \'166549 1201777365 Melanie\', 30, \'.store.bg" +
                            //"\',\'/\', 0, 0);\" method=\"get\" style=\"display: inline;\"><input type=\"submit\" value=" +
                            //"\"Виж още\" class=\"forms-buttons-moreinfo-list\"></form></div>\n <div style=\"positio" +
                            //"n: relative; float: right;\"><a href=\"http://www.book.store.bg/p166549/prepare-ni" +
                            //"vo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-me" +
                            //"lanie-williams-annette-capel.html\" onclick=\"st_Set_Cookie(\'search_product_data_t" +
                            //"ransfer\', \'166549 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, 0);\"><img src=\"ht" +
                            //"tp://bg1.base.msrv.stor.bg/b-images/ht-listicons-pages-list.gif\" width=\"60\" heig" +
                            //"ht=\"45\" style=\"position: relative; margin-top: -8px; float: left; z-index: 222;\"" +
                            //" alt=\"Тази книга е представена със сканирани страници!\"></a></div>\n </div>\n <spa" +
                            //"n class=\"ftext\" style=\"margin-right: 5px;\"><span style=\"color: #000000\">Съвпаден" +
                            //"ие за:</span> <b>Melanie</b> <del style=\"color: #AAAAAA\">Delon</del> <br>Учебник" +
                            //"ът подготвя за изпита \"Key English Test\". ... Съдържанието на учебника от всяко " +
                            //"ниво осигурява материал за 60 до 80 учебни часа. С помощта на допълнителните ком" +
                            //"поненти от системата учебните часове може да се разширят в интервал от 110 до 16" +
                            //"0 часа. Всеки учебник в различните нива се състои от уроци, които представят акт" +
                            //"уални теми и текстове, за да предизвикат интереса на учениците и дори да предизв" +
                            //"икат дискусии. Едновременно с това са включени необходимите граматични и лексика" +
                            //"лни правила. Част от учебния материал са и практическите упражнения, които са ра" +
                            //"зработени с помощта на примери, предоставени от Корпуса за обучение на  <span st" +
                            //"yle=\"padding-top: 3px; width: 15px; text-align: left;\"><a href=\"http://www.book." +
                            //"store.bg/p166549/prepare-nivo-3-a2-uchebnik-uchebna-sistema-po-anglijski-ezik-fi" +
                            //"rst-edition-joanna-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Co" +
                            //"okie(\'search_product_data_transfer\', \'166549 1201777365 Melanie\', 30, \'.store.bg" +
                            //"\',\'/\', 0, 0);\" class=\"links-readmore-text-store\">...<img src=\"http://bg1.base.ms" +
                            //"rv.stor.bg/b-images/quad-transp.gif\" width=\"13\" height=\"13\" style=\"display: inli" +
                            //"ne;\" border=\"0\" alt=\"\" class=\"links-readmore-btn-store\"></a></span></span></td><" +
                            //"/tr><tr class=\"mc-page-list-delimiter\"><td style=\"position: relative; clear: bot" +
                            //"h;\"><div class=\"mc-page-list-delimiter-t1\"><img src=\"http://bg1.base.msrv.stor.b" +
                            //"g/b-images/ht-mc-page-list-delimiter-t1-h.gif\" height=\"1\" class=\"mc-page-product" +
                            //"-delimiter-img\"></div></td></tr><tr data-screenadapt=\"row\"><td data-screenadapt=" +
                            //"\"cell\" align=\"left\" valign=\"top\" style=\"padding-right: 47px;\"> <table cellpaddin" +
                            //"g=\"0\" cellspacing=\"0\" style=\"width: 100px; height: 100px; margin: 0px 20px 10px " +
                            //"0px; border: 0px; padding: 0px; float: left;\"><tbody><tr><td valign=\"middle\" ali" +
                            //"gn=\"center\"><table cellpadding=\"0\" cellspacing=\"0\"><tbody><tr><td class=\"product" +
                            //"-image-cell-store\" align=\"left\" valign=\"top\"><a href=\"http://www.book.store.bg/p" +
                            //"166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-po-anglijski-ezik-first-editio" +
                            //"n-joanna-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Cookie(\'sear" +
                            //"ch_product_data_transfer\', \'166458 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, " +
                            //"0);\"><img src=\"http://bg1.ms01.st.msrv.stor.bg/lstimg/166458/prepare-nivo-1-a1-u" +
                            //"chebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-wil" +
                            //"liams-annette-capel.jpg\" width=\"96\" height=\"135\" border=\"0\" style=\"display:block" +
                            //";\" alt=\"Prepare! - Ниво 1 (A1): Учебник : Учебна система по английски език - Fir" +
                            //"st Edition - Joanna Kosta, Melanie Williams, Annette Capel - \" data-screenadapt=" +
                            //"\"box-product-img\"></a></td><td class=\"product-image-cell-r\" align=\"left\" valign=" +
                            //"\"top\"></td></tr><tr><td class=\"product-image-cell-b\" align=\"left\" valign=\"top\"><" +
                            //"/td><td class=\"product-image-cell-br\" align=\"left\" valign=\"top\"><img src=\"http:/" +
                            //"/bg1.base.msrv.stor.bg/b-images/quad-transp.gif\" width=\"2\" height=\"2\" style=\"dis" +
                            //"play:block;\" alt=\"\"></td></tr></tbody></table></td></tr></tbody></table>\n <a hre" +
                            //"f=\"http://www.book.store.bg/p166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-p" +
                            //"o-anglijski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html\"" +
                            //" onclick=\"st_Set_Cookie(\'search_product_data_transfer\', \'166458 1201777365 Melan" +
                            //"ie\', 30, \'.store.bg\',\'/\', 0, 0);\"><h3 itemprop=\"name\">Prepare! - Ниво 1 (A1): Уч" +
                            //"ебник<br>Учебна система по английски език - First Edition</h3><br><span class=\"p" +
                            //"rdsubnames-store prdsubnames-list\"><span itemprop=\"author\">Joanna Kosta</span>, " +
                            //"<span itemprop=\"author\">Melanie Williams</span>, <span itemprop=\"author\">Annette" +
                            //" Capel</span></span></a><br>\n <span class=\"stext vvftext\">Cambridge University P" +
                            //"ress</span>\n <div style=\"margin: 7px 0px 55px 0px;\">\n <div style=\"position: rela" +
                            //"tive; float: left; width: 270px;\"><span class=\"prices-texts-list\">Цени: &nbsp;</" +
                            //"span><span class=\"prices-values-list\">33.<span class=\"prices-valuessupper\">90</s" +
                            //"pan><span style=\"margin-left: 3px; margin-right: 5px;\">÷</span>55.<span class=\"p" +
                            //"rices-valuessupper\">90</span></span><span class=\"prices-texts-list\"> лв.</span><" +
                            //"/div>\n <div style=\"margin-top: 8px; float: left;\"><form action=\"http://www.book." +
                            //"store.bg/p166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-po-anglijski-ezik-fi" +
                            //"rst-edition-joanna-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Co" +
                            //"okie(\'search_product_data_transfer\', \'166458 1201777365 Melanie\', 30, \'.store.bg" +
                            //"\',\'/\', 0, 0);\" method=\"get\" style=\"display: inline;\"><input type=\"submit\" value=" +
                            //"\"Виж още\" class=\"forms-buttons-moreinfo-list\"></form></div>\n <div style=\"positio" +
                            //"n: relative; float: right;\"><a href=\"http://www.book.store.bg/p166458/prepare-ni" +
                            //"vo-1-a1-uchebnik-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-me" +
                            //"lanie-williams-annette-capel.html\" onclick=\"st_Set_Cookie(\'search_product_data_t" +
                            //"ransfer\', \'166458 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, 0);\"><img src=\"ht" +
                            //"tp://bg1.base.msrv.stor.bg/b-images/ht-listicons-pages-list.gif\" width=\"60\" heig" +
                            //"ht=\"45\" style=\"position: relative; margin-top: -8px; float: left; z-index: 222;\"" +
                            //" alt=\"Тази книга е представена със сканирани страници!\"></a></div>\n </div>\n <spa" +
                            //"n class=\"ftext\" style=\"margin-right: 5px;\"><span style=\"color: #000000\">Съвпаден" +
                            //"ие за:</span> <b>Melanie</b> <del style=\"color: #AAAAAA\">Delon</del> <br>Съдържа" +
                            //"нието на учебника от всяко ниво осигурява материал за 60 до 80 учебни часа. С по" +
                            //"мощта на допълнителните компоненти от системата учебните часове може да се разши" +
                            //"рят в интервал от 110 до 160 часа. Всеки учебник в различните нива се състои от " +
                            //"уроци, които представят актуални теми и текстове, за да предизвикат интереса на " +
                            //"учениците и дори да предизвикат дискусии. Едновременно с това са включени необхо" +
                            //"димите граматични и лексикални правила. Част от учебния материал са и практическ" +
                            //"ите упражнения, които са разработени с помощта на примери, предоставени от Корпу" +
                            //"са за обучение на Кеймбридж. Задачите се фокусират върху ключови проблемни сфери" +
                            //",  <span style=\"padding-top: 3px; width: 15px; text-align: left;\"><a href=\"http:" +
                            //"//www.book.store.bg/p166458/prepare-nivo-1-a1-uchebnik-uchebna-sistema-po-anglij" +
                            //"ski-ezik-first-edition-joanna-kosta-melanie-williams-annette-capel.html\" onclick" +
                            //"=\"st_Set_Cookie(\'search_product_data_transfer\', \'166458 1201777365 Melanie\', 30," +
                            //" \'.store.bg\',\'/\', 0, 0);\" class=\"links-readmore-text-store\">...<img src=\"http://" +
                            //"bg1.base.msrv.stor.bg/b-images/quad-transp.gif\" width=\"13\" height=\"13\" style=\"di" +
                            //"splay: inline;\" border=\"0\" alt=\"\" class=\"links-readmore-btn-store\"></a></span></" +
                            //"span></td></tr><tr class=\"mc-page-list-delimiter\"><td style=\"position: relative;" +
                            //" clear: both;\"><div class=\"mc-page-list-delimiter-t1\"><img src=\"http://bg1.base." +
                            //"msrv.stor.bg/b-images/ht-mc-page-list-delimiter-t1-h.gif\" height=\"1\" class=\"mc-p" +
                            //"age-product-delimiter-img\"></div></td></tr><tr data-screenadapt=\"row\"><td data-s" +
                            //"creenadapt=\"cell\" align=\"left\" valign=\"top\" style=\"padding-right: 47px;\"> <table" +
                            //" cellpadding=\"0\" cellspacing=\"0\" style=\"width: 100px; height: 100px; margin: 0px" +
                            //" 20px 10px 0px; border: 0px; padding: 0px; float: left;\"><tbody><tr><td valign=\"" +
                            //"middle\" align=\"center\"><table cellpadding=\"0\" cellspacing=\"0\"><tbody><tr><td cla" +
                            //"ss=\"product-image-cell-store\" align=\"left\" valign=\"top\"><a href=\"http://www.book" +
                            //".store.bg/p57793/kid-s-box-uchebna-sistema-po-anglijski-ezik-nivo-6-rykovodstvo-" +
                            //"za-uchitelia-melanie-williams-caroline-nixon-michael-tomlinson.html\" onclick=\"st" +
                            //"_Set_Cookie(\'search_product_data_transfer\', \'57793 1201777365 Melanie\', 30, \'.st" +
                            //"ore.bg\',\'/\', 0, 0);\"><img src=\"http://bg1.ms01.st.msrv.stor.bg/lstimg/57793/kid-" +
                            //"s-box-uchebna-sistema-po-anglijski-ezik-nivo-6-rykovodstvo-za-uchitelia-melanie-" +
                            //"williams-caroline-nixon-michael-tomlinson.jpg\" width=\"96\" height=\"120\" border=\"0" +
                            //"\" style=\"display:block;\" alt=\"Kid\'s Box: Учебна система по английски език : Ниво" +
                            //" 6: Ръководство за учителя - Melanie Williams, Caroline Nixon, Michael Tomlinson" +
                            //" - \" data-screenadapt=\"box-product-img\"></a></td><td class=\"product-image-cell-r" +
                            //"\" align=\"left\" valign=\"top\"></td></tr><tr><td class=\"product-image-cell-b\" align" +
                            //"=\"left\" valign=\"top\"></td><td class=\"product-image-cell-br\" align=\"left\" valign=" +
                            //"\"top\"><img src=\"http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif\" width=\"2\"" +
                            //" height=\"2\" style=\"display:block;\" alt=\"\"></td></tr></tbody></table></td></tr></" +
                            //"tbody></table>\n <a href=\"http://www.book.store.bg/p57793/kid-s-box-uchebna-siste" +
                            //"ma-po-anglijski-ezik-nivo-6-rykovodstvo-za-uchitelia-melanie-williams-caroline-n" +
                            //"ixon-michael-tomlinson.html\" onclick=\"st_Set_Cookie(\'search_product_data_transfe" +
                            //"r\', \'57793 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, 0);\"><h3 itemprop=\"name\"" +
                            //">Kid\'s Box: Учебна система по английски език<br>Ниво 6: Ръководство за учителя</" +
                            //"h3><br><span class=\"prdsubnames-store prdsubnames-list\"><span itemprop=\"author\">" +
                            //"Melanie Williams</span>, <span itemprop=\"author\">Caroline Nixon</span>, <span it" +
                            //"emprop=\"author\">Michael Tomlinson</span></span></a><br>\n <span class=\"stext vvft" +
                            //"ext\">Cambridge University Press</span>\n <div style=\"margin: 7px 0px 55px 0px;\">\n" +
                            //" <div style=\"position: relative; float: left; width: 270px;\"><span class=\"prices" +
                            //"-texts-list\">Цена: &nbsp;</span><span class=\"prices-values-list\">32.<span class=" +
                            //"\"prices-valuessupper\">90</span></span><span class=\"prices-texts-list\"> лв.</span" +
                            //"></div>\n <div style=\"margin-top: 8px; float: left;\"><form action=\"https://www.st" +
                            //"ore.bg/cgi-bin/order.cgi\" method=\"get\" style=\"display: inline;\"><input type=\"sub" +
                            //"mit\" value=\"Поръчай\" class=\"forms-buttons-order-list\" onclick=\"st_updateCartCook" +
                            //"ie(event, false, st_itemAdded, st_alreadyExists)\"><input type=\"hidden\" name=\"car" +
                            //"taction\" value=\"add\"><input type=\"hidden\" name=\"contenttype\" value=\"p\"><input ty" +
                            //"pe=\"hidden\" name=\"contentid\" value=\"60883\"><input type=\"hidden\" name=\"p\" value=\"" +
                            //"cart\"><input type=\"hidden\" name=\"forcetostore\" value=\"book\"><input type=\"hidden\"" +
                            //" name=\"srchstr\" value=\"Melanie Delon\"><input type=\"hidden\" name=\"sin\" value=\"0\">" +
                            //"<input type=\"hidden\" name=\"sinstore\" value=\"2\"></form></div>\n <div style=\"positi" +
                            //"on: relative; float: right;\"><a href=\"http://www.book.store.bg/p57793/kid-s-box-" +
                            //"uchebna-sistema-po-anglijski-ezik-nivo-6-rykovodstvo-za-uchitelia-melanie-willia" +
                            //"ms-caroline-nixon-michael-tomlinson.html\" onclick=\"st_Set_Cookie(\'search_product" +
                            //"_data_transfer\', \'57793 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, 0);\"><img s" +
                            //"rc=\"http://bg1.base.msrv.stor.bg/b-images/ht-listicons-pages-list.gif\" width=\"60" +
                            //"\" height=\"45\" style=\"position: relative; margin-top: -8px; float: left; z-index:" +
                            //" 222;\" alt=\"Тази книга е представена със сканирани страници!\"></a></div>\n </div>" +
                            //"\n <span class=\"ftext\" style=\"margin-right: 5px;\"><span style=\"color: #000000\">Съ" +
                            //"впадение за:</span> <b>Melanie</b> <del style=\"color: #AAAAAA\">Delon</del> <br>З" +
                            //"а \"Kid\'s Box\"\"Kid\'s Box\" е учебна система по английски език, одобрена от МОМН съ" +
                            //"с Заповед №РД 09-219/27.02.2013 г. и подходяща за обучение на учениците от 1. до" +
                            //" 4. клас. Напълно съвместима с Общата европейска езикова рамка, тя целенасочено " +
                            //"подготвя за сертификатните тестове YLE (Young Learners English Tests).Учебната с" +
                            //"истема се състои от следните нива:ниво 1 – подходящо за начинаещи без никакви по" +
                            //"знания по езиканиво 2 – извежда до А1 и учениците натрупват основни знанияниво 3" +
                            //" – покрива А1ниво 4 – покрива А1 докрайниво 5 – покрива А2ниво 6 – покрива А2 до" +
                            //"крайВсяко от нивата предоставя практическа подготовка за  <span style=\"padding-t" +
                            //"op: 3px; width: 15px; text-align: left;\"><a href=\"http://www.book.store.bg/p5779" +
                            //"3/kid-s-box-uchebna-sistema-po-anglijski-ezik-nivo-6-rykovodstvo-za-uchitelia-me" +
                            //"lanie-williams-caroline-nixon-michael-tomlinson.html\" onclick=\"st_Set_Cookie(\'se" +
                            //"arch_product_data_transfer\', \'57793 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0," +
                            //" 0);\" class=\"links-readmore-text-store\">...<img src=\"http://bg1.base.msrv.stor.b" +
                            //"g/b-images/quad-transp.gif\" width=\"13\" height=\"13\" style=\"display: inline;\" bord" +
                            //"er=\"0\" alt=\"\" class=\"links-readmore-btn-store\"></a></span></span></td></tr><tr c" +
                            //"lass=\"mc-page-list-delimiter\"><td style=\"position: relative; clear: both;\"><div " +
                            //"class=\"mc-page-list-delimiter-t1\"><img src=\"http://bg1.base.msrv.stor.bg/b-image" +
                            //"s/ht-mc-page-list-delimiter-t1-h.gif\" height=\"1\" class=\"mc-page-product-delimite" +
                            //"r-img\"></div></td></tr><tr data-screenadapt=\"row\"><td data-screenadapt=\"cell\" al" +
                            //"ign=\"left\" valign=\"top\" style=\"padding-right: 47px;\"> <table cellpadding=\"0\" cel" +
                            //"lspacing=\"0\" style=\"width: 100px; height: 100px; margin: 0px 20px 10px 0px; bord" +
                            //"er: 0px; padding: 0px; float: left;\"><tbody><tr><td valign=\"middle\" align=\"cente" +
                            //"r\"><table cellpadding=\"0\" cellspacing=\"0\"><tbody><tr><td class=\"product-image-ce" +
                            //"ll-store\" align=\"left\" valign=\"top\"><a href=\"http://www.book.store.bg/p166539/pr" +
                            //"epare-nivo-3-a2-2-cd-s-audiomateriali-uchebna-sistema-po-anglijski-ezik-first-ed" +
                            //"ition-joanna-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Cookie(\'" +
                            //"search_product_data_transfer\', \'166539 1201777365 Melanie\', 30, \'.store.bg\',\'/\'," +
                            //" 0, 0);\"><img src=\"http://bg1.ms01.st.msrv.stor.bg/lstimg/166539/prepare-nivo-3-" +
                            //"a2-2-cd-s-audiomateriali-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-" +
                            //"kosta-melanie-williams-annette-capel.jpg\" width=\"96\" height=\"95\" border=\"0\" styl" +
                            //"e=\"display:block;\" alt=\"Prepare! - Ниво 3 (A2): 2 CD с аудиоматериали : Учебна с" +
                            //"истема по английски език - First Edition - Joanna Kosta, Melanie Williams, Annet" +
                            //"te Capel - \" data-screenadapt=\"box-product-img\"></a></td><td class=\"product-imag" +
                            //"e-cell-r\" align=\"left\" valign=\"top\"></td></tr><tr><td class=\"product-image-cell-" +
                            //"b\" align=\"left\" valign=\"top\"></td><td class=\"product-image-cell-br\" align=\"left\"" +
                            //" valign=\"top\"><img src=\"http://bg1.base.msrv.stor.bg/b-images/quad-transp.gif\" w" +
                            //"idth=\"2\" height=\"2\" style=\"display:block;\" alt=\"\"></td></tr></tbody></table></td" +
                            //"></tr></tbody></table>\n <a href=\"http://www.book.store.bg/p166539/prepare-nivo-3" +
                            //"-a2-2-cd-s-audiomateriali-uchebna-sistema-po-anglijski-ezik-first-edition-joanna" +
                            //"-kosta-melanie-williams-annette-capel.html\" onclick=\"st_Set_Cookie(\'search_produ" +
                            //"ct_data_transfer\', \'166539 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, 0);\"><h3" +
                            //" itemprop=\"name\">Prepare! - Ниво 3 (A2): 2 CD с аудиоматериали<br>Учебна система" +
                            //" по английски език - First Edition</h3><br><span class=\"prdsubnames-store prdsub" +
                            //"names-list\"><span itemprop=\"author\">Joanna Kosta</span>, <span itemprop=\"author\"" +
                            //">Melanie Williams</span>, <span itemprop=\"author\">Annette Capel</span></span></a" +
                            //"><br>\n <span class=\"stext vvftext\">Cambridge University Press</span>\n <div style" +
                            //"=\"margin: 7px 0px 55px 0px;\">\n <div style=\"position: relative; float: left; widt" +
                            //"h: 270px;\"><span class=\"prices-texts-list\">Цена при носител <b>CD</b>: &nbsp;</s" +
                            //"pan><span class=\"prices-values-list\">32.<span class=\"prices-valuessupper\">90</sp" +
                            //"an></span><span class=\"prices-texts-list\"> лв.</span></div>\n <div style=\"margin-" +
                            //"top: 8px; float: left;\"><form action=\"https://www.store.bg/cgi-bin/order.cgi\" me" +
                            //"thod=\"get\" style=\"display: inline;\"><input type=\"submit\" value=\"Поръчай\" class=\"" +
                            //"forms-buttons-order-list\" onclick=\"st_updateCartCookie(event, false, st_itemAdde" +
                            //"d, st_alreadyExists)\"><input type=\"hidden\" name=\"cartaction\" value=\"add\"><input " +
                            //"type=\"hidden\" name=\"contenttype\" value=\"p\"><input type=\"hidden\" name=\"contentid\"" +
                            //" value=\"214457\"><input type=\"hidden\" name=\"p\" value=\"cart\"><input type=\"hidden\" " +
                            //"name=\"forcetostore\" value=\"book\"><input type=\"hidden\" name=\"srchstr\" value=\"Mela" +
                            //"nie Delon\"><input type=\"hidden\" name=\"sin\" value=\"0\"><input type=\"hidden\" name=\"" +
                            //"sinstore\" value=\"2\"></form></div>\n <div style=\"position: relative; float: right;" +
                            //"\"></div>\n </div>\n <span class=\"ftext\" style=\"margin-right: 5px;\"><span style=\"co" +
                            //"lor: #000000\">Съвпадение за:</span> <b>Melanie</b> <del style=\"color: #AAAAAA\">D" +
                            //"elon</del> <br>Аудиодисковете подготвят за изпита \"Key English Test\". ... Необхо" +
                            //"димите аудиоматериали за всички задачи за слушане и правилно произношение в учеб" +
                            //"ника са включени в настоящия комплект от 2 CD-та, които пълноценно допълват учеб" +
                            //"ната дейност на обучаващите се по системата \"Prepare!\".\n\nУчебната система \"Prepa" +
                            //"re! - First Edition\" се състои от:\n\nучебник\nучебна тетрадка\nкнига за учителя + D" +
                            //"VD\n2 CD с аудиоматериали\n <span style=\"padding-top: 3px; width: 15px; text-align" +
                            //": left;\"><a href=\"http://www.book.store.bg/p166539/prepare-nivo-3-a2-2-cd-s-audi" +
                            //"omateriali-uchebna-sistema-po-anglijski-ezik-first-edition-joanna-kosta-melanie-" +
                            //"williams-annette-capel.html\" onclick=\"st_Set_Cookie(\'search_product_data_transfe" +
                            //"r\', \'166539 1201777365 Melanie\', 30, \'.store.bg\',\'/\', 0, 0);\" class=\"links-readm" +
                            //"ore-text-store\">...<img src=\"http://bg1.base.msrv.stor.bg/b-images/quad-transp.g" +
                            //"if\" width=\"13\" height=\"13\" style=\"display: inline;\" border=\"0\" alt=\"\" class=\"lin" +
                            //"ks-readmore-btn-store\"></a></span></span></td></tr>\n </tbody></table>\n ");
            
        //}
    }
}
