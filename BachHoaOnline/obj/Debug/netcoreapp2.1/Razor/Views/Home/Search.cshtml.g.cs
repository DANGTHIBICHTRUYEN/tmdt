#pragma checksum "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d0cee5b27c8e38a51ee0421e97d8e6d610b8f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Search.cshtml", typeof(AspNetCore.Views_Home_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0cee5b27c8e38a51ee0421e97d8e6d610b8f84", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5546f6676abff122824656ff414f5d8de197e5d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BachHoaOnline.Models.Hanghoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
   BACHHOA_ONLINEContext db = new BACHHOA_ONLINEContext();

#line default
#line hidden
            BeginContext(109, 109, true);
            WriteLiteral("\n<!-- Start Best Seller -->\n<section class=\"lattest-product-area pb-40 category-list\">\n    <div class=\"row\">\n");
            EndContext();
#line 7 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(265, 180, true);
            WriteLiteral("            <div class=\"col-md-6 col-lg-4\">\n                <div class=\"card text-center card-product\">\n                    <div class=\"card-product__img\">\n                        ");
            EndContext();
            BeginContext(445, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d0cee5b27c8e38a51ee0421e97d8e6d610b8f845268", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 472, "~/images/", 472, 9, true);
#line 12 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 481, item.Hinh, 481, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(500, 128, true);
            WriteLiteral("\n                        <ul class=\"card-product__imgOverlay\">\n                            <span class=\"product-name\" hidden><a>");
            EndContext();
            BeginContext(629, 10, false);
#line 14 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
                                                            Write(item.Tenhh);

#line default
#line hidden
            EndContext();
            BeginContext(639, 379, true);
            WriteLiteral(@"</a></span>
                            <li><button><i class=""ti-search""></i></button></li>
                            <li><button class=""add-to-cart""><i class=""ti-shopping-cart""></i></button></li>
                            <li><button><i class=""ti-heart""></i></button></li>
                        </ul>
                    </div>
                    <div class=""card-body"">
");
            EndContext();
#line 21 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
                          
                            string loai = @db.Loai.SingleOrDefault(x => x.Maloai == item.Maloai).Tenloaialias;
                        

#line default
#line hidden
            BeginContext(1182, 58, true);
            WriteLiteral("                        <h4 class=\"card-product__title\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1240, "\"", 1276, 4);
            WriteAttributeValue("", 1247, "san-pham/", 1247, 9, true);
#line 24 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
WriteAttributeValue("", 1256, loai, 1256, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1261, "/", 1261, 1, true);
#line 24 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
WriteAttributeValue("", 1262, item.Tenalias, 1262, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1277, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1279, 10, false);
#line 24 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
                                                                                           Write(item.Tenhh);

#line default
#line hidden
            EndContext();
            BeginContext(1289, 65, true);
            WriteLiteral("</a></h4>\n                        <p class=\"card-product__price\">");
            EndContext();
            BeginContext(1355, 11, false);
#line 25 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
                                                  Write(item.Dongia);

#line default
#line hidden
            EndContext();
            BeginContext(1366, 74, true);
            WriteLiteral("</p>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 29 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Home\Search.cshtml"
        }

#line default
#line hidden
            BeginContext(1450, 48, true);
            WriteLiteral("    </div>\n</section>\n<!-- End Best Seller -->\n\n");
            EndContext();
            BeginContext(1498, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d0cee5b27c8e38a51ee0421e97d8e6d610b8f8410508", async() => {
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
            BeginContext(1540, 2875, true);
            WriteLiteral(@"
<!-- Cart script -->
<script>
    $("".add-to-cart"").click(function () {
        var tensp = $(this).parent().parent().find("".product-name"").find(""a"").text();
        var soluong = 1;
        if ($('#sst').length > 0) {
            soluong = $('#sst').val();
        }
        $.ajax({
            url: ""/Cart/AddToCart"",
            data: { ""tenhh"": tensp, ""soluong"": soluong },
            success: function (cart) {
                var htmlCartList = """";
                total = 0;
                count = 0;
                $(cart).each(function (i, item) {
                    htmlCartList += '<div class=""product product-widget""><div class=""product-thumb""><img src=""images/' + item.hinh + '"" alt=""""></div>""';
                    htmlCartList += '<div class=""product-body""><h3 class=""product-price"">' + item.dongia + '<span class=""qty""> x' + item.soluong + '</span></h3>';
                    htmlCartList += '<h2 class=""product-name""><a href=""#"">' + item.tensp + '</a></h2></div>';
                    htmlCartList += ");
            WriteLiteral(@"'<button class=""cancel-btn""><i class=""fa fa-trash""></i></button></div>';

                    total += parseInt(item.thanhTien);
                    count += 1;
                })
                $('.shopping-cart-list').html(htmlCartList);
                $('#cart-count').html(count);
                $('#cart-total').html(total);

                window.scrollTo(0, 0);
                $('#cartt').addClass(""open"");
                $('#cartt').attr(""aria-expanded"", false);
            }
        });
    });
    $('.cancel-btn').click(function () {
        var name = $(this).parent().find("".product-name"").find('a').text();
        $.ajax({
            url: ""/Cart/RemoveCartItem"",
            data: { ""itemName"": name },
            success: function (cart) {
                var htmlCartList = """";
                total = 0;
                count = 0;
                $(cart).each(function (i, item) {
                    htmlCartList += '<div class=""product product-widget""><div class=""product-thumb""><img src=""images");
            WriteLiteral(@"/' + item.hinh + '"" alt=""""></div>""';
                    htmlCartList += '<div class=""product-body""><h3 class=""product-price"">' + item.dongia + '<span class=""qty""> x' + item.soluong + '</span></h3>';
                    htmlCartList += '<h2 class=""product-name""><a href=""#"">' + item.tensp + '</a></h2></div>';
                    htmlCartList += '<button class=""cancel-btn""><i class=""fa fa-trash""></i></button></div>';

                    total += parseInt(item.thanhTien);
                    count += 1;
                })
                $('.shopping-cart-list').html(htmlCartList);
                $('#cart-count').html(count);
                $('#cart-total').html(total);
                if ($('#tbCart').length > 0)
                    location.reload();
            }
        });
    });
</script>
<!-- Cart script -->");
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
