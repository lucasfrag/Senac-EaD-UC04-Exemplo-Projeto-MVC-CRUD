#pragma checksum "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aacae1aa2d752c06ad2e4f1af26e9cc9e3611c20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Lista), @"mvc.1.0.view", @"/Views/Usuario/Lista.cshtml")]
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
#line 1 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\_ViewImports.cshtml"
using ExemploCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\_ViewImports.cshtml"
using ExemploCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aacae1aa2d752c06ad2e4f1af26e9cc9e3611c20", @"/Views/Usuario/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bccc5751ed720b49de067d6c07925191f1f5ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n            <th>Login</th>\r\n            <th>Senha</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 16 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml"
               Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml"
               Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 521, "\"", 552, 2);
            WriteAttributeValue("", 528, "/Usuario/Editar?Id=", 528, 19, true);
#nullable restore
#line 24 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 547, u.Id, 547, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 588, "\"", 620, 2);
            WriteAttributeValue("", 595, "/Usuario/Remover?Id=", 595, 20, true);
#nullable restore
#line 25 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 615, u.Id, 615, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remover</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Lucas Fraga\Desktop\ExemploCRUD\Views\Usuario\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tbody>\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
