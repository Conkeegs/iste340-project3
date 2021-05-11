#pragma checksum "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da32ef126274645270ea1c31eaf51d89ff6349f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Grad), @"mvc.1.0.view", @"/Views/Home/Grad.cshtml")]
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
#line 1 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\_ViewImports.cshtml"
using Project3_FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\_ViewImports.cshtml"
using Project3_FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da32ef126274645270ea1c31eaf51d89ff6349f9", @"/Views/Home/Grad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Grad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.GraduateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/themes/le-frog/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
  
    ViewData["Title"] = "Graduate Majors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div id=\"graduate-div\">\r\n\r\n    <h1 class=\"title\">Graduate Majors</h1>\r\n    <div id=\"myGradDegrees\"></div>\r\n\r\n</div>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
 foreach (var grad in Model.Grads)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
     if (grad.concentrations != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3");
            BeginWriteAttribute("id", " id=", 414, "", 459, 1);
#nullable restore
#line 22 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
WriteAttributeValue("", 418, String.Concat("myHdng", grad.degreeName), 418, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 22 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
                                                       Write(grad.degreeName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n");
            WriteLiteral("        <div");
            BeginWriteAttribute("id", " id=", 514, "", 558, 1);
#nullable restore
#line 24 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
WriteAttributeValue("", 518, String.Concat("myDiv", grad.degreeName), 518, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <p>");
#nullable restore
#line 25 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
          Write(grad.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 26 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
          Write(grad.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <ul>\r\n");
#nullable restore
#line 28 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
                 foreach (var conc in @grad.concentrations)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 30 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
                   Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 31 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
     if (grad.availableCertificates != null)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3");
            BeginWriteAttribute("id", " id=", 896, "", 941, 1);
#nullable restore
#line 40 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
WriteAttributeValue("", 900, String.Concat("myHdng", grad.degreeName), 900, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 40 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
                                                       Write(grad.degreeName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n");
            WriteLiteral("        <div");
            BeginWriteAttribute("id", " id=", 996, "", 1040, 1);
#nullable restore
#line 42 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
WriteAttributeValue("", 1000, String.Concat("myDiv", grad.degreeName), 1000, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <ul>\r\n");
#nullable restore
#line 44 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
                 foreach (var cert in @grad.availableCertificates)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 46 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
                   Write(cert);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 47 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n");
#nullable restore
#line 51 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Max Gerber\Documents\GitHub\iste340-project3\Views\Home\Grad.cshtml"
     
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da32ef126274645270ea1c31eaf51d89ff6349f910766", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "da32ef126274645270ea1c31eaf51d89ff6349f911806", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da32ef126274645270ea1c31eaf51d89ff6349f912922", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    // Create Accordion
    let headings = document.querySelectorAll(""h3"");
    let divs = document.querySelectorAll(""[id^='myDiv']"");

    for (var i = 0; i < headings.length; i++) {
        $(""#myGradDegrees"").append($(""#"" + headings[i].id));
        $(""#myGradDegrees"").append($(""#"" + divs[i].id));
    }

    $('#myGradDegrees').accordion({
        collapsible: true,
        active: false,
        heightStyle: ""content""
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.GraduateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
