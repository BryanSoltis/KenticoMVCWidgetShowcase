using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using System.Collections.Generic;

namespace KenticoMVCWidgetShowcase.Models.Widgets.MVCWidgetListWidget
{
    public class MVCWidgetListWidgetViewModel
    {
        public string HeaderText { get; set; }
        public string IntroText { get; set; }
        public IEnumerable<MVCWidget> MVCWidgets { get; set; }
        public bool ShowAllLink { get; set; }
    }
}