#pragma checksum "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce0c8110315d23d145ed53994a2f1546f4846c07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Details), @"mvc.1.0.view", @"/Views/Categories/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Details.cshtml", typeof(AspNetCore.Views_Categories_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\_ViewImports.cshtml"
using HiShop;

#line default
#line hidden
#line 2 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\_ViewImports.cshtml"
using HiShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0c8110315d23d145ed53994a2f1546f4846c07", @"/Views/Categories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de869a20bf865f147f1447ec25d5858d4fa88d9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HiShop.Models.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
  
    ViewData["Title"] = "نمایش جزییات دسته بندی";

#line default
#line hidden
            BeginContext(198, 44, true);
            WriteLiteral("<br class=\"my-3\" />\r\n<h2 class=\"text-right\">");
            EndContext();
            BeginContext(243, 17, false);
#line 8 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
                  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(260, 178, true);
            WriteLiteral(" </h2>\r\n<hr />\r\n\r\n<table class=\"table table-bordered table-hover table-striped table-info text-center table-sm\">\r\n    <tbody>\r\n        <tr>\r\n            <td class=\"align-middle\">");
            EndContext();
            BeginContext(439, 37, false);
#line 14 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
                                Write(Html.DisplayNameFor(m => m.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(476, 27, true);
            WriteLiteral("</td>\r\n            <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 503, "\"", 525, 1);
#line 15 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
WriteAttributeValue("", 509, Model.ImagePath, 509, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 526, "\"", 559, 5);
            WriteAttributeValue("", 532, "سایت", 532, 4, true);
            WriteAttributeValue(" ", 536, "های", 537, 4, true);
            WriteAttributeValue(" ", 540, "شاپ", 541, 4, true);
            WriteAttributeValue(" ", 544, "-", 545, 2, true);
#line 15 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
WriteAttributeValue(" ", 546, Model.Title, 547, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 560, "\"", 595, 5);
            WriteAttributeValue("", 568, "سایت", 568, 4, true);
            WriteAttributeValue(" ", 572, "های", 573, 4, true);
            WriteAttributeValue(" ", 576, "شاپ", 577, 4, true);
            WriteAttributeValue(" ", 580, "-", 581, 2, true);
#line 15 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
WriteAttributeValue(" ", 582, Model.Title, 583, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(596, 68, true);
            WriteLiteral(" class=\"w-75\" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(665, 33, false);
#line 18 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(m => m.Title));

#line default
#line hidden
            EndContext();
            BeginContext(698, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(722, 11, false);
#line 19 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(733, 52, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(786, 39, false);
#line 22 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(825, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(849, 17, false);
#line 23 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(866, 68, true);
            WriteLiteral(" </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<br class=\"my-2\" />\r\n");
            EndContext();
#line 28 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
 if (User.IsInRole("مدیر دسته بندی ها"))
{

#line default
#line hidden
            BeginContext(979, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(983, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7112ef6995f04b769c65b9019bb16633", async() => {
                BeginContext(1061, 86, true);
                WriteLiteral("\r\n        <i class=\"fas fa-edit align-middle\"></i>\r\n        ویرایش این دسته بندی\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1151, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1157, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e18971edeab24e83b23d0cc0893e0583", async() => {
                BeginContext(1236, 84, true);
                WriteLiteral("\r\n        <i class=\"fas fa-trash align-middle\"></i>\r\n        حذف این دسته بندی\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
                             WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1324, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Ehsan\Desktop\HiShop\HiShop\Views\Categories\Details.cshtml"
}

#line default
#line hidden
            BeginContext(1329, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cfaf70671a94977a23a522a7fd8e023", async() => {
                BeginContext(1380, 82, true);
                WriteLiteral("\r\n    <i class=\"fas fa-share align-middle\"></i>\r\n    بازگشت به لیست دسته بندی ها\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.UserManager<HiShop.Areas.Identity.Data.ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HiShop.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591