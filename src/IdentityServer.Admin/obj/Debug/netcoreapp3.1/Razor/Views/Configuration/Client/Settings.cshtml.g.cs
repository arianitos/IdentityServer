#pragma checksum "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "456a8102bcda463990e80160d17d8d9558deaa87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuration_Client_Settings), @"mvc.1.0.view", @"/Views/Configuration/Client/Settings.cshtml")]
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
#line 1 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456a8102bcda463990e80160d17d8d9558deaa87", @"/Views/Configuration/Client/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edca01545d93ac98cb5a7aeb092b7743ee81dba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuration_Client_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration.ClientDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col-md-12\">\r\n\t\t<h3>");
#nullable restore
#line 7 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
       Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t<nav>\r\n\t\t\t<div class=\"nav nav-tabs mt-3\" id=\"nav-tab\" role=\"tablist\">\r\n\t\t\t\t<a class=\"nav-item nav-link active\" id=\"nav-name-tab\" data-toggle=\"tab\" href=\"#nav-name\" role=\"tab\" aria-controls=\"nav-name\" aria-selected=\"true\">");
#nullable restore
#line 10 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                             Write(Localizer["NavName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 11 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
                 if (Model.Id != 0)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-basics-tab\" data-toggle=\"tab\" href=\"#nav-basics\" role=\"tab\" aria-controls=\"nav-basics\" aria-selected=\"false\">");
#nullable restore
#line 13 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                                 Write(Localizer["NavBasics"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-authentication-tab\" data-toggle=\"tab\" href=\"#nav-authentication\" role=\"tab\" aria-controls=\"nav-authentication\" aria-selected=\"false\">");
#nullable restore
#line 14 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                                                         Write(Localizer["NavAuthentication"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-token-tab\" data-toggle=\"tab\" href=\"#nav-token\" role=\"tab\" aria-controls=\"nav-token\" aria-selected=\"false\">");
#nullable restore
#line 15 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                              Write(Localizer["NavToken"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-consent-tab\" data-toggle=\"tab\" href=\"#nav-consent\" role=\"tab\" aria-controls=\"nav-consent\" aria-selected=\"false\">");
#nullable restore
#line 16 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                                    Write(Localizer["NavConsent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-deviceflow-tab\" data-toggle=\"tab\" href=\"#nav-deviceflow\" role=\"tab\" aria-controls=\"nav-deviceflow\" aria-selected=\"false\">");
#nullable restore
#line 17 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                                             Write(Localizer["NavDeviceFlow"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 18 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</nav>\r\n\t\t<div class=\"tab-content\" id=\"nav-tabContent\">\r\n\t\t\t<div class=\"tab-pane show active\" id=\"nav-name\" role=\"tabpanel\" aria-labelledby=\"nav-name-tab\">\r\n\t\t\t\t");
#nullable restore
#line 23 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
           Write(await Html.PartialAsync("Client/Section/Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
             if (Model.Id != 0)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"tab-pane\" id=\"nav-basics\" role=\"tabpanel\" aria-labelledby=\"nav-basics-tab\">\r\n\t\t\t\t\t");
#nullable restore
#line 29 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/Basics"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t\t<div class=\"tab-pane\" id=\"nav-authentication\" role=\"tabpanel\" aria-labelledby=\"nav-authentication-tab\">\r\n\t\t\t\t\t");
#nullable restore
#line 33 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/Authentication"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"tab-pane\" id=\"nav-token\" role=\"tabpanel\" aria-labelledby=\"nav-token-tab\">\r\n\t\t\t\t\t");
#nullable restore
#line 36 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/Token"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"tab-pane\" id=\"nav-consent\" role=\"tabpanel\" aria-labelledby=\"nav-consent-tab\">\r\n\t\t\t\t\t");
#nullable restore
#line 39 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/Consent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"tab-pane\" id=\"nav-deviceflow\" role=\"tabpanel\" aria-labelledby=\"nav-deviceflow-tab\">\r\n\t\t\t\t\t");
#nullable restore
#line 42 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/DeviceFlow"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 44 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Configuration\Client\Settings.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration.ClientDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
