#pragma checksum "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57de024611f943993dca9ede579212ae2de61c23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57de024611f943993dca9ede579212ae2de61c23", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5546f6676abff122824656ff414f5d8de197e5d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BachHoaOnline.Models.Khachhang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "Frontend";

#line default
#line hidden
            BeginContext(115, 39, true);
            WriteLiteral("\n<h2>Danh s??ch t??i kho???n</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(154, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57de024611f943993dca9ede579212ae2de61c234658", async() => {
                BeginContext(177, 17, true);
                WriteLiteral("T???o m???i t??i kho???n");
                EndContext();
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
            EndContext();
            BeginContext(198, 592, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
               Email
            </th>
            <th>
                M???t kh???u
            </th>
            <th>
                H??? t??n
            </th>
            <th>
                Gi???i t??nh
            </th>
            <th>
                Ng??y sinh
            </th>
            <th>
                ?????a ch???
            </th>
            <th>
                ??i???n tho???i
            </th>
            <th>
               Random key
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 44 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(821, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(868, 40, false);
#line 47 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(908, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(961, 42, false);
#line 50 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Matkhau));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1056, 40, false);
#line 53 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hoten));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 19, true);
            WriteLiteral("\n            </td>\n");
            EndContext();
#line 55 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
             if (item.Gioitinh == true)
            {

#line default
#line hidden
            BeginContext(1169, 29, true);
            WriteLiteral("                <td>Nam</td>\n");
            EndContext();
#line 58 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1243, 28, true);
            WriteLiteral("                <td>N???</td>\n");
            EndContext();
#line 62 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1285, 33, true);
            WriteLiteral("            <td>\n                ");
            EndContext();
            BeginContext(1319, 43, false);
#line 64 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ngaysinh));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1415, 41, false);
#line 67 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Diachi));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1509, 44, false);
#line 70 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dienthoai));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1606, 44, false);
#line 73 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Randomkey));

#line default
#line hidden
            EndContext();
            BeginContext(1650, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1702, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57de024611f943993dca9ede579212ae2de61c2311019", async() => {
                BeginContext(1751, 3, true);
                WriteLiteral("S???a");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
                                         WriteLiteral(item.Makh);

#line default
#line hidden
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
            EndContext();
            BeginContext(1758, 23, true);
            WriteLiteral("<br />\n                ");
            EndContext();
            BeginContext(1781, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57de024611f943993dca9ede579212ae2de61c2313402", async() => {
                BeginContext(1830, 3, true);
                WriteLiteral("X??a");
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
#line 77 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
                                         WriteLiteral(item.Makh);

#line default
#line hidden
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
            EndContext();
            BeginContext(1837, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 80 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1872, 34, true);
            WriteLiteral("    </tbody>\n</table>\n<div>\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1906, "\"", 1949, 1);
#line 84 "C:\Users\misad\Downloads\BachHoaOnline-master (1)\BachHoaOnline-master\BachHoaOnline\Views\Account\Index.cshtml"
WriteAttributeValue("", 1913, Url.Action("Index","Administrator"), 1913, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1950, 33, true);
            WriteLiteral(">V??? l???i trang qu???n tr???</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BachHoaOnline.Models.Khachhang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
