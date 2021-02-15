#pragma checksum "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba7df262b223d2c399576ba95494bea9d4599e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
using Microsoft.Extensions.Hosting;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7df262b223d2c399576ba95494bea9d4599e34", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d180285ccac3a6d354b6c87ff0e74ec1d40e6f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServer.STS.Identity.ViewModels.Home.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
  
	var error = Model?.Error?.Error;
	var errorDescription = Host.IsDevelopment() ? Model?.Error?.ErrorDescription : null;
	var request_id = Model?.Error?.RequestId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"error-page\">\r\n\t<div class=\"page-header\">\r\n\t\t<h1>");
#nullable restore
#line 16 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
       Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t</div>\r\n\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-6\">\r\n\t\t\t<div class=\"alert alert-danger\">\r\n\t\t\t\t");
#nullable restore
#line 22 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
           Write(Localizer["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
                 if (error != null)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<strong>\r\n\t\t\t\t\t\t<em>\r\n\t\t\t\t\t\t\t: ");
#nullable restore
#line 28 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
                         Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</em>\r\n\t\t\t\t\t</strong>\r\n");
#nullable restore
#line 31 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"

					if (errorDescription != null)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div>");
#nullable restore
#line 34 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
                        Write(errorDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 35 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
					}
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
             if (request_id != null)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"request-id\">");
#nullable restore
#line 41 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
                                   Write(Localizer["Request"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
                                                         Write(request_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 42 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.STS.Identity\Views\Shared\Error.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebHostEnvironment Host { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServer.STS.Identity.ViewModels.Home.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
