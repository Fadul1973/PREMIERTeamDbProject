#pragma checksum "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\Home\TeamDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc29240f7689f0d3e094ca23672625a0194cf7d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TeamDetails), @"mvc.1.0.view", @"/Views/Home/TeamDetails.cshtml")]
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
#line 1 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\_ViewImports.cshtml"
using PREMIERTeamDbProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\_ViewImports.cshtml"
using PREMIERTeamDbProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc29240f7689f0d3e094ca23672625a0194cf7d0", @"/Views/Home/TeamDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b928c57a71871bc91456f1343ec58e099ec5918a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TeamDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PREMIERTeamDbProject.Models.Team>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\Home\TeamDetails.cshtml"
  
    Layout = "_TeamDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\Home\TeamDetails.cshtml"
  
    ViewData["Title"] = @Model.TeamTitle;
    ViewData["PageHeading"] = @Model.TeamTitle;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n\r\n    <div class=\"mainImage\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc29240f7689f0d3e094ca23672625a0194cf7d03848", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 243, "~/images/", 243, 9, true);
#nullable restore
#line 15 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\Home\TeamDetails.cshtml"
AddHtmlAttributeValue("", 252, Model.TeamImage, 252, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\Home\TeamDetails.cshtml"
AddHtmlAttributeValue("", 275, Model.TeamTitle, 275, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"teamInfo\">\r\n        <h2>");
#nullable restore
#line 19 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\Home\TeamDetails.cshtml"
       Write(Model.TeamTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p>");
#nullable restore
#line 20 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\Home\TeamDetails.cshtml"
      Write(Model.TeamDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Certificate: ");
#nullable restore
#line 21 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\Home\TeamDetails.cshtml"
                   Write(Model.TeamCertificate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Streaming Price: &pound;");
#nullable restore
#line 22 "C:\Users\abdof\OneDrive\Desktop\PREMIERTeamDbProject\PREMIERTeamDbProject\Views\Home\TeamDetails.cshtml"
                               Write((Model.TeamPrice).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PREMIERTeamDbProject.Models.Team> Html { get; private set; }
    }
}
#pragma warning restore 1591
