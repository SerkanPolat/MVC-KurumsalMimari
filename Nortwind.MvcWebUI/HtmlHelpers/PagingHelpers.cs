using Nortwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Nortwind.MvcWebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString Pager(this HtmlHelper html,PagingInfo pagingInfo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= Math.Ceiling((decimal)pagingInfo.TotalItems/pagingInfo.ItemsPerPage); i++)
            {
                var tagBuilder = new TagBuilder("a");
                tagBuilder.MergeAttribute("href", String.Format("/Product/Index/?page=" + i+"&category="+pagingInfo.CurrentCategory));
                tagBuilder.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                {
                    tagBuilder.AddCssClass("selected");
                }
                stringBuilder.Append(tagBuilder);
            }
            

            return MvcHtmlString.Create(stringBuilder.ToString());
        }
    }
}