#pragma checksum "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac89ecca5c209ee4431beec0690c8d7bd3e3094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AppMenu__UserMenuItem), @"mvc.1.0.view", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
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
#line 1 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
using GymManager.Core.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac89ecca5c209ee4431beec0690c8d7bd3e3094", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AppMenu__UserMenuItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.Web.Models.UserMenuItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
  
    var orderedChildMenuItems = Model.MenuItem.Items.OrderBy(x => x.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
 if (Model.MenuItem.Items.Count < 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 253, "\"", 339, 2);
            WriteAttributeValue("", 261, "nav-link", 261, 8, true);
#nullable restore
#line 11 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 269, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? " active" :"", 270, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                              Write(Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "aria-current=\" page\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 11 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                            Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </li>\r\n");
#nullable restore
#line 13 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
}
else
{
    string currentElementId = "menu-" + new Random().Next(0);


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item dropdown\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 603, "\"", 705, 3);
            WriteAttributeValue("", 611, "nav-link", 611, 8, true);
            WriteAttributeValue(" ", 619, "dropdown-toggle", 620, 16, true);
#nullable restore
#line 19 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 635, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? " active" :"", 636, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"");
            BeginWriteAttribute("id", " id=\"", 715, "\"", 737, 1);
#nullable restore
#line 19 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 720, currentElementId, 720, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">");
#nullable restore
#line 19 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                             Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <ul class=\"dropdown-menu\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 853, "\"", 888, 1);
#nullable restore
#line 20 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 871, currentElementId, 871, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 22 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
             foreach (var submenu in Model.MenuItem.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1013, "\"", 1032, 1);
#nullable restore
#line 24 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 1020, submenu.Url, 1020, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                            Write(submenu.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 25 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </li>\r\n");
#nullable restore
#line 28 "C:\Users\hecto\Source\Repos\DN_Hector_Jaramillo\06_AspNetCore MVC con Entity Framework\T8\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.Web.Models.UserMenuItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
