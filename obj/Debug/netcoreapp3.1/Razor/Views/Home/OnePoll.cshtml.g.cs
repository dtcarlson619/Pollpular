#pragma checksum "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\Pollpular\Views\Home\OnePoll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276c66ec71d304d2150c14ae623697e7ff526baa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OnePoll), @"mvc.1.0.view", @"/Views/Home/OnePoll.cshtml")]
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
#line 1 "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\Pollpular\Views\_ViewImports.cshtml"
using Pollpular;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\Pollpular\Views\_ViewImports.cshtml"
using Pollpular.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276c66ec71d304d2150c14ae623697e7ff526baa", @"/Views/Home/OnePoll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a855efb8eaeca54f0d162496c16f87463c7ab39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OnePoll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Poll>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\Pollpular\Views\Home\OnePoll.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    html, body { 
    background: url(images/vote.jpeg) no-repeat center center fixed; 
    -webkit-background-size: cover;
    -moz-background-size: cover;
    -o-background-size: cover;
    background-size: cover;
    }
</style>
<div>
    <h2 class=""text-primary"">");
#nullable restore
#line 15 "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\Pollpular\Views\Home\OnePoll.cshtml"
                        Write(Model.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"border border-dark p-3 m-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "276c66ec71d304d2150c14ae623697e7ff526baa4003", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 499, "\"", 504, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"sample\"");
                BeginWriteAttribute("value", " value=\"", 519, "\"", 527, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"male\">Option A</label><br>\r\n                <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 622, "\"", 627, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"sample\"");
                BeginWriteAttribute("value", " value=\"", 642, "\"", 650, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"male\">Option B</label><br>\r\n                <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 745, "\"", 750, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"sample\"");
                BeginWriteAttribute("value", " value=\"", 765, "\"", 773, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"male\">Option C</label><br>\r\n                <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 868, "\"", 873, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"sample\"");
                BeginWriteAttribute("value", " value=\"", 888, "\"", 896, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"male\">Option D</label><br>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<a class=\"col-3 text-right\"");
            BeginWriteAttribute("href", " href=\"", 1040, "\"", 1070, 2);
            WriteAttributeValue("", 1047, "results/", 1047, 8, true);
#nullable restore
#line 31 "C:\Users\elder\Desktop\Coding Dojo\ASP.NET\Pollpular\Views\Home\OnePoll.cshtml"
WriteAttributeValue("", 1055, ViewBag.PollId, 1055, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><input type=\"button\" value=\"Vote\" class=\"btn btn-primary\"></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Poll> Html { get; private set; }
    }
}
#pragma warning restore 1591
