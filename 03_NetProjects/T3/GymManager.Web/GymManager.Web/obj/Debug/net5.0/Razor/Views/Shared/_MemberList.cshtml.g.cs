#pragma checksum "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\03_NetProjects\T3\GymManager.Web\GymManager.Web\Views\Shared\_MemberList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90bc60f81c05dc92238696370941d4f1bc53608d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MemberList), @"mvc.1.0.view", @"/Views/Shared/_MemberList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90bc60f81c05dc92238696370941d4f1bc53608d", @"/Views/Shared/_MemberList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MemberList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GymManager.Core.Members.Member>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"col\">Name</th>\r\n      <th scope=\"col\">lastName</th>\r\n      <th scope=\"col\">Birthday</th>\r\n      <th scope=\"col\">Email</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n   \r\n");
#nullable restore
#line 16 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\03_NetProjects\T3\GymManager.Web\GymManager.Web\Views\Shared\_MemberList.cshtml"
       foreach (var member in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\r\n              <th scope=\"row\">");
#nullable restore
#line 19 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\03_NetProjects\T3\GymManager.Web\GymManager.Web\Views\Shared\_MemberList.cshtml"
                         Write(member.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <td>");
#nullable restore
#line 20 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\03_NetProjects\T3\GymManager.Web\GymManager.Web\Views\Shared\_MemberList.cshtml"
             Write(member.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               <td>");
#nullable restore
#line 21 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\03_NetProjects\T3\GymManager.Web\GymManager.Web\Views\Shared\_MemberList.cshtml"
              Write(member.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\03_NetProjects\T3\GymManager.Web\GymManager.Web\Views\Shared\_MemberList.cshtml"
               Write(member.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         </tr>\r\n");
#nullable restore
#line 24 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\03_NetProjects\T3\GymManager.Web\GymManager.Web\Views\Shared\_MemberList.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GymManager.Core.Members.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
