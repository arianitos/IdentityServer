#pragma checksum "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.Admin\Views\Identity\User\Section\Label.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27b6239fd83a7720f690b66a714222f48e4369b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Identity_User_Section_Label), @"mvc.1.0.view", @"/Views/Identity/User/Section/Label.cshtml")]
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
#line 1 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.Admin\Views\Identity\User\Section\Label.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b6239fd83a7720f690b66a714222f48e4369b0", @"/Views/Identity/User/Section/Label.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edca01545d93ac98cb5a7aeb092b7743ee81dba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Identity_User_Section_Label : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.Admin\Views\Identity\User\Section\Label.cshtml"
Write(Localizer[$"{Model}_Label"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<span data-toggle=\"tooltip\" data-original-title=\"");
#nullable restore
#line 7 "C:\Users\lorik\Lori\Projects\wdis\src\IdentityServer.Admin\Views\Identity\User\Section\Label.cshtml"
                                            Write(Localizer[$"{Model}_Info"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span style=\"font-size: 12px;\" class=\"oi oi-comment-square\"></span></span>\r\n\r\n\r\n\r\n\r\n\r\n");
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
