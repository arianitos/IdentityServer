#pragma checksum "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c36df584d6951c5713d7a113f97e98ed8abed98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoggedOut), @"mvc.1.0.view", @"/Views/Account/LoggedOut.cshtml")]
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
#line 1 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c36df584d6951c5713d7a113f97e98ed8abed98", @"/Views/Account/LoggedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d180285ccac3a6d354b6c87ff0e74ec1d40e6f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoggedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServer.STS.Identity.ViewModels.Account.LoggedOutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signout-redirect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
  
	// set this so the layout rendering sees an anonymous user
	ViewData["signed-out"] = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header logged-out-container\">\r\n\t<h1>\r\n\t\t");
#nullable restore
#line 12 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
   Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t<small>");
#nullable restore
#line 13 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
          Write(Localizer["SubTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t</h1>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
     if (Model.PostLogoutRedirectUri != null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div>\r\n\t\t\t");
#nullable restore
#line 19 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
       Write(Localizer["Click"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a class=\"PostLogoutRedirectUri\"");
            BeginWriteAttribute("href", " href=\"", 500, "\"", 535, 1);
#nullable restore
#line 19 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 507, Model.PostLogoutRedirectUri, 507, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
                                                                                                Write(Localizer["Here"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> ");
#nullable restore
#line 19 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
                                                                                                                       Write(Localizer["Return"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<span>");
#nullable restore
#line 20 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
             Write(Model.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>.\r\n\t\t</div>\r\n");
#nullable restore
#line 22 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
     if (Model.SignOutIframeUrl != null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<iframe width=\"0\" height=\"0\" class=\"signout\"");
            BeginWriteAttribute("src", " src=\"", 723, "\"", 752, 1);
#nullable restore
#line 26 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 729, Model.SignOutIframeUrl, 729, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n");
#nullable restore
#line 27 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
     if (Model.AutomaticRedirectAfterSignOut)
	{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c36df584d6951c5713d7a113f97e98ed8abed987769", async() => {
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
#nullable restore
#line 35 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.STS.Identity\Views\Account\LoggedOut.cshtml"
	}

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUrlHelper UrlHelper { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServer.STS.Identity.ViewModels.Account.LoggedOutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
