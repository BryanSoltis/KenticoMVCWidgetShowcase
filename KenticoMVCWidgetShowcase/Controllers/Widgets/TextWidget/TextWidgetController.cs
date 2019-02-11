using Kentico.PageBuilder.Web.Mvc;
using KenticoMVCWidgetShowcase.Controllers.Widgets;
using KenticoMVCWidgetShowcase.Models.Widgets;
using System.Web.Mvc;

[assembly: RegisterWidget("DancingGoat.General.TextWidget", typeof(TextWidgetController), "Text Widget", Description = "Text area supporting basic formatting.", IconClass = "icon-l-text")]

namespace KenticoMVCWidgetShowcase.Controllers.Widgets
{
    public class TextWidgetController : WidgetController<TextWidgetProperties>
    {
        /// <summary>
        /// Creates an instance of <see cref="TextWidgetController"/> class.
        /// </summary>
        public TextWidgetController()
        {
        }


        /// <summary>
        /// Creates an instance of <see cref="TextWidgetController"/> class.
        /// </summary>
        /// <param name="propertiesRetriever">Retriever for widget properties.</param>
        /// <param name="currentPageRetriever">Retriever for current page where is the widget used.</param>
        /// <remarks>Use this constructor for tests to handle dependencies.</remarks>
        public TextWidgetController(IWidgetPropertiesRetriever<TextWidgetProperties> propertiesRetriever,
                                        ICurrentPageRetriever currentPageRetriever) : base(propertiesRetriever, currentPageRetriever)
        {
        }


        // GET: TextWidget
        public ActionResult Index()
        {
            var properties = GetProperties();
            return PartialView("Widgets/_TextWidget", new TextWidgetViewModel { Text = properties.Text });
        }
    }
}