#pragma checksum "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7b4b97193b9703ef89f195ecde92331638e9a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetFaculty), @"mvc.1.0.view", @"/Views/Home/GetFaculty.cshtml")]
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
#line 1 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\_ViewImports.cshtml"
using Project3_FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\_ViewImports.cshtml"
using Project3_FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7b4b97193b9703ef89f195ecde92331638e9a6", @"/Views/Home/GetFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/themes/le-frog/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/site.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
  
    ViewData["Title"] = "Faculty";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\" style=\"margin-right:60px\">");
#nullable restore
#line 8 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
                                               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div id=\"faculty-div\">\r\n\r\n    <h1 class=\"title\" style=\"margin-left: 360px;\">Your Faculty</h1>\r\n");
#nullable restore
#line 14 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
     for (var i = 0; i < Model.Faculty.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-3\">\r\n                <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 468, "", 510, 1);
#nullable restore
#line 18 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 472, String.Concat("myDiv:", i.ToString()), 472, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 559, "\"", 592, 1);
#nullable restore
#line 19 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 565, Model.Faculty[i].imagePath, 565, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"faculty-img\" style=\"height:160px;width:150px; \"");
            BeginWriteAttribute("alt", " alt=\"", 645, "\"", 651, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"caption\">\r\n                    <h3 id=\"faculty-name\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
                   Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
              
                if (i < Model.Faculty.Count - 1)
                {
                    i++;
                }
                else
                {
                    break;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-3\">\r\n                <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 1190, "", 1232, 1);
#nullable restore
#line 38 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 1194, String.Concat("myDiv:", i.ToString()), 1194, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1281, "\"", 1314, 1);
#nullable restore
#line 39 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 1287, Model.Faculty[i].imagePath, 1287, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"faculty-img\" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 1365, "\"", 1371, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"caption\">\r\n                    <h3 id=\"faculty-name\">\r\n                        ");
#nullable restore
#line 43 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
                   Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
              
                if (i < Model.Faculty.Count - 1)
                {
                    i++;
                }
                else
                {
                    break;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-3\">\r\n                <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 1910, "", 1952, 1);
#nullable restore
#line 58 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 1914, String.Concat("myDiv:", i.ToString()), 1914, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2001, "\"", 2034, 1);
#nullable restore
#line 59 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 2007, Model.Faculty[i].imagePath, 2007, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"faculty-img\" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 2085, "\"", 2091, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"caption\">\r\n                    <h3  id=\"faculty-name\">\r\n                        ");
#nullable restore
#line 63 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
                   Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 67 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
              
                if (i < Model.Faculty.Count - 1)
                {
                    i++;
                }
                else
                {
                    break;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-3\">\r\n                <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 2631, "", 2673, 1);
#nullable restore
#line 78 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 2635, String.Concat("myDiv:", i.ToString()), 2635, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2722, "\"", 2755, 1);
#nullable restore
#line 79 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
WriteAttributeValue("", 2728, Model.Faculty[i].imagePath, 2728, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"faculty-img\" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 2806, "\"", 2812, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"caption\">\r\n                    <h3  id=\"faculty-name\">\r\n                        ");
#nullable restore
#line 83 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
                   Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n            </div>\r\n            <div>&nbsp;</div>\r\n            <div>&nbsp;</div>\r\n        </div>\r\n");
#nullable restore
#line 90 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div id=\"dialog\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7b4b97193b9703ef89f195ecde92331638e9a614716", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e7b4b97193b9703ef89f195ecde92331638e9a615756", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7b4b97193b9703ef89f195ecde92331638e9a616872", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e7b4b97193b9703ef89f195ecde92331638e9a617912", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 98 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    var $j = jQuery.noConflict();\r\n    var facultyData = ");
#nullable restore
#line 101 "C:\Users\conke\Desktop\Projects\C# Projects\ISTE-340\Project3_StarterCode\iste340-project3\Views\Home\GetFaculty.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.Faculty)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    function getName(id) {
        console.log(facultyData);
        let facultyElement = (id).split(':')[1];

        var divContent = ""<div><ul>"";

        divContent += ""<li><font color='#18ADEA'><b><u>Title:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].title + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Email:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].email + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Office:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].office + ""</b></<li>"";
        divContent += ""<li><font color='#18ADEA'><b><u>Email:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].username + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Office:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].phone + ""</b></<li>"";

        divContent += ""</ul></div>"";

   ");
            WriteLiteral(@"     console.log(divContent);

        let elmnt = document.getElementById(id);
        $j(""#dialog"").html(divContent);
        $j(""#dialog"").dialog({
            title: facultyData[facultyElement].name,
            width: 500,
            position: { my: ""center"", at: ""bottom+40%"", of: elmnt}
        });
        $j(""#dialog"").dialog(""open"")
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
