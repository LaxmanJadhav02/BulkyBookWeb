#pragma checksum "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7e1939841d95b6e49719462f85b685c74a15465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Details.cshtml")]
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
#line 1 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\_ViewImports.cshtml"
using BulkyBooks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\_ViewImports.cshtml"
using BulkyBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e1939841d95b6e49719462f85b685c74a15465", @"/Areas/Customer/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6178d6e8b6ca40d7794fee64a2d9b7efa0455193", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BulkyBook.Models.ShoppingCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7e1939841d95b6e49719462f85b685c74a154655304", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7e1939841d95b6e49719462f85b685c74a154655566", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 4 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"card  container\">\r\n        <div class=\"card-header bg-primary text-light ml-0  row \">\r\n            <div class=\"col-12 col-md-6\">\r\n                <h1 class=\"text-white-50\">");
#nullable restore
#line 8 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                     Write(Model.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                <p class=\"text-warning\">by  : ");
#nullable restore
#line 9 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                         Write(Model.Product.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-12 col-md-6 text-end pt-4\">\r\n                <span class=\"badge bg-info pt-2\" style=\"height:30px;\">");
#nullable restore
#line 12 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                                                 Write(Model.Product.CoverTypes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                <span class=\"badge bg-warning pt-2\" style=\"height:30px;\">");
#nullable restore
#line 13 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                                                    Write(Model.Product.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
            </div>
        </div>
        <div class=""card-body row container"">
            <div class=""container rounded p-2"">
                <div class=""row"">
                    <div class=""col-8 col-lg-8"">

                        <div class=""row pl-2"">
                            <h5 class=""text-muted"">ISBN : ");
#nullable restore
#line 22 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                                     Write(Model.Product.ISBN);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"row pl-2\">\r\n                            <h5 class=\"text-muted pb-2\">List Price : <strike>");
#nullable restore
#line 25 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                                                        Write(Model.Product.ListPrice.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strike></h5>
                        </div>
                        <div class=""row text-center pl-2"">
                            <div class=""p-1 col-2 bg-secondary border-bottom"">
                                <div>Quantity</div>
                            </div>
                            <div class=""p-1 col-2 bg-secondary border-bottom"">
                                <div>1-50</div>
                            </div>
                            <div class=""p-1 col-2 bg-secondary border-bottom"">
                                <div>51-100</div>
                            </div>
                            <div class=""p-1 col-2 bg-secondary border-bottom"">
                                <div>100+</div>
                            </div>
                        </div>
                        <div class=""row text-center pl-2"" style=""color:maroon; font-weight:bold"">
                            <div class=""p-1 col-2 bg-secondary"">
                                <div>Price</div>
   ");
                WriteLiteral("                         </div>\r\n                            <div class=\"p-1 col-2 bg-secondary\">\r\n                                <div>");
#nullable restore
#line 46 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                Write(Model.Product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"p-1 col-2 bg-secondary\">\r\n                                <div>");
#nullable restore
#line 49 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                Write(Model.Product.Price50.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"p-1 col-2 bg-secondary\">\r\n                                <div>");
#nullable restore
#line 52 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                Write(Model.Product.Price100.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row pl-2\">\r\n                            <p class=\"text-secondary\">");
#nullable restore
#line 56 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
                                                 Write(Html.Raw(Model.Product.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"row pl-2\">\r\n                            <div class=\"col-2 text-primary\"><h4>Count</h4></div>\r\n                            <div class=\"col-10\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7e1939841d95b6e49719462f85b685c74a1546513382", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 60 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-12 col-lg-3 offset-lg-1 text-center\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 3432, "\"", 3461, 1);
#nullable restore
#line 64 "C:\Projects\Learning\BulkyBookWeb\BulkyBookWeb\BulkyBooks\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 3438, Model.Product.ImageUrl, 3438, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" width=""100%"" class=""rounded"" />
                    </div>
                </div>
            </div>
        </div>
        <div class=""card-footer"">
            <div class=""row"">
                <div class=""col-12 col-md-6 pb-1"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7e1939841d95b6e49719462f85b685c74a1546515824", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <div class=""col-12 col-md-6 pb-1"">
                    <button type=""submit"" value=""Add to Cart"" class=""btn btn-primary form-control"" style=""height:50px;"">Add to Cart</button>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BulkyBook.Models.ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
