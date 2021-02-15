#pragma checksum "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6c3933a996e4e704c301267bf28727e00945764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Common_Notification), @"mvc.1.0.view", @"/Views/Shared/Common/Notification.cshtml")]
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
#line 1 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
using IdentityServer.Admin.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6c3933a996e4e704c301267bf28727e00945764", @"/Views/Shared/Common/Notification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edca01545d93ac98cb5a7aeb092b7743ee81dba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Common_Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
 if (ViewBag.Notifications != null)
{
	var settings = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.All
	};

	var obj = JsonConvert.DeserializeObject<List<NotificationHelpers.Alert>>(ViewBag.Notifications, settings);

	foreach (NotificationHelpers.Alert notification in obj)
	{
		switch (notification.Type)
		{
			case NotificationHelpers.AlertType.Success:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<script type=\"text/javascript\">toastr.options.closeButton = true; toastr.success(\'");
#nullable restore
#line 17 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
                                                                                             Write(notification.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 17 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
                                                                                                                      Write(notification.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');</script>\r\n");
#nullable restore
#line 18 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
				break;
			case NotificationHelpers.AlertType.Error:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<script type=\"text/javascript\">toastr.error(\'");
#nullable restore
#line 20 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
                                                        Write(notification.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 20 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
                                                                                 Write(notification.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');</script>\r\n");
#nullable restore
#line 21 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
				break;
			case NotificationHelpers.AlertType.Info:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<script type=\"text/javascript\">toastr.options.closeButton = true; toastr.info(\'");
#nullable restore
#line 23 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
                                                                                          Write(notification.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 23 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
                                                                                                                   Write(notification.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');</script>\r\n");
#nullable restore
#line 24 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
				break;
			case NotificationHelpers.AlertType.Warning:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<script type=\"text/javascript\">toastr.options.closeButton = true; toastr.warning(\'");
#nullable restore
#line 26 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
                                                                                             Write(notification.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 26 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
                                                                                                                      Write(notification.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');</script>\r\n");
#nullable restore
#line 27 "C:\Users\Arianit\Documents\Productivity\EverCloud\IdentityServer\src\IdentityServer.Admin\Views\Shared\Common\Notification.cshtml"
				break;
		}
	}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
