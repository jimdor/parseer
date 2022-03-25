using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace parser.Core.Habra
{
    class SiteParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document) //метод поиска нужной инфы
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("tm-article-snippet__title-link"));
            foreach(var item in items)
            {
                list.Add(item.TextContent);
                list.Add(" ");
            }

            return list.ToArray();
        }
    }
}
