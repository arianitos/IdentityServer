#pragma checksum "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\ApplicationVersion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79bb0cd8c5efd1c17c3e3bf1470e53485a8c5bf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Common_ApplicationVersion), @"mvc.1.0.view", @"/Views/Shared/Common/ApplicationVersion.cshtml")]
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
#line 1 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\ApplicationVersion.cshtml"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\ApplicationVersion.cshtml"
using IdentityServer.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79bb0cd8c5efd1c17c3e3bf1470e53485a8c5bf4", @"/Views/Shared/Common/ApplicationVersion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edca01545d93ac98cb5a7aeb092b7743ee81dba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Common_ApplicationVersion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\ApplicationVersion.cshtml"
  
    var runtimeVersion = typeof(Startup)
        .GetTypeInfo()
        .Assembly
        .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\ApplicationVersion.cshtml"
Write(runtimeVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
