#pragma checksum "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be1a5e97ec0a123f72a7d4c3ea7aa8f5213e75f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
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
#line 1 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be1a5e97ec0a123f72a7d4c3ea7aa8f5213e75f", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c243f9d56e095733f8a8c9af2259bc8a8cfadd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "List of all users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-6 offset-3\">\n        <p>\n            <h4>List of all users</h4>\n        </p>\n\n        <table class=\"table\">\n            <thead>\n                <tr class=\"text-center\">\n                    <th>");
#nullable restore
#line 16 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 17 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 18 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 22 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 26 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 29 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 32 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 35 "C:\Users\Muhameti\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Account\Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n\n        </table>\n\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
