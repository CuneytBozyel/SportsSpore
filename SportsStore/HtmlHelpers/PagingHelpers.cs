using Antlr.Runtime.Misc;
using SportsStore.Models;
using System.Text;
using System.Web.Mvc;

namespace SportsStore.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html,PageInfo pagingInfo,Func<int,string> pageUrl)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();

                if (i==pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn_primary");
                }
                tag.AddCssClass("btn btn_default");
                result.Append(tag.ToString());

            }
            return MvcHtmlString.Create(result.ToString());

        }
    }
}