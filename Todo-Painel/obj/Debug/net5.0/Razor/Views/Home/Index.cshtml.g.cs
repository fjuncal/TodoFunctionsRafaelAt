#pragma checksum "C:\Users\juncal\RiderProjects\TodoFunctionsRafaelAt\Todo-Painel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "914d206b496e35b6ce34c55aff78713e0c9e53e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\juncal\RiderProjects\TodoFunctionsRafaelAt\Todo-Painel\Views\_ViewImports.cshtml"
using Todo_Painel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\juncal\RiderProjects\TodoFunctionsRafaelAt\Todo-Painel\Views\_ViewImports.cshtml"
using Todo_Painel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\juncal\RiderProjects\TodoFunctionsRafaelAt\Todo-Painel\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"914d206b496e35b6ce34c55aff78713e0c9e53e8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09ebcf2662d666a3f7268a93afcb768ba7084b5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\juncal\RiderProjects\TodoFunctionsRafaelAt\Todo-Painel\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bem vindo a página de Todos</h1>\r\n");
#nullable restore
#line 12 "C:\Users\juncal\RiderProjects\TodoFunctionsRafaelAt\Todo-Painel\Views\Home\Index.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Usuário: <i>");
#nullable restore
#line 14 "C:\Users\juncal\RiderProjects\TodoFunctionsRafaelAt\Todo-Painel\Views\Home\Index.cshtml"
                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h3>\r\n");
#nullable restore
#line 15 "C:\Users\juncal\RiderProjects\TodoFunctionsRafaelAt\Todo-Painel\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
