#pragma checksum "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Components\IdentityServerLink\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "357c780b3ad6ec67c13cf0cce2ec0218b29f4f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_IdentityServerLink_Default), @"mvc.1.0.view", @"/Views/Shared/Components/IdentityServerLink/Default.cshtml")]
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
#line 1 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Components\IdentityServerLink\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"357c780b3ad6ec67c13cf0cce2ec0218b29f4f97", @"/Views/Shared/Components/IdentityServerLink/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edca01545d93ac98cb5a7aeb092b7743ee81dba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_IdentityServerLink_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<a class=\"menu-item my-2 btn btn-outline-primary mr-md-3\"");
            BeginWriteAttribute("href", " href=\"", 154, "\"", 167, 1);
#nullable restore
#line 5 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Components\IdentityServerLink\Default.cshtml"
WriteAttributeValue("", 161, Model, 161, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 5 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Components\IdentityServerLink\Default.cshtml"
                                                                   Write(Localizer["IdentityServer"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
