#pragma checksum "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7526cc3d4c506b8f1e4d3714c7d3dfaab14b95b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SysUsers_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/SysUsers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SysUsers/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_SysUsers_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7526cc3d4c506b8f1e4d3714c7d3dfaab14b95b3", @"/Areas/Admin/Views/SysUsers/Details.cshtml")]
    public class Areas_Admin_Views_SysUsers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryEntities.Models.SysUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(138, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>SysUser</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(267, 43, false);
#line 15 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Account));

#line default
#line hidden
            EndContext();
            BeginContext(310, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(372, 39, false);
#line 18 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Account));

#line default
#line hidden
            EndContext();
            BeginContext(411, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(472, 40, false);
#line 21 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(512, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(574, 36, false);
#line 24 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(610, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(671, 44, false);
#line 27 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(715, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(777, 40, false);
#line 30 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(817, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(878, 40, false);
#line 33 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Salt));

#line default
#line hidden
            EndContext();
            BeginContext(918, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(980, 36, false);
#line 36 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Salt));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1077, 43, false);
#line 39 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1182, 39, false);
#line 42 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1282, 48, false);
#line 45 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreationTime));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1392, 44, false);
#line 48 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreationTime));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1497, 50, false);
#line 51 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LoginFailedNum));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1609, 46, false);
#line 54 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LoginFailedNum));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1716, 50, false);
#line 57 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AllowLoginTime));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1828, 46, false);
#line 60 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.AllowLoginTime));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1935, 45, false);
#line 63 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LoginLock));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2042, 41, false);
#line 66 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LoginLock));

#line default
#line hidden
            EndContext();
            BeginContext(2083, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2144, 49, false);
#line 69 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastLoginTime));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2255, 45, false);
#line 72 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastLoginTime));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2361, 48, false);
#line 75 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ViolationNum));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2471, 44, false);
#line 78 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ViolationNum));

#line default
#line hidden
            EndContext();
            BeginContext(2515, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2576, 49, false);
#line 81 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ScheduledLock));

#line default
#line hidden
            EndContext();
            BeginContext(2625, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2687, 45, false);
#line 84 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.ScheduledLock));

#line default
#line hidden
            EndContext();
            BeginContext(2732, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2793, 53, false);
#line 87 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AllowScheduleTime));

#line default
#line hidden
            EndContext();
            BeginContext(2846, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2908, 49, false);
#line 90 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.AllowScheduleTime));

#line default
#line hidden
            EndContext();
            BeginContext(2957, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3004, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7526cc3d4c506b8f1e4d3714c7d3dfaab14b95b315689", async() => {
                BeginContext(3050, 4, true);
                WriteLiteral("Edit");
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
#line 95 "D:\vs2019Project\LibraryReservationSystem\LibraryReservationSystem\Areas\Admin\Views\SysUsers\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(3058, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3066, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7526cc3d4c506b8f1e4d3714c7d3dfaab14b95b318040", async() => {
                BeginContext(3088, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(3104, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryEntities.Models.SysUser> Html { get; private set; }
    }
}
#pragma warning restore 1591