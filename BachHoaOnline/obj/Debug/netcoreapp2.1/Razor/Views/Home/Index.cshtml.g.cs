#pragma checksum "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c40a10e2a7876f1ab2965679fd7784025d6c19a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\_ViewImports.cshtml"
using BachHoaOnline;

#line default
#line hidden
#line 2 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\_ViewImports.cshtml"
using BachHoaOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c40a10e2a7876f1ab2965679fd7784025d6c19a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5546f6676abff122824656ff414f5d8de197e5d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BachHoaOnline.Models.Hanghoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/025bbc4aa5162453506f362c12eda0e4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/02a66fb2d83019493ff96e7dc4995576.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/02c49735d353bcb92a8cca81efbe85f4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
  
    BACHHOA_ONLINEContext db = new BACHHOA_ONLINEContext();
    List<Hanghoa> hanghoa = Model.ToList();
    int count = 0;

#line default
#line hidden
            BeginContext(217, 304, true);
            WriteLiteral(@"<!-- HOME -->
<div id=""home"">
    <!-- container -->
    <div class=""container"">
        <!-- home wrap -->
        <div class=""home-wrap"">
            <!-- home slick -->
            <div id=""home-slick"">
                <!-- banner -->
                <div class=""banner banner-1"">
                    ");
            EndContext();
            BeginContext(521, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c40a10e2a7876f1ab2965679fd7784025d6c19a5867", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(580, 155, true);
            WriteLiteral("\n                </div>\n                <!-- /banner -->\n                <!-- banner -->\n                <div class=\"banner banner-1\">\n                    ");
            EndContext();
            BeginContext(735, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c40a10e2a7876f1ab2965679fd7784025d6c19a7195", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(794, 172, true);
            WriteLiteral("                 \n                </div>\n                <!-- /banner -->\n                <!-- banner -->\n                <div class=\"banner banner-1\">\n                    ");
            EndContext();
            BeginContext(966, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c40a10e2a7876f1ab2965679fd7784025d6c19a8540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1025, 887, true);
            WriteLiteral(@"
                </div>
                <!-- /banner -->
            </div>
            <!-- /home slick -->
        </div>
        <!-- /home wrap -->
    </div>
    <!-- /container -->
</div>
<!-- /HOME -->
<!-- section -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- section-title -->
            <div class=""col-md-12"">
                <div class=""section-title"">
                    <h2 class=""title"">Sản phẩm</h2>
                    <div class=""pull-right"">
                        <div class=""product-slick-dots-1 custom-dots""></div>
                    </div>
                </div>
            </div>
            <!-- /section-title -->
            <!-- banner -->
            <div class=""col-md-3 col-sm-6 col-xs-6"">
                <div class=""banner banner-2"">
                    ");
            EndContext();
            BeginContext(1912, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c40a10e2a7876f1ab2965679fd7784025d6c19a10616", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1922, "~/images/", 1922, 9, true);
#line 62 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1931, hanghoa[0].Hinh, 1931, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1956, 282, true);
            WriteLiteral(@"                   
                </div>
            </div>
            <!-- /banner -->
            <!-- Product Slick -->
            <div class=""col-md-9 col-sm-6 col-xs-6"">
                <div class=""row"">
                    <div id=""product-slick-1"" class=""product-slick"">
");
            EndContext();
#line 70 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                         for (int j = 0; j < 4; ++j)
                        {
                            string loai = db.Loai.SingleOrDefault(x => x.Maloai == hanghoa[j].Maloai).Tenloaialias;

#line default
#line hidden
            BeginContext(2433, 301, true);
            WriteLiteral(@"                            <!-- Product Single -->
                            <div class=""product product-single"">
                                <div class=""product-thumb"">
                                    <div class=""product-label"">
                                        <span class=""sale"">-");
            EndContext();
            BeginContext(2735, 18, false);
#line 77 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                       Write(hanghoa[j].Giamgia);

#line default
#line hidden
            EndContext();
            BeginContext(2753, 118, true);
            WriteLiteral("%</span>\n                                    </div>\n                                    <a class=\"main-btn quick-view\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2871, "\"", 2914, 4);
            WriteAttributeValue("", 2878, "/san-pham/", 2878, 10, true);
#line 79 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 2888, loai, 2888, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2893, "/", 2893, 1, true);
#line 79 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 2894, hanghoa[j].Tenalias, 2894, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2915, 79, true);
            WriteLiteral("><i class=\"fa fa-search-plus\"></i> Xem</a>\n                                    ");
            EndContext();
            BeginContext(2994, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c40a10e2a7876f1ab2965679fd7784025d6c19a14752", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3004, "~/images/", 3004, 9, true);
#line 80 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3013, hanghoa[j].Hinh, 3013, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3038, 161, true);
            WriteLiteral("\n                                </div>\n                                <div class=\"product-body\">\n                                    <h3 class=\"product-price\">");
            EndContext();
#line 83 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                                float dg = (float)(hanghoa[j].Dongia - hanghoa[j].Dongia * (hanghoa[j].Giamgia / 100));

#line default
#line hidden
            BeginContext(3290, 2, false);
#line 83 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                                                                                                                   Write(dg);

#line default
#line hidden
            EndContext();
            BeginContext(3292, 31, true);
            WriteLiteral("<del class=\"product-old-price\">");
            EndContext();
            BeginContext(3324, 17, false);
#line 83 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                                                                                                                                                     Write(hanghoa[j].Dongia);

#line default
#line hidden
            EndContext();
            BeginContext(3341, 526, true);
            WriteLiteral(@"</del></h3>
                                    <div class=""product-rating"">
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star-o empty""></i>
                                    </div>
                                    <h2 class=""product-name""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3867, "\"", 3910, 4);
            WriteAttributeValue("", 3874, "/san-pham/", 3874, 10, true);
#line 91 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 3884, loai, 3884, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 3889, "/", 3889, 1, true);
#line 91 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 3890, hanghoa[j].Tenalias, 3890, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3911, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3913, 16, false);
#line 91 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                                                                       Write(hanghoa[j].Tenhh);

#line default
#line hidden
            EndContext();
            BeginContext(3929, 624, true);
            WriteLiteral(@"</a></h2>
                                    <div class=""product-btns"">
                                        <button class=""main-btn icon-btn""><i class=""fa fa-heart""></i></button>
                                        <button class=""main-btn icon-btn""><i class=""fa fa-exchange""></i></button>
                                        <a class=""primary-btn add-to-cart"" style=""cursor: pointer""><i class=""fa fa-shopping-cart""></i> Thêm vào giỏ</a>
                                    </div>
                                </div>
                                <!-- /Product Single -->
                            </div>
");
            EndContext();
#line 100 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4579, 507, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <!-- /Product Slick -->
        </div>
    </div>
    <!-- /container -->
</div>
<!-- /section -->
<!-- section -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <!-- section title -->
        <div class=""col-md-12"">
            <div class=""section-title"">
                <h2 class=""title"">Sản phẩm</h2>
            </div>
        </div>
        <!-- section title -->
");
            EndContext();
#line 122 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
         for (int i = 0; i < 2; ++i)
        {

#line default
#line hidden
            BeginContext(5133, 30, true);
            WriteLiteral("            <div class=\"row\">\n");
            EndContext();
#line 125 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                 for (int j = i * (i + 3); j < 4 * (i + 1); ++j)
                {
                    string loai = db.Loai.SingleOrDefault(x => x.Maloai == hanghoa[j].Maloai).Tenloaialias;

#line default
#line hidden
            BeginContext(5354, 338, true);
            WriteLiteral(@"                    <!-- Product Single -->
                    <div class=""col-md-3 col-sm-6 col-xs-6"">
                        <div class=""product product-single"">
                            <div class=""product-thumb"">
                                <div class=""product-label"">
                                    <span class=""sale"">-");
            EndContext();
            BeginContext(5693, 18, false);
#line 133 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                   Write(hanghoa[j].Giamgia);

#line default
#line hidden
            EndContext();
            BeginContext(5711, 110, true);
            WriteLiteral("%</span>\n                                </div>\n                                <a class=\"main-btn quick-view\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5821, "\"", 5864, 4);
            WriteAttributeValue("", 5828, "/san-pham/", 5828, 10, true);
#line 135 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 5838, loai, 5838, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 5843, "/", 5843, 1, true);
#line 135 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 5844, hanghoa[j].Tenalias, 5844, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5865, 75, true);
            WriteLiteral("><i class=\"fa fa-search-plus\"></i> Xem</a>\n                                ");
            EndContext();
            BeginContext(5940, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c40a10e2a7876f1ab2965679fd7784025d6c19a23686", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5950, "~/images/", 5950, 9, true);
#line 136 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5959, hanghoa[j].Hinh, 5959, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5984, 149, true);
            WriteLiteral("\n                            </div>\n                            <div class=\"product-body\">\n                                <h3 class=\"product-price\">");
            EndContext();
#line 139 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                            float dg = (float)(hanghoa[j].Dongia - (float)hanghoa[j].Dongia * (hanghoa[j].Giamgia / 100));

#line default
#line hidden
            BeginContext(6231, 2, false);
#line 139 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                                                                                                                      Write(dg);

#line default
#line hidden
            EndContext();
            BeginContext(6233, 31, true);
            WriteLiteral("<del class=\"product-old-price\">");
            EndContext();
            BeginContext(6265, 17, false);
#line 139 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                                                                                                                                                        Write(hanghoa[j].Dongia);

#line default
#line hidden
            EndContext();
            BeginContext(6282, 494, true);
            WriteLiteral(@"</del></h3>
                                <div class=""product-rating"">
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star""></i>
                                    <i class=""fa fa-star-o empty""></i>
                                </div>
                                <h2 class=""product-name""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6776, "\"", 6819, 4);
            WriteAttributeValue("", 6783, "/san-pham/", 6783, 10, true);
#line 147 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 6793, loai, 6793, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 6798, "/", 6798, 1, true);
#line 147 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 6799, hanghoa[j].Tenalias, 6799, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6820, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(6822, 16, false);
#line 147 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                                                                                                   Write(hanghoa[j].Tenhh);

#line default
#line hidden
            EndContext();
            BeginContext(6838, 611, true);
            WriteLiteral(@"</a></h2>
                                <div class=""product-btns"">
                                    <button class=""main-btn icon-btn""><i class=""fa fa-heart""></i></button>
                                    <button class=""main-btn icon-btn""><i class=""fa fa-exchange""></i></button>
                                    <a class=""primary-btn add-to-cart"" style=""cursor: pointer""><i class=""fa fa-shopping-cart""></i> Thêm vào giỏ</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /Product Single -->
");
            EndContext();
#line 157 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(7467, 19, true);
            WriteLiteral("            </div>\n");
            EndContext();
#line 159 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(7496, 61, true);
            WriteLiteral("    </div>\n    <!-- /container -->\n</div>\n<!-- /section -->\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BachHoaOnline.Models.Hanghoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
