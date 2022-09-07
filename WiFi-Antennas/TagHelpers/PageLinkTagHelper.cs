using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using WiFi_Antennas.Models;

namespace WiFi_Antennas.TagHelpers
{
    public class PageLinkTagHelper: TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory factory)
        {
            urlHelperFactory = factory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; } = null;
        public PageViewModel? PageModel { get; set; }
        public string PageAction { get; set; } = string.Empty;

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (PageModel is null)
            {
                throw new Exception("PageModel is not set!");
            }

            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "div";
            TagBuilder tag = new TagBuilder("ul");
            tag.AddCssClass("pagination");
            TagBuilder currentItem = CreateTag(PageModel.PageNumber, urlHelper);

            if (PageModel.HasPreviousPage)
            {
                TagBuilder prevItem = CreateTag(PageModel.PageNumber - 1, urlHelper);
                tag.InnerHtml.AppendHtml(prevItem);
            }

            tag.InnerHtml.AppendHtml(currentItem);

            if (PageModel.HasNextPage)
            {
                TagBuilder nextItem = CreateTag(PageModel.PageNumber + 1, urlHelper);
                tag.InnerHtml.AppendHtml(nextItem);
            }

            if (PageModel.HasLastSpace)
            {
                TagBuilder space = CreateTag(0, urlHelper);
                tag.InnerHtml.AppendHtml(space);
            }

            if (PageModel.HasFinalPage)
            {
                TagBuilder space = CreateTag(PageModel.TotalPages, urlHelper);
                tag.InnerHtml.AppendHtml(space);
            }

            output.Content.AppendHtml(tag);
        }

        private TagBuilder CreateTag(int pageNumber, IUrlHelper urlHelper)
        {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");
            if (pageNumber == 0)
            {
                item.AddCssClass("disabled");
            }
            else if (pageNumber == PageModel!.PageNumber)
            {
                item.AddCssClass("active");
            }
            else
            {
                PageUrlValues["page"] = pageNumber;
                link.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);
            }

            item.AddCssClass("page-item");
            link.AddCssClass("page-link");
            link.InnerHtml.Append(pageNumber == 0 ? ".." : pageNumber.ToString());
            item.InnerHtml.AppendHtml(link);
            return item;
        }
    }
}
