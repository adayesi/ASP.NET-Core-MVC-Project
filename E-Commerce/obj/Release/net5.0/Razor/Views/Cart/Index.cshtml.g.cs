#pragma checksum "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97dab9060a8188b7447063aba31d6a7090d2b6cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
using Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97dab9060a8188b7447063aba31d6a7090d2b6cf", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6639e8b8c38a8f96387e01c1d7c17846a7da1e82", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Clear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Update Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
 if (Model.Any())
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97dab9060a8188b7447063aba31d6a7090d2b6cf10232", async() => {
                WriteLiteral(@"
        <br />
        <div class=""backgroundWhiteBorder"">
            <div class=""container row"">
                <div class=""col -8"">
                    <div class=""card mt-4"">
                        <div class=""card-header bg-dark text-light ml-0 row container"">
                            <div class=""col-6"">
                                <i class=""fa fa-shopping-cart""></i> &nbsp;
                                Shopping Cart
                            </div>
                            <div class=""col-6 text-right"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97dab9060a8188b7447063aba31d6a7090d2b6cf11080", async() => {
                    WriteLiteral("Clear Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97dab9060a8188b7447063aba31d6a7090d2b6cf12423", async() => {
                    WriteLiteral("Continue Shopping");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class="" d-none d-lg-block"">
                                <div class=""row"" style=""color:#821f3d"">
                                    <div class=""col-lg-2"">
                                    </div>
");
#nullable restore
#line 30 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstant.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-12 col-lg-3\">\r\n                                            Product Details\r\n                                        </div>\r\n");
#nullable restore
#line 35 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-12 col-lg-7\">\r\n                                            Product Details\r\n                                        </div>\r\n");
#nullable restore
#line 42 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-12 col-lg-2\">\r\n                                        Price per sqft\r\n                                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstant.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""col-6 col-lg-2"">
                                            Sqft
                                        </div>
                                        <div class=""col-6 col-lg-2"">
                                            Total Price
                                        </div>
");
#nullable restore
#line 54 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-6 col-sm-4 col-lg-1\">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <hr />\r\n");
#nullable restore
#line 61 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                              
                                var OrderTotal = 0.0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                             for (int i = 0; i < Model.Count(); i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97dab9060a8188b7447063aba31d6a7090d2b6cf17456", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 66 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].Id);

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
                WriteLiteral("\r\n                                <div class=\"row h-100\">\r\n                                    <div class=\"col-4 col-md-2 text-center py-2\">\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 3278, "\"", 3321, 2);
#nullable restore
#line 69 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3284, WebConstant.ImagePath, 3284, 22, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3306, Model[i].Image, 3306, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded\" width=\"100%\" />\r\n                                    </div>\r\n");
#nullable restore
#line 71 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstant.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-8 col-lg-3\">\r\n                                            <h5>");
#nullable restore
#line 74 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                           Write(Model[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                            <div style=\"font-size: 11px;\">");
#nullable restore
#line 75 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                                                     Write(Model[i].ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                        </div>\r\n");
#nullable restore
#line 77 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                    }
                                    else
                                    {



#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-8 col-lg-7\">\r\n                                            <h5>");
#nullable restore
#line 83 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                           Write(Model[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                            <div style=\"font-size: 11px;\">");
#nullable restore
#line 84 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                                                     Write(Model[i].ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                        </div>\r\n");
#nullable restore
#line 86 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\r\n                                        <span style=\"font-size:17px;\"> $");
#nullable restore
#line 88 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                                                   Write(Model[i].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>/ sqft\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 91 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstant.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-4 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97dab9060a8188b7447063aba31d6a7090d2b6cf23600", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 94 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => (Model[i].TempSqFt));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97dab9060a8188b7447063aba31d6a7090d2b6cf25433", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 95 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].TempSqFt);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                        </div>\r\n                                        <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\r\n                                            <span style=\"font-size:17px;\"> $");
#nullable restore
#line 99 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                                                        Write(Model[i].Price * Model[i].TempSqFt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 102 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-2 col-lg-1 p-0 pt-lg-4 text-center\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97dab9060a8188b7447063aba31d6a7090d2b6cf28059", async() => {
                    WriteLiteral("\r\n                                            <i class=\"fas fa-trash\"></i>\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                                                 WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 110 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                OrderTotal += Model[i].Price * Model[i].TempSqFt;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <hr />\r\n");
#nullable restore
#line 112 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                             if (User.IsInRole(WebConstant.AdminRole))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"row\">\r\n                                    <div class=\"col-12 text-right pr-4\" style=\"color: #821f3d\">\r\n                                        Order Total:  ");
#nullable restore
#line 117 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                                  Write($"{OrderTotal:c}");

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 120 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div class=\"card-footer\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-6 col-md-3 offset-md-6\">\r\n");
#nullable restore
#line 125 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstant.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97dab9060a8188b7447063aba31d6a7090d2b6cf32788", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 129 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                                <div class=""col-6 col-md-3 "">
                                    <button type=""submit"" class=""btn btn-success form-control "">
                                        <span>Continue</span>
                                    </button>
                                </div>
                            </div>
                        </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 144 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Cart is empty. Please add items to cart.</p>\r\n");
#nullable restore
#line 148 "C:\Users\hp\Documents\E-Comm\E-Commerce\E-Commerce\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97dab9060a8188b7447063aba31d6a7090d2b6cf36893", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_17.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591