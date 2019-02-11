using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace KenticoMVCWidgetShowcase.Models.Widgets.MVCWidgetListWidget
{
    public sealed class MVCWidgetListWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Header Text")]
        public string HeaderText { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 1, Label = "Intro Text")]
        public string IntroText { get; set; }

        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 2, Label = "Select Top N")]
        public int SelectTopN { get; set; } = 3;

        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 3, Label = "Show ALL Link")]
        public bool ShowAllLink { get; set; } = false;
    }
}