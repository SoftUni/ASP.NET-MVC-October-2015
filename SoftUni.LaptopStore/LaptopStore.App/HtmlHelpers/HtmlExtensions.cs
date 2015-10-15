using System.Web.Mvc;

namespace LaptopStore.App.HtmlHelpers
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString Image(
            this HtmlHelper helper,
            string imageUrl,
            string altText = "")
        {
            var imgBuilder = new TagBuilder("img");
            imgBuilder.MergeAttribute("src", imageUrl);
            imgBuilder.MergeAttribute("alt", altText);

            return new MvcHtmlString(imgBuilder.ToString());
        }
    }
}