#pragma checksum "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5809368fb7e815c4ce4436a30b196b565365e517"
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
#line 1 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\_ViewImports.cshtml"
using Fiorella;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\_ViewImports.cshtml"
using Fiorella.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\_ViewImports.cshtml"
using Fiorella.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5809368fb7e815c4ce4436a30b196b565365e517", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b29d5502358db0d706c7b49338c0c9803b561b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- MAIN START -->

<main>
    <!-- PRODUCTS START -->
    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 376, "\"", 383, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 614, "\"", 621, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 16 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                                 foreach (Category cat in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 805, "\"", 812, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cat-");
#nullable restore
#line 18 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                                                           Write(cat.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 18 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                                                                    Write(cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 19 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1088, "\"", 1095, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 25 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                         foreach (Category cat in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1255, "\"", 1262, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cat-");
#nullable restore
#line 27 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                                                   Write(cat.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 27 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                                                            Write(cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 28 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1468, "\"", 1475, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 39 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                 foreach (Product product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n                        <div class=\"product-item text-cener\" data-id=\"cat-");
#nullable restore
#line 42 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                                                                     Write(product.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <div class=\"img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5809368fb7e815c4ce4436a30b196b565365e5179895", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5809368fb7e815c4ce4436a30b196b565365e51710186", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2146, "~/img/", 2146, 6, true);
#nullable restore
#line 45 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2152, product.Image, 2152, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                                                                                   WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"title mt-3\">\r\n                                <h6>");
#nullable restore
#line 49 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"price\">\r\n                                <span class=\"text-black-50\">Add to cart</span>\r\n                                <span class=\"text-black-50\">$");
#nullable restore
#line 53 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 57 "C:\Users\nigar\OneDrive\Masaüstü\Fiorella\Fiorella\Views\Products\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <!-- PRODUCTS END -->\r\n\r\n</main>\r\n\r\n<!-- MAIN END -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591