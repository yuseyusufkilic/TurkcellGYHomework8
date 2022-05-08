#pragma checksum "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b818d80838e9f0779c51a4c87b0f395596f196d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#nullable restore
#line 1 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\_ViewImports.cshtml"
using RetroShirtWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\_ViewImports.cshtml"
using RetroShirtWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\_ViewImports.cshtml"
using RetroShirtEntities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\_ViewImports.cshtml"
using RetroShirtDAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\_ViewImports.cshtml"
using RetroShirtDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\_ViewImports.cshtml"
using RetroShirtDtos.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\_ViewImports.cshtml"
using RetroShirtDtos.Requests;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b818d80838e9f0779c51a4c87b0f395596f196d", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8c96f2d9bf7c3c00b1a73aa066a0816c0c1db7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductListResponse>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTeam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mt-3\">Products</h1>\r\n<p class=\"mb-0\">All added products can remove and edit, it is possible to creating new product.</p>\r\n\r\n<p>You might want to add new team before you create a product.</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b818d80838e9f0779c51a4c87b0f395596f196d5052", async() => {
                WriteLiteral("Create new team");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b818d80838e9f0779c51a4c87b0f395596f196d6227", async() => {
                WriteLiteral("Create new product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                 <p class=\"mb-0\">Stock</p>\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Team));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 59 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>           \r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1954, "\"", 1974, 1);
#nullable restore
#line 68 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
WriteAttributeValue("", 1960, item.ImageUrl, 1960, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail w-75\"><img />\r\n            </td>\r\n            <td>\r\n                <div class=\"ml-4\"> ");
#nullable restore
#line 71 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
                                    if (@item.IsActive)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"form-check-input\" type=\"checkbox\" id=\"flexSwitchCheckCheckedDisabled\" checked disabled>\r\n");
#nullable restore
#line 74 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
                  
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"form-check-input\" type=\"checkbox\" id=\"flexSwitchCheckDisabled\" disabled>\r\n");
#nullable restore
#line 79 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
                       
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n              \r\n                </td>\r\n            <td>\r\n                ");
#nullable restore
#line 84 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Team.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>              \r\n                ");
#nullable restore
#line 87 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 90 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("-\r\n                ");
#nullable restore
#line 91 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("-\r\n                ");
#nullable restore
#line 92 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.ActionLink("Inactive", "Delete", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("-\r\n                ");
#nullable restore
#line 93 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
           Write(Html.ActionLink("Remove", "Remove", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 98 "D:\C# Projects\RetroShirtWeb\RetroShirtWeb\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductListResponse>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
